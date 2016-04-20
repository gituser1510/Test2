using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ChemInform.Reports
{
    public partial class frmMonthlyReport : Form
    {
        public frmMonthlyReport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dpFromDate.Text != null && dpToDate.Text != null)
                {
                    //DataTable dtMonthlyStatus = ReactDataAccess.Get_MonthlyStatus_Report(dpFromDate.Value, dpToDate.Value);
                    //BindDataToGrid(dtMonthlyStatus);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDataToGrid(DataTable _reportdata)
        {
            try
            {
                if (_reportdata != null)
                {
                    dgvReport.AutoGenerateColumns = false;
                    dgvReport.DataSource = _reportdata;

                    colUserID.DataPropertyName = "user_id";
                    colUserName.DataPropertyName = "user_name";
                    colUserRole.DataPropertyName = "role_name";
                    colPTTID.DataPropertyName = "ptt_user_id";
                    colTANCount.DataPropertyName = "completed tans";
                    colRxnCount.DataPropertyName = "completed tans rxn count";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void frmMonthlyReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReport.Rows.Count > 0)
                {
                    DialogResult diaRes = MessageBox.Show("Do you want to save the User Monthly Status Report?","Monthly Report",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (diaRes == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvReport.Rows.Count; i++)
                        {
                            //PTTProductivity objPttBll = new PTTProductivity();
                            //objPttBll.ApplicationID = 4;//CASREACT Application ID is 4
                            //objPttBll.SupervisorID = 244;//Project InCharge PTT User ID is 244
                            //objPttBll.PTT_UserID = Convert.ToInt32(dgvReport.Rows[i].Cells["colPTTID"].Value.ToString());

                            //objPttBll.UserID = Convert.ToInt32(dgvReport.Rows[i].Cells["colUserID"].Value.ToString());
                            //objPttBll.UserRole = dgvReport.Rows[i].Cells["colUserRole"].Value.ToString();
                            //objPttBll.Productivity = Convert.ToInt32(dgvReport.Rows[i].Cells["colRxnCount"].Value.ToString());

                            //objPttBll.FromDate = dpFromDate.Value.ToShortDateString();
                            //objPttBll.ToDate = dpToDate.Value.ToShortDateString();
                            //PTTProductivityDAL.UpdateUserMonthlyStatusReport(objPttBll);
                        }
                        MessageBox.Show("User Monthly report saved successfully", "Monthly Status Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No Data is available to save","Monthly Status Report",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
    }
}
