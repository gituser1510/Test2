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
using System.Windows.Forms.DataVisualization.Charting;

namespace ChemInform.Reports
{
    public partial class frmUserHourlyReport : Form
    {
        public frmUserHourlyReport()
        {
            InitializeComponent();
        }

        private void dpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Validate user inputs
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {
                    Cursor = Cursors.WaitCursor;
                    
                    DataTable dtDStatus = DataOperations.GetMonthlyStatusReport(dpFromDate.Value, dpFromDate.Value, "RA");
                    BindDailyStatusDataToGrid(dtDStatus);

                    Cursor = Cursors.Default;
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
                    colRefRxnCount.DataPropertyName = "COMPLETED_RXN_CNT";

                    //Reactions count
                    lblCurationCnt.Text = dailystatusdata.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'ANALYST'").ToString();
                    lblReviewCnt.Text = dailystatusdata.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'REVIEW ANALYST'").ToString();
                    lblQCCnt.Text = dailystatusdata.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'QUALITY ANALYST'").ToString();
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
                if (dpFromDate.Text == null)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select Date";
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
                
        private void BindUserHourlyReportDataToChart(DataTable hourlyData)
        {
            try
            {
                chart1.Series["serCreated"].Points.Clear();
                chart1.Series["serCompleted"].Points.Clear();

                if (hourlyData != null)
                {  
                    //Completed Reactions
                    int[] saHrs;
                    int[] yComplData;
                                        
                    DataRow[] createdRows = hourlyData.Select();

                    List<int> completedHrsList = new List<int>();
                    List<int> completedRxnList = new List<int>();
                    foreach (DataRow dr in createdRows)
                    {
                        if (Convert.ToInt32(dr["HR"]) > 21)
                        {
                            break;
                        }

                        completedHrsList.Add(Convert.ToInt32(dr["HR"].ToString()));
                        completedRxnList.Add(Convert.ToInt32(dr["COMPLETED_CNT"]));                       
                    }
                    saHrs = completedHrsList.ToArray();
                    yComplData = completedRxnList.ToArray();

                   
                    //Series completedSeries = new Series();
                    //completedSeries.Points.DataBindXY(saHrs, yComplData);
                    //completedSeries.ChartType = SeriesChartType.Column;
                    //completedSeries.Color = Color.Green;
                    chart1.Series["serCompleted"].Points.DataBindXY(saHrs, yComplData);

                    //chart1.ChartAreas[0].AxisX.Minimum = 0;
                    //chart1.ChartAreas[0].AxisX.Maximum = 22;
                    //chart1.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45;
                    //chart1.ChartAreas[0].AxisX.Interval = 1.0;

                    //Created Reactions
                    if (hourlyData.Columns.Contains("CREATED_CNT"))
                    {                      
                        
                        DataRow[] complRows = hourlyData.Select();
                        int[] saCreated;
                        int[] yCreatedData;

                        List<int> createdHrsList = new List<int>();
                        List<int> createdRxnList = new List<int>();

                        foreach (DataRow dr in complRows)
                        {
                            if (Convert.ToInt32(dr["HR"]) > 21)
                            {
                                break;
                            }

                            createdHrsList.Add(Convert.ToInt32(dr["HR"].ToString()));
                            createdRxnList.Add(Convert.ToInt32(dr["CREATED_CNT"]));
                        }
                        saCreated = createdHrsList.ToArray();
                        yCreatedData = createdRxnList.ToArray();
                        chart1.Series["serCreated"].Points.DataBindXY(saCreated, yCreatedData);
                        //Series createdSeries = new Series();
                        //createdSeries.Points.DataBindXY(saCreated, yCreatedData);
                        //createdSeries.ChartType = SeriesChartType.Column;
                        //createdSeries.Color = Color.Red;
                        //chart1.Series.Add(createdSeries);
                    }
                }

                ////Reactions count
                //lblCurationCnt.Text = dailyStatusData.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'ANALYST'").ToString();
                //lblReviewCnt.Text = dailyStatusData.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'REVIEW ANALYST'").ToString();
                //lblQCCnt.Text = dailyStatusData.Compute("sum([COMPLETED_RXN_CNT])", "ROLE_NAME = 'QUALITY ANALYST'").ToString();

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvReport_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvReport.Rows[e.RowIndex].Cells[colUR_ID.Name].Value != null)
                {
                    Cursor = Cursors.WaitCursor;
                    
                    DataTable userHourlyRep = DataOperations.GetUserHourlySummaryReport(Convert.ToInt32(dgvReport.Rows[e.RowIndex].Cells[colUR_ID.Name].Value), dpFromDate.Value);
                   
                    //Bind user hourly data to chart 
                    BindUserHourlyReportDataToChart(userHourlyRep);

                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
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
        
    }
}
