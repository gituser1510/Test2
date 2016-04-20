using System;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.Common;

namespace ChemInform.Task_Management
{
    public partial class FrmMasterEntry : Form
    {
        public FrmMasterEntry()
        {
            InitializeComponent();
        }

        int editRowIndxMstrEntry = 0;
        bool blEditMstrEntry = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErrMsg = "";
            if (ValidateInPutControls(out strErrMsg))
            {
                MasterEntry objMstrEntry = new MasterEntry();
                objMstrEntry.Type = (string)cmbType.SelectedItem;
                objMstrEntry.Value = txtValue.Text;

                if (blEditMstrEntry)
                {
                    UpdateMasterEntry(objMstrEntry, editRowIndxMstrEntry);
                }
                else
                {
                    InsertMasterEntry(objMstrEntry);
                }

                //TODO.

                ResetMasterEntryControls();
            }
            else
            {
                MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InsertMasterEntry(MasterEntry objMstrEntry)
        {
            dgvMasterEntry.Rows.Add();
            int RowIndex = dgvMasterEntry.Rows.Count - 1;
            dgvMasterEntry.Rows[RowIndex].Cells["ColType"].Value = objMstrEntry.Type;
            dgvMasterEntry.Rows[RowIndex].Cells["ColValue"].Value = objMstrEntry.Value;
            MessageBox.Show("Inserted successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateMasterEntry(MasterEntry objMstrEntry, int editRowIndxMstrEntry)
        {
            dgvMasterEntry.Rows[editRowIndxMstrEntry].Cells["ColType"].Value = objMstrEntry.Type;
            dgvMasterEntry.Rows[editRowIndxMstrEntry].Cells["ColValue"].Value = objMstrEntry.Value;
            editRowIndxMstrEntry = -1;
            blEditMstrEntry = false;
            MessageBox.Show("Updated successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetMasterEntryControls()
        {
            cmbType.SelectedIndex = -1;
            txtValue.Clear();
            editRowIndxMstrEntry = -1;
            blEditMstrEntry = false;
        }



        private bool ValidateInPutControls(out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (cmbType.SelectedItem == null)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Type", strErrMsg.Trim());
                    blStatus = false;
                }
                if (string.IsNullOrEmpty(txtValue.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please enter Value.";
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

        private void dgvMasterEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                if (dgvMasterEntry.Columns[e.ColumnIndex].Name == "ColEdit")
                {
                    cmbType.SelectedIndex = cmbType.FindStringExact((string)dgvMasterEntry.Rows[e.RowIndex].Cells["ColType"].Value);
                    txtValue.Text = (string)dgvMasterEntry.Rows[e.RowIndex].Cells["ColValue"].Value;

                    editRowIndxMstrEntry = e.RowIndex;
                    blEditMstrEntry = true;

                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMasterEntryControls();
        }
    }
}
