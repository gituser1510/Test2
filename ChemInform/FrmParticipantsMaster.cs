using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Bll;

namespace ChemInform
{
    public partial class FrmParticipantsMaster : Form
    {
        public FrmParticipantsMaster()
        {
            InitializeComponent();
        }

        bool IsEdit = false;
        int EditIndex = -1;
        
        /// <summary>
        /// Check mandatory fields for user role creation or Updation.
        /// </summary>
        /// <param name="_errmsg">Summary Error message.</param>
        /// <returns>True Mandatory fields are filled. Otherwise false.</returns>
        private bool ValidateInPutControls(out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Enter participants name.";
                    blStatus = false;
                }
                if (!string.IsNullOrEmpty(txtSynonym.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Add Synonym to Synonyms list.";
                    blStatus = false;
                }
                if (string.IsNullOrEmpty(txtSynonyms.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Enter Synonyms.";
                    blStatus = false;
                }
                if (string.IsNullOrEmpty(txtInchi.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please Enter Inchi key.";
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

        private void dgvParticipants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvParticipants.Columns[e.ColumnIndex].Name == "ColParticipantsEdit") //(dgvParticipants.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        SetParticipantDetails(dgvParticipants.Rows[e.RowIndex]);
                        EditIndex = e.RowIndex; //To Edit.
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Set InputControls with user information to Update.
        /// </summary>
        /// <param name="dataGridViewRow">">Datagridview row to Update.</param>
        private void SetParticipantDetails(DataGridViewRow dataGridViewRow)
        {
            try
            {
                txtName.Text = (string)dataGridViewRow.Cells["ColParticipantName"].Value;
                txtSynonyms.Text = (string)dataGridViewRow.Cells["ColParticipantSynonyms"].Value;

                txtInchi.Text = (string)dataGridViewRow.Cells["ColParticipantInchiKey"].Value;
                IsEdit = true;
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strErrMsg = "";
            if (ValidateInPutControls(out strErrMsg))
            {

                ParticipantMaster participant = new ParticipantMaster();
                participant.Name = txtName.Text.Trim();
                //participant.Type = txtType.Text.Trim();
                participant.Synonyms = txtSynonyms.Text.Trim();
                participant.InchiKey = txtInchi.Text.Trim();

                SaveParticipant(participant);
                ResetControls();
            }
            else
            {
                MessageBox.Show(strErrMsg, "Wiley ChemInform", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Inserts the new participant or updates an existing participant.
        /// </summary>
        /// <param name="participant">An instance of Participant class</param>
        private void SaveParticipant(ParticipantMaster participant)
        {

            if (!IsEdit)
            {
                dgvParticipants.Rows.Add();
                EditIndex = dgvParticipants.Rows.Count - 1;
            }
            dgvParticipants.Rows[EditIndex].Cells["ColParticipantId"].Value = participant.Id;
            dgvParticipants.Rows[EditIndex].Cells["ColParticipantName"].Value = participant.Name;
            dgvParticipants.Rows[EditIndex].Cells["ColParticipantSynonyms"].Value = participant.Synonyms;
            dgvParticipants.Rows[EditIndex].Cells["ColParticipantInchiKey"].Value = participant.InchiKey;

            ResetControls();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        /// <summary>
        /// Reset UserRole Input controls.
        /// </summary>
        private void ResetControls()
        {
            txtName.Clear();
            txtSynonym.Clear();
            txtSynonyms.Clear();
            txtInchi.Clear();
            EditIndex = -1;
            IsEdit = false;
        }

        private void btnAddSynonym_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSynonym.Text.Trim()))
            {
                if (txtSynonyms.Text.Trim() == "")
                {
                    txtSynonyms.Text = txtSynonym.Text.Trim();
                }
                else
                {
                    txtSynonyms.Text += " , " + txtSynonym.Text.Trim();
                }
                txtSynonym.Clear();
            }
        }

        private void dgvParticipants_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvParticipants.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvParticipants.Font);

                if (dgvParticipants.RowHeadersWidth < (int)(size.Width + 20)) dgvParticipants.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

    }
}
