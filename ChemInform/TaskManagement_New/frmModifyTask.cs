using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Common;
using ChemInform.Dal;

namespace ChemInform.TaskManagement_New
{
    public partial class frmModifyTask : Form
    {

        #region Local Variables

        private int _totalCheckBoxes = 0;
        private int _totalCheckedCheckBoxes = 0;
        private CheckBox _headerCheckBox = null;
        private bool _isHeaderCheckBoxClicked = false;
        private DataTable _dtGetManualTans = null;

        private DataTable userAssignedRefs = null;
        private DataTable usersTaskCounts = null;

        #endregion

        public frmModifyTask()
        {
            InitializeComponent();
        }

        private void frmModifyTask_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
                FillRolesDropDownList();

                #region Select All - Check Box addition

                AddHeaderCheckBox();

                _headerCheckBox.KeyUp -= new KeyEventHandler(HeaderCheckBox_KeyUp);
                _headerCheckBox.MouseClick -= new MouseEventHandler(HeaderCheckBox_MouseClick);
                dgvUserTasks.CellValueChanged -= new DataGridViewCellEventHandler(dgvTans_CellValueChanged);
                dgvUserTasks.CurrentCellDirtyStateChanged -= new EventHandler(dgvTans_CurrentCellDirtyStateChanged);
                dgvUserTasks.CellPainting -= new DataGridViewCellPaintingEventHandler(dgvTans_CellPainting);

                _headerCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
                _headerCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
                dgvUserTasks.CellValueChanged += new DataGridViewCellEventHandler(dgvTans_CellValueChanged);
                dgvUserTasks.CurrentCellDirtyStateChanged += new EventHandler(dgvTans_CurrentCellDirtyStateChanged);
                dgvUserTasks.CellPainting += new DataGridViewCellPaintingEventHandler(dgvTans_CellPainting);

                #endregion
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }        

