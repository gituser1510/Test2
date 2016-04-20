using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ChemInform;
using ChemInform.Common;
using ChemInform.Dal;

namespace ChemInform
{
    public partial class frmTaskAssignment : Form
    {
        public frmTaskAssignment()
        {
            InitializeComponent();
        }

        #region Public variables
               
        public DataTable AvailableRefsTbl
        {
            get;
            set;
        }
             
        public DataTable AppModuleUsers
        {
            get;
            set;
        }
                       
        Int64 teamUserID = 0;

        #endregion

        #region Private Methods
                
        private void SetApplicationModuleUsersToComboBox()
        {
            try
            {
                if (cmbModule.SelectedValue != null)
                {
                    string strModule = cmbModule.SelectedValue.ToString();

                    DataTable dtModuleUsers = null;
                    dtModuleUsers = TaskManagementDB.GetUsersByModule(strModule);
                    if (dtModuleUsers != null)
                    {
                        AppModuleUsers = dtModuleUsers;

                        cmbCurator.DataSource = dtModuleUsers;
                        cmbCurator.ValueMember = "ANLST_UR_ID";
                        cmbCurator.DisplayMember = "ANLST_NAME";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void GetUsersTaskCountAndBindToGrid()
        {
            try
            {
                if (cmbModule.SelectedItem != null)
                {
                    DataTable dtModuleUsers = null;
                    DataTable dtTaskCounts = TaskManagementDB.GetUserTaskCountsOnModule(GetSelectedModuleCode(), out dtModuleUsers);
                    if (dtTaskCounts != null)
                    {
                        dgvTaskCounts.AutoGenerateColumns = false;
                        dgvTaskCounts.DataSource = dtTaskCounts;

                        colUserName_TC.DataPropertyName = "USER_NAME";
                        colRoleName_TC.DataPropertyName = "ROLE_NAME";
                        colAssignedCnt_TC.DataPropertyName = "ASSIGNED_CNT";
                        colInPrgressCnt_TC.DataPropertyName = "PROGRESS_CNT";
                    }
                    AppModuleUsers = dtModuleUsers;
                    if (dtModuleUsers != null)
                    {
                        cmbCurator.DataSource = dtModuleUsers;
                        cmbCurator.ValueMember = "ANLST_UR_ID";
                        cmbCurator.DisplayMember = "ANLST_NAME";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void GetAssignedShipmentRefsAndBindToGrid()
        {
            try
            {
                string strModule = GetSelectedModuleCode();
                int shipmentID = Convert.ToInt32(cmbShipment.SelectedValue);

                DataTable dtAssignedRefs = TaskManagementDB.GetAssignedRefrencesOnShipment(strModule, shipmentID);
                dgvAssignedRefs.DataSource = dtAssignedRefs;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void GetUnAssignedShipmentReferencesAndBindToControl()
        {
            try
            {
                //TANs on Phase,Shipment,userid and roleid
                if (cmbShipment.SelectedItem != null)
                {
                    Cursor = Cursors.WaitCursor;

                    int shipmentID = Convert.ToInt32(cmbShipment.SelectedValue);                    
                    string moduleName = GetSelectedModuleCode();

                    DataTable dtTANs = TaskManagementDB.GetUnAssignedRefrencesOnShipment(moduleName, shipmentID);
                    if (dtTANs != null)
                    {
                        if (dtTANs.Rows.Count > 0)
                        {
                            AvailableRefsTbl = dtTANs;
                            BindDataToUnAssignedRefsGrid(dtTANs);
                        }
                        else
                        {
                            AvailableRefsTbl = null;
                            BindDataToUnAssignedRefsGrid(dtTANs);
                        }
                    }
                    else
                    {
                        AvailableRefsTbl = null;
                        BindDataToUnAssignedRefsGrid(dtTANs);
                    }                    

                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDataToUnAssignedRefsGrid(DataTable unassignedRefs)
        {
            try
            {
                if (unassignedRefs != null)
                {
                    dgvUnAssignedRefs.AutoGenerateColumns = false;
                    dgvUnAssignedRefs.DataSource = unassignedRefs;

                    colAvl_Doc_ID.DataPropertyName = "SHIPMENT_REF_ID";
                    colAvl_Ref.DataPropertyName = "REFERENCE_NAME";
                    colSysClassType.DataPropertyName = "SYS_CLASS_TYPE";
                    //colAvl_BT_ID.DataPropertyName = "TAN_ID";
                    //colAvl_TAN.DataPropertyName = "TAN_NAME";
                    //colAvl_TAN_Type.DataPropertyName = "TAN_TYPE";
                    //colDocClass_Avl.DataPropertyName = "DOC_CLASS";
                    //colTANPriority_Avl.DataPropertyName = "TAN_PRIORITY";
                }
                else
                {
                    dgvUnAssignedRefs.DataSource = unassignedRefs;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private List<int> GetSelectedRef_IDsFromGrid()
        {
            List<int> selRefsList = null;
            try
            {
                if (dgvUnAssignedRefs.Rows.Count > 0)
                {
                    if (dgvUnAssignedRefs.SelectedRows.Count > 0)
                    {
                        selRefsList = new List<int>();
                        DataGridViewSelectedRowCollection selRowColl = dgvUnAssignedRefs.SelectedRows;
                        if (selRowColl != null)
                        {
                            if (selRowColl.Count > 0)
                            {
                                for (int i = 0; i < selRowColl.Count; i++)
                                {
                                    selRefsList.Add(Convert.ToInt32(selRowColl[i].Cells[0].Value));
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
            return selRefsList;
        }

        private string GetFilterCondition(string _query_tan)
        {
            string strFCond = "";
            try
            {
                if (_query_tan.Trim().Contains(";"))
                {
                    string[] splitter = { ";" };
                    string[] saRefs = _query_tan.Trim().Split(splitter, StringSplitOptions.RemoveEmptyEntries);

                    if (saRefs != null)
                    {
                        if (saRefs.Length > 0)
                        {
                            for (int i = 0; i < saRefs.Length; i++)
                            {
                                if (i == 0)
                                {
                                    strFCond = "REFERENCE_NAME Like '" + saRefs[i] + "%' ";
                                }
                                else
                                {
                                    strFCond += " OR" + " REFERENCE_NAME Like '" + saRefs[i] + "%'";
                                }
                            }
                        }
                    }
                }
                else
                {
                    strFCond = "REFERENCE_NAME Like '" + _query_tan.Trim() + "%'";
                }
                return strFCond;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strFCond;
        }         
        
        #endregion

        #region Events

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> selRefIDs = GetSelectedRef_IDsFromGrid();

                if (selRefIDs != null)
                {
                    if (selRefIDs.Count > 0)
                    {
                        string strModule = GetSelectedModuleCode();
                        int shipmentID = Convert.ToInt32(cmbShipment.SelectedValue);

                        if (TaskManagementDB.UpdateTaskAssignmentDetails(strModule, shipmentID, teamUserID, selRefIDs))
                        {
                            MessageBox.Show("Task assigned successfully", GlobalVariables.MessageCaption,MessageBoxButtons.OK,MessageBoxIcon.Information);

                            //Get UnAssigned TANs
                            GetUnAssignedShipmentReferencesAndBindToControl();

                            //Get User Task Counts in the Module
                            GetUsersTaskCountAndBindToGrid();

                            //Get Assigned TANs
                            GetAssignedShipmentRefsAndBindToGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error in task allication", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void frmTaskAssignment_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                               
                //int userID = IndxReactNarr.Generic.GlobalVariables.UserID;
                //int userRoleID = IndxReactNarr.Generic.GlobalVariables.RoleID;
                //int urID = IndxReactNarr.Generic.GlobalVariables.URID;
                //string userRole = IndxReactNarr.Generic.GlobalVariables.RoleName;

                ////GlobalVariables.ApplicationName = "ORGANIC";

                ////Set applicaton modules to combobox
                //SetApplicationModulesToComboBox();

                ////Get Application Shipments and bind to combobox
                //SetApplicationShipmentsToComboBox();

                ////Get Application Module Users
                ////SetApplicationModuleUsersToComboBox();

                ////Get User Task counts
                ////GetUsersTaskCountAndBindToGrid();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void cancelAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignedRefs.SelectedRows.Count == 1)
                {
                    DialogResult diaRes = MessageBox.Show("Do you want to cancel the task assignment?", "Cancel Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes == DialogResult.Yes)
                    {
                      //  int Ass_By_URID = GlobalVariables.URID;
                        string strTan = dgvAssignedRefs.Rows[dgvAssignedRefs.CurrentCell.RowIndex].Cells["tan"].Value.ToString();
                        string Ass_to_User = dgvAssignedRefs.Rows[dgvAssignedRefs.CurrentCell.RowIndex].Cells["assigned to user"].Value.ToString();
                        string Ass_to_URole = dgvAssignedRefs.Rows[dgvAssignedRefs.CurrentCell.RowIndex].Cells["role"].Value.ToString();
                        string tanStatus = dgvAssignedRefs.Rows[dgvAssignedRefs.CurrentCell.RowIndex].Cells["tan status"].Value.ToString();

                        //if (ReactDB.DeleteTaskAssignmentDetails(strTan, Ass_By_URID, Ass_to_User, Ass_to_URole, tanStatus))
                        //{
                        //    #region Code Commented
                        //    ////Refresh Assigned TANs grid to refrect changes
                        //    //DataTable dtAssTANDetails = CASRxnDataAccess.GetPM_SupvisorTANs_BName_BNo_UID_RoleID(cmbBatch.SelectedItem.ToString(), Convert.ToInt32(cmbBatchNo.SelectedItem.ToString()), Generic.GlobalVariables.UserRoleID, Generic.GlobalVariables.URID);
                        //    //if (dtAssTANDetails != null)
                        //    //{
                        //    //    dtGridAssigedTANs.DataSource = dtAssTANDetails;
                        //    //} 
                        //    #endregion

                        //    GetUnAssignedTANsAndBindToControl();

                        //    MessageBox.Show("Task assignment cancelled successfully", "Cancel Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Error in Task assignment cancellation", "Cancel Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void txtTANSrch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AvailableRefsTbl != null)
                {
                    if (txtTANSrch.Text.Trim() != "")
                    {
                        string strFCond = GetFilterCondition(txtTANSrch.Text.Trim());

                        DataTable dtAllTANs = AvailableRefsTbl.Copy();
                        DataView dvTemp = dtAllTANs.DefaultView;
                        dvTemp.RowFilter = strFCond;
                        DataTable dtTANs = dvTemp.ToTable();
                        dgvUnAssignedRefs.DataSource = dtTANs;
                    }
                    else
                    {
                        DataTable dtAllTANs = AvailableRefsTbl.Copy();
                        dgvUnAssignedRefs.DataSource = dtAllTANs;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
       
        private void cmbCurator_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCurator.SelectedItem != null && AppModuleUsers != null)
                {

                    if (!string.IsNullOrEmpty(cmbCurator.Text.ToString()))
                    {
                        var rows = from r in AppModuleUsers.AsEnumerable()
                                   where r.Field<string>("ANLST_NAME") == cmbCurator.Text.ToString()
                                   select new
                                   {
                                       Reviewer = r.Field<string>("REV_ANLST_NAME"),
                                       QC = r.Field<string>("QUAL_ANLST_NAME"),
                                       TeamUserID = r.Field<Int64>("TEAM_USER_ID")
                                   };
                        if (rows != null)
                        {
                            foreach (var r in rows)
                            {
                                txtReviewer.Text = r.Reviewer;
                                txtQC.Text = r.QC;
                                teamUserID = r.TeamUserID;
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

        #endregion

        #region Grid RowPostPaint Events

        private void dtGridAssigedTANs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {                
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvAssignedRefs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvAssignedRefs.Font);

                if (dgvAssignedRefs.RowHeadersWidth < (int)(size.Width + 20)) dgvAssignedRefs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        
        private void dtGrid_TANs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {             
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvAssignedRefs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvAssignedRefs.Font);

                if (dgvAssignedRefs.RowHeadersWidth < (int)(size.Width + 20)) dgvAssignedRefs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;

                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dtGridSelTANs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {                
                string strRowNumber = (e.RowIndex + 1).ToString();
             
                while (strRowNumber.Length < dgvAssignedRefs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;
                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvAssignedRefs.Font);
                if (dgvAssignedRefs.RowHeadersWidth < (int)(size.Width + 20)) dgvAssignedRefs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;

                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }       

        private void dgvTaskCounts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvTaskCounts.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;
                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvTaskCounts.Font);
                if (dgvTaskCounts.RowHeadersWidth < (int)(size.Width + 20)) dgvTaskCounts.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;

                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Get Shipments on Module
                DataTable dtShipments = ShipmentManagementDB.GetShipmentsOnModule(GetSelectedModuleCode());
                if (dtShipments != null)
                {
                    cmbShipment.DataSource = dtShipments;
                    cmbShipment.DisplayMember = "SHIPMENT_NAME";
                    cmbShipment.ValueMember = "SHIPMENT_ID";
                }

                //Ger User Task Count on Module
                GetUsersTaskCountAndBindToGrid();

                //Set Module Users
                SetApplicationModuleUsersToComboBox();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private string GetSelectedModuleCode()
        {
            string moduleCode = "";
            try
            {
                if (cmbModule.SelectedItem != null)
                {
                    moduleCode = cmbModule.Text.ToUpper();
                    if (moduleCode.ToUpper() == "TASK PREPARATION")
                    {
                        moduleCode = "TP";
                    }
                    else if (moduleCode.ToUpper() == "REACTION ANALYSIS")
                    {
                        moduleCode = "RA";
                    }
                    else 
                    {
                        moduleCode = "SA";
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }
            return moduleCode;
        }

        private void cmbShipment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //Get UnAssigned TANs
                GetUnAssignedShipmentReferencesAndBindToControl();

                //Get Assigned TANs
                GetAssignedShipmentRefsAndBindToGrid();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

    }
}
