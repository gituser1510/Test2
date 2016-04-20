using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.Dal;
using ChemInform.Common;

namespace ChemInform
{
    public partial class frmCreateShipment : Form
    {
        public frmCreateShipment()
        {
            InitializeComponent();
        }

        int TempShipMentId = -1;
        int EditIndex = -1;
        public DataTable MasterProjects { get; set; }

        private void FrmCreateShipment_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                // Set the Format type and the CustomFormat string.
                dtpDeliveryDate.Format = DateTimePickerFormat.Custom;                
                dtpDeliveryDate.CustomFormat = "d-MMM-yyyy  hh:mm:ss"; // Ex:24-Jan-2014 11:18:47

                dtpDownloadDate.Format = DateTimePickerFormat.Custom;
                dtpDownloadDate.CustomFormat = "d-MMM-yyyy  hh:mm:ss"; // Ex:24-Jan-2014 11:18:47

                GetShipMentsAndBindToGrid();

                cmbType.SelectedIndex = 0;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string strErrMsg = "";
            if (ValidateInPutControls(out strErrMsg))
            {
                if (IsValidDate())
                {
                    Shipment shipment = new Shipment();
                    shipment.ShipmentID = TempShipMentId;
                    shipment.ShipmentName = txtShipmentName.Text.Trim();
                    shipment.Type = cmbType.Text.Trim();
                    shipment.AbstractRefsCount = Convert.ToInt32(txtAbstractRefsCount.Text.Trim());
                    shipment.ShipmentIssue = Convert.ToInt32(txtIssue.Text.Trim());
                    shipment.ShipmentYear = Convert.ToInt32(txtYear.Text.Trim());
                    shipment.DownloadDate = Convert.ToDateTime(dtpDownloadDate.Value.Date);
                    shipment.ScheduleDeliveryDate = Convert.ToDateTime(dtpDeliveryDate.Value.Date);
                    shipment.DownloadFileName = txtDownloadedFileName.Text.Trim();

                    SaveShipmentDetails(shipment);
                    ResetControls();

                    GetShipMentsAndBindToGrid();

                    MessageBox.Show("Shipment created successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveShipmentDetails(Shipment shipment)
        {
            try
            {
                string strMsg = "";
                if (DataOperations.SaveShipment(shipment, out strMsg))
                {
                    if (strMsg.ToUpper() == "INSERT SUCCESS")
                    {
                        MessageBox.Show("Shipment created Successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetShipMentsAndBindToGrid();

                        ResetControls();
                    }
                    else if (strMsg.ToUpper() == "DUPLICATE SHIPMENT")
                    {
                        MessageBox.Show("Duplicate Shipment", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error in Shipment Creation", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }         
        }

        private void GetShipMentsAndBindToGrid()
        {
            try
            {
                DataTable dtShipmensts = DataOperations.GetShipments();
                if (dtShipmensts != null)
                {
                    dgvShipmentDetails.AutoGenerateColumns = false;
                    dgvShipmentDetails.DataSource = dtShipmensts;

                    ColSmId.DataPropertyName = "SHIPMENT_ID";
                    ColSmName.DataPropertyName = "SHIPMENT_NAME";
                    ColSmType.DataPropertyName = "DOC_TYPE";
                    colAbstractCount.DataPropertyName = "REF_COUNT";
                    ColSmDownloadedDate.DataPropertyName = "DOWNLOADED_DATE";
                    ColSmDeliveryDate.DataPropertyName = "SCH_DELIVERY_DATE";
                    ColSmDownloadedFile.DataPropertyName = "DOWNLOADED_FILENAME";
                    ColSmTaskPrepStatus.DataPropertyName = "TASK_PREPARATION_STATUS";
                }
                else
                {
                    dgvShipmentDetails.DataSource = null;
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ResetControls()
        {
            txtShipmentName.Clear();
            txtDownloadedFileName.Clear();
            cmbType.SelectedIndex = -1;
            dtpDeliveryDate.ResetText();
            dtpDownloadDate.ResetText();

            txtIssue.Clear();
            txtYear.Clear();
            EditIndex = -1;
            btnCreate.Text = "Create";
        }
        
        private bool IsValidDate()
        {
            bool status = true;
            if (CheckSameDate())
            {
                if (DialogResult.No == MessageBox.Show("Downloaded date and delivery date is same. Are you sure ?", GlobalVariables.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    status = false;
                }
            }
            else if (!IsDeliveryDateValid())
            {
                MessageBox.Show("Delivery should be later date of Downloaded date.", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return status;
        }

        private bool IsDeliveryDateValid()
        {
            DateTime downloadDate = Convert.ToDateTime(dtpDownloadDate.Value.Date);
            DateTime deliveryDate = Convert.ToDateTime(dtpDeliveryDate.Value.Date);
            if (downloadDate < deliveryDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateInPutControls(out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (string.IsNullOrEmpty(txtShipmentName.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Enter Shipment name.";
                    blStatus = false;
                }
                if (cmbType.SelectedItem == null)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select Shipment Type.";
                    blStatus = false;
                }
                if (string.IsNullOrEmpty(txtDownloadedFileName.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Enter downloaded date.";
                    blStatus = false;
                }

                if (string.IsNullOrEmpty(txtAbstractRefsCount.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Enter Abstracts count.";
                    blStatus = false;
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errmsg_out = strErrMsg;
            return blStatus;
        }

        private bool CheckSameDate()
        {
            DateTime downloadDate = Convert.ToDateTime(dtpDownloadDate.Value.Date);
            DateTime deliveryDate = Convert.ToDateTime(dtpDeliveryDate.Value.Date);
            if (downloadDate == deliveryDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvShipmentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvShipmentDetails.Columns[e.ColumnIndex].Name == "ColSmEdit") //(dgvShipmentDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        SetShipMentDetails(dgvShipmentDetails.Rows[e.RowIndex]);
                        EditIndex = e.RowIndex; //To Edit.
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void SetShipMentDetails(DataGridViewRow dataGridViewRow)
        {
            try
            {
                cmbType.SelectedIndex = cmbType.FindStringExact((string)dataGridViewRow.Cells["ColSmType"].Value);
                TempShipMentId = Convert.ToInt32(dataGridViewRow.Cells["ColSmId"].Value);
                txtShipmentName.Text = (string)dataGridViewRow.Cells["ColSmName"].Value;
                dtpDownloadDate.Value = (DateTime)dataGridViewRow.Cells["ColSmDownloadedDate"].Value;
                dtpDeliveryDate.Value = (DateTime)dataGridViewRow.Cells["ColSmDeliveryDate"].Value;
                txtDownloadedFileName.Text = (string)dataGridViewRow.Cells["ColSmDownloadedFile"].Value;

                btnCreate.Text = "Update";
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        #region Row post paint

        private void dgvShipmentDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvShipmentDetails.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvShipmentDetails.Font);

                if (dgvShipmentDetails.RowHeadersWidth < (int)(size.Width + 20)) dgvShipmentDetails.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }


        #endregion

        private void txtAbstractRefsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog flDlg = new FolderBrowserDialog())
                {
                    if (flDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string strFoldName = System.IO.Path.GetFileName(flDlg.SelectedPath);
                        txtDownloadedFileName.Text = strFoldName;
                        txtShipmentName.Text = strFoldName.Replace("_pdf", "").Trim();
                        string strYear_Issue = strFoldName.Replace("_pdf", "").Replace("CI_", "").Trim();
                        if (!string.IsNullOrEmpty(strYear_Issue))
                        {
                            string[] saVals = strYear_Issue.Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
                            if (saVals != null)
                            {
                                if (saVals.Length == 2)
                                {
                                    txtIssue.Text = saVals[1].Trim();
                                    txtYear.Text = saVals[0].Trim();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