        private void cmbUsers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsers.SelectedIndex != -1)
                {                  
                    userAssignedRefs = TaskManagementDB.GetUserAssignedTasks(Convert.ToInt32(cmbUsers.SelectedValue));
                    {
                        if (userAssignedRefs.Rows.Count > 0)
                        {
                            if (_headerCheckBox != null)
                            {
                                _headerCheckBox.Enabled = false;
                                _headerCheckBox.Checked = false;
                            }

                            dgvUserTasks.AutoGenerateColumns = false;
                            dgvUserTasks.DataSource = userAssignedRefs;

                            if (_headerCheckBox != null)
                            {
                                _headerCheckBox.Enabled = true;
                            }
                            _totalCheckBoxes = dgvUserTasks.RowCount;
                            _totalCheckedCheckBoxes = 0;
                        }
                        else
                        {
                            dgvUserTasks.DataSource = null;
                        }
                    }

                    //Bind user Task Counts to Grid
                    BindUsersTaskCountsToGrid(usersTaskCounts);

                    //if (usersTaskCounts.Rows.Count > 0)
                    //{
                    //    DataView dvTemp = usersTaskCounts.Copy().DefaultView;

                    //    dvTemp.RowFilter = "UR_ID NOT IN ( " + Convert.ToInt32(cmbUsers.SelectedValue) + " )";
                    //    DataTable dtResult = dvTemp.ToTable();
                    //    if (dtResult != null)
                    //    {
                    //        if (dtResult.Rows.Count > 0)
                    //        {
                    //            dgvReallocateToUser.AutoGenerateColumns = false;
                    //            dgvReallocateToUser.DataSource = dtResult;
                    //        }
                    //        else
                    //        {
                    //            dgvReallocateToUser.DataSource = null;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    dgvReallocateToUser.DataSource = null;
                    //}
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void GetUserAssignedReferences(int urID)
        {
            try
            {                

                using (DataTable dtRellocated = new DataTable())//TaskManagementDB.GetAllocatedTasksExceptSpecifiedUser(Convert.ToInt32(cmbShipment.SelectedValue), Convert.ToInt32(cmbRole.SelectedValue)))
                {
                    if (dtRellocated.Rows.Count > 0)
                    {
                        DataView dvTemp = dtRellocated.Copy().DefaultView;

                        dvTemp.RowFilter = "UR_ID NOT IN ( " + Convert.ToInt32(cmbUsers.SelectedValue) + " )";
                        DataTable dtResult = dvTemp.ToTable();
                        if (dtResult != null)
                        {
                            if (dtResult.Rows.Count > 0)
                            {
                                dgvReallocateToUser.AutoGenerateColumns = false;
                                dgvReallocateToUser.DataSource = dtResult;
                            }
                            else
                            {
                                dgvReallocateToUser.DataSource = null;
                            }
                        }
                    }
                    else
                    {
                        dgvReallocateToUser.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

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

        private void cmbRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedIndex != -1)
                {
                    dgvUserTasks.DataSource = null;

                    usersTaskCounts = TaskManagementDB.GetUsersTaskCountsOnRole("RA", Convert.ToInt32(cmbRole.SelectedValue));

                    //Get Users On Role
                    cmbUsers.DisplayMember = "USER_NAME";
                    cmbUsers.ValueMember = "UR_ID";
                    cmbUsers.DataSource = usersTaskCounts.Copy();

                    BindUsersTaskCountsToGrid(usersTaskCounts);        
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void BindUsersTaskCountsToGrid(DataTable usrsTaskCnts)
        {
            try
            {
                if (usrsTaskCnts.Rows.Count > 0)
                {
                    DataView dvTemp = usrsTaskCnts.Copy().DefaultView;

                    dvTemp.RowFilter = "UR_ID NOT IN ( " + Convert.ToInt32(cmbUsers.SelectedValue) + " )";
                    DataTable dtResult = dvTemp.ToTable();
                    if (dtResult != null)
                    {
                        if (dtResult.Rows.Count > 0)
                        {
                            dgvReallocateToUser.AutoGenerateColumns = false;
                            dgvReallocateToUser.DataSource = dtResult;
                        }
                        else
                        {
                            dgvReallocateToUser.DataSource = null;
                        }
                    }
                }
                else
                {
                    dgvReallocateToUser.DataSource = null;
                }  
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }
            
        /// <summary>
        /// Gets the filter condition based .
        /// </summary>
        /// <param name="queryTans">The query tans.</param>
        /// <param name="databaseTanFiledName">Name of the database tan filed.</param>
        /// <returns>Filter condition.</returns>
        private string GetFilterCondition(string queryTans, string databaseTanFiledName)
        {
            string strFCond = "";
            string[] tans = null;
            try
            {
                if (queryTans.Trim().Contains(";"))
                {
                    tans = queryTans.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    string inParams = null;

                    foreach (string tan in tans)
                    {
                        if (string.IsNullOrEmpty(inParams))
                        {
                            inParams = string.Format("'{0}'", tan.Trim());
                        }
                        else
                        {
                            inParams += string.Format(", '{0}'", tan.Trim());
                        }
                    }
                    strFCond = databaseTanFiledName + " IN (" + inParams + ")";
                }
                else
                {
                    strFCond = databaseTanFiledName + " = '" + queryTans.Trim() + "'";
                }
                return strFCond;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return strFCond;
        }
        
        #region Select All - Event Args
        
        private void AddHeaderCheckBox()
        {
            try
            {
                _headerCheckBox = new CheckBox();

                _headerCheckBox.Size = new Size(80, 21);
                _headerCheckBox.Text = "Select All";
                _headerCheckBox.BackColor = Color.Transparent;
                _headerCheckBox.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point);
                _headerCheckBox.TabIndex = 2;

                //Add the CheckBox into the DataGridView
                dgvUserTasks.Controls.Add(_headerCheckBox);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void ResetHeaderCheckBoxLocation(int columnIndex, int rowIndex)
        {
            try
            {
                //Get the column header cell bounds
                Rectangle oRectangle = dgvUserTasks.GetCellDisplayRectangle(columnIndex, rowIndex, true);

                Point oPoint = new Point();

                oPoint.X = oRectangle.Location.X + (oRectangle.Width - _headerCheckBox.Width) / 2 + 1;
                oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - _headerCheckBox.Height) / 2 + 1;

                //Change the location of the CheckBox to make it stay on the header
                _headerCheckBox.Location = oPoint;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void RowCheckBoxClick(DataGridViewCheckBoxCell rCheckBox)
        {
            try
            {
                if (rCheckBox != null)
                {
                    //Modifiy Counter;            
                    if (Convert.ToBoolean(rCheckBox.Value) && _totalCheckedCheckBoxes < _totalCheckBoxes)
                        _totalCheckedCheckBoxes++;
                    else if (_totalCheckedCheckBoxes > 0)
                        _totalCheckedCheckBoxes--;

                    //Change state of the header CheckBox.
                    if (_totalCheckedCheckBoxes < _totalCheckBoxes)
                        _headerCheckBox.Checked = false;
                    else if (_totalCheckedCheckBoxes == _totalCheckBoxes)
                        _headerCheckBox.Checked = true;
                }
                UpdateSelectedTanCount();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void HeaderCheckBoxClick(CheckBox hCheckBox)
        {
            try
            {
                _isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dgvUserTasks.Rows)
                    ((DataGridViewCheckBoxCell)row.Cells[chkReallocateSelectTan.Name]).Value = hCheckBox.Checked;

                dgvUserTasks.RefreshEdit();

                _totalCheckedCheckBoxes = hCheckBox.Checked ? _totalCheckBoxes : 0;

                UpdateSelectedTanCount();

                _isHeaderCheckBoxClicked = false;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                    HeaderCheckBoxClick((CheckBox)sender);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void dgvTans_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!_isHeaderCheckBoxClicked)
                {
                    if (e.RowIndex != -1)
                        RowCheckBoxClick((DataGridViewCheckBoxCell)dgvUserTasks[e.ColumnIndex, e.RowIndex]);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void dgvTans_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvUserTasks.CurrentCell is DataGridViewCheckBoxCell)
                    dgvUserTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void dgvTans_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 && e.ColumnIndex == 0)
                    ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        #endregion
               
        #region Row Post paint
        private void dgvModify_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUserTasks.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUserTasks.Font);

                if (dgvUserTasks.RowHeadersWidth < (int)(size.Width + 20)) dgvUserTasks.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void dgvReallocateTo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvReallocateToUser.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvReallocateToUser.Font);

                if (dgvReallocateToUser.RowHeadersWidth < (int)(size.Width + 20)) dgvReallocateToUser.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }
        
        #endregion

        private void UpdateSelectedTanCount()
        {
            try
            {
                if (dgvUserTasks.Rows.Count > 0)
                {
                    lblSelected.Text = "Selected References count : " + _totalCheckedCheckBoxes;
                }
                else
                {
                    lblSelected.Text = "Selected References count : 0";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void dgvModify_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateSelectedTanCount();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }
               
        private List<int> _lstTaskAllocIds = null;
        private List<int> _lstReallocateToUserIds = null;

        /// <summary>
        /// Re-assign the selected user task to another user.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReAssign_Click(object sender, EventArgs e)
        {
            _lstTaskAllocIds = new List<int>();
            _lstReallocateToUserIds = new List<int>();

            try
            {
                string strErr = string.Empty;
                if (ValidateReallocateInputs(ref _lstTaskAllocIds, out strErr))
                {
                    if (_lstTaskAllocIds.Count > 0)
                    {
                        DialogResult diaRes = MessageBox.Show("Do you want to re-assign the selected references?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (diaRes == System.Windows.Forms.DialogResult.Yes)
                        {
                            int reallocURID = Convert.ToInt32(dgvReallocateToUser.SelectedRows[0].Cells[colReallocateToURID.Name].Value);

                            if (TaskManagementDB.ModifyTaskAssignment(_lstTaskAllocIds, reallocURID, GlobalVariables.UR_ID))
                            {
                                _headerCheckBox.Checked = false;

                                usersTaskCounts = TaskManagementDB.GetUsersTaskCountsOnRole("RA", Convert.ToInt32(cmbRole.SelectedValue));
                                BindUsersTaskCountsToGrid(usersTaskCounts);

                                //Refresh User tasks
                                cmbUsers_SelectionChangeCommitted(null, null);

                                MessageBox.Show("Tasks Re-Assigned successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error in task Re-Assignment", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(strErr.Trim(), GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private List<int> GetSelectedTaskIDsForCancellation()
        {
            List<int> lstCancelTaskIDs = new List<int>();
            try
            {
                for (int rowIndex = 0; rowIndex < dgvUserTasks.Rows.Count; rowIndex++)
                {
                    if (Convert.ToBoolean(dgvUserTasks.Rows[rowIndex].Cells[chkReallocateSelectTan.Name].Value))
                    {
                        lstCancelTaskIDs.Add(Convert.ToInt32(dgvUserTasks.Rows[rowIndex].Cells[colTaskId.Name].Value));
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstCancelTaskIDs;
        }

        private void btnCancelTask_Click(object sender, EventArgs e)
        {
            try
            {
                string strErr = string.Empty;
                List<int> lstCancelTaskIDs = GetSelectedTaskIDsForCancellation();

                if (lstCancelTaskIDs.Count > 0)
                {
                    DialogResult diaRes = MessageBox.Show("Do you want to cancel the selected references?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (TaskManagementDB.CancelTaskAssignment(lstCancelTaskIDs))
                        {
                            _headerCheckBox.Checked = false;

                            usersTaskCounts = TaskManagementDB.GetUsersTaskCountsOnRole("RA", Convert.ToInt32(cmbRole.SelectedValue));
                            BindUsersTaskCountsToGrid(usersTaskCounts);

                            //Refresh User tasks
                            cmbUsers_SelectionChangeCommitted(null, null);

                            MessageBox.Show("References cancelled successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No References selected for cancellation", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }    

        /// <summary>
        /// Validates the reallocate inputs.
        /// </summary>
        /// <param name="lstModifyTask">The list of modify task.</param>
        /// <param name="errmsgOut">The errmsg.</param>
        /// <returns></returns>
        private bool ValidateReallocateInputs(ref List<int> lstModifyTask, out string errmsgOut)
        {
            bool blStatus = true;
            string strErrMsg = string.Empty;

            try
            {
                //if (cmbModifyTaskShipment.SelectedIndex == -1)
                //{
                //    strErrMsg = "Please select shipment.";
                //    blStatus = false;
                //}
                //if (cmbSection.SelectedIndex == -1)
                //{
                //    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select section.";
                //    blStatus = false;
                //}
                if (cmbRole.SelectedIndex == -1)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select role.";
                    blStatus = false;
                }
                if (cmbUsers.SelectedIndex == -1)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select user.";
                    blStatus = false;
                }
                if (dgvUserTasks.Rows.Count == 0)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "No TANs available to Re-allocate.";
                    blStatus = false;
                }
                if (blStatus)
                {
                    if (!CheckReferencesSelected())
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "Select at least one TAN to Re-allocate.";
                        blStatus = false;
                    }
                    if (dgvReallocateToUser.Rows.Count == 0)
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "No user available to Re-allocate.";
                        blStatus = false;
                    }
                    else if (dgvReallocateToUser.SelectedRows.Count == 0)
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "Select user to Re-allocate.";
                        blStatus = false;
                    }
                }
                if (blStatus)
                {
                    //Add selected task allocation ids to Generic list.
                    for (int rowIndex = 0; rowIndex < dgvUserTasks.Rows.Count; rowIndex++)
                    {
                        if (Convert.ToBoolean(dgvUserTasks.Rows[rowIndex].Cells[chkReallocateSelectTan.Name].Value))
                        {
                            lstModifyTask.Add(Convert.ToInt32(dgvUserTasks.Rows[rowIndex].Cells[colTaskAllocId.Name].Value));
                        }
                    }
                    if (lstModifyTask.Count < dgvReallocateToUser.SelectedRows.Count)
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "Reallocating " + lstModifyTask.Count + " TANs to " +
                                    dgvReallocateToUser.SelectedRows.Count + " users is not possible.";
                        blStatus = false;
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            errmsgOut = strErrMsg;
            return blStatus;
        }

        /// <summary>
        /// Check tans selected or not.
        /// </summary>
        /// <returns></returns>
        private bool CheckReferencesSelected()
        {
            try
            {
                if (dgvUserTasks.DataSource != null)
                {
                    if (dgvUserTasks.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgvUserTasks.Rows.Count; i++)
                        {
                            if (dgvUserTasks.Rows[i].Cells[chkReallocateSelectTan.Name].Value != null)
                            {
                                if (Convert.ToBoolean(dgvUserTasks.Rows[i].Cells[chkReallocateSelectTan.Name].Value.ToString()))
                                    return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }

            return false;
        }

        private string GetFilterCondition(string queryRefs)
        {
            string filterCond = "";
            try
            {
                if (queryRefs.Trim().Contains(";"))
                {
                    string[] splitter = { ";" };
                    string[] saRefNames = queryRefs.Trim().Split(splitter, StringSplitOptions.RemoveEmptyEntries);

                    if (saRefNames != null)
                    {
                        if (saRefNames.Length > 0)
                        {
                            for (int i = 0; i < saRefNames.Length; i++)
                            {
                                if (i == 0)
                                {
                                    filterCond = "REFERENCE_NAME Like '" + saRefNames[i] + "%' ";
                                }
                                else
                                {
                                    filterCond += " OR" + " REFERENCE_NAME Like '" + saRefNames[i] + "%'";
                                }
                            }
                        }
                    }
                }
                else
                {
                    filterCond = "REFERENCE_NAME Like '" + queryRefs.Trim() + "%'";
                }
                return filterCond;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return filterCond;
        }         

        private void txtModifyTaskSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (userAssignedRefs != null)
                {
                    if (!string.IsNullOrEmpty(txtModifyTaskSearch.Text.Trim()))
                    {
                        string strFCond = GetFilterCondition(txtModifyTaskSearch.Text.Trim());

                        DataTable dtAllTANs = userAssignedRefs.Copy();
                        DataView dvTemp = dtAllTANs.DefaultView;
                        dvTemp.RowFilter = strFCond;
                        DataTable dtFilteredRefs = dvTemp.ToTable();

                        dgvUserTasks.DataSource = dtFilteredRefs;                        
                    }
                    else
                    {
                        dgvUserTasks.DataSource = userAssignedRefs;  
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
