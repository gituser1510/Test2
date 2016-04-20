using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChemInform.TaskSheets
{
    public partial class FrmTaskSheetTL : Form
    {
        public FrmTaskSheetTL()
        {
            InitializeComponent();
        }

        private void FrmTaskSheetPM_DM_MH_TL_Load(object sender, EventArgs e)
        {
            BindAllShipments();
            LoadProjects();
        }

        // Bind AllShipments.
        private void BindAllShipments()
        {
            try
            {
                DataTable dtShipMents =Dal.DataOperations.GetShipments(); //Dal.DataOperations.GetAllShipments();
                if (dtShipMents.Rows.Count > 0)
                {
                    //Bind User Roles To Combo Box 
                    cmbShipmentName.DataSource = dtShipMents;
                    cmbShipmentName.DisplayMember = "SHIPMENT_NAME";
                    cmbShipmentName.ValueMember = "SHIPMENT_ID";
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }


        private void LoadProjects()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId");
            dt.Columns.Add("Analyst");
            dt.Columns.Add("Reviewer");
            dt.Columns.Add("Qc");
            dt.Columns.Add("Status");

            dt.Rows.Add("001", "Analyst1", "Reviewer1", "Qc1", "Assinged For Curation.");
            dgvProjects.AutoGenerateColumns = false;
            ColDocId.DataPropertyName = "DocId";
            ColAssingedToCurator.DataPropertyName = "Analyst";
            ColAssignedReviewer.DataPropertyName = "Reviewer";
            ColAssingedQC.DataPropertyName = "Qc";
            ColStatus.DataPropertyName = "Status";
            dgvProjects.DataSource = dt;
        }

        private void modifyAnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count == 1)
            {
                using (FrmTL_ModifyTask objModify = new FrmTL_ModifyTask())
                {
                    objModify.DocId = Convert.ToInt32(dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColDocId"].Value);
                    objModify.AnalystName = dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColAssingedToCurator"].Value.ToString();
                    objModify.ReviewerName = dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColAssignedReviewer"].Value.ToString();
                    objModify.QcAnalystName = dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColAssingedQC"].Value.ToString();
                    if (objModify.ShowDialog() == DialogResult.OK)
                    {
                        if (objModify.ModifiedAnalyst != null)
                        {
                            dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColAssingedToCurator"].Value = objModify.ModifiedAnalyst;
                        }
                        if (objModify.ModifiedReviewAnalst != null)
                        {
                            dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColAssignedReviewer"].Value = objModify.ModifiedReviewAnalst;
                        }
                        if (objModify.ModifiedQc != null)
                        {
                            dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColAssingedQC"].Value = objModify.ModifiedQc;
                        }
                    }
                }
            }
        }

        private void dgvProjects_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvProjects.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvProjects.Font);

                if (dgvProjects.RowHeadersWidth < (int)(size.Width + 20)) dgvProjects.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadProjects();
        }

    }
}
