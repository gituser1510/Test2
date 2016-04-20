using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MSExcel = Microsoft.Office.Interop.Excel;
using ChemInform.Dal;
using ChemInform.Common;
using DataGridViewAutoFilter;

namespace ChemInform.Reports
{
    public partial class frmShipmentStatusReport : Form
    {
        public frmShipmentStatusReport()
        {
            InitializeComponent();
        }

        public DataTable ShipmentData { get; set; }

        private void frmShipmentReport_New_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                BindAllShipments(ref cmbShipment);
                cmbShipment.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        BindingSource bsShipmentData;
        private void BindShipmentDataToGrid(System.Data.DataTable dtshipmentdata)
        {
            try
            {
                if (dtshipmentdata != null)
                {
                    if (bsShipmentData == null)
                    {
                        bsShipmentData = new BindingSource();
                        bsShipmentData.AllowNew = true;
                    }

                    bsShipmentData.DataSource = dtshipmentdata;

                    dgvReport.AutoGenerateColumns = false;
                    dgvReport.DataSource = bsShipmentData;

                    colShipmentRefID.DataPropertyName = "SHIPMENT_REF_ID";
                    colReferance.DataPropertyName = "REFERENCE_NAME";
                    colSysText.DataPropertyName = "SYS_TEXT";
                    colSysNo.DataPropertyName = "SYS_NO";
                    colDocType.DataPropertyName = "REFERENCE_TYPE";
                    colRxnCount.DataPropertyName = "REACTION_CNT";
                    colSysClassType.DataPropertyName = "SYS_CLASS_TYPE";
                    colTaskStatus.DataPropertyName = "TASK_STATUS";
                    colCurator.DataPropertyName = "CURATION_USER_NAME";
                    colReviewer.DataPropertyName = "REVIEWER_USER_NAME";
                    colQC.DataPropertyName = "QC_USER_NAME";
                    colIsDelivered.DataPropertyName = "IS_DELIVERED";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private int GetZeroReactionsCount(System.Data.DataTable _reporttbl)
        {
            int intCnt = 0;
            try
            {
                if (_reporttbl != null)
                {
                    if (_reporttbl.Rows.Count > 0)
                    {
                        System.Data.DataTable dtReport = _reporttbl.Copy();
                        DataView dvTemp = dtReport.DefaultView;
                        dvTemp.RowFilter = "[No.of Reactions]" + " = 0";
                        System.Data.DataTable dt = dvTemp.ToTable();
                        if (dt != null)
                        {
                            intCnt = dt.Rows.Count;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return intCnt;
        }

        private void SaveGridDataToExcel()
        {
            try
            {
                if (dgvReport.Rows.Count > 0)
                {
                    MSExcel.Application excel = new MSExcel.Application();

                    if (excel != null)
                    {
                        excel.Application.Workbooks.Add(true);

                        System.Data.DataTable table = bsShipmentData.DataSource as System.Data.DataTable; //(System.Data.DataTable)dgvReport.DataSource;
                        int ColumnIndex = 0;
                        foreach (DataColumn col in table.Columns)
                        {
                            ColumnIndex++;
                            excel.Cells[1, ColumnIndex] = col.ColumnName;
                        }
                        int rowIndex = 0;
                        foreach (DataRow row in table.Rows)
                        {
                            rowIndex++;
                            ColumnIndex = 0;
                            foreach (DataColumn col in table.Columns)
                            {
                                ColumnIndex++;
                                excel.Cells[rowIndex + 1, ColumnIndex] = row[col.ColumnName].ToString();
                            }
                        }

                        //excel.Cells[rowIndex + 2, 1] = txtZeroRxnCnt.Text.Trim();

                        excel.Visible = true;
                        //Worksheet worksheet = (Worksheet)excel.ActiveSheet;
                        //worksheet.Activate();
                    }
                    else
                    {
                        MessageBox.Show("Excel is not installed on your system. Please install Excel", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
                
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveGridDataToExcel();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
               
        public void BindAllShipments(ref ComboBox cmb)
        {
            try
            {
                DataTable dtShipMents = Dal.ShipmentManagementDB.GetAllShipments();
                if (dtShipMents.Rows.Count > 0)
                {
                    //Bind shipmetns To Combo Box 
                    cmb.DisplayMember = "SHIPMENT_NAME";
                    cmb.ValueMember = "SHIPMENT_ID";
                    cmb.DataSource = dtShipMents;
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }
        
        private void dgvReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvReport.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvReport.Font);

                if (dgvReport.RowHeadersWidth < (int)(size.Width + 20)) dgvReport.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        string strYear_Issue = "";
        private void cmbShipment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbShipment.SelectedIndex != -1)
                {
                    //Get Year & Issue
                    strYear_Issue = GetYearAndIssueFromShipmentName(cmbShipment.Text);

                    DataTable dtReportData = ShipmentManagementDB.GetShipmentStatusReport(Convert.ToInt32(cmbShipment.SelectedValue));
                    if (dtReportData != null)
                    {
                        Cursor = Cursors.WaitCursor;

                        ShipmentData = dtReportData;

                        if (dtReportData.Rows.Count > 0)
                        {
                            //Bind shipment data to grid
                            BindShipmentDataToGrid(dtReportData);

                            //set Status labels
                            SetShipmentStatusLabels(dtReportData);
                        }
                        else
                        {
                            dgvReport.DataSource = null;
                            MessageBox.Show("No data available for the shipment", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cursor = Cursors.Default;
                        }
                    }
                    else
                    {
                        dgvReport.DataSource = null;
                        MessageBox.Show("No data available for the shipment", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string GetYearAndIssueFromShipmentName(string shipmentName)
        {
            string yearIssue = "";
            try
            {
                if (!string.IsNullOrEmpty(shipmentName))
                {
                    string[] saTemp = shipmentName.Trim().Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
                    if (saTemp != null && saTemp.Length == 3)
                    {
                        yearIssue = saTemp[1].Trim().Substring(2, 2) + saTemp[2].Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return yearIssue;
        }

        private void SetShipmentStatusLabels(DataTable reportData)
        {
            try
            {
                if (reportData != null)
                {
                    //Reactions count
                    object objRxnsCnt = reportData.Compute("sum([REACTION_CNT])", "[REACTION_CNT] is not null");
                    if (objRxnsCnt != null)
                    {
                        lblRxnsCnt.Text = objRxnsCnt.ToString();
                    }

                    //No.of References
                    lblRefsCount.Text = reportData.Rows.Count.ToString();

                    //Delivered References
                    using (DataView dv_RAC = reportData.Copy().DefaultView)
                    {
                        dv_RAC.RowFilter = "IS_DELIVERED = 'Y'";
                        lblDelRefCnt.Text = dv_RAC.ToTable().Rows.Count.ToString();
                    }

                    //Not Assigned References
                    using (DataView dv_RAC = reportData.Copy().DefaultView)
                    {
                        dv_RAC.RowFilter = "TASK_STATUS = 'NOT ASSIGNED'";
                       lblNotAssignedRefs.Text = dv_RAC.ToTable().Rows.Count.ToString();                       
                    }
                    
                    //Curation Progress References
                    using (DataView dv_RAC = reportData.Copy().DefaultView)
                    {
                        dv_RAC.RowFilter = "TASK_STATUS = 'CURATION - PROGRESS'";
                        lblCurationProgressCnt.Text = dv_RAC.ToTable().Rows.Count.ToString();
                    }

                    //Curation Completed References
                    using (DataView dv_RAC = reportData.Copy().DefaultView)
                    {
                        dv_RAC.RowFilter = "TASK_STATUS = 'REVIEW - ASSIGNED'";
                        lblCurationCompleteCnt.Text = dv_RAC.ToTable().Rows.Count.ToString();
                    }

                    //Review Progress References
                    using (DataView dv_RAC = reportData.Copy().DefaultView)
                    {
                        dv_RAC.RowFilter = "TASK_STATUS = 'REVIEW - PROGRESS'";
                        lblReviewProgressCnt.Text = dv_RAC.ToTable().Rows.Count.ToString();
                    }

                    //Review Completed References
                    using (DataView dv_RAC = reportData.Copy().DefaultView)
                    {
                        dv_RAC.RowFilter = "TASK_STATUS = 'QC - ASSIGNED'";
                        lblReviewCompleteCnt.Text = dv_RAC.ToTable().Rows.Count.ToString();
                    }

                    //QC Progress References
                    using (DataView dv_RAC = reportData.Copy().DefaultView)
                    {
                        dv_RAC.RowFilter = "TASK_STATUS = 'QC - PROGRESS'";
                        lblQCProgressCnt.Text = dv_RAC.ToTable().Rows.Count.ToString();
                    }

                    //QC Completed References
                    using (DataView dv_RAC = reportData.Copy().DefaultView)
                    {
                        dv_RAC.RowFilter = "TASK_STATUS = 'QC - COMPLETED'";
                        lblQCCompleteCnt.Text = dv_RAC.ToTable().Rows.Count.ToString();
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvReport.Columns[e.ColumnIndex].Name.ToUpper() == colReferance.Name.ToUpper())
                    {
                        int shipmentRefID = Convert.ToInt32(dgvReport.Rows[e.RowIndex].Cells[colShipmentRefID.Name].Value.ToString());
                        string refType = dgvReport.Rows[e.RowIndex].Cells[colDocType.Name].Value.ToString();
                        if (shipmentRefID > 0)
                        {
                            if (refType == "ABSTRACT")
                            {
                                frmReactionCuration absCuration = new frmReactionCuration();                               
                                absCuration.ShipmentRefID = shipmentRefID;
                                absCuration.MdiParent = this.ParentForm;
                                absCuration.Show();
                            }
                            else if (refType == "JOURNAL")
                            {
                                frmReactionCuration_Journal journlCuration = new frmReactionCuration_Journal();                                
                                journlCuration.ShipmentRefID = shipmentRefID;
                                journlCuration.MdiParent = this.ParentForm;
                                journlCuration.Show();
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

        private void txtSearchRef_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ShipmentData != null)
                {
                    if (!string.IsNullOrEmpty(txtSearchRef.Text.Trim()))
                    {
                        string strFCond = GetFilterCondition(txtSearchRef.Text.Trim());

                        DataTable dtAllTANs = ShipmentData.Copy();
                        DataView dvTemp = dtAllTANs.DefaultView;
                        dvTemp.RowFilter = strFCond;
                        DataTable dtFilteredRefs = dvTemp.ToTable();

                        BindShipmentDataToGrid(dtFilteredRefs);
                    }
                    else
                    {
                        BindShipmentDataToGrid(ShipmentData);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
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

                    if (saRefNames != null && saRefNames.Length > 0)
                    {
                        for (int i = 0; i < saRefNames.Length; i++)
                        {
                            if (i == 0)
                            {
                                filterCond = "REFERENCE_NAME Like '" + strYear_Issue + "-" + saRefNames[i].Trim() + "%' ";
                            }
                            else
                            {
                                filterCond += " OR" + " REFERENCE_NAME Like '" + strYear_Issue + "-" + saRefNames[i].Trim() + "%'";
                            }
                        }
                    }
                }
                else
                {
                    filterCond = "REFERENCE_NAME Like '" + strYear_Issue + "-" + queryRefs.Trim() + "%'";
                }            
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return filterCond.Trim();
        }

        private void lnkClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {               
                DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvReport);
                bsShipmentData.DataSource = ShipmentData;
                dgvReport.DataSource = bsShipmentData;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (bsShipmentData.List != null)
                {
                    DataView dvTemp = bsShipmentData.List as DataView;
                    if (dvTemp != null)
                    {
                        //set Status labels
                        SetShipmentStatusLabels(dvTemp.ToTable());
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
