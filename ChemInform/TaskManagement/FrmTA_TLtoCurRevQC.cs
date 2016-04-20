using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChemInform.Dal;
using ChemInform.Common;

namespace ChemInform.Task_Management
{
    public partial class FrmTA_TLtoCurRevQC : Form
    {
        public FrmTA_TLtoCurRevQC()
        {
            InitializeComponent();
        }

        string ModifiedToRole = null;
        private void lblAssignedTo_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BindAllShipments();
            BindAllCuratorsUnderTL();
            BindRolesUnderTeamLead();
            cmbRolesUnderTL.Enabled = false;
        }

        #region BindComboBoxes.
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
                    //cmbShipmentName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindAllCuratorsUnderTL()
        {
            try
            {
                DataTable dtCurators = DataOperations.GetAllCuratorsUnderTeamLead();
                if (dtCurators.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbUserName.DataSource = dtCurators;
                    cmbUserName.DisplayMember = "Curator_name";
                    cmbUserName.ValueMember = "Curator_ID";
                    //cmbUserName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindRolesUnderTeamLead()
        {
            try
            {
                DataTable dtRoles = DataOperations.RolesUnderTeamLead();
                if (dtRoles.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbRolesUnderTL.DataSource = dtRoles;
                    cmbRolesUnderTL.DisplayMember = "RoleName_name";
                    cmbRolesUnderTL.ValueMember = "Role_ID";
                    //cmbAssignedTo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindAllQcUnderTL()
        {
            try
            {
                DataTable dtQc = DataOperations.GetAllQcUnderTeamLead();
                if (dtQc.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbUserName.DataSource = dtQc;
                    cmbUserName.DisplayMember = "Qc_name";
                    cmbUserName.ValueMember = "Qc_ID";
                    //cmbUserName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindAllReviewerUnderTL()
        {
            try
            {
                DataTable dtReviews = DataOperations.GetAllReviewersUnderTeamLead();
                if (dtReviews.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbUserName.DataSource = dtReviews;
                    cmbUserName.DisplayMember = "Reviewer_name";
                    cmbUserName.ValueMember = "Reviewer_ID";
                    //cmbUserName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        #endregion

        // Bind Documents based on the Shipment selected.
        private void cmbShipmentName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                dgvUnAssignedToTeamMembers.AutoGenerateColumns = false;
                colUnAssignedDocName.DataPropertyName = "colUnAssignedDocName";
                colUnAssignedDocStatus.DataPropertyName = "colUnAssignedDocStatus";
                dgvUnAssignedToTeamMembers.DataSource = DataOperations.GetNotAssignedDocsToTLBasedOnShipments();
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
                    if (ModifiedToRole == null)
                    {
                        if (dgvUnAssignedToTeamMembers.Rows.Count > 0)
                        {
                            if (dgvUnAssignedToTeamMembers.SelectedRows.Count > 0)
                            {
                                foreach (DataGridViewRow r in dgvUnAssignedToTeamMembers.SelectedRows)
                                {
                                    //dgvAssignedDocToTL.Rows.Add(r);
                                    dgvAssignedDocToTeamMembers.Rows.Add(r.Cells["colUnAssignedDocName"].Value, "Test Type", cmbUserName.Text, "Reviewer 1", "Qc 1", DateTime.Today, "Assigned");

                                    // TODO : Update Status as assign To Team Lead.
                                    dgvUnAssignedToTeamMembers.Rows.Remove(r);
                                }
                            }
                        }
                    }
                    else if (ModifiedToRole == "Reviewer")
                    {
                        if (dgvAssignedDocToTeamMembers.SelectedRows.Count > 0)
                        {
                            for (int i = 0; i < dgvAssignedDocToTeamMembers.SelectedRows.Count; i++)
                            {
                                // TODO : database changes.
                                dgvAssignedDocToTeamMembers.SelectedRows[i].Cells["colAssignedReview"].Value = "Modified reviewer1";

                            }
                        }
                        btnAssign.Text = "Assign";
                        ModifiedToRole = null;
                    }
                    else if (ModifiedToRole == "Quality Check")
                    {
                        for (int i = 0; i < dgvAssignedDocToTeamMembers.SelectedRows.Count; i++)
                        {
                            // TODO : database changes.
                            dgvAssignedDocToTeamMembers.SelectedRows[i].Cells["colAssignedQc"].Value = "Modified Qc1";

                        }
                        btnAssign.Text = "Assign";
                        ModifiedToRole = null;
                    }
                    else if (ModifiedToRole == "Curator")
                    {
                        if (dgvAssignedDocToTeamMembers.SelectedRows.Count > 0)
                        {
                            for (int i = 0; i < dgvAssignedDocToTeamMembers.SelectedRows.Count; i++)
                            {
                                // TODO : database changes.
                                dgvAssignedDocToTeamMembers.SelectedRows[i].Cells["colAssignedDocCurator"].Value = "Modified Curator";

                            }
                        }
                        btnAssign.Text = "Assign";
                        ModifiedToRole = null;
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

        // Show heirarchy of Team.
        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if (cmbRolesUnderTL.Text == "Curator")
                {
                    lblTeamMapping.Text = "Curator1 --> Reviewer1---> Qc 1";  //DataOperations.GetUserMappingByCurator(Convert.ToInt32(cmbUserName.SelectedValue));
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Modify Assigned Task.
        // Remove Assigned Task.
        private void removeAssignedTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignedDocToTeamMembers.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow r in dgvAssignedDocToTeamMembers.SelectedRows)
                    {
                        DataTable dt = dgvUnAssignedToTeamMembers.DataSource as DataTable;
                        dgvUnAssignedToTeamMembers.DataSource = null;
                        dt.NewRow();
                        DataRow dr = dt.NewRow();
                        dr["colUnAssignedDocName"] = r.Cells["colAssignedDocName"].Value;
                        dr["colUnAssignedDocStatus"] = "Not Assigned";
                        dt.Rows.Add(dr);
                        dgvUnAssignedToTeamMembers.DataSource = dt;

                        // TODO : Update Status as Unassign To Team Lead.
                        dgvAssignedDocToTeamMembers.Rows.Remove(r);
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

        // Modify Reviewer tak to another reviewer.
        private void modifyReviewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbRolesUnderTL.SelectedIndex = cmbRolesUnderTL.FindStringExact("Reviewer");
            BindAllReviewerUnderTL();
            ModifiedToRole = "Reviewer";
            btnAssign.Text = "Modity";


        }

        // Modify Qc task to another Qc.
        private void modifyQualityCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbRolesUnderTL.SelectedIndex = cmbRolesUnderTL.FindStringExact("Quality Check");
            BindAllQcUnderTL();
            ModifiedToRole = "Quality Check";
            btnAssign.Text = "Modity";

        }

        // Modify Curator task to another curator.
        private void modifyCuratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbRolesUnderTL.SelectedIndex = cmbRolesUnderTL.FindStringExact("Curator");
            BindAllCuratorsUnderTL();
            ModifiedToRole = "Curator";
            btnAssign.Text = "Modity";
        }
        #endregion

        #region Validate inputControls
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
                if (cmbUserName.SelectedItem == null)
                {
                    strErrMsg = String.Format("{0}\r\nPlease select Username", strErrMsg.Trim());
                    blStatus = false;
                }
                if (cmbRolesUnderTL.Enabled)
                {
                    if (cmbRolesUnderTL.SelectedItem == null)
                    {
                        strErrMsg = String.Format("{0}\r\nPlease select Assigned for Curation/Review/Qc", strErrMsg.Trim());
                        blStatus = false;
                    }
                }
                if (ModifiedToRole == null)
                {
                    if (dgvUnAssignedToTeamMembers.Rows.Count == 0)
                    {
                        strErrMsg = String.Format("{0}\r\n No Tasks avilable to Assign.", strErrMsg.Trim());
                        blStatus = false;
                    }
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbUserName.SelectedIndex = -1;
            ModifiedToRole = null;
            btnAssign.Text = "Assign";
        }
        #endregion

        #region RowPostPaint for Grids
        private void dgvUnAssignedToCuration_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvUnAssignedToTeamMembers.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvUnAssignedToTeamMembers.Font);

                if (dgvUnAssignedToTeamMembers.RowHeadersWidth < (int)(size.Width + 20)) dgvUnAssignedToTeamMembers.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvAssignedDocToCuration_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvAssignedDocToTeamMembers.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvAssignedDocToTeamMembers.Font);

                if (dgvAssignedDocToTeamMembers.RowHeadersWidth < (int)(size.Width + 20)) dgvAssignedDocToTeamMembers.RowHeadersWidth = (int)(size.Width + 20);

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
