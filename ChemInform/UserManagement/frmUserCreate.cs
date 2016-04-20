#region Name spaces
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.DirectoryServices;
using System.Configuration;
using ChemInform;
using ChemInform.Common;
using ChemInform.Dal;
using ChemInform.Bll;
using DataGridViewAutoFilter;

#endregion
namespace ChemInform.UserManagement
{
    public partial class frmUserCreate : Form
    {    
        public frmUserCreate()
        {
            InitializeComponent();
        }
               
        int intUserID = 0;
        int TotalTANs = 0;
        int TotalTeams = 0;
        BindingSource bsReport = new BindingSource();
        BindingSource bsTeam = new BindingSource();

        #region Public Properties

        public DataTable UserDetails
        { get; set; }

        public DataTable UserRoles
        { get; set; }

        public DataTable TeamLeadDetails
        { get; set; }

        public DataTable InchargeDetails
        { get; set; }

        public DataTable UserProfileDetails
        { get; set; }

        public DataTable _dtTeamUsers
        { get; set; }

        #endregion
               
        private void frmUserCreate_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                cmbStatus.SelectedIndex = 0;
                               
                //Get uSer details and bind to grid
                UserDetails = UserMasterDAL.GetUserDetails();

                //Bind USER details to grid
                BindUser_DetailsToGrid(UserDetails);

                txtPassword.Enabled = false;

                FillUserNameDropDown();

                UserProfileDefaultLoad();
                                        
                //Get Role details
                UserRoles = UserMasterDAL.GetRoles();

                //Bind Role details to Dropdown
                BindUserRolesToDropdown(UserRoles);

                DataTable dtTeamUsers = UserMasterDAL.GetUserTeamUsersDetails();
                BindTeamUsersToGrid(dtTeamUsers);              
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Events
        
        /// <summary>
        /// User creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrormsg = string.Empty;

                //Validate & get details from LDAP
                btnLDAPAuth_Click(null, null);

