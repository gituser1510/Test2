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
using MSExcel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using DataGridViewAutoFilter;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChemInform.Reports
{
    public partial class frmDeliveryReport : Form
    {
        public frmDeliveryReport()
        {
            InitializeComponent();
        }

        #region Properties

        BindingSource bsDelivery = new BindingSource();
        BindingSource bsDeliveryDetails = new BindingSource();
        int DeliveryRecordCount = 0;
        int DetailRecordCount = 0;

        public DataTable dtDeliveryMaster { get; set; }
        public DataTable dtDeliveryDetails { get; set; }

        #endregion

        private void frmDeliveryReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                                
                GetDeliveryMasterDetailsAndBindToGrid();

                bsDeliveryDetails.DataSource = null;
                dgvDeliveryDetails.DataSource = bsDeliveryDetails;

                if (dgvDeliveryMaster.Rows.Count > 0)
                {
                    dgvDeliveryMaster.Rows[0].Cells[1].Selected = true;
                }
            }
            catch (Exception ex)
            {

                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        
        private static void SetChartProperties(Chart _chartcntrl, string charttype, string xproptype, string xPropName, string yPropName)
        {
            try
            {
                _chartcntrl.Series[0].EmptyPointStyle.MarkerStyle = MarkerStyle.None;
                _chartcntrl.Series[0].EmptyPointStyle.MarkerColor = Color.Transparent;
                _chartcntrl.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                _chartcntrl.Series[0].BorderColor = Color.Black;
                _chartcntrl.Legends[0].Enabled = false;
                _chartcntrl.Location = new System.Drawing.Point(0, 0);
                _chartcntrl.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));

                _chartcntrl.ChartAreas[0].CursorX.IsUserEnabled = true;
                _chartcntrl.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                _chartcntrl.ChartAreas[0].CursorY.IsUserEnabled = true;
                _chartcntrl.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                _chartcntrl.ChartAreas[0].CursorX.Interval = 0.0000001;
                _chartcntrl.ChartAreas[0].CursorX.LineColor = Color.Transparent;
                _chartcntrl.ChartAreas[0].CursorX.SelectionColor = Color.SandyBrown;
                _chartcntrl.ChartAreas[0].CursorY.Interval = 0.00000001;
                _chartcntrl.ChartAreas[0].CursorY.LineColor = Color.Transparent;
                _chartcntrl.ChartAreas[0].CursorY.SelectionColor = Color.SandyBrown;

                _chartcntrl.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                _chartcntrl.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

                // Set Border Color
                _chartcntrl.ChartAreas[0].BorderColor = Color.Black;
                _chartcntrl.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
                _chartcntrl.ChartAreas[0].BorderWidth = 1;

                if (_chartcntrl.Titles.Count == 0)
                {
                    _chartcntrl.Titles.Add("Title");
                }
                _chartcntrl.Titles[0].Text = xPropName + " - " + yPropName;
                _chartcntrl.ChartAreas[0].Axes[0].Title = xPropName;
                _chartcntrl.ChartAreas[0].Axes[1].Title = yPropName;

                if (xproptype == "NUMBER")
                {
                    _chartcntrl.ChartAreas[0].AxisX.LabelStyle.Format = "F4";
                }
                //_chartcntrl.ChartAreas[0].AxisY.LabelStyle.Format = "F4";

                if (charttype.ToUpper() == "POINT")
                {
                    _chartcntrl.Series[0].ChartType = SeriesChartType.Point;
                    _chartcntrl.Series[0].MarkerSize = 10;
                    _chartcntrl.Series[0].MarkerColor = Color.FromArgb(200, Color.GreenYellow);
                    _chartcntrl.Series[0].MarkerBorderColor = Color.FromArgb(200, Color.Black);
                }
                else if (charttype.ToUpper() == "BUBBLE")
                {
                    _chartcntrl.Series[0].ChartType = SeriesChartType.Bubble;
                    // Set bubble size scale
                    _chartcntrl.Series[0]["BubbleScaleMin"] = "0";
                    _chartcntrl.Series[0]["BubbleScaleMax"] = "100";
                    _chartcntrl.Series[0].MarkerSize = 1;
                    _chartcntrl.Series[0].MarkerStyle = MarkerStyle.Circle;
                    _chartcntrl.Series[0].MarkerColor = Color.FromArgb(200, Color.GreenYellow);
                    _chartcntrl.Series[0].MarkerBorderColor = Color.FromArgb(200, Color.Black);
                }
                else if (charttype.ToUpper() == "LINE")
                {
                    _chartcntrl.ChartAreas[0].CursorY.AutoScroll = true;
                    _chartcntrl.Series[0].ChartType = SeriesChartType.Line;
                    _chartcntrl.Series[0].Sort(PointSortOrder.Ascending);
                }
                else if (charttype.ToUpper() == "COLUMN")
                {
                    _chartcntrl.Series[0].ChartType = SeriesChartType.Column;
                    _chartcntrl.Series[0].MarkerSize = 2;
                    _chartcntrl.Series[0].Color = Color.Green; // Color.FromArgb(200, Color.GreenYellow);
                    _chartcntrl.Series[0].BorderColor = Color.Transparent;
                    //_chartcntrl.ChartAreas[0].AxisX.View.Zoomable = false;
                    //_chartcntrl.ChartAreas[0].AxisY.View.Zoomable = false;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
 
        #region Export to Excel

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrormsg = string.Empty;
                BindingSource btTemp = new BindingSource();

                if (ValidateUserInputs(out strErrormsg))
                {
                    if (chkDeliveries.Checked)
                    {
                        btTemp = (BindingSource)dgvDeliveryMaster.DataSource;
                        DataTable dtDeliveries = (DataTable)btTemp.DataSource;
                        if (dtDeliveries.Rows.Count > 0)
                        {
                            SaveGridDataToExcel(dtDeliveries);
                        }
                    }
                    if (chkDeliveryDetails.Checked)
                    {
                        btTemp = (BindingSource)dgvDeliveryDetails.DataSource;
                        DataTable dtDeliveryDetails = (DataTable)btTemp.DataSource;
                        if (dtDeliveryDetails.Rows.Count > 0)
                        {
                            SaveGridDataToExcel(dtDeliveryDetails);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(strErrormsg.Trim(), GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void SaveGridDataToExcel(DataTable dtInputtable)
        {
            try
            {
                MSExcel.Application excel = new MSExcel.Application();

                if (excel != null)
                {
                    excel.Application.Workbooks.Add(true);
                    int ColumnIndex = 0;
                    foreach (DataColumn col in dtInputtable.Columns)
                    {
                        ColumnIndex++;
                        excel.Cells[1, ColumnIndex] = col.ColumnName;
                    }
                    int rowIndex = 0;
                    foreach (DataRow row in dtInputtable.Rows)
                    {
                        rowIndex++;
                        ColumnIndex = 0;
                        foreach (DataColumn col in dtInputtable.Columns)
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
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool ValidateUserInputs(out string _errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";

            try
            {
                if (string.IsNullOrEmpty(txtOutputFolder.Text.Trim()))
                {
                    strErrMsg = "Please select output folder to Export excel files.";
                    blStatus = false;
                }
                if (!(chkDeliveries.Checked || chkDeliveryDetails.Checked))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select Grid to export to excel";
                    blStatus = false;
                }
                else
                {
                    if (chkDeliveries.Checked)
                    {
                        if (dgvDeliveryMaster.Rows.Count == 0)
                        {
                            strErrMsg = strErrMsg.Trim() + "\r\n" + "Deliveries Grid has no rows to export. Please uncheck deliveries checkbox.";
                            blStatus = false;
                        }
                    }

                    if (chkDeliveryDetails.Checked)
                    {
                        if (dgvDeliveryDetails.Rows.Count == 0)
                        {
                            strErrMsg = strErrMsg.Trim() + "\r\n" + "Delivery details Grid has no rows to export. Please uncheck delivery details checkbox.";
                            blStatus = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            _errmsg_out = strErrMsg;
            return blStatus;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbdIpBrowse = new FolderBrowserDialog())
                {
                    if (fbdIpBrowse.ShowDialog() == DialogResult.OK)
                    {
                        txtOutputFolder.Text = fbdIpBrowse.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Delivery Filters

        private void dgvDeliveries_BindingContextChanged(object sender, EventArgs e)
        {
            if (dgvDeliveryMaster.DataSource == null)
            {
                return;
            }

            dgvDeliveryMaster.AutoResizeColumns();
        }

        private void dgvDeliveries_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                String filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dgvDeliveryMaster);
                if (String.IsNullOrEmpty(filterStatus))
                {
                    lnkLbClearFilter.Visible = false;
                }
                else
                {
                    lnkLbClearFilter.Visible = true;
                }

                if (DeliveryRecordCount == dgvDeliveryMaster.Rows.Count)
                {
                    lnkLbClearFilter.Visible = false;
                }

                if (bsDelivery.List != null)
                {
                    DataView dvTemp = bsDelivery.List as DataView;
                    if (dvTemp != null)
                    {
                        //set Status labels
                        SetDeliveryMasterStatusLabels(dvTemp.ToTable());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvDeliveries_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void lnkLbClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lnkLbClearFilter.Visible = false;
                DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvDeliveryMaster);

                bsDelivery.DataSource = dtDeliveryMaster;
                dgvDeliveryMaster.DataSource = bsDelivery;

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        #endregion

        #region Delivery Datails Filtering

        private void lnklblAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lnklblAll.Visible = false;
                DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvDeliveryDetails);

                bsDeliveryDetails.DataSource = dtDeliveryDetails;
                dgvDeliveryDetails.DataSource = bsDeliveryDetails;

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvDeliveryDetails_BindingContextChanged(object sender, EventArgs e)
        {
            if (dgvDeliveryDetails.DataSource == null)
            {
                return;
            }

            dgvDeliveryDetails.AutoResizeColumns();
        }

        private void dgvDeliveryDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgvDeliveryDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                String filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dgvDeliveryDetails);
                if (String.IsNullOrEmpty(filterStatus))
                {
                    lnklblAll.Visible = false;
                }
                else
                {
                    lnklblAll.Visible = true;
                }

                if (DetailRecordCount == dgvDeliveryDetails.Rows.Count)
                {
                    lnklblAll.Visible = false;
                }

                if (bsDeliveryDetails.List != null)
                {
                    DataView dvTemp = bsDeliveryDetails.List as DataView;
                    if (dvTemp != null)
                    {
                        //set Status labels
                        SetDeliveryDetailsStatusLabels(dvTemp.ToTable());
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void SetDeliveryMasterStatusLabels(DataTable deliveryMasterData)
        {
            try
            {
                if (deliveryMasterData != null)
                {
                    //Reactions count
                    object objRxnsCnt = deliveryMasterData.Compute("sum([DELIVERED_REACTION_CNT])", "[DELIVERED_REACTION_CNT] is not null");
                    if (objRxnsCnt != null)
                    {
                        lblDeliveredRxnsCnt.Text = objRxnsCnt.ToString();
                    }

                    object objRefsCnt = deliveryMasterData.Compute("sum([DELIVERED_REFS_CNT])", "[DELIVERED_REFS_CNT] is not null");
                    if (objRefsCnt != null)
                    {
                        lblDeliveredRefsCnt.Text = objRefsCnt.ToString();
                    }

                    //No.of References
                    lblTotalDeliveriesCnt.Text = deliveryMasterData.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void SetDeliveryDetailsStatusLabels(DataTable reportData)
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
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Grid RowPostPaint Events

        private void dgvDeliveries_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvDeliveryMaster.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvDeliveryMaster.Font);

                if (dgvDeliveryMaster.RowHeadersWidth < (int)(size.Width + 20)) dgvDeliveryMaster.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvDeliveryDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvDeliveryDetails.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvDeliveryDetails.Font);

                if (dgvDeliveryDetails.RowHeadersWidth < (int)(size.Width + 20)) dgvDeliveryDetails.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvDeliverySolvents_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvDeliveryDetails.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvDeliveryDetails.Font);

                if (dgvDeliveryDetails.RowHeadersWidth < (int)(size.Width + 20)) dgvDeliveryDetails.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private void dgvDeliveryMaster_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    int delivertyId = Convert.ToInt32(dgvDeliveryMaster.Rows[e.RowIndex].Cells[colDeliveryId.Name].Value);

                    DataSet dsDeliveryDtls = DeliveriesDB.GetDeliverDetails(delivertyId);

                    if (dsDeliveryDtls != null && dsDeliveryDtls.Tables.Count == 2)
                    {
                        bsDeliveryDetails.Filter = String.Empty;

                        dtDeliveryDetails = dsDeliveryDtls.Tables[0];                       
                       
                        //Bind Delivery references to grid
                        BindDeliveryDetailsToGrid(dtDeliveryDetails);

                        //Bind Delivery Solvents to grid
                        BindDeliverySolventsToGrid(dsDeliveryDtls.Tables[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvDeliverySolvents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    solventRenderer.MolfileString = dgvDeliverySolvents.Rows[e.RowIndex].Cells[colSolventMolFile.Name].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }        

        private void GetDeliveryMasterDetailsAndBindToGrid()
        {
            try
            {
                dgvDeliveryMaster.AutoGenerateColumns = false;

                colDeliveryId.DataPropertyName = "DELIVERY_ID";
                colDeliveryName.DataPropertyName = "DELIVERY_NAME";
                colDeliveryDate.DataPropertyName = "DELIVERY_DATE";
                colDeliveredRefCount.DataPropertyName = "DELIVERED_REFS_CNT";
                colDeliveredReactionCount.DataPropertyName = "DELIVERED_REACTION_CNT";
                colMdlStartNum.DataPropertyName = "MDL_START_NO";
                colMdlEndNum.DataPropertyName = "MDL_END_NO";
                colDeliveredBy.DataPropertyName = "CREATED_BY";

                colRefName.DataPropertyName = "REFERENCE_NAME";
                colClassType.DataPropertyName = "SYS_CLASS_TYPE";
                colRefRxnCount.DataPropertyName = "REACTION_CNT";
                colDR_ID.DataPropertyName = "DR_ID";
                colShipmentRefID.DataPropertyName = "SHIPMENT_REF_ID";

                //Get Delivery Master details
                dtDeliveryMaster = DeliveriesDB.GetDeliveryMasterDetails();

                bsDelivery.Filter = String.Empty;
                if (dtDeliveryMaster != null)
                {
                    if (dtDeliveryMaster.Rows.Count > 0)
                    {
                        DeliveryRecordCount = dtDeliveryMaster.Rows.Count;
                        bsDelivery.DataSource = dtDeliveryMaster;
                        dgvDeliveryMaster.DataSource = bsDelivery;

                        //Bind delivery master data to chart
                        BindDeliveryDataToChart(dtDeliveryMaster);
                    }
                    else
                    {
                        bsDelivery.DataSource = null;
                        dgvDeliveryMaster.DataSource = bsDelivery;
                    }
                }
                else
                {
                    bsDelivery.DataSource = null;
                    dgvDeliveryMaster.DataSource = bsDelivery;
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDeliveryDetailsToGrid(DataTable deliveryDtls)
        {
            try
            {
                if (deliveryDtls != null && deliveryDtls.Rows.Count > 0)
                {
                    DetailRecordCount = deliveryDtls.Rows.Count;
                    bsDeliveryDetails.DataSource = deliveryDtls;

                    colRefName.DataPropertyName = "REFERENCE_NAME";
                    colClassType.DataPropertyName = "SYS_CLASS_TYPE";
                    colRefRxnCount.DataPropertyName = "REACTION_CNT";
                    colDR_ID.DataPropertyName = "DR_ID";
                    colShipmentRefID.DataPropertyName = "SHIPMENT_REF_ID";

                    dgvDeliveryDetails.AutoGenerateColumns = false;
                    dgvDeliveryDetails.DataSource = bsDeliveryDetails;
                }
                else
                {
                    bsDeliveryDetails.DataSource = null;
                    dgvDeliveryDetails.DataSource = bsDeliveryDetails;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDeliverySolventsToGrid(DataTable deliverySolvCats)
        {
            try
            {
                if (deliverySolvCats != null && deliverySolvCats.Rows.Count > 0)
                {
                    dgvDeliverySolvents.AutoGenerateColumns = false;
                    dgvDeliverySolvents.DataSource = deliverySolvCats;

                    colShipmentRef_Solv.DataPropertyName = "REFERENCE_NAME";
                    colSolventName_Solv.DataPropertyName = "MOL_NAME";
                    colSolventMolFile.DataPropertyName = "MOL_FILE";
                }
                else
                {                   
                    dgvDeliverySolvents.DataSource = null;
                    solventRenderer.MolfileString = "";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDeliveryDataToChart(DataTable deliveryMaster)
        {
            try
            {
                if (deliveryMaster != null)
                {
                    string[] saUsers;
                    int[] yData;

                    DataRow[] rows = deliveryMaster.Select();
                    saUsers = Array.ConvertAll(rows, row => row.ItemArray[0].ToString());
                    yData = Array.ConvertAll(rows, row => Convert.ToInt32(row["DELIVERED_REACTION_CNT"]));

                    chart1.Series[0].Points.DataBindXY(saUsers, yData);

                    SetChartProperties(chart1, "COLUMN", "STRING", "Delivery", "RXN Count");
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        
    }
}
