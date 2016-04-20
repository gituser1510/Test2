using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChemInform.Dal;
using ChemInform.Common;

namespace ChemInform.Task_Management
{
    public partial class FrmTA_MHtoTL : Form
    {

        public FrmTA_MHtoTL()
        {
            InitializeComponent();
        }

        private void FrmTA_MHtoTL_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
                BindAllShipments();
                BindTeamLeads();
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Bind TeamLead combobox.
        private void BindTeamLeads()
        {
            try
            {
                DataTable dtTeamLeads = DataOperations.GetAllTeamLeads();
                if (dtTeamLeads.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbTeamLead.DataSource = dtTeamLeads;
                    cmbTeamLead.DisplayMember = "TeamLead_Name";
                    cmbTeamLead.ValueMember = "TeamLead_Id";
                    //cmbTeamLead.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Bind Shipments Combobox.
        private void BindAllShipments()
        {
            DataTable dtShipMents = DataOperations.GetAllShipments();
            if (dtShipMents.Rows.Count > 0)
            {
                //Bind User Roles To Combo Box 
                cmbShipmentName.DataSource = dtShipMents;
                cmbShipmentName.DisplayMember = "Shipment_NAME";
                cmbShipmentName.ValueMember = "Shipment_ID";
                //cmbShipmentName.SelectedIndex = -1;
            }
        }

        // Assign Task.
        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {
                    if (dgvUnAssignedToTL.Rows.Count > 0)
                    {
                        if (dgvUnAssignedToTL.SelectedRows.Count > 0)
                        {
                            foreach (DataGridViewRow r in dgvUnAssignedToTL.SelectedRows)
                            {
                                //dgvAssignedDocToTL.Rows.Add(r);
                                dgvAssignedToTL.Rows.Add(r.Cells["colUnAssignedDocName"].Value, r.Cells["colUnAssignedDocStatus"].Value, cmbTeamLead.Text, DateTime.Today, "Assigned");

                                // TODO : Update Status as assign To Team Lead.
                                dgvUnAssignedToTL.Rows.Remove(r);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Get Documents  based on the shipment.
        private void cmbShipmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUnAssignedToTL.AutoGenerateColumns = false;
                colUnAssignedDocName.DataPropertyName = "colUnAssignedDocName";
                colUnAssignedDocStatus.DataPropertyName = "colUnAssignedDocStatus";
                dgvUnAssignedToTL.DataSource = DataOperations.GetNotAssignedDocsToTLBasedOnShipments();
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Remove assigned task.
        private void tsremoveassignedtask_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignedToTL.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow r in dgvAssignedToTL.SelectedRows)
                    {
                        DataTable dt = dgvUnAssignedToTL.DataSource as DataTable;
                        dgvUnAssignedToTL.DataSource = null;
                        dt.NewRow();
                        DataRow dr = dt.NewRow();
                        dr["colUnAssignedDocName"] = r.Cells["colAssignedDocName"].Value;
                        dr["colUnAssignedDocStatus"] = "Not Assigned";
                        dt.Rows.Add(dr);
                        dgvUnAssignedToTL.DataSource = dt;

                        // TODO : Update Status as Unassign To Team Lead.
                        dgvAssignedToTL.Rows.Remove(r);
                    }
                }
                else
                {
                    MessageBox.Show("No records available to remove", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Row postpaint Grids
        private void dgvUnAssignedToMH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUnAssignedToTL.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUnAssignedToTL.Font);

                if (dgvUnAssignedToTL.RowHeadersWidth < (int)(size.Width + 20)) dgvUnAssignedToTL.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvAssignedDocToMH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvAssignedToTL.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvAssignedToTL.Font);

                if (dgvAssignedToTL.RowHeadersWidth < (int)(size.Width + 20)) dgvAssignedToTL.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Validate input controls
        private bool ValidateUserInputs(out string _errmsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (cmbShipmentName.SelectedItem == null)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Shipment Name", strErrMsg.Trim());
                    blStatus = false;
                }
                if (cmbTeamLead.SelectedItem == null)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Team Lead", strErrMsg.Trim());
                    blStatus = false;
                }
                if (dgvUnAssignedToTL.Rows.Count == 0)
                {
                    strErrMsg = String.Format("{0}\r\n No Tasks avilable to Assign.", strErrMsg.Trim());
                    blStatus = false;
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            _errmsg = strErrMsg;
            return blStatus;

        }
        #endregion
    }
}