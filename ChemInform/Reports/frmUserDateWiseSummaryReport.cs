#region Name Spaces
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MSExcel = Microsoft.Office.Interop.Excel;
using ChemInform.Dal;
using ChemInform.Common;
using System.Runtime.InteropServices;

#endregion

namespace ChemInform.Reports
{
    public partial class frmUserDateWiseSummaryReport : Form
    {
        #region Default Constructor

        public frmUserDateWiseSummaryReport()
        {
            InitializeComponent();

        }

        #endregion

        #region Local & Instance Variables

        BindingSource bsReport = new BindingSource();
        public DataTable ShipmentTaskStatusDetails { get; set; }
        int TotalTANs = 0;

        #endregion

        #region Form Load
        /// <summary>
        /// Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserDateWiseSummaryReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                BindAllShipments(ref cmbShipment);
                cmbShipment.SelectedIndex = 0;
                cmbShipment_SelectionChangeCommitted(null, null);

                dtpFromDate.MaxDate = DateTime.Today;
                dtpToDate.MaxDate = DateTime.Today;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        #endregion

        /// <summary>
        /// Bind AllShipments.
        /// </summary>
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



        #region Methods

        /// <summary>
        /// Bind report data to data grid view 
        /// </summary>
        /// <param name="dtReport"></param>
        private void BindUserDateWiseSummaryReport(DataTable dtReport)
        {
            try
            {
                dgvReport.DataSource = null;

                if (dtReport != null && dtReport.Rows.Count > 0)
                {
                    dgvReport.AutoGenerateColumns = true;
                    dgvReport.DataSource = dtReport;

                    dgvReport.Columns["UR_ID"].Visible = false;

                    btnExport.Enabled = true;

                }
                else
                {
                    btnExport.Enabled = false;
                    dgvReport.DataSource = null;
                    MessageBox.Show("No Data Found between selected Dates.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }

        }

        /// <summary>
        /// Differences the of dates.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>Difference Number of dates, if Enddate is less than startdate it returns -1</returns>
        private static int DifferenceOfDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                TimeSpan tsShipmentSpan = Convert.ToDateTime(endDate.ToShortDateString()) -
                                             Convert.ToDateTime(startDate.ToShortDateString());
                return tsShipmentSpan.Days;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
                return -1;
            }
        }

        /// <summary>
        /// Validates User Inputs
        /// </summary>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        private bool ValidateUserInputs(out string errMsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (string.IsNullOrEmpty(cmbShipment.Text))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select shipment";
                    blStatus = false;
                }

                if (DifferenceOfDates(dtpFromDate.Value, dtpToDate.Value) < 0)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "To Date is must be Greater than or Equals to From date";
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

        #endregion




        private void cmbShipment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtpFromDate.ResetText();
            dtpToDate.ResetText();

            dgvReport.DataSource = null;
            btnExport.Enabled = false;
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate user inputs
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {
                    DataTable dtUserDateWiseSummary = DataOperations.GetUserDateWiseSummaryReport(Convert.ToInt32(cmbShipment.SelectedValue), dtpFromDate.Value, dtpToDate.Value);
                    BindUserDateWiseSummaryReport(dtUserDateWiseSummary);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Excel Export.

            try
            {
                //Validate user inputs
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {
                    if (dgvReport.Rows.Count > 0)
                    {
                        ExportToExcel(dgvReport);
                    }
                    else
                    {
                        MessageBox.Show("No rows available to export.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ExportToExcel(DataGridView dgv)
        {
            try
            {
                SaveFileDialog sfdExcelSave = new SaveFileDialog();
                sfdExcelSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfdExcelSave.Title = "Save excel Files";
                sfdExcelSave.DefaultExt = "xls";
                sfdExcelSave.Filter = "Excel files (*.xls)|*.xls";
                sfdExcelSave.FilterIndex = 2;
                sfdExcelSave.RestoreDirectory = true;

                if (sfdExcelSave.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    MSExcel.Application xlApp;
                    MSExcel.Workbook xlWorkBook;
                    MSExcel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlApp = new MSExcel.Application();

                    xlWorkBook = xlApp.Workbooks.Add(misValue);

                    xlWorkSheet = (MSExcel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    int i = 0;
                    int j = 0;

                    //for headers from grid to excel
                    for (j = 0; j <= dgv.ColumnCount - 1; j++)
                    {
                        xlWorkSheet.Cells[1, j + 1] = dgv.Columns[j].HeaderText;
                    }

                    //for data from grid to excel
                    for (i = 0; i <= dgv.RowCount - 1; i++)
                    {
                        for (j = 0; j <= dgv.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dgv[j, i];
                            xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                        }
                    }
                    xlWorkBook.SaveAs(sfdExcelSave.FileName, MSExcel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, MSExcel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);


                    MessageBox.Show("Successfully exported to Excel Sheet.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
                
        private void dgvReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                // get the row number in leading zero format, 
                //  where the width of the number = the width of the maximum number
                int RowNumWidth = dgvReport.RowCount.ToString().Length;
                StringBuilder RowNumber = new StringBuilder(RowNumWidth);
                RowNumber.Append(e.RowIndex + 1);
                while (RowNumber.Length < RowNumWidth)
                    RowNumber.Insert(0, "0");

                // get the size of the row number string
                SizeF Sz = e.Graphics.MeasureString(RowNumber.ToString(), dgvReport.Font);

                // adjust the width of the column that contains the row header cells 
                if (dgvReport.RowHeadersWidth < (int)(Sz.Width + 20))
                    dgvReport.RowHeadersWidth = (int)(Sz.Width + 20);

                // draw the row number
                e.Graphics.DrawString(
                    RowNumber.ToString(),
                    dgvReport.Font,
                    SystemBrushes.ControlText,
                    e.RowBounds.Location.X + 15,
                    e.RowBounds.Location.Y + ((e.RowBounds.Height - Sz.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }



    }
}
