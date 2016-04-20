using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChemInform.Common;
using ChemInform.Dal;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChemInform.Reports
{
    public partial class frmDailyStatusReport : Form
    {
        public frmDailyStatusReport()
        {
            InitializeComponent();
        }

        private void frmDailyStatusReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                dpFromDate.MaxDate = DateTime.Today;
                dpToDate.MaxDate = DateTime.Today;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate user inputs
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {
                    if (dpFromDate.Text != null && dpToDate.Text != null)
                    {
                        string module = GetSelectedModuleCode();

                        DataTable dtDStatus = DataOperations.GetMonthlyStatusReport(dpFromDate.Value, dpToDate.Value, module);
                        BindDailyStatusDataToGrid(dtDStatus);
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
              
        private bool ValidateUserInputs(out string errMsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (string.IsNullOrEmpty(cmbModule.Text))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select Module";
                    blStatus = false;
                }

                if (dpFromDate.Value > dpToDate.Value)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "From Date must be less than To Date.";
                    blStatus = false;
                }
                if (dpToDate.Value > DateTime.Today)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "To Date is must be less than Today.";
                    blStatus = false;
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errMsg = strErrMsg.Trim();
            return blStatus;
        }
        
        private void BindDailyStatusDataToGrid(DataTable dailystatusdata)
        {
            try
            {
                if (dailystatusdata != null)
                {
                    dgvReport.AutoGenerateColumns = false;
                    dgvReport.DataSource = dailystatusdata;

                    colUR_ID.DataPropertyName = "UR_ID";
                    colUserName.DataPropertyName = "USER_NAME";
                    colRoleName.DataPropertyName = "ROLE_NAME";
                    colReferenceCount.DataPropertyName = "COMPLETED_REF_CNT";
                    colRefRxnCount.DataPropertyName = "COMPLETED_RXN_CNT";

                    BindReportDataToChart(dailystatusdata);

                    SetChartProperties(chart1, "COLUMN", "STRING", "Curator", "RXN Count");

                }
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

        private void BindReportDataToChart(DataTable dailyStatusData)
        {
            try
            {
                DataView dvCuratorData = dailyStatusData.Copy().DefaultView;
                dvCuratorData.RowFilter = "ROLE_NAME = 'ANALYST'";
                DataTable dtCuratorData = dvCuratorData.ToTable();
                if (dtCuratorData != null)
                {
                    string[] saUsers;
                    int[] yData;

                    DataRow[] rows = dtCuratorData.Select();
                    saUsers = Array.ConvertAll(rows, row => row["USER_NAME"].ToString());
                    yData = Array.ConvertAll(rows, row => Convert.ToInt32(row["COMPLETED_RXN_CNT"]));

                    chart1.Series[0].Points.DataBindXY(saUsers, yData);
                }

                //Reactions count
                lblCurationCnt.Text = dailyStatusData.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'ANALYST'").ToString();
                lblReviewCnt.Text = dailyStatusData.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'REVIEW ANALYST'").ToString();
                lblQCCnt.Text = dailyStatusData.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'QUALITY ANALYST'").ToString();
                
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
        
    }
}
