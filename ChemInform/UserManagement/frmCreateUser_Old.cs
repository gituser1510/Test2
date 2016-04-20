using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.Dal;
using ChemInform.Bll.UsersManagment;
using ChemInform.Common;

namespace ChemInform.UserManagement
{

    public partial class frmCreateUser_Old : Form
    {
        public frmCreateUser_Old()
        {
            InitializeComponent();
        }

        #region LocalVarialbles

        int TempUserId = -1;
        int TempUserRoleId = -1;
        int TempUserMappingId = -1;
        bool blEditUser = false;
        bool blEditTeam = false;
        string strErrMsg = string.Empty;

        public DataTable dtUsers = null;
        public DataTable dtAssignedRolesWithUsers = null;
        public DataTable dtTeamUsers = null;

        #endregion

        /// <summary>
        /// Load Roles, Moduels, already created users.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
                BindRoles();
                UpdateUsers();
                chkIsUserActive.Enabled = false;
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Users Creation.

        /// <summary>
        /// Update user details to Datagrid and combobox.
        /// </summary>
        private void UpdateUsers()
        {
            try
            {
                using (DataTable dtUserDetails = UserManagementDB.GetAllUsers())
                {
                    dtUsers = new DataTable();
                    if (dtUserDetails != null)
                    {
                        if (dtUserDetails.Rows.Count > 0)
                        {
                            dtUsers = dtUserDetails;
                            dgvUsers.AutoGenerateColumns = false;
                            dgvUsers.DataSource = dtUserDetails;

                            colUserId.DataPropertyName = "USER_ID";
                            colUserName.DataPropertyName = "USER_NAME";
                            colEmail.DataPropertyName = "EMAIL_ID";
                            colStatus.DataPropertyName = "IS_ACTIVE";

                            BindAllAcitveUserNames(dtUserDetails);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Create user and updates users status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            strErrMsg = "";
            try
            {
                if (ValidateUserInputs(out strErrMsg))
                {
                    if (LdapAuthentication.ValidateUserWithLDAP(txtEmail.Text.Trim()))
                    {
                        User objUser = new User();
                        objUser.Name = txtEmail.Text.Trim().ToLower();
                        objUser.EmailId = txtEmail.Text.Trim().ToLower() + lblEmailDomain.Text;
                        objUser.ID = TempUserId;
                        objUser.IsActive = chkIsUserActive.Checked ? 'Y' : 'N';

                        if (objUser.ID == -1)  // Create new User.
                        {
                            if (SaveUser(objUser) != -1)
                            {
                                MessageBox.Show("Created new user successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else // update user.
                        {
                            if (SaveUser(objUser) != -1)
                            {
                                MessageBox.Show("User updated successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        UpdateUsers();
                        ResetControls();
                    }
                    else
                    {
                        MessageBox.Show("User details not found...", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }

        }

        /// <summary>
        /// Save user and Update user.
        /// </summary>
        /// <param name="objUser">An Instance of user.</param>
        /// <returns>Returns user id if saves. Otherwise default value (-1).</returns>
        private int SaveUser(User objUser)
        {
            try
            {
                return UserManagementDB.SaveUser(objUser);
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return 0;
        }

        /// <summary>
        /// Check mandatory fields for user creation or Updation.
        /// </summary>
        /// <param name="_errmsg">Summary Error message.</param>
        /// <returns>True Mandatory fields are filled. Otherwise false.</returns>
        private bool ValidateUserInputs(out string _errmsg)
        {
            bool blStatus = true;
            strErrMsg = "";
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please enter Email.";
                    blStatus = false;
                }
                if (blStatus && TempUserId == -1)
                {
                    if (dtUsers.Rows.Count > 0)
                    {
                        DataView dvTemp = dtUsers.Copy().DefaultView;
                        dvTemp.RowFilter = "USER_NAME = '" + txtEmail.Text + " '";
                        DataTable dtTemp = dvTemp.ToTable();
                        if (dtTemp != null)
                        {
                            if (dtTemp.Rows.Count > 0)
                            {
                                blStatus = false;
                                strErrMsg = txtEmail.Text + " already exist";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            _errmsg = strErrMsg;
            return blStatus;
        }

        /// <summary>
        /// Set InputControls with user information to Update.
        /// </summary>
        /// <param name="dataGridViewRow">Datagridview row to Update.</param>
        private void SetUserDetails(DataGridViewRow dataGridViewRow)
        {
            try
            {
                txtEmail.Text = (string)dataGridViewRow.Cells["colUserName"].Value;
                TempUserId = Convert.ToInt32(dataGridViewRow.Cells["colUserId"].Value.ToString());
                if (dataGridViewRow.Cells["colStatus"].Value.ToString() == "N")
                {
                    chkIsUserActive.Checked = false;
                }
                else
                {
                    chkIsUserActive.Checked = true;
                }
                chkIsUserActive.Enabled = true;
                btnCreate.Text = "Update";
                txtEmail.ReadOnly = true;
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// To Set input control values when users clicks on edit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvUsers.Columns[e.ColumnIndex].Name == "colEdit") //(dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        SetUserDetails(dgvUsers.Rows[e.RowIndex]);
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Reset User Creation Controls

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        /// <summary>
        /// Reset Input Controls.
        /// </summary>
        private void ResetControls()
        {
            txtEmail.Clear();
            chkIsUserActive.Checked = true;
            chkIsUserActive.Enabled = false;
            btnCreate.Text = "Create";
            txtEmail.ReadOnly = false;
        }

        #endregion

        #endregion

        #region Assigning Roles.

        /// <summary>
        /// Bind Modules checkbox.
        /// </summary>
        private void BindModules(ref ComboBox cmb)
        {
            try
            {
                DataTable dtModules = DataOperations.GetAllModules();
                if (dtModules.Rows.Count > 0)
                {
                    cmb.DataSource = dtModules;
                    cmb.DisplayMember = "MODULE_NAME";
                    cmb.ValueMember = "MODULE_VALUE";
                    cmb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Bind Roles.
        /// </summary>
        private void BindRoles()
        {
            try
            {
                DataTable dtRoles = UserManagementDB.GetAllMasterRoles();
                if (dtRoles.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbUcRole.DataSource = dtRoles;
                    cmbUcRole.DisplayMember = "ROLE_NAME";
                    cmbUcRole.ValueMember = "ROLE_ID";
                    cmbUcRole.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Filter userdetatils datatable for active users.
        /// </summary>
        /// <param name="dtUserDetails">All users(Active & InActive)</param>
        private void BindAllAcitveUserNames(DataTable dtUserDetails)
        {
            try
            {
                DataView dvTemp = dtUserDetails.Copy().DefaultView;
                dvTemp.RowFilter = "IS_ACTIVE='Y'";
                dtUserDetails = dvTemp.ToTable();
                //Bind User names to combobox
                cmbUserName.DataSource = dtUserDetails.Copy();
                cmbUserName.DisplayMember = "USER_NAME";
                cmbUserName.ValueMember = "USER_ID";
                cmbUserName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Create or Update user role.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_UsrRole_Click(object sender, EventArgs e)
        {
            try
            {
                strErrMsg = "";

                if (ValidateUserRoleInputs(out strErrMsg))
                {
                    UserRole objUserInfo = new UserRole();
                    objUserInfo.UserID = Convert.ToInt32(cmbUserName.SelectedValue);
                    objUserInfo.RoleId = Convert.ToInt32(cmbUcRole.SelectedValue);
                    objUserInfo.ModuleName = (string)cmbAssignToModule.SelectedValue;
                    objUserInfo.IsActive = chkIsRoleActive.Checked ? 'Y' : 'N';

                    if (TempUserRoleId == -1)
                    {
                        if (SaveUserRole(objUserInfo) != -1)
                        {
                            MessageBox.Show("Role assigned successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        objUserInfo.UserRoleId = TempUserRoleId;
                        if (SaveUserRole(objUserInfo) != -1)
                        {
                            MessageBox.Show("Role updated successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    UpdateUserRolesGrid();
                    ResetUserRoleControls();

                }
                else
                {
                    MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Fill user roles Datagridview.
        /// </summary>
        private void UpdateUserRolesGrid()
        {
            try
            {
                using (DataTable dtUserRoleDetails = UserManagementDB.GetUserRoleDetails())
                {
                    dtAssignedRolesWithUsers = new DataTable();
                    if (dtUserRoleDetails != null)
                    {
                        if (dtUserRoleDetails.Rows.Count > 0)
                        {
                            dtAssignedRolesWithUsers = dtUserRoleDetails;

                            dgvUserRoles.AutoGenerateColumns = false;
                            dgvUserRoles.DataSource = dtUserRoleDetails;

                            colAssignedToUserName.DataPropertyName = "USER_NAME";
                            colAssignUserRole.DataPropertyName = "ROLE_NAME";
                            colAssignedModule.DataPropertyName = "APP_MODULE";
                            colRoleStatus.DataPropertyName = "IS_ACTIVE";
                            colAssignedUrId.DataPropertyName = "UR_ID";
                        }
                    }
                }

            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Inserts the new role for user or updates an existing role.
        /// </summary>
        /// <param name="objUserInfo">An instance of UserRole class.</param>
        /// <returns>Returns user role id if saves. Otherwise default value (-1).</returns>
        private int SaveUserRole(UserRole objUserInfo)
        {
            try
            {
                return UserManagementDB.SaveUserRole(objUserInfo);
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return 0;
        }

        /// <summary>
        /// Reset UserRole Input controls.
        /// </summary>
        private void ResetUserRoleControls()
        {
            cmbUserName.SelectedIndex = -1;
            cmbUcRole.SelectedIndex = -1;
            cmbAssignToModule.SelectedIndex = -1;

            cmbUserName.Enabled = true;
            cmbUcRole.Enabled = true;
            cmbAssignToModule.Enabled = false;

            TempUserRoleId = -1;
            blEditUser = false;

            chkIsRoleActive.Enabled = false;
            chkIsRoleActive.Checked = true;
            btnCreate_UsrRole.Text = "Create";
        }

        /// <summary>
        /// Check mandatory fields for user role creation or Updation.
        /// </summary>
        /// <param name="_errmsg">Summary Error message.</param>
        /// <returns>True Mandatory fields are filled. Otherwise false.</returns>
        private bool ValidateUserRoleInputs(out string _errmsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            DataTable dtTemp = null;
            try
            {
                if (cmbUserName.SelectedItem == null)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select User name", strErrMsg.Trim());
                    blStatus = false;
                }
                if (cmbUcRole.SelectedItem == null)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Role", strErrMsg.Trim());
                    blStatus = false;
                }

                if (cmbAssignToModule.SelectedItem == null && !(cmbUcRole.Text == "Project Manager" || cmbUcRole.Text == "Delivery Manager" || cmbUcRole.Text == "Administrator" || cmbUcRole.Text == "Task Preparation"))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select Module";
                    blStatus = false;
                }
                if (blStatus && !blEditUser)
                {
                    if (dtAssignedRolesWithUsers.Rows.Count > 0)
                    {
                        DataView dvTemp = dtAssignedRolesWithUsers.Copy().DefaultView; 
                        if (cmbUcRole.Text == "Project Manager" || cmbUcRole.Text == "Administrator" || cmbUcRole.Text == "Delivery Manager" || cmbUcRole.Text == "Task Preparation")
                        {
                            dvTemp.RowFilter = "USER_NAME = '" + cmbUserName.Text + " ' and ROLE_NAME = '" + cmbUcRole.Text + "'";
                            dtTemp = dvTemp.ToTable();
                            if (dtTemp != null)
                            {
                                if (dtTemp.Rows.Count > 0)
                                {
                                    blStatus = false;
                                    strErrMsg = cmbUserName.Text + " - " + cmbUcRole.Text + " already exist";
                                }
                            }
                        }
                        else
                        {
                            dvTemp.RowFilter = "USER_NAME = '" + cmbUserName.Text + " ' and ROLE_NAME = '" + cmbUcRole.Text + "' and APP_MODULE = '" + (string)cmbAssignToModule.SelectedValue + "'";
                            dtTemp = dvTemp.ToTable();
                            if (dtTemp != null)
                            {
                                if (dtTemp.Rows.Count > 0)
                                {
                                    blStatus = false;
                                    strErrMsg = cmbUserName.Text + " - " + cmbUcRole.Text + " already existed in " + cmbAssignToModule.Text;
                                }
                            }
                            if (blStatus)
                            {
                                if (cmbAssignToModule.SelectedItem != null)
                                {
                                    if (cmbAssignToModule.SelectedValue.ToString() == "TP")
                                    {
                                        blStatus = false;
                                        strErrMsg = "User belongs to either Reaction or Spectral Analysis.";
                                    }
                                }
                            }
                        }

                        if (cmbUcRole.Text == "Project Manager" && !blEditUser) // Check Project manager already created or not.
                        {
                            dvTemp = dtAssignedRolesWithUsers.Copy().DefaultView;
                            dvTemp.RowFilter = "ROLE_NAME ='Project Manager' and IS_ACTIVE='Y'";
                            dtTemp = dvTemp.ToTable();
                            if (dtTemp != null)
                            {
                                if (dtTemp.Rows.Count > 0)
                                {
                                    blStatus = false;
                                    strErrMsg = "Project Manager already Created";
                                }
                            }
                            if (blStatus && !blEditUser) // if the same user assigned as Delivery manager.
                            {
                                dvTemp = dtAssignedRolesWithUsers.Copy().DefaultView;
                                dvTemp.RowFilter = "ROLE_NAME = 'Delivery Manager'"; //"USER_NAME = '" + cmbUserName.Text + " ' and ROLE_NAME = 'Delivery Manager' ";
                                dtTemp = dvTemp.ToTable();
                                if (dtTemp != null)
                                {
                                    if (dtTemp.Rows.Count > 0)
                                    {
                                        blStatus = false;
                                        strErrMsg = cmbUserName.Text + " already assigned as Delivery Manager.";
                                    }
                                }
                            }
                        }

                        if (cmbUcRole.Text == "Administrator" && !blEditUser) // Check Administrator already created or not.
                        {
                            dvTemp = dtAssignedRolesWithUsers.Copy().DefaultView;
                            dvTemp.RowFilter = "ROLE_NAME ='Administrator' and IS_ACTIVE='Y'";
                            dtTemp = dvTemp.ToTable();
                            if (dtTemp != null)
                            {
                                if (dtTemp.Rows.Count > 0)
                                {
                                    blStatus = false;
                                    strErrMsg = "Administrator already Created";
                                }
                            }
                        }

                        if (cmbUcRole.Text == "Delivery Manager" && !blEditUser) // Check Delivery Manager already created or not.
                        {
                            dvTemp = dtAssignedRolesWithUsers.Copy().DefaultView;
                            dvTemp.RowFilter = "ROLE_NAME ='Delivery Manager' and IS_ACTIVE='Y'";
                            dtTemp = dvTemp.ToTable();
                            if (dtTemp != null)
                            {
                                if (dtTemp.Rows.Count > 0)
                                {
                                    blStatus = false;
                                    strErrMsg = "Delivery Manager already Created";
                                }
                            }
                            if (blStatus && !blEditUser) // if the same user assigned as Project Manager.
                            {
                                dvTemp = dtAssignedRolesWithUsers.Copy().DefaultView;
                                dvTemp.RowFilter = "USER_NAME = '" + cmbUserName.Text + " ' and ROLE_NAME = 'Project Manager' and IS_ACTIVE='Y'";
                                dtTemp = dvTemp.ToTable();
                                if (dtTemp != null)
                                {
                                    if (dtTemp.Rows.Count > 0)
                                    {
                                        blStatus = false;
                                        strErrMsg = cmbUserName.Text + " already assigned as Project Manager.";
                                    }
                                }
                            }
                        }


                        if (cmbUcRole.Text == "Module Head" && !blEditUser)
                        {

                            dvTemp = dtAssignedRolesWithUsers.Copy().DefaultView;
                            dvTemp.RowFilter = "ROLE_NAME = '" + cmbUcRole.Text + "' and APP_MODULE = '" + (string)cmbAssignToModule.SelectedValue + "'";
                            dtTemp = dvTemp.ToTable();
                            if (dtTemp != null)
                            {
                                if (dtTemp.Rows.Count > 0)
                                {
                                    blStatus = false;
                                    strErrMsg = (string)cmbAssignToModule.SelectedValue + " Module Head already Created";
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
            _errmsg = strErrMsg;
            return blStatus;

        }

        /// <summary>
        /// Restrict Module selection for Project Manager,Delivery Manager,Administrator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUcRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbUcRole.SelectedIndex != -1 && cmbUcRole.SelectedItem != null)
                {
                    if (cmbUcRole.Text == "Task Preparation")
                    {
                        cmbAssignToModule.SelectedIndex = cmbAssignToModule.FindStringExact(cmbUcRole.Text);
                        cmbAssignToModule.Enabled = false;
                    }
                    else if (cmbUcRole.Text == "Project Manager" || cmbUcRole.Text == "Delivery Manager" || cmbUcRole.Text == "Administrator")
                    {
                        cmbAssignToModule.Enabled = false;
                        cmbAssignToModule.SelectedIndex = -1;
                    }
                    else
                    {
                        cmbAssignToModule.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// To Set input control values when users clicks on edit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvUserRoles.Columns[e.ColumnIndex].Name == "colRoleEdit") //(dgvUserRoles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        SetRoleDetails(dgvUserRoles.Rows[e.RowIndex]);
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Set InputControls with user information to Update.
        /// </summary>
        /// <param name="dataGridViewRow">">Datagridview row to Update.</param>
        private void SetRoleDetails(DataGridViewRow dataGridViewRow)
        {
            try
            {
                cmbUserName.Enabled = false;
                cmbUcRole.Enabled = false;
                cmbAssignToModule.Enabled = false;
                cmbUserName.SelectedIndex = cmbUserName.FindStringExact((string)dataGridViewRow.Cells["colAssignedToUserName"].Value);
                cmbUcRole.SelectedIndex = cmbUcRole.FindStringExact((string)dataGridViewRow.Cells["colAssignUserRole"].Value);
                TempUserRoleId = Convert.ToInt32(dataGridViewRow.Cells["colAssignedUrId"].Value);
                if (dataGridViewRow.Cells["colAssignedModule"].Value != null)
                {
                    string Module = null;
                    if (dataGridViewRow.Cells["colAssignedModule"].Value.ToString() == "RA")
                    {
                        Module = "Reaction Analysis";
                    }
                    else if (dataGridViewRow.Cells["colAssignedModule"].Value.ToString() == "SA")
                    {
                        Module = "Spectral Analysis";
                    }
                    else if (dataGridViewRow.Cells["colAssignedModule"].Value.ToString() == "TP")
                    {
                        Module = "Task Preparation";
                    }
                    cmbAssignToModule.SelectedIndex = cmbAssignToModule.FindStringExact(Module);
                }
                if (dataGridViewRow.Cells["colRoleStatus"].Value.ToString() == "N")
                {
                    chkIsRoleActive.Checked = false;
                }
                else
                {
                    chkIsRoleActive.Checked = true;
                }
                chkIsRoleActive.Enabled = true;
                btnCreate_UsrRole.Text = "Update";
                blEditUser = true;
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Reset Role Input Controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetRole_Click(object sender, EventArgs e)
        {
            ResetUserRoleControls();
        }


        #endregion

        #region Team Users Creation.

        /// <summary>
        /// Create Team user mapping and updates Team user mapping status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeamUserCreate_Click(object sender, EventArgs e)
        {
            strErrMsg = "";
            try
            {
                if (ValidateTeamUserInputs(out strErrMsg))
                {
                    TeamUsers objTeamUser = new TeamUsers();
                    objTeamUser.TeamUserId = TempUserMappingId;
                    objTeamUser.PrjMgrUrId = Convert.ToInt32(cmbTeamPM.SelectedValue);
                    objTeamUser.DelyMgrUrId = Convert.ToInt32(cmbTeamDM.SelectedValue);
                    //objTeamUser.Module = rbTeamReaction.Checked ? "RA" : "SA";
                    objTeamUser.Module = (string)cmbTeamModule.SelectedValue;
                    objTeamUser.ModHeadUrId = Convert.ToInt32(cmbTeamModuleHead.SelectedValue);
                    objTeamUser.AnlstUrId = Convert.ToInt32(cmbTeamCurator.SelectedValue);
                    objTeamUser.RevAnlstUrId = Convert.ToInt32(cmbTeamReviewer.SelectedValue);
                    objTeamUser.QualAnlstUrId = Convert.ToInt32(cmbTeamQc.SelectedValue);
                    objTeamUser.TeamLdrUrId = Convert.ToInt32(cmbTeamTL.SelectedValue);
                    objTeamUser.TaskPrepUrId = Convert.ToInt32(cmbTeamTaskPrep.SelectedValue);
                    objTeamUser.IsActive = chkTeamUserIsActive.Checked ? 'Y' : 'N';
                    objTeamUser.CreatedBy = Common.GlobalVariables.RoleId;

                    if (objTeamUser.TeamUserId == -1)  // Create new Mapping.
                    {
                        if (SaveUserMapping(objTeamUser) != -1)
                        {
                            MessageBox.Show("Created new mapping successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else // update Mapping.
                    {
                        if (SaveUserMapping(objTeamUser) != -1)
                        {
                            MessageBox.Show("User mapping updated successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    UpdateTeamUsersGrid();
                    ResetTeamUserControls();
                }
                else
                {
                    MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// To Set input control values when users clicks on edit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTeamUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvTeamUsers.Columns[e.ColumnIndex].Name == "ColTeamEdit") //(dgvTeamUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        blEditTeam = true;
                        SetTeamDetails(dgvTeamUsers.Rows[e.RowIndex]);
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Fill roles,Team users when ever perticular tab selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcUserProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcUserProfiles.SelectedTab == tpTeamUsers)
                {
                    BindModules(ref cmbTeamModule);
                    UpdateTeamUsersGrid();

                    int pmRoleId = 2;
                    DataTable dtPmDetails = UserManagementDB.GetUserNamesAndUserRoleIds(pmRoleId); //UserManagementDB.GetUserDetailsOnRoleId(pmRoleId);
                    BindPM(dtPmDetails);

                    int dmRoleId = 3;
                    DataTable dtDmDetails = UserManagementDB.GetUserNamesAndUserRoleIds(dmRoleId); //UserManagementDB.GetUserDetailsOnRoleId(dmRoleId);
                    BindDM(dtDmDetails);

                    chkTeamUserIsActive.Enabled = false;
                }
                if (tcUserProfiles.SelectedTab == tpUserRoles)
                {
                    BindModules(ref cmbAssignToModule);
                    chkIsRoleActive.Enabled = false;
                    cmbAssignToModule.Enabled = false;
                    UpdateUserRolesGrid();

                }
            
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void cmbTeamModule_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BindUsers();
        }

        /// <summary>
        /// Bind users to comboboxes
        /// </summary>
        private void BindUsers()
        {
            if (cmbTeamModule.SelectedItem != null)
            {
                if (cmbTeamModule.Text == "Reaction Analysis" || cmbTeamModule.Text == "Spectral Analysis")
                {
                    cmbTeamTL.Enabled = true;
                    cmbTeamQc.Enabled = true;
                    cmbTeamReviewer.Enabled = true;
                    cmbTeamCurator.Enabled = true;

                    FillUserComboboxes((string)cmbTeamModule.SelectedValue);

                    cmbTeamModuleHead.Enabled = false;
                    cmbTeamTaskPrep.Enabled = false;
                    cmbTeamTaskPrep.DataSource = null;
                }
                else if (cmbTeamModule.Text == "Task Preparation")
                {
                    BindTaskPreparationUsers();
                    cmbTeamTaskPrep.Enabled = true;

                    cmbTeamModuleHead.Enabled = false;
                    cmbTeamTL.Enabled = false;
                    cmbTeamQc.Enabled = false;
                    cmbTeamReviewer.Enabled = false;
                    cmbTeamCurator.Enabled = false;

                    cmbTeamModuleHead.DataSource = null;
                    cmbTeamTL.DataSource = null;
                    cmbTeamQc.DataSource = null;
                    cmbTeamReviewer.DataSource = null;
                    cmbTeamCurator.DataSource = null;
                }
            }
        }

        /// <summary>
        /// Fill Team user mapping DatagridView.
        /// </summary>
        private void UpdateTeamUsersGrid()
        {
            try
            {
                using (DataTable dtTeamUserDetails = UserManagementDB.GetTeamUserDetails())
                {
                    dtTeamUsers = new DataTable();
                    if (dtTeamUserDetails != null)
                    {
                        if (dtTeamUserDetails.Rows.Count > 0)
                        {
                            dtTeamUsers = dtTeamUserDetails;

                            dgvTeamUsers.AutoGenerateColumns = false;
                            dgvTeamUsers.DataSource = dtTeamUserDetails;

                            ColTeamUserId.DataPropertyName = "TEAM_USER_ID";
                            ColTeamModule.DataPropertyName = "APP_MODULE";
                            ColTeamCurator.DataPropertyName = "CURATOR";
                            ColTeamReview.DataPropertyName = "REVIEWER";
                            ColTeamQc.DataPropertyName = "QC";
                            ColTeamTL.DataPropertyName = "TEAM_LEAD";
                            ColTeamStatus.DataPropertyName = "IS_ACTIVE";
                            ColTeamTaskPrep.DataPropertyName = "TASK_PREPARATION_NAME";
                        }
                    }
                    else
                    {
                        dgvTeamUsers.DataSource = null;
                        dtTeamUsers = null;
                    }
                }

            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Inserts the new Team mapping or updates an existing Team mapping.
        /// </summary>
        /// <param name="objTeamUser">Instance of TeamUsers</param>
        /// <returns>Unique mapping Id if Exists. else -1.</returns>
        private int SaveUserMapping(TeamUsers objTeamUser)
        {
            try
            {
                return UserManagementDB.SaveUserMapping(objTeamUser);
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return 0;

        }

        /// <summary>
        /// Check mandatory fields for Team user creation or Updation.
        /// </summary>
        /// <param name="_errmsg">Summary Error Message.</param>
        /// <returns>True Mandatory fields are filled. Otherwise false</returns>
        private bool ValidateTeamUserInputs(out string _errmsg)
        {
            bool blStatus = true;
            strErrMsg = "";
            try
            {
                if (cmbTeamPM.SelectedItem == null)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Create or Activate Project Manager.";
                    blStatus = false;
                }
                if (cmbTeamDM.SelectedItem == null)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Create or ActivateDelivery Manager.";
                    blStatus = false;
                }
                if (cmbTeamModuleHead.SelectedItem == null && cmbTeamModuleHead.Enabled == true)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Module.", strErrMsg.Trim());
                    blStatus = false;
                }
                if (cmbTeamCurator.SelectedItem == null && cmbTeamCurator.Enabled == true)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Curator.", strErrMsg.Trim());
                    blStatus = false;
                }
                if (cmbTeamReviewer.SelectedItem == null && cmbTeamReviewer.Enabled == true)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Reviewer.", strErrMsg.Trim());
                    blStatus = false;
                }
                if (cmbTeamQc.SelectedItem == null && cmbTeamQc.Enabled == true)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Quality checker.", strErrMsg.Trim());
                    blStatus = false;
                }
                if (cmbTeamTL.SelectedItem == null && cmbTeamTL.Enabled == true)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select TeamLeader.", strErrMsg.Trim());
                    blStatus = false;
                }
                if (cmbTeamTaskPrep.SelectedItem == null && cmbTeamTaskPrep.Enabled == true)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Task Preparation.", strErrMsg.Trim());
                    blStatus = false;
                }
                if (blStatus && !blEditTeam)
                {
                    if (dtTeamUsers.Rows.Count > 0)
                    {
                        DataView dvTemp = dtTeamUsers.Copy().DefaultView; 
                        string module = null;
                        if (cmbTeamModule.SelectedItem != null)
                        {
                            module = (string)cmbTeamModule.SelectedValue;
                        }
                        if ((string)cmbTeamModule.SelectedValue != "TP")
                        {
                            dvTemp.RowFilter = "APP_MODULE = '" + module + " ' and CURATOR = '" + cmbTeamCurator.Text + "' and REVIEWER = '" + cmbTeamReviewer.Text + "' and QC= '" + cmbTeamQc.Text + "'  and TEAM_LEAD= '" + cmbTeamTL.Text + "'";
                            DataTable dtTemp = dvTemp.ToTable();
                            if (dtTemp != null)
                            {
                                if (dtTemp.Rows.Count > 0)
                                {
                                    blStatus = false;
                                    strErrMsg = "Mapping already existed under same Module.";
                                }
                            }
                        }
                        else
                        {
                            dvTemp.RowFilter = "APP_MODULE = '" + module + "' and TASK_PREPARATION_NAME = '" + cmbTeamTaskPrep.Text + "'";
                            DataTable dtTemp = dvTemp.ToTable();
                            if (dtTemp != null)
                            {
                                if (dtTemp.Rows.Count > 0)
                                {
                                    blStatus = false;
                                    strErrMsg = "Task Preparation user Created under same Module.";
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
            _errmsg = strErrMsg;
            return blStatus;
        }

        /// <summary>
        /// Fill Analyst users when user selects Module.
        /// </summary>
        /// <param name="dtActiveCurators">An Instance of Datatable of Analyst</param>
        private void BindActiveCurators(DataTable dtActiveCurators)
        {
            try
            {
                if (dtActiveCurators.Rows.Count > 0 && dtActiveCurators != null)
                {
                    cmbTeamCurator.DataSource = dtActiveCurators;
                    cmbTeamCurator.DisplayMember = "USER_NAME";
                    cmbTeamCurator.ValueMember = "UR_ID";
                    cmbTeamCurator.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Fill Reviewers when user selects Analyst.
        /// </summary>
        /// <param name="dtActiveReviewers">An Instance of Datatable of Reviewer</param>
        private void BindActiveReviewers(DataTable dtActiveReviewers)
        {
            try
            {
                if (dtActiveReviewers.Rows.Count > 0 && dtActiveReviewers != null)
                {
                    cmbTeamReviewer.DataSource = dtActiveReviewers;
                    cmbTeamReviewer.DisplayMember = "USER_NAME";
                    cmbTeamReviewer.ValueMember = "UR_ID";
                    cmbTeamReviewer.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }

        }

        /// <summary>
        /// Fill Qcs when user selects Reviewer.
        /// </summary>
        /// <param name="dtActiveQcs">An Instance of Qcs Datatable.</param>
        private void BindActiveQcs(DataTable dtActiveQcs)
        {
            try
            {
                if (dtActiveQcs.Rows.Count > 0 && dtActiveQcs != null)
                {
                    cmbTeamQc.DataSource = dtActiveQcs;
                    cmbTeamQc.DisplayMember = "USER_NAME";
                    cmbTeamQc.ValueMember = "UR_ID";
                    cmbTeamQc.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }

        }

        /// <summary>
        /// Fill Team Leaders when user selects Qc.
        /// </summary>
        /// <param name="dtTLs">An Instance of Datatable from db.</param>
        private void BindActiveTLs(DataTable dtTLs)
        {
            try
            {
                if (dtTLs.Rows.Count > 0)
                {
                    cmbTeamTL.DataSource = dtTLs;
                    cmbTeamTL.DisplayMember = "USER_NAME";
                    cmbTeamTL.ValueMember = "UR_ID";
                    cmbTeamTL.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }

        }

        /// <summary>
        ///  Set InputControls with TeamUsers information to Update.
        /// </summary>
        /// <param name="dataGridViewRow">Record to update.</param>
        private void SetTeamDetails(DataGridViewRow dataGridViewRow)
        {
            try
            {
                cmbTeamModuleHead.Enabled = false;
                cmbTeamCurator.Enabled = false;
                cmbTeamQc.Enabled = false;
                cmbTeamReviewer.Enabled = false;
                cmbTeamCurator.Enabled = false;
                cmbTeamTL.Enabled = false;
                cmbTeamModule.Enabled = false;

                string Module = null;
                if (dataGridViewRow.Cells["ColTeamModule"].Value.ToString() == "RA")
                {
                    Module = "Reaction Analysis";
                }
                else if (dataGridViewRow.Cells["ColTeamModule"].Value.ToString() == "SA")
                {
                    Module = "Spectral Analysis";
                }
                else if (dataGridViewRow.Cells["ColTeamModule"].Value.ToString() == "TP")
                {
                    Module = "Task Preparation";
                }

                cmbTeamModule.SelectedIndex = cmbTeamModule.FindStringExact(Module);
                BindUsers();
                if (cmbTeamModule.SelectedItem != null)
                {
                    if (cmbTeamModule.Text == "Reaction Analysis" || cmbTeamModule.Text == "Spectral Analysis")
                    {
                        cmbTeamCurator.SelectedIndex = dataGridViewRow.Cells["ColTeamCurator"].Value != null ? cmbTeamCurator.FindStringExact((string)dataGridViewRow.Cells["ColTeamCurator"].Value) : -1;
                        cmbTeamReviewer.SelectedIndex = dataGridViewRow.Cells["ColTeamReview"].Value != null ? cmbTeamReviewer.FindStringExact((string)dataGridViewRow.Cells["ColTeamReview"].Value) : -1;
                        cmbTeamQc.SelectedIndex = dataGridViewRow.Cells["ColTeamQc"].Value != null ? cmbTeamQc.FindStringExact((string)dataGridViewRow.Cells["ColTeamQc"].Value) : -1;
                        cmbTeamTL.SelectedIndex = dataGridViewRow.Cells["ColTeamTL"].Value != null ? cmbTeamTL.FindStringExact((string)dataGridViewRow.Cells["ColTeamTL"].Value) : -1;
                        cmbTeamCurator.Enabled = false;
                        cmbTeamReviewer.Enabled = false;
                        cmbTeamQc.Enabled = false;
                        cmbTeamTL.Enabled = false;

                    }
                    else if (cmbTeamModule.Text == "Task Preparation")
                    {
                        cmbTeamTaskPrep.SelectedIndex = dataGridViewRow.Cells["ColTeamTaskPrep"].Value != null ? cmbTeamTaskPrep.FindStringExact((string)dataGridViewRow.Cells["ColTeamTaskPrep"].Value) : -1;
                        cmbTeamTaskPrep.Enabled = false;
                    }
                    TempUserMappingId = Convert.ToInt32(dataGridViewRow.Cells["ColTeamUserId"].Value);

                    if (dataGridViewRow.Cells["ColTeamStatus"].Value != null)
                    {
                        if (dataGridViewRow.Cells["ColTeamStatus"].Value.ToString() == "N")
                        {
                            chkTeamUserIsActive.Checked = false;
                        }
                        else
                        {
                            chkTeamUserIsActive.Checked = true;
                        }
                    }
                    chkTeamUserIsActive.Enabled = true;
                    btnTeamUserCreate.Text = "Update";

                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Bind Delivery manager to combobox.
        /// </summary>
        /// <param name="dtDmDetails">An Instance of Datatable.</param>
        private void BindDM(DataTable dtDmDetails)
        {
            try
            {
                if (dtDmDetails.Rows.Count > 0 && dtDmDetails != null)
                {
                    cmbTeamDM.DataSource = dtDmDetails;
                    cmbTeamDM.DisplayMember = "USER_NAME";
                    cmbTeamDM.ValueMember = "UR_ID";
                    cmbTeamDM.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Bind Project managers to combobox.
        /// </summary>
        /// <param name="dtPmDetails">An Instance of Datatable.</param>
        private void BindPM(DataTable dtPmDetails)
        {
            try
            {
                if (dtPmDetails.Rows.Count > 0 && dtPmDetails != null)
                {
                    cmbTeamPM.DataSource = dtPmDetails;
                    cmbTeamPM.DisplayMember = "USER_NAME";
                    cmbTeamPM.ValueMember = "UR_ID";
                    cmbTeamPM.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }

        }

        /// <summary>
        /// bind Module heads to combobox.
        /// </summary>
        /// <param name="dtMhDetails">An Instance of Datatable.</param>
        private void BindMH(DataTable dtMhDetails)
        {
            try
            {
                if (dtMhDetails.Rows.Count > 0 && dtMhDetails != null)
                {
                    cmbTeamModuleHead.DataSource = dtMhDetails;
                    cmbTeamModuleHead.DisplayMember = "USER_NAME";
                    cmbTeamModuleHead.ValueMember = "UR_ID";
                    cmbTeamModuleHead.SelectedIndex = 0;
                    cmbTeamModuleHead.Enabled = false;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region commented Code for Remove already selected user.
        /// <summary>
        /// Fill Reviewers when user selects Analyst.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTeamCurator_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //if (cmbTeamCurator.SelectedItem != null)
                //{
                //    DataTable dtActiveReviewers = UserManagementDB.GetUserNamesAndUserRoleIds(7, rbTeamReaction.Text); //UserManagementDB.GetRoleWiseUsersInModule(rbTeamReaction.Checked ? "RA" : "SA", "Reviewanalyst");
                //    //RemoveSelctedUsers(dtActiveReviewers, cmbTeamCurator.Text);
                //    BindActiveReviewers(dtActiveReviewers);
                //}
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        ///// <summary>
        ///// Remove Selected username from Incharge combox.
        ///// </summary>
        ///// <param name="dtUsers">users Datatable.</param>
        ///// <param name="selectedCurator">Selected curator.</param>
        ///// <param name="selectedReviewer">Selected Reviewer.</param>
        ///// <param name="selectQc">Selected Qc.</param>
        //private void RemoveSelctedUsers(DataTable dtUsers, string selectedCurator, string selectedReviewer = "", string selectQc = "")
        //{
        //    foreach (DataRow dr in dtUsers.Rows)
        //    {
        //        if (dr["USER_NAME"] != null)
        //        {
        //            if (dr["USER_NAME"].ToString() == selectedCurator || dr["USER_NAME"].ToString() == selectedReviewer || dr["USER_NAME"].ToString() == selectQc)
        //                dr.Delete();
        //        }
        //    }
        //}
        private void cmbTeamReviewer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //if (cmbTeamCurator.SelectedItem != null && cmbTeamReviewer.SelectedItem != null)
                //{
                //    DataTable dtActiveQcs = UserManagementDB.GetUserNamesAndUserRoleIds(6, rbTeamReaction.Text); //UserManagementDB.GetRoleWiseUsersInModule(rbTeamReaction.Checked ? "RA" : "SA", "Qualityanalyst");
                //    //RemoveSelctedUsers(dtActiveQcs, cmbTeamCurator.Text, cmbTeamReviewer.Text);
                //    BindActiveQcs(dtActiveQcs);
                //}
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Fill Team Leaders when user selects Qc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTeamQc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbTeamCurator.SelectedItem != null && cmbTeamReviewer.SelectedItem != null && cmbTeamQc.SelectedItem != null && cmbTeamModule.SelectedItem != null)
                {
                    DataTable dtActiveTLs = UserManagementDB.GetUserNamesAndUserRoleIds(5, cmbTeamModule.Text); //UserManagementDB.GetRoleWiseUsersInModule(rbTeamReaction.Checked ? "RA" : "SA", "Teamleader");
                    // RemoveSelctedUsers(dtActiveTLs, cmbTeamCurator.Text, cmbTeamReviewer.Text, cmbTeamQc.Text);
                    BindActiveTLs(dtActiveTLs);
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        #endregion

        /// <summary>
        /// Bind Analyst,Review Analyst,Quality Analist,Team Leaders to combobox.
        /// </summary>
        /// <param name="module">Module</param>
        private void FillUserComboboxes(string module)
        {
            try
            {
                int mhRoleId = 4;
                DataTable dtMhDetails = UserManagementDB.GetUserNamesAndUserRoleIds(mhRoleId, module); //UserManagementDB.GetUserDetailsOnRoleId(mhRoleId, roleName);
                BindMH(dtMhDetails);

                cmbTeamCurator.DataSource = null;
                cmbTeamReviewer.DataSource = null;
                cmbTeamQc.DataSource = null;
                cmbTeamTL.DataSource = null;

                DataTable dtActiveCurators = UserManagementDB.GetUserNamesAndUserRoleIds(8, module); //UserManagementDB.GetRoleWiseUsersInModule(roleName, "Analyst");
                BindActiveCurators(dtActiveCurators);

                DataTable dtActiveReviewers = UserManagementDB.GetUserNamesAndUserRoleIds(7, module); //UserManagementDB.GetRoleWiseUsersInModule(rbTeamReaction.Checked ? "RA" : "SA", "Reviewanalyst");
                //RemoveSelctedUsers(dtActiveReviewers, cmbTeamCurator.Text);
                BindActiveReviewers(dtActiveReviewers);

                DataTable dtActiveQcs = UserManagementDB.GetUserNamesAndUserRoleIds(6, module); //UserManagementDB.GetRoleWiseUsersInModule(rbTeamReaction.Checked ? "RA" : "SA", "Qualityanalyst");
                //RemoveSelctedUsers(dtActiveQcs, cmbTeamCurator.Text, cmbTeamReviewer.Text);
                BindActiveQcs(dtActiveQcs);

                DataTable dtActiveTLs = UserManagementDB.GetUserNamesAndUserRoleIds(5, module); //UserManagementDB.GetRoleWiseUsersInModule(rbTeamReaction.Checked ? "RA" : "SA", "Teamleader");
                // RemoveSelctedUsers(dtActiveTLs, cmbTeamCurator.Text, cmbTeamReviewer.Text, cmbTeamQc.Text);
                BindActiveTLs(dtActiveTLs);
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Bind TakPreparation user.
        /// </summary>
        private void BindTaskPreparationUsers()
        {
            try
            {
                int TaskPreparationRoleid = 9;

                cmbTeamTaskPrep.DataSource = UserManagementDB.GetUserNamesAndUserRoleIds(TaskPreparationRoleid);
                cmbTeamTaskPrep.DisplayMember = "USER_NAME";
                cmbTeamTaskPrep.ValueMember = "UR_ID";
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Reset Team Users Controls

        /// <summary>
        /// Reset Team user Input Controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeamUserReset_Click(object sender, EventArgs e)
        {
            ResetTeamUserControls();
        }

        /// <summary>
        /// Reset Role Input Controls.
        /// </summary>
        private void ResetTeamUserControls()
        {
            cmbTeamCurator.Enabled = true;
            cmbTeamReviewer.Enabled = true;
            cmbTeamQc.Enabled = true;
            cmbTeamTL.Enabled = true;

            cmbTeamModule.SelectedIndex = -1;
            cmbTeamTL.SelectedIndex = -1;
            cmbTeamQc.SelectedIndex = -1;
            cmbTeamReviewer.SelectedIndex = -1;
            cmbTeamCurator.SelectedIndex = -1;
            cmbTeamTaskPrep.SelectedIndex = -1;

            chkTeamUserIsActive.Enabled = false;
            chkTeamUserIsActive.Checked = true;
            TempUserMappingId = -1;
            btnTeamUserCreate.Text = "Create";

            cmbTeamModule.Enabled = true;
            cmbTeamModule.SelectedIndex = -1;

            blEditTeam = false;
        }

        #endregion

        #endregion

        #region RowpostPaint

        private void dgvUsers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUsers.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUsers.Font);

                if (dgvUsers.RowHeadersWidth < (int)(size.Width + 20)) dgvUsers.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvUserRoles_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUserRoles.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUserRoles.Font);

                if (dgvUserRoles.RowHeadersWidth < (int)(size.Width + 20)) dgvUserRoles.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvTeamUsers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvTeamUsers.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvTeamUsers.Font);

                if (dgvTeamUsers.RowHeadersWidth < (int)(size.Width + 20)) dgvTeamUsers.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }


        #endregion

    
    }
}

