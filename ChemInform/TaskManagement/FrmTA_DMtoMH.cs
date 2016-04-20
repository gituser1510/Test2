using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChemInform.Dal;
using ChemInform.Common;

namespace ChemInform.Task_Management
{
    public partial class FrmTA_DMtoMH : Form
    {
        public FrmTA_DMtoMH()
        {
            InitializeComponent();
        }

        private void FrmTA_DMtoMH_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BindAllShipments();
            BindAllModuleHeads();
        }

        // Bind Modulehead Combobox.
        private void BindAllModuleHeads()
        {
            try
            {
                DataTable dtModuleHead = DataOperations.GetModuleHeads();
                if (dtModuleHead.Rows.Count > 0)
                {
                    cmbModule.DataSource = dtModuleHead;
                    cmbModule.DisplayMember = "ModuleHead_Name";
                    cmbModule.ValueMember = "ModuleHead_Id";
                    cmbModule.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Bind AllShipments.
        private void BindAllShipments()
        {
            try
            {
                DataTable dtShipMents = DataOperations.GetAllShipments();
                if (dtShipMents.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbShipmentName.DataSource = dtShipMents;
                    cmbShipmentName.DisplayMember = "Shipment_NAME";
                    cmbShipmentName.ValueMember = "Shipment_ID";
                    cmbShipmentName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
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
                    if (dgvUnAssignedToMH.Rows.Count > 0)
                    {
                        if (dgvUnAssignedToMH.SelectedRows.Count > 0)
                        {
                            foreach (DataGridViewRow r in dgvUnAssignedToMH.SelectedRows)
                            {
                                //dgvAssignedDocToTL.Rows.Add(r);
                                dgvAssignedToMH.Rows.Add(r.Cells["colUnAssignedDocName"].Value, " Test Doc Type", cmbModule.Text, DateTime.Now, "Assigned");
                                // TODO : Update Status as assign To Team Lead.
                                dgvUnAssignedToMH.Rows.Remove(r);
                            }
                        }
                    }


                    //UnAssignedDocNames.Add(item.Cells["colUnAssignedDocName"].Value.ToString());
                    //dgvAssignedToMH.Rows.Add();
                    //dgvAssignedToMH.Rows[dgvAssignedToMH.Rows.Count - 1].Cells["colAssignedDocName"].Value = item.Cells["colUnAssignedDocName"].Value.ToString();
                    //dgvAssignedToMH.Rows[dgvAssignedToMH.Rows.Count - 1].Cells["colAssignedDocType"].Value = "Doc Type";
                    //dgvAssignedToMH.Rows[dgvAssignedToMH.Rows.Count - 1].Cells["colAssignedDocModuleHead"].Value = cmbModule.Text;
                    //dgvAssignedToMH.Rows[dgvAssignedToMH.Rows.Count - 1].Cells["colAssignedDocDate"].Value = DateTime.Today;
                    //dgvAssignedToMH.Rows[dgvAssignedToMH.Rows.Count - 1].Cells["colAssignedDocStatus"].Value = "Progress";

                    ResetUserInPuts();
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

        // Load Documents based on the shipment selected.
        private void cmbShipmentName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dgvUnAssignedToMH.AutoGenerateColumns = false;
                colUnAssignedDocName.DataPropertyName = "colUnAssignedDocName";
                colUnAssignedDocStatus.DataPropertyName = "colUnAssignedDocStatus";
                dgvUnAssignedToMH.DataSource = DataOperations.GetNotAssignedDocsToTLBasedOnShipments();
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        // Remove Assign Task.
        private void tsremoveassignedtask_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignedToMH.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow r in dgvAssignedToMH.SelectedRows)
                    {
                        DataTable dt = dgvUnAssignedToMH.DataSource as DataTable;
                        dgvUnAssignedToMH.DataSource = null;
                        dt.NewRow();
                        DataRow dr = dt.NewRow();
                        dr["colUnAssignedDocName"] = r.Cells["colAssignedDocName"].Value;
                        dr["colUnAssignedDocStatus"] = "Not Assigned";
                        dt.Rows.Add(dr);
                        dgvUnAssignedToMH.DataSource = dt;

                        // TODO : Update Status as Unassign To Team Lead.
                        dgvAssignedToMH.Rows.Remove(r);
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

        #region Validate Inputcontrols
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
                if (cmbModule.SelectedItem == null)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Module Head", strErrMsg.Trim());
                    blStatus = false;
                }
                if (dgvUnAssignedToMH.Rows.Count == 0)
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

        #region Reset Controls
        private void ResetUserInPuts()
        {
            cmbShipmentName.SelectedIndex = -1;
            cmbModule.SelectedIndex = -1;
        }
        #endregion

        #region RowPostPaint for Datagrids
        private void dgvAssignedTaskPreparation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUnAssignedToMH.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUnAssignedToMH.Font);

                if (dgvUnAssignedToMH.RowHeadersWidth < (int)(size.Width + 20)) dgvUnAssignedToMH.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }


        }

        private void dgvNotAssignedToMH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUnAssignedToMH.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUnAssignedToMH.Font);

                if (dgvUnAssignedToMH.RowHeadersWidth < (int)(size.Width + 20)) dgvUnAssignedToMH.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {

            }


        }
        #endregion
    }
}
