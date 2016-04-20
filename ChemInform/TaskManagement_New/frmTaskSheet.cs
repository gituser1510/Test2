using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using ChemInform.Common;
using ChemInform.Bll;
using ChemInform.Dal;

namespace ChemInform
{
    public partial class frmTaskSheet : Form
    {
        #region Class Constructor

        public frmTaskSheet()
        {
            InitializeComponent();
        }

        #endregion

        #region Property Procedures

        public string SelectedRef
        {
            get;
            set;
        }

        public string ShipmentName
        {
            get;
            set;
        }       

        public string SelectedModule
        {
            get;
            set;
        }       
      
        public int ShipmentRef_ID
        { get; set; }

        public int Task_ID
        { get; set; }

        public int TaskAllocation_ID
        { get; set; }

        public DataTable AssignedTANs
        {
            get;
            set;
        }

        public string DocType
        {
            get;
            set;
        }       

        #endregion

        private void frmTaskSheet_Load(object sender, EventArgs e)
        {
            try
            {

                //GlobalVariables.ModuleName = "INDX";
              
                //Analyst
                //AssignedTANs = TaskManagementDB.GetUserAssignedTANs(GlobalVariables.UserRoleID, GlobalVariables.ApplicationName, GlobalVariables.ModuleName);

                //Review Analyst
                //  AssignedTANs = TaskManagementDB.GetUserAssignedTANs(79);

                //Qc
                //    AssignedTANs = TaskManagementDB.GetUserAssignedTANs(78);

                //Get Assigned TANs for this user and bind to grid here
                BindAssignedTANsToGrid(AssignedTANs);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindAssignedTANsToGrid(DataTable assignedTans)
        {
            try
            {
                if (assignedTans != null)
                {
                    dgvAssignTANs.AutoGenerateColumns = false;
                    dgvAssignTANs.DataSource = assignedTans;

                    colTaskID.DataPropertyName = "TASK_ID";
                    colTaskAllocationID.DataPropertyName = "TASK_ALLOC_ID";
                    colShipmentRefID.DataPropertyName = "SHIPMENT_REF_ID";

                    colShipmentRefNo.DataPropertyName = "REFERENCE_NAME";
                    colYear.DataPropertyName = "SHIPMENT_YEAR";
                    colIssue.DataPropertyName = "ISSUE";
                    colSysClassType.DataPropertyName = "SYS_CLASS_TYPE";
                    colShipmentName.DataPropertyName = "SHIPMENT_NAME";                   
                    colManagerURId.DataPropertyName = "TOOL_MGR_UR_ID";
                    colDocType.DataPropertyName = "DOC_TYPE";
                    colTaskStatus.DataPropertyName = "TASK_STATUS";
                    colRxnCount.DataPropertyName = "REACTION_CNT";  
                    colIsReAssigned.DataPropertyName = "IS_REASSIGNED";
                    colIsRejected.DataPropertyName = "IS_REJECTED";

                    colAnalystName.DataPropertyName = "ANALYST";
                    colReviewerName.DataPropertyName = "REV_ANALYST";                   

                    colAnalystStatus.DataPropertyName = "ANA_STATUS";
                    colReviewStatus.DataPropertyName = "REV_ANA_STATUS";
                    colQCStatus.DataPropertyName = "QUA_ANA_STATUS";

                    if (GlobalVariables.RoleName.ToUpper() == "ANALYST")
                    {
                        colAnalystName.Visible = false;
                        colReviewerName.Visible = false;
                    }
                    else if (GlobalVariables.RoleName.ToUpper() == "REVIEW ANALYST")
                    {
                        colReviewerName.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvAssignTANs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;

                string strColName = dgvAssignTANs.Columns[e.ColumnIndex].HeaderText;
                if (strColName.ToUpper() == "REFERENCENO")
                {
                    SelectedRef = dgvAssignTANs.Rows[e.RowIndex].Cells[colShipmentRefNo.Name].Value.ToString();
                    ShipmentRef_ID = Convert.ToInt32(dgvAssignTANs.Rows[e.RowIndex].Cells[colShipmentRefID.Name].Value.ToString());
                    ShipmentName = dgvAssignTANs.Rows[e.RowIndex].Cells[colShipmentName.Name].Value.ToString();
                    DocType = dgvAssignTANs.Rows[e.RowIndex].Cells[colDocType.Name].Value.ToString();   

                    Task_ID = Convert.ToInt32(dgvAssignTANs.Rows[e.RowIndex].Cells[colTaskID.Name].Value.ToString());
                    TaskAllocation_ID = Convert.ToInt32(dgvAssignTANs.Rows[e.RowIndex].Cells[colTaskAllocationID.Name].Value.ToString());
                           
                    //Set Task to PROGRESS, if status is ASSIGNED
                    UpdateUserAssignedTaskStatus(dgvAssignTANs.Rows[e.RowIndex]);

                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }                
                else if (strColName.ToUpper() == "VIEW")//View PDF 
                {
                    Cursor = Cursors.WaitCursor;
                    string strTAN = dgvAssignTANs.Rows[e.RowIndex].Cells[colShipmentRefNo.Name].Value.ToString();
                    string strShipment = dgvAssignTANs.Rows[e.RowIndex].Cells[colShipmentName.Name].Value.ToString();

                    //Check & Open Reference Pdf
                    OpenReferencePdfFile(strTAN, strShipment);
                    Cursor = Cursors.Default;
                }               
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void UpdateUserAssignedTaskStatus(DataGridViewRow gridRow)
        {
            try
            {
                if (gridRow != null)
                {
                    string allocStatus = "";
                    if (GlobalVariables.RoleName.ToUpper() == "ANALYST")
                    {
                        allocStatus = gridRow.Cells[colAnalystStatus.Name].Value.ToString();
                    }
                    else if (GlobalVariables.RoleName.ToUpper() == "REVIEW ANALYST")
                    {
                        allocStatus = gridRow.Cells[colReviewStatus.Name].Value.ToString();
                    }
                    else if (GlobalVariables.RoleName.ToUpper() == "QUALITY ANALYST")
                    {
                        allocStatus = gridRow.Cells[colQCStatus.Name].Value.ToString();
                    }

                    if (allocStatus == "ASSIGNED")
                    {
                        TaskStatus taskStatus = new TaskStatus();
                        taskStatus.Task_ID = Task_ID;
                        taskStatus.TaskAllocation_ID = TaskAllocation_ID;                       
                        taskStatus.Role_ID = GlobalVariables.RoleId;
                        taskStatus.UR_ID = GlobalVariables.UR_ID;
                        taskStatus.TaskStatusName = "SET PROGRESS";

                        //Update User Task Status
                        TaskManagementDB.UpdateUserTaskStatus(taskStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvAssignTANs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvAssignTANs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvAssignTANs.Font);
                if (dgvAssignTANs.RowHeadersWidth < (int)(size.Width + 20)) dgvAssignTANs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void curationCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dgvAssignTANs.SelectedRows.Count == 1)
                //{

                //    string TanStatus = dgvAssignTANs.SelectedRows[0].Cells["colTANStatus"].Value.ToString().ToUpper();

                //    if (TanStatus == "ASSIGNED FOR CURATION" || TanStatus == "RE-ASSIGNED FOR CURATION")
                //    {
                //        string strTAN = dgvAssignTANs.SelectedRows[0].Cells["colTan"].Value.ToString();

                //        //Check if TAN is curated or not by check no.of records in Patent Table
                //        //if (CASRxnDataAccess.CheckIfTANIsCuratedROrNot(strTAN))
                //        //{
                //        //Show Error Report here -(Zero participants/Duplicate Reaction(Same Reactants),Free Text spell check
                //        if (CheckForZeroPartpntsAndRSN_SpellCheck(strTAN, "Curation"))
                //        {
                //            string Ass_User = dgvAssignTANs.SelectedRows[0].Cells["assbyuser"].Value.ToString();
                //            int Ass_Role_Id = Common.DataConversions.GetRoleIDByRoleName(dgvAssignTANs.SelectedRows[0].Cells["assbyrole"].Value.ToString());

                //            int[] intTAN_BtID = new int[1];
                //            intTAN_BtID[0] = Convert.ToInt32(dgvAssignTANs.SelectedRows[0].Cells["colTanID"].Value.ToString());

                //            string strTanStatus = "Curation Completed";

                //            if (ReactDB.InsertTaskAssignmentDetails(intTAN_BtID, Ass_User, Ass_Role_Id, GlobalVariables.URID, strTanStatus, DateTime.Now))
                //            {
                //                //Retrieve assigned TANs for the user based on userid,role
                //                DataTable dtAssignedTans = ReactDB.GetUserAssignedTANs(GlobalVariables.URID, GlobalVariables.RoleID);

                //                //Refresh Assigned TANS
                //                AssignedTANs = dtAssignedTans;

                //                //Bind TANs to Grid
                //                BindAssignedTANsToGrid(dtAssignedTans);

                //                //Delete TAN Pdf from SetUp path
                //                //DeleteTANPdfFile(strTAN);

                //                MessageBox.Show("Reported Curation Complete Status", "Curation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //            else
                //            {
                //                MessageBox.Show("Error in Reporting Curation Complete Status", "Curation Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            }
                //        }
                //        //}
                //        //else
                //        //{
                //        //    MessageBox.Show("TAN - " + strTAN + " is not curated. Please curate the TAN", "Curation Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        //}
                //    }
                //}
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
                
        private void OpenReferencePdfFile(string refName, string shipmentName)
        {
            try
            {
                if (!string.IsNullOrEmpty(refName) && !string.IsNullOrEmpty(shipmentName))
                {
                    string strPdfName = refName;
                    strPdfName = strPdfName + ".pdf";

                    string strShipment = shipmentName;
                    string pdfFolderName = System.Configuration.ConfigurationSettings.AppSettings["PdfFolderName"].ToString();
                    string strPdfDirPath = Path.Combine(Application.StartupPath.ToString(), pdfFolderName);

                    if (!Directory.Exists(strPdfDirPath))
                    {
                        Directory.CreateDirectory(strPdfDirPath);
                    }

                    string strPdfPath = strPdfDirPath + "\\" + strPdfName;

                    if (!File.Exists(strPdfPath))
                    {                           
                        string serverPath = System.Configuration.ConfigurationSettings.AppSettings["FileServerPath"].ToString();

                        string strFilepath = serverPath + "\\" + shipmentName + "\\" + strPdfName;

                        string strError_Out = "";
                        if (Common.Download_UploadPdf.DownloadFileFromWindowsServer(strFilepath, strPdfPath, out strError_Out))
                        {
                            System.Diagnostics.Process.Start(strPdfPath);
                        }
                        else
                        {
                            MessageBox.Show(strError_Out, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(strPdfPath);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Filtering Methods & Events

        private void txtTAN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GetFilterDataAndBindToGrid();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void txtBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    GetFilterDataAndBindToGrid();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private string GetFilterCondition()
        {
            string strFCond = "";
            try
            {
                //if (txtTAN.Text.Trim() != "")
                //{
                //    strFCond = "TAN_NAME like '" + txtTAN.Text.Trim() + "%'";
                //}
                //if (txtBName.Text.Trim() != "")
                //{
                //    if (strFCond.Trim() == "")
                //    {
                //        strFCond = "SHIPMENT_NAME = '" + txtBName.Text.Trim() + "'";
                //    }
                //    else
                //    {
                //        strFCond = strFCond + " and SHIPMENT_NAME = '" + txtBName.Text.Trim() + "'";
                //    }
                //}
                //if (txtBNo.Text.Trim() != "")
                //{
                //    if (strFCond.Trim() == "")
                //    {
                //        strFCond = "BATCH_NO = " + txtBNo.Text.Trim() + "";
                //    }
                //    else
                //    {
                //        strFCond = strFCond + " and BATCH_NO = " + txtBNo.Text.Trim() + "";
                //    }
                //}
                //if (txtTanStatus.Text.Trim() != "")
                //{
                //    if (strFCond.Trim() == "")
                //    {
                //        strFCond = "TAN_STATUS like '" + txtTanStatus.Text.Trim() + "%'";
                //    }
                //    else
                //    {
                //        strFCond = strFCond + " and TAN_STATUS like '" + txtTanStatus.Text.Trim() + "%'";
                //    }
                //}
                ////if (txtAssignBy.Text.Trim() != "")
                ////{
                ////    if (strFCond.Trim() == "")
                ////    {
                ////        strFCond = "Assigned_By_User like '" + txtAssignBy.Text.Trim() + "%'";
                ////    }
                ////    else
                ////    {
                ////        strFCond = strFCond + " and Assigned_By_User like '" + txtAssignBy.Text.Trim() + "%'";
                ////    }
                ////}
                ////if (txtAssignbyRole.Text.Trim() != "")
                ////{
                ////    if (strFCond.Trim() == "")
                ////    {
                ////        strFCond = "Assigned_by_Role like '" + txtAssignbyRole.Text.Trim() + "%'";
                ////    }
                ////    else
                ////    {
                ////        strFCond = strFCond + " and Assigned_by_Role like '" + txtAssignbyRole.Text.Trim() + "%'";
                ////    }
                ////}
                ////if (txtAssignTo.Text.Trim() != "")
                ////{
                ////    if (strFCond.Trim() == "")
                ////    {
                ////        strFCond = "Assigned_To_User like '" + txtAssignTo.Text.Trim() + "%'";
                ////    }
                ////    else
                ////    {
                ////        strFCond = strFCond + " and Assigned_To_User like '" + txtAssignTo.Text.Trim() + "%'";
                ////    }
                ////}
                ////if (txtAssignToRole.Text.Trim() != "")
                ////{
                ////    if (strFCond.Trim() == "")
                ////    {
                ////        strFCond = "Assigned_To_Role like '" + txtAssignToRole.Text.Trim() + "%'";
                ////    }
                ////    else
                ////    {
                ////        strFCond = strFCond + " and Assigned_To_Role like '" + txtAssignToRole.Text.Trim() + "%'";
                ////    }
                ////}
                return strFCond;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strFCond;
        }

        private void GetFilterDataAndBindToGrid()
        {
            try
            {
                if (AssignedTANs != null)
                {
                    if (AssignedTANs.Rows.Count > 0)
                    {
                        string strFCond = GetFilterCondition();
                        if (strFCond.Trim() != "")
                        {
                            DataTable dtAllTANs = AssignedTANs.Copy();
                            DataView dv = dtAllTANs.DefaultView;
                            DataTable dtTemp = null;

                            dv.RowFilter = strFCond;
                            dtTemp = dv.ToTable();
                            BindAssignedTANsToGrid(dtTemp);
                        }
                        else
                        {
                            DataTable dtAllTANs = AssignedTANs.Copy();
                            BindAssignedTANsToGrid(dtAllTANs);
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

    }
}
