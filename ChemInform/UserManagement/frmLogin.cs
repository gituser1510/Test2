#region Namespaces
using System;
using System.Data;
using System.Windows.Forms;
using ChemInform.Dal;
using ChemInform.Common;
#endregion

namespace ChemInform.UserManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //static int i = 0;

        //static System.Collections.Generic.IEnumerable<int> YieldReturn()
        //{
        //    i = i + 10;

        //    yield return i;

        //    i = i + 20;
        //    yield return i;

        //    i = i + 30;
        //    yield return i;
        //}

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //foreach (int i1 in YieldReturn())
                //{
                //    int s = i1;

                //    i = i1 + 100;
                //}

                //Get User Names and Set Auto Fill
                GetUserNamesAndSetToUserNameTxtBox_AutoComplete();
                FillRolesDropDownList();
                txtUserName.Focus();
                cmbModule.SelectedIndex = -1;
                cmbModule.Enabled = false;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void GetUserNamesAndSetToUserNameTxtBox_AutoComplete()
        {
            try
            {
                using (DataTable dtUserNames = UserMasterDAL.GetAllUsersInformation())
                {
                    if (dtUserNames != null)
                    {
                        if (dtUserNames.Rows.Count > 0)
                        {
                            AutoCompleteStringCollection usrNameColl = new AutoCompleteStringCollection();
                            for (int i = 0; i < dtUserNames.Rows.Count; i++)
                            {
                                if (dtUserNames.Rows[i]["USER_NAME"] != null)
                                {
                                    usrNameColl.Add(dtUserNames.Rows[i]["USER_NAME"].ToString());
                                }
                            }
                            txtUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                            txtUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            txtUserName.AutoCompleteCustomSource = usrNameColl;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }


        #region Methods

        /// <summary>
        /// Fill Roles drop down.
        /// </summary>
        private void FillRolesDropDownList()
        {
            try
            {
                DataTable dtRoles = UserMasterDAL.GetRoles();
                if (dtRoles != null)
                {
                    if (dtRoles.Rows.Count > 0)
                    {
                        cmbRole.DataSource = dtRoles;
                        cmbRole.DisplayMember = "ROLE_NAME";
                        cmbRole.ValueMember = "ROLE_ID";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Validates User inputs & LDAP Authentication
        /// </summary>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        private bool ValidateUserInputs(out string errMsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "User name can't be null";
                    blStatus = false;
                }

                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Password can't be null";
                    blStatus = false;
                }
                if (cmbRole.Text.ToUpper() != "ADMINISTRATOR" && cmbRole.Text.ToUpper() != "PROJECT MANAGER")
                {
                    if (cmbModule.Text == null && cmbModule.Text == "")
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + " Please select module";
                        blStatus = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errMsg = strErrMsg.Trim();
            return blStatus;
        }

        private bool ValidateUserAgainstLDAP()
        {
            bool flag = false;
            try
            {
                if (!string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    string adPath = "LDAP://gvkbio.com:389/DC=gvkbio,DC=com";
                    LdapAuthentication ldap = new LdapAuthentication(adPath);
                    //Checking User credentials using LDAP Server.
                    if (ldap.IsAuthenticated("GVKBIO", txtUserName.Text.Trim(), txtPassword.Text.Trim()))
                    {
                        flag = true;

                    }
                }
                else
                {
                    MessageBox.Show("User can't be null", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return flag;
        }

        #endregion

        #region Events

        /// <summary>
        /// Validate LDAP user & give access to appplication.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {
                  //bool blStatus = ChemistryOperations.MoleculeComparisonTest("", "");
                                        
                    //Get User Details
                    DataTable dtUserDetails = UserMasterDAL.GetUserDetailsByUserNameAndRoleId(txtUserName.Text.Trim(), Convert.ToInt32(cmbRole.SelectedValue), cmbModule.Text);
                    if (dtUserDetails != null && dtUserDetails.Rows.Count > 0)
                    {
                        char isLDAPUser = Convert.ToChar(dtUserDetails.Rows[0]["IS_LDAP_USER"]);
                        if (isLDAPUser == 'N')
                        {
                            DataTable dtUserCredentilas = UserMasterDAL.GetUserCredentialsByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                            if (dtUserCredentilas != null && dtUserCredentilas.Rows.Count > 0)
                            {
                                //Filling Data into Global variables.
                                GlobalVariables.UserName = txtUserName.Text.Trim();
                                GlobalVariables.RoleName = cmbRole.Text;
                                GlobalVariables.Module = cmbModule.Text;
                                GlobalVariables.RoleId = Convert.ToInt32(cmbRole.SelectedValue);
                                GlobalVariables.UserID = Convert.ToInt32(dtUserDetails.Rows[0]["USER_ID"].ToString());
                                GlobalVariables.UR_ID = Convert.ToInt32(dtUserDetails.Rows[0]["UR_ID"].ToString());
                                GlobalVariables.IsLoginSuccess = true;

                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid User Name / Password", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // LDAP user exists or not
                            if (ValidateUserAgainstLDAP())
                            {
                                //Filling Data into Global variables.
                                GlobalVariables.UserName = txtUserName.Text.Trim();
                                GlobalVariables.RoleName = cmbRole.Text;
                                GlobalVariables.Module = cmbModule.Text;
                                GlobalVariables.RoleId = Convert.ToInt32(cmbRole.SelectedValue);
                                GlobalVariables.UserID = Convert.ToInt32(dtUserDetails.Rows[0]["USER_ID"].ToString());
                                GlobalVariables.UR_ID = Convert.ToInt32(dtUserDetails.Rows[0]["UR_ID"].ToString());
                                GlobalVariables.IsLoginSuccess = true;

                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid User Name / Password", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }//End LDAP.
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name / Password / Role", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(strErrMsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex != -1)
            {
                if (String.IsNullOrEmpty(cmbRole.Text))
                {
                    cmbModule.SelectedIndex = -1;
                    cmbModule.Enabled = false;
                }
                else if (cmbRole.Text.ToUpper() == "ADMINISTRATOR" || cmbRole.Text.ToUpper() == "PROJECT MANAGER")
                {
                    cmbModule.SelectedIndex = -1;
                    cmbModule.Enabled = false;
                }
                else
                {
                    cmbModule.Enabled = true;
                    cmbModule.SelectedIndex = 0;
                }
            }
            else
            {
                cmbModule.SelectedIndex = -1;
                cmbModule.Enabled = false;
            }
        }
    }
}