                //Save User
                if (ValidateUserInputs(out strErrormsg))
                {
                    User userMaster = new User();
                    userMaster.Name = txtUserName.Text.Trim();

                    userMaster.EmailId = txtEmailAddress.Text.Trim();
                    if (txtPassword.Enabled)
                    {
                        userMaster.Password = txtPassword.Text.ToString();
                        userMaster.IsLDAPUser = 'N';
                    }
                    else
                    {
                        userMaster.Password = "12345";
                        userMaster.IsLDAPUser = 'Y';
                    }
                    userMaster.Status = cmbStatus.Text.ToUpper() == "ACTIVE" ? "Y" : "N";

                    if (intUserID == 0)
                    {
                        userMaster.ID = 0;
                        userMaster.OptionType = DmlOperations.INSERT;

                        string strUserStatus = UserMasterDAL.CreateUser(userMaster);
                        if (string.Equals("INSERT SUCCESSFUL", strUserStatus))
                        {
                            MessageBox.Show("New User Details Created Successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Get uSer details and bind to grid
                            UserDetails = UserMasterDAL.GetUserDetails();
                            //Bind USER details to grid
                            BindUser_DetailsToGrid(UserDetails);

                            intUserID = 0;

                            ResetUserInfoControls();
                        }
                        else if (string.Equals("DUPLICATE USER NAME!", strUserStatus))
                        {
                            MessageBox.Show("User Name Already Exists", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (string.Equals("ERRORS", strUserStatus))
                        {
                            MessageBox.Show("Error in User Creation", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        userMaster.ID = intUserID;
                        userMaster.OptionType = DmlOperations.UPDATE;

                        string strUserStatus = UserMasterDAL.CreateUser(userMaster);
                        if (string.Equals("UPDATE SUCCESSFUL", strUserStatus))
                        {
                            MessageBox.Show("User Details Updated Successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Get uSer details and bind to grid
                            UserDetails = UserMasterDAL.GetUserDetails();
                            //Bind USER details to grid
                            BindUser_DetailsToGrid(UserDetails);

                            intUserID = 0;

                            ResetUserInfoControls();
                        }
                        else if (string.Equals("Success", strUserStatus))
                        {
                            MessageBox.Show("Error in saving the User", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    FillUserNameDropDown();
                    cmbUserName.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(strErrormsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Profile save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoleSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrormsg = string.Empty;

                if (ValidateProfileInputs(out strErrormsg))
                {
                    if (ValidateUserRoleDetails(out strErrormsg))
                    {
                        string strUserStatus = string.Empty;
                        UserProfileBLL userProfile = new UserProfileBLL();
                        userProfile.UserId = Convert.ToInt32(cmbUserName.SelectedValue);
                        userProfile.RoleId = Convert.ToInt32(cmbRoles.SelectedValue);
                        userProfile.ModuleName = cmbModule_UR.Text.ToString();

                        strUserStatus = UserMasterDAL.CreateProfile(userProfile);

                        if (string.Equals("Success", strUserStatus))
                        {
                            MessageBox.Show("User Profile Created Successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Bind USER Role details to grid
                            UserProfileDetails = UserMasterDAL.GetUserProfileDetails();
                            BindUserProfile_DetailsToGrid(UserProfileDetails);
                            clearUserProfile();
                        }
                        else if (string.Equals("User Role already exists", strUserStatus))
                        {
                            MessageBox.Show("User Role already exists", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(strUserStatus, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(strErrormsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(strErrormsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        /// <summary>
        /// Clear controls when user click on close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ResetUserInfoControls();
                txtUserName.ReadOnly = false;

                intUserID = 0;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        /// <summary>
        /// User details cell click for User Edit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserDet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6 && e.RowIndex >= 0)
                {
                    intUserID = dgvUserDet.Rows[e.RowIndex].Cells["colUserID"].Value != null ? Convert.ToInt32(dgvUserDet.Rows[e.RowIndex].Cells["colUserID"].Value) : 0;
                    txtUserName.Text = dgvUserDet.Rows[e.RowIndex].Cells["colUserName"].Value.ToString();
                    txtEmailAddress.Text = dgvUserDet.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
                    cmbStatus.Text = dgvUserDet.Rows[e.RowIndex].Cells["colStatus"].Value.ToString();
                    char isLDAPUser = Convert.ToChar(dgvUserDet.Rows[e.RowIndex].Cells["colIsLDAPUser"].Value);
                    if (isLDAPUser == 'N')
                    {
                        txtPassword.Enabled = true;
                        txtPassword.Text = dgvUserDet.Rows[e.RowIndex].Cells["colPassword"].Value != null ? dgvUserDet.Rows[e.RowIndex].Cells["colPassword"].Value.ToString() : null;
                    }
                    else
                    {
                        txtPassword.Enabled = false;
                    }

                    txtUserName.ReadOnly = true;

                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Validate user against LDAP.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLDAPAuth_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    DirectoryEntry entry = new DirectoryEntry("LDAP://gvkbio.com:389/DC=gvkbio,DC=com", ConfigurationManager.AppSettings["DomainAdminUser"], ConfigurationManager.AppSettings["DomainAdminPwd"]);

                    DirectorySearcher search = new DirectorySearcher(entry);

                    search.Filter = string.Format("SAMAccountName={0}", txtUserName.Text.Trim().ToLower());
                    SearchResult sResult = search.FindOne();

                    if (sResult != null)
                    {
                        //txtempname.text = sresult.properties["cn"][0].tostring();
                        txtEmailAddress.Text = sResult.Properties["mail"][0].ToString();
                        txtPassword.Enabled = false;
                    }
                    else
                    {
                        txtPassword.Enabled = true;
                        MessageBox.Show("user details not found...", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("user name cannot be blank", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        private void btnRoleCancel_Click(object sender, EventArgs e)
        {
            try
            {
                cmbUserName.SelectedIndex = -1;
                cmbRoles.SelectedIndex = -1;
                cmbModule_UR.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }
               
        private void dgvUserProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex > 0 && e.RowIndex >= 0)
                {
                    if (dgvUserProfile.Columns[e.ColumnIndex].HeaderText.ToString().ToUpper() == "INACTIVE")
                    {
                        string statusMsg = string.Empty;

                        if (MessageBox.Show("Do you want to in-active the selected user role?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            int urId = Convert.ToInt32(dgvUserProfile.Rows[e.RowIndex].Cells[colUserRoleId.Name].Value.ToString());

                            ////Deactivate Profile.
                            if (UserMasterDAL.InActivateUserRole(urId, out statusMsg))
                            {
                                if (statusMsg.ToUpper() == "SUCCESS")
                                {
                                    MessageBox.Show("User role in-activated successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    UserProfileDetails = UserMasterDAL.GetUserProfileDetails();
                                    BindUserProfile_DetailsToGrid(UserProfileDetails);
                                }
                                else
                                {
                                    MessageBox.Show("Unable to in-activate the selected user role. Please contact Administrator", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void cmbModule_TU_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BindUsersToControls();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        private void btnSaveTeamDetailsClick(object sender, EventArgs e)
        {
            try
            {
                string strErrormsg = string.Empty;
                DataTable dtTeamUsers = null;
                if (ValidateTeamCreationInputs(out strErrormsg))
                {
                    string strUserStatus = string.Empty;
                    UserProfileBLL userProfile = new UserProfileBLL();
                    userProfile.ModuleName = cmbModule_TU.Text.ToString();
                    userProfile.QualityAnalystURID = Convert.ToInt32(cmbQualityAnalyst.SelectedValue.ToString());
                    userProfile.ReviewerAnalystURID = Convert.ToInt32(cmbReviewAnalyst.SelectedValue.ToString());
                    userProfile.AnalystURID = Convert.ToInt32(cmbAnalyst.SelectedValue.ToString());
                    strUserStatus = UserMasterDAL.CreateTeamStructure(userProfile);

                    if (string.Equals("Insertion Success", strUserStatus))
                    {
                        dtTeamUsers = UserMasterDAL.GetUserTeamUsersDetails();
                        BindTeamUsersToGrid(dtTeamUsers);

                        MessageBox.Show("Team Users created successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Clear inputs
                        ClearTeamStructure();
                    }
                    else
                    {
                        MessageBox.Show(strUserStatus, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(strErrormsg.Trim(), GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void tpUser_Management_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tpUser_Management.SelectedTab == tbUserCreate)
                {
                    ResetUserInfoControls();
                }
                else if (tpUser_Management.SelectedTab == tbProfileCreation)
                {
                    FillUserNameDropDown();

                    UserProfileDetails = UserMasterDAL.GetUserProfileDetails();
                    BindUserProfile_DetailsToGrid(UserProfileDetails);

                    clearUserProfile();
                }
                else if (tpUser_Management.SelectedTab == tbTeamCreation)
                {
                    ClearTeamStructure();
                    BindUsersToControls();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnClearTeamDetails_Click(object sender, EventArgs e)
        {
            cmbModule_TU.SelectedIndex = -1;
            cmbQualityAnalyst.SelectedIndex = -1;
            cmbReviewAnalyst.SelectedIndex = -1;
            cmbAnalyst.SelectedIndex = -1;
        }

        #endregion

        #region Grid RowPostPaint Events

        private void dgvUserDet_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUserDet.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUserDet.Font);

                if (dgvUserDet.RowHeadersWidth < (int)(size.Width + 20)) dgvUserDet.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvUserProfile_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUserProfile.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUserProfile.Font);

                if (dgvUserProfile.RowHeadersWidth < (int)(size.Width + 20)) dgvUserProfile.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvTeam_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvTeam.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvTeam.Font);

                if (dgvTeam.RowHeadersWidth < (int)(size.Width + 20)) dgvTeam.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Methods

        private void FillUserNameDropDown()
        {
            try
            {
                UserDetails = UserMasterDAL.GetActiveUserDetails();
                if (UserDetails != null)
                {
                    cmbUserName.DataSource = UserDetails;
                    cmbUserName.ValueMember = "USER_ID";
                    cmbUserName.DisplayMember = "USER_NAME";
                    cmbUserName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void UserProfileDefaultLoad()
        {

            try
            {
                //Get uSer details and bind to grid
                UserProfileDetails = UserMasterDAL.GetUserProfileDetails();

                //Bind USER Role details to grid
                BindUserProfile_DetailsToGrid(UserProfileDetails);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void clearUserProfile()
        {
            try
            {
                cmbRoles.SelectedIndex = -1;
                cmbModule_UR.SelectedIndex = -1;
                cmbUserName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Bind users data to controls
        /// </summary>
        /// <param name="_userDetails"></param>
        private void BindUserDetailsToControls(DataTable _userDetails)
        {
            try
            {
                if (_userDetails != null)
                {
                    if (_userDetails.Rows.Count > 0)
                    {
                        //Set Textbox values
                        txtUserName.Text = _userDetails.Rows[0]["UserName"].ToString();
                        txtEmailAddress.Text = _userDetails.Rows[0]["EmailAddress"].ToString();
                        cmbStatus.SelectedText = _userDetails.Rows[0]["Status"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        /// <summary>
        /// Bind users data to gridview
        /// </summary>
        /// <param name="_userDetails"></param>
        private void BindUser_DetailsToGrid(DataTable _userDetails)
        {
            try
            {
                if (_userDetails != null)
                {
                    if (_userDetails.Rows.Count > 0)
                    {
                        //Remove Administrator
                        _userDetails = RemoveAdministratorFromTable(_userDetails);
                    }
                    colUserID.DataPropertyName = "USER_ID";
                    colUserName.DataPropertyName = "USER_NAME";
                    colEmail.DataPropertyName = "EMAIL_ID";
                    colStatus.DataPropertyName = "IS_ACTIVE";
                    dgvUserDet.AutoGenerateColumns = false;
                    dgvUserDet.DataSource = _userDetails;

                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        private DataTable RemoveAdministratorFromTable(DataTable userDetails)
        {
            DataTable dtUsers = null;
            try
            {
                if (userDetails != null)
                {
                    if (userDetails.Rows.Count > 0)
                    {
                        DataView dvTemp = userDetails.DefaultView;
                        dvTemp.RowFilter = "USER_NAME not in ('Administrator')";
                        dtUsers = dvTemp.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
            return dtUsers;
        }

        /// <summary>
        /// Fill user profiles data  grid view
        /// </summary>
        /// <param name="_userProfileDetails"></param>
        private void BindUserProfile_DetailsToGrid(DataTable _userProfileDetails)
        {
            try
            {
                if (_userProfileDetails != null && _userProfileDetails.Rows.Count > 0)
                {
                    TotalTANs = dgvUserProfile.Rows.Count;
                    _userProfileDetails.Rows.RemoveAt(0);
                    _userProfileDetails.AcceptChanges();

                    dgvUserProfile.AutoGenerateColumns = false;
                    bsReport.RemoveFilter();

                    bsReport.DataSource = _userProfileDetails;
                    dgvUserProfile.DataSource = bsReport;

                    dgvUserProfile_BindingContextChanged(null, null);


                    colUserRoleId.DataPropertyName = "UR_ID";
                    co_User_Name.DataPropertyName = "USER_NAME";
                    col_User_Role.DataPropertyName = "ROLE_NAME";
                    colModule.DataPropertyName = "MODULE";
                    colAction.DataPropertyName = "IS_ACTIVE";
                    colUserRoleId.Visible = false;

                }
                else
                {
                    bsReport.DataSource = null;
                    dgvUserProfile.DataSource = bsReport;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }

        }

        /// <summary>
        /// Fill users dropdown
        /// </summary>
        /// <param name="_userDetails"></param>
        private void BindUserDetailsToDropdown(DataTable _userDetails)
        {
            try
            {
                if (_userDetails != null)
                {
                    cmbUserName.DataSource = _userDetails;
                    cmbUserName.ValueMember = "USER_ID";
                    cmbUserName.DisplayMember = "USER_NAME";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        /// <summary>
        /// Fill Roles dropdown
        /// </summary>
        /// <param name="_userRoles"></param>
        private void BindUserRolesToDropdown(DataTable _userRoles)
        {
            try
            {
                if (_userRoles != null)
                {
                    cmbRoles.DataSource = _userRoles;
                    cmbRoles.ValueMember = "ROLE_ID";
                    cmbRoles.DisplayMember = "ROLE_NAME";
                    cmbRoles.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        /// <summary>
        /// Validate user creation form
        /// </summary>
        /// <param name="_errmsg_out"></param>
        /// <returns></returns>
        private bool ValidateUserInputs(out string _errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";

            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    strErrMsg = "User Name can't be null";
                    blStatus = false;
                }

                if (string.IsNullOrEmpty(txtEmailAddress.Text.Trim()))
                {
                    strErrMsg = strErrMsg + "\r\n" + "Email Address can't be null";
                    blStatus = false;
                }
                else if (!Regex.IsMatch(txtEmailAddress.Text.Trim(), @"^(?("")(""[^""]+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"))
                {
                    strErrMsg = strErrMsg + "\r\n" + "Email address not valid";
                    blStatus = false;
                }
                if (txtPassword.Enabled)
                {
                    if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        strErrMsg = strErrMsg + "\r\n" + "Password can't be null";
                        blStatus = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
            _errmsg_out = strErrMsg;
            return blStatus;
        }

        private bool ValidateProfileInputs(out string _errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";

            try
            {
                if (cmbUserName.SelectedIndex == -1)
                {
                    strErrMsg = "User name can't be null";
                    blStatus = false;
                }
                if (cmbRoles.SelectedIndex == -1)
                {
                    strErrMsg = strErrMsg + "\r\n" + "User role can't be null";
                    blStatus = false;
                }

                if (cmbRoles.SelectedIndex != -1)
                {
                    if (cmbRoles.Text.ToUpper() != "ADMINISTRATOR" && cmbRoles.Text.ToUpper() != "PROJECT MANAGER")
                    {
                        if (cmbModule_UR.SelectedIndex == -1)
                        {
                            strErrMsg = strErrMsg + "\r\n" + "Module can't be null";
                            blStatus = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
            _errmsg_out = strErrMsg;
            return blStatus;
        }

        private bool ValidateUserRoleDetails(out string strErrormsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {

                if (dgvUserProfile.Rows.Count > 0)
                {
                    DataView dvTemp = null;
                    dvTemp = UserProfileDetails.Copy().DefaultView;
                    if (cmbRoles.Text.ToUpper() == "ADMINISTRATOR" || cmbRoles.Text.ToUpper() == "PROJECT MANAGER")
                    {
                        IsAdminOrPmExists(cmbUserName.Text, cmbRoles.Text, ref blStatus, ref strErrMsg, dvTemp);
                    }
                    else if (cmbRoles.Text.ToUpper() == "TOOL MANAGER")
                    {
                        IsToolManagerExists(cmbModule_UR.Text, cmbRoles.Text, ref blStatus, ref strErrMsg, dvTemp);
                    }
                    else
                    {
                        IsUserRoleExists(cmbUserName.Text, cmbRoles.Text, cmbModule_UR.Text, ref blStatus, ref strErrMsg, dvTemp);
                    }
                }

                //if (cmbRoles.Text != "Tool Manager")
                //{
                //    blStatus = true;
                //}
                //else
                //{
                //    DataTable dtProfile = CheckUserProfileDetails();
                //    if (dtProfile != null)
                //    {
                //        if (dtProfile.Rows.Count > 0)
                //        {
                //            blStatus = false;
                //            strErrMsg = "Tool Manager Already Created for this Application";
                //        }
                //    }
                //}



            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            strErrormsg = strErrMsg;
            return blStatus;
        }
        
        private void IsAdminOrPmExists(string ldapId, string role, ref bool blStatus, ref string strErrMsg, DataView dvTemp)
        {
            try
            {
                dvTemp.RowFilter = "ROLE_NAME='" + role + "'";
                DataTable dtTemp = dvTemp.ToTable();
                if (dtTemp != null)
                {
                    if (dtTemp.Rows.Count > 0)
                    {
                        blStatus = false;
                        strErrMsg = strErrMsg.Trim() + "\r\n" + role + " Role already allocated.";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void IsUserRoleExists(string ldapId, string role, string module, ref bool blStatus, ref string strErrMsg, DataView dvTemp)
        {
            try
            {
                dvTemp.RowFilter = "USER_NAME= '" + ldapId + "' and ROLE_NAME= '" + role + "' and MODULE= '" + module + "'";
                DataTable dtTemp = dvTemp.ToTable();
                if (dtTemp != null)
                {
                    if (dtTemp.Rows.Count > 0)
                    {
                        blStatus = false;
                        strErrMsg = strErrMsg.Trim() + "\r\n" + role + " Role already allocated to " + ldapId + " for module " + module;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void IsUserExistsInTeam(string ldapId, string role, string module, ref bool blStatus, ref string strErrMsg, DataView dvTemp)
        {
            try
            {
                string Temprole = string.Empty;
                if (role == "Analyst")
                {
                    Temprole = "ANALYST_NAME";
                }
                else if (role == "Review Analyst")
                {
                    Temprole = "REVEIWER_NAME";
                }
                else if (role == "Quality Analyst")
                {
                    Temprole = "QC_NAME";
                }

                dvTemp.RowFilter = "" + Temprole + "= '" + ldapId + "' and MODULE= '" + module + "'";
                DataTable dtTemp = dvTemp.ToTable();
                if (dtTemp != null && dtTemp.Rows.Count > 0)
                {
                    blStatus = false;
                    strErrMsg = strErrMsg.Trim() + "\r\n" + role + " Role already allocated to " + ldapId + " for module " + module;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void IsToolManagerExists(string module, string role, ref bool blStatus, ref string strErrMsg, DataView dvTemp)
        {
            try
            {
                dvTemp.RowFilter = "MODULE= '" + module + "' and ROLE_NAME= '" + role + "'";
                DataTable dtTemp = dvTemp.ToTable();
                if (dtTemp != null)
                {
                    if (dtTemp.Rows.Count > 0)
                    {
                        blStatus = false;
                        strErrMsg = strErrMsg.Trim() + "\r\n" + role + " Role already allocated for module " + module;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private DataTable CheckUserProfileDetails()
        {
            DataTable dtUserProfileDetails = null;
            try
            {
                dtUserProfileDetails = UserMasterDAL.CheckUserProfileDetails(cmbModule_UR.Text);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }

            return dtUserProfileDetails;

        }

        private DataTable GetUserDetailsTableDefinition()
        {
            DataTable dtUserDetails = null;
            try
            {
                dtUserDetails = new DataTable();
                dtUserDetails.Columns.Add("USER_NAME");
                dtUserDetails.Columns.Add("EMP_NAME");
                dtUserDetails.Columns.Add("EMAIL_ADDRESS");
                dtUserDetails.Columns.Add("STATUS");
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }

            return dtUserDetails;
        }
                
        private void ResetUserInfoControls()
        {
            try
            {
                txtUserName.Text = "";
                txtEmailAddress.Text = "";
                cmbStatus.SelectedIndex = 0;
                txtPassword.Text = "";
                txtPassword.Enabled = false;
                txtUserName.ReadOnly = false;

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        private void FilterAnalystsAndBindToControl(DataTable analystsData, DataTable teamUsersData)
        {
            try
            {
                if (analystsData != null && teamUsersData != null)
                {
                    cmbAnalyst.ValueMember = "UR_ID";
                    cmbAnalyst.DisplayMember = "USER_NAME";

                    //Get all the existing analysts in the team
                    var analysts = (from DataRow dr in teamUsersData.AsEnumerable()
                                  select dr["ANALYST_NAME"]);

                    string filterCond = "";
                    foreach (string analyst in analysts)
                    {
                        filterCond = string.IsNullOrEmpty(filterCond.Trim()) ? "'" + analyst + "'" : filterCond.Trim() + "," + "'" + analyst + "'";
                    }

                    if (!string.IsNullOrEmpty(filterCond))
                    {
                        //Filter all the analysts 
                        DataRow[] drAnalystsRem = analystsData.Select("USER_NAME not in (" + filterCond + ")");

                        if (drAnalystsRem != null)
                        {
                            cmbAnalyst.DataSource = drAnalystsRem.CopyToDataTable();                            
                        }
                    }
                    else
                    {
                        cmbAnalyst.DataSource = analystsData;                        
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); 
            }
        }

        private void BindUsersToControls()
        {
            try
            {
                string strModuleName = cmbModule_TU.Text.ToString();
                DataTable dtUsers = null;
                if (!string.IsNullOrEmpty(cmbModule_TU.Text.Trim()))
                {                    
                    // 4 indicates Quality Analyst RoleID
                    dtUsers = UserMasterDAL.GetUserDetailsByApplicationAndRoleID(strModuleName, 4);           
                    if (dtUsers != null)
                    {
                        cmbQualityAnalyst.DataSource = dtUsers;
                        cmbQualityAnalyst.ValueMember = "UR_ID";
                        cmbQualityAnalyst.DisplayMember = "USER_NAME";
                    }

                    //// 5 indicates Review Analyst RoleID
                    dtUsers = UserMasterDAL.GetUserDetailsByApplicationAndRoleID(strModuleName, 5);
                    if (dtUsers != null)
                    {
                        cmbReviewAnalyst.DataSource = dtUsers;

                        cmbReviewAnalyst.ValueMember = "UR_ID";
                        cmbReviewAnalyst.DisplayMember = "USER_NAME";
                    }

                    //// 6 indicates Analyst RoleID
                    dtUsers = UserMasterDAL.GetUserDetailsByApplicationAndRoleID(strModuleName, 6);
                    
                    //Filter Analysts and bind to control
                    FilterAnalystsAndBindToControl(dtUsers, _dtTeamUsers);
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        private void BindTeamUsersToGrid(DataTable userTeamDetails)
        {
            try
            {
                TotalTeams = userTeamDetails.Rows.Count;
                _dtTeamUsers = userTeamDetails;

                bsTeam.DataSource = _dtTeamUsers;
                dgvTeam.AutoGenerateColumns = false;
                dgvTeam.DataSource = bsTeam;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
        }

        private bool ValidateTeamCreationInputs(out string _errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";

            try
            {
                if (string.IsNullOrEmpty(cmbModule_TU.Text))
                {
                    strErrMsg = strErrMsg + "\r\n" + "Module can't be null";
                    blStatus = false;
                }

                if (string.IsNullOrEmpty(cmbQualityAnalyst.Text))
                {
                    strErrMsg = strErrMsg + "\r\n" + "Quality Analyst can't be null";
                    blStatus = false;
                }
                if (string.IsNullOrEmpty(cmbReviewAnalyst.Text))
                {
                    strErrMsg = strErrMsg + "\r\n" + "Review Analyst can't be null";
                    blStatus = false;
                }
                if (string.IsNullOrEmpty(cmbAnalyst.Text))
                {
                    strErrMsg = strErrMsg + "\r\n" + "Analyst can't be null";
                    blStatus = false;
                }

                if (dgvTeam.Rows.Count > 0)
                {

                    DataView dvTemp = null;
                    dvTemp = _dtTeamUsers.Copy().DefaultView;

                    IsTeamExists(cmbModule_TU.Text, cmbQualityAnalyst.Text, cmbReviewAnalyst.Text, cmbAnalyst.Text, ref blStatus, ref strErrMsg, dvTemp);

                    if (blStatus)
                    {
                        IsUserExistsInTeam(cmbAnalyst.Text, "Analyst", cmbModule_TU.Text, ref blStatus, ref strErrMsg, _dtTeamUsers.Copy().DefaultView);
                    }
                    if (blStatus)
                    {                       
                        IsReviewerAnalystUniqueInTeam(cmbReviewAnalyst.Text, cmbAnalyst.Text, cmbModule_TU.Text, ref blStatus, ref strErrMsg, _dtTeamUsers.Copy().DefaultView);
                        if (blStatus)
                        {
                            IsQAReviewerValidationInTeam(cmbQualityAnalyst.Text, cmbReviewAnalyst.Text, cmbModule_TU.Text, ref blStatus, ref strErrMsg, _dtTeamUsers.Copy().DefaultView);    
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString()); ;
            }
            _errmsg_out = strErrMsg.Trim();
            return blStatus;
        }

        private void IsReviewerAnalystUniqueInTeam(string reviewer, string analyst, string module, ref bool blStatus, ref string strErrMsg, DataView dvTemp)
        {           
            try
            {
                if (reviewer.ToUpper() != "AUTO.PROCESS")
                {
                    dvTemp.RowFilter = "MODULE= '" + module + "' and REVEIWER_NAME= '" + reviewer + "' and ANALYST_NAME= '" + analyst + "'";
                    DataTable dtTemp = dvTemp.ToTable();
                    if (dtTemp != null && dtTemp.Rows.Count > 0)
                    {
                        blStatus = false;
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "Analyst already Assigned to Reviewer.";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void IsQAReviewerValidationInTeam(string qc, string reviewer, string module, ref bool blStatus, ref string strErrMsg, DataView dvTemp)
        {
            try
            {
                if (qc.ToUpper() != "AUTO.PROCESS" && reviewer.ToUpper() != "AUTO.PROCESS")
                {
                    dvTemp.RowFilter = "MODULE= '" + module + "' and REVEIWER_NAME= '" + reviewer + "' and QC_NAME not in ('" + qc + "')";
                    DataTable dtTemp = dvTemp.ToTable();
                    if (dtTemp != null && dtTemp.Rows.Count > 0)
                    {
                        blStatus = false;
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "Reviewer already assigned to another QC.";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }


        private void IsTeamExists(string modulename, string qc, string reviewer, string analyst, ref bool blStatus, ref string strErrMsg, DataView dvTemp)
        {
            try
            {
                dvTemp.RowFilter = "MODULE= '" + modulename + "' and QC_NAME= '" + qc + "' and REVEIWER_NAME= '" + reviewer + "' and ANALYST_NAME= '" + analyst + "'";
                DataTable dtTemp = dvTemp.ToTable();
                if (dtTemp != null)
                {
                    if (dtTemp.Rows.Count > 0)
                    {
                        blStatus = false;
                        strErrMsg = strErrMsg.Trim() + "\r\n" + " Team already created";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ClearTeamStructure()
        {
            cmbModule_TU.SelectedIndex = -1;
            cmbQualityAnalyst.SelectedIndex = -1;
            cmbReviewAnalyst.SelectedIndex = -1;
            cmbAnalyst.SelectedIndex = -1;
        }

        #endregion

        private void cmbModule_UR_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRoles.SelectedItem != null)
                {
                    if (cmbRoles.Text.ToUpper() == "ADMINISTRATOR" || cmbRoles.Text.ToUpper() == "PROJECT MANAGER")
                    {
                        cmbModule_UR.SelectedIndex = -1;
                        cmbModule_UR.Enabled = false;
                    }
                    else
                    {
                        cmbModule_UR.Enabled = true;
                        cmbModule_UR.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvUserProfile_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                String filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dgvUserProfile);
                if (String.IsNullOrEmpty(filterStatus))
                {
                    lnkClearFilter.Visible = false;
                }
                else
                {
                    lnkClearFilter.Visible = true;
                }
                if (TotalTANs == dgvUserProfile.Rows.Count)
                {
                    lnkClearFilter.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void lnkClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lnkClearFilter.Visible = false;

                DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvUserProfile);

                bsReport.DataSource = UserProfileDetails;
                dgvUserProfile.DataSource = bsReport;

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvUserProfile_BindingContextChanged(object sender, EventArgs e)
        {
            try
            {
                // Continue only if the data source has been set.
                if (dgvUserProfile.DataSource == null)
                {
                    return;
                }

                // Add the AutoFilter header cell to each column.
                foreach (DataGridViewColumn col in dgvUserProfile.Columns)
                {
                    if (col.HeaderText != "")
                        col.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
                }

                // Format the OrderTotal column as currency. 
                // dgvDailyStatus.Columns["OrderTotal"].DefaultCellStyle.Format = "c";

                // Resize the columns to fit their contents.
                //  dgvUserTaskSheet.AutoResizeColumns();


            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvUserProfile_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        
        private void lnkTeamUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lnkTeamUsers.Visible = false;

                DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvTeam);

                bsTeam.DataSource = _dtTeamUsers;
                dgvTeam.DataSource = bsTeam;

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvTeam_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                String filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dgvTeam);
                if (String.IsNullOrEmpty(filterStatus))
                {
                    lnkTeamUsers.Visible = false;
                }
                else
                {
                    lnkTeamUsers.Visible = true;
                }
                if (TotalTeams == dgvTeam.Rows.Count)
                {
                    lnkTeamUsers.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvTeam_BindingContextChanged(object sender, EventArgs e)
        {
            try
            {
                // Continue only if the data source has been set.
                if (dgvTeam.DataSource == null)
                {
                    return;
                }

                // Add the AutoFilter header cell to each column.
                foreach (DataGridViewColumn col in dgvTeam.Columns)
                {
                    if (col.HeaderText != "")
                        col.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
                }

                // Format the OrderTotal column as currency. 
                // dgvDailyStatus.Columns["OrderTotal"].DefaultCellStyle.Format = "c";

                // Resize the columns to fit their contents.
                //  dgvUserTaskSheet.AutoResizeColumns();


            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvTeam_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgvTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex > 0 && e.RowIndex >= 0)
                {
                    if (dgvTeam.Columns[e.ColumnIndex].HeaderText.ToString().ToUpper() == "INACTIVE")
                    {
                        string statusMsg = string.Empty;

                        if (MessageBox.Show("Do you want to in-active the selected user team?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            int teamUserID = Convert.ToInt32(dgvTeam.Rows[e.RowIndex].Cells[colTeamUserID.Name].Value.ToString());

                            if (UserMasterDAL.InActivateTeamUser(teamUserID, out statusMsg))
                            {
                                if (statusMsg.ToUpper() == "SUCCESS")
                                {
                                    MessageBox.Show("User team inactivated successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    DataTable dtTeamUsers = UserMasterDAL.GetUserTeamUsersDetails();
                                    BindTeamUsersToGrid(dtTeamUsers);
                                }
                                else
                                {
                                    MessageBox.Show("Unable to inactivate user team, please contact Administrator", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
    }
}
