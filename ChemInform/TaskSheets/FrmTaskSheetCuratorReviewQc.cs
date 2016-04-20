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
    public partial class FrmTaskSheetCuratorReviewQc : Form
    {
        public FrmTaskSheetCuratorReviewQc()
        {
            InitializeComponent();
        }

        string DocName { get; set; }
        string Pdf { get; set; }


        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DocName = dgvProjects.Rows[e.RowIndex].Cells["ColDocName"].Value.ToString();
                    Pdf = (string)dgvProjects.Rows[e.RowIndex].Cells["ColPdf"].Value;
                    MessageBox.Show("Doc Name =" + DocName + "pdf=" + Pdf);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmTS_CuratorReviewQc_Load(object sender, EventArgs e)
        {
            if (Common.GlobalVariables.DtProject == null)
            {
                LoadProjects();
            }
            else
            {
                dgvProjects.AutoGenerateColumns = false;
                ColDocId.DataPropertyName = "ColDocId";
                ColPdf.DataPropertyName = "ColPdf";
                ColAnalyst.DataPropertyName = "ColAnalyst";
                ColReviewer.DataPropertyName = "ColReviewer";
                ColQualityAnalyst.DataPropertyName = "ColQualityAnalyst";
                ColTeamLead.DataPropertyName = "ColTeamLead";
                ColStatus.DataPropertyName = "ColStatus";
                dgvProjects.DataSource = Common.GlobalVariables.DtProject;
            }
        }

        private void LoadProjects()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId");
            dt.Columns.Add("Pdf");
            dt.Columns.Add("Analyst");
            dt.Columns.Add("Reviewer");
            dt.Columns.Add("Qc");
            dt.Columns.Add("Tl");
            dt.Columns.Add("Status");

            dt.Rows.Add("001", "pdf1", "Analyst1", "Reviewer1", "Qc1", "TL1", "Assigned for Curation");
            dgvProjects.AutoGenerateColumns = false;
            ColDocId.DataPropertyName = "DocId";
            ColPdf.DataPropertyName = "Pdf";
            ColAnalyst.DataPropertyName = "Analyst";
            ColReviewer.DataPropertyName = "Reviewer";
            ColQualityAnalyst.DataPropertyName = "Qc";
            ColTeamLead.DataPropertyName = "Tl";
            ColStatus.DataPropertyName = "Status";
            dgvProjects.DataSource = dt;
            Common.GlobalVariables.DtProject = dt;
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

        private void dgvProjects_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //try
            //{
            //    if (e.Button == MouseButtons.Right)
            //    {
            //        cntMnuTaskSubmission.Show(dgvProjects, new Point(e.X, e.Y));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ErrorHandling.WriteErrorLog(ex.ToString());
            //}
        }

        private void cntMnuTaskSubmission_Opening(object sender, CancelEventArgs e)
        {

            try
            {
                DisableContextMenuItems();

                int RoleId = Common.GlobalVariables.RoleId;
                switch (RoleId)
                {
                    case 8:
                        curationCompletedToolStripMenuItem.Visible = true;
                        break;
                    case 7:
                        reviewCompletedToolStripMenuItem.Visible = true;
                        break;
                    case 6:
                        qualityCheckCompltedToolStripMenuItem.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void DisableContextMenuItems()
        {
            curationCompletedToolStripMenuItem.Visible = false;
            reviewCompletedToolStripMenuItem.Visible = false;
            qualityCheckCompltedToolStripMenuItem.Visible = false;
        }

        private void curationCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColStatus"].Value.ToString() == "Assigned for Curation")
            {
                dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColStatus"].Value = "Curation Completed";
                Common.GlobalVariables.DtProject = DataGridView2DataTable(dgvProjects);
            }
            else
            {
                MessageBox.Show("Not Accessible");
            }
        }

        private void reviewCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColStatus"].Value.ToString() == "Curation Completed")
            {
                dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColStatus"].Value = "Review Completed";
                Common.GlobalVariables.DtProject = DataGridView2DataTable(dgvProjects);
            }
            else
            {
                MessageBox.Show("Not Accessible");
            }
        }

        private void qualityCheckCompltedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColStatus"].Value.ToString() == "Review Completed")
            {
                dgvProjects.Rows[dgvProjects.CurrentRow.Index].Cells["ColStatus"].Value = "Qc Completed";
                Common.GlobalVariables.DtProject = DataGridView2DataTable(dgvProjects);
            }
            else
            {
                MessageBox.Show("Not Accessible");
            }
        }

        //Converts the DataGridView to DataTable
        public DataTable DataGridView2DataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (dgv != null)
                {

                    

                    // Header columns
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        DataColumn dc = new DataColumn(column.Name.ToString());
                        dt.Columns.Add(dc);
                    }

                    // Data cells
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        DataGridViewRow row = dgv.Rows[i];
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                        }
                        dt.Rows.Add(dr);
                    }

                    // Related to the bug arround min size when using ExcelLibrary for export
                    for (int i = dgv.Rows.Count; i < 0; i++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            dr[j] = "  ";
                        }
                        dt.Rows.Add(dr);
                    }
                   
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dt;
        }

        private void txtDocId_TextChanged(object sender, EventArgs e)
        {
            if (Common.GlobalVariables.DtProject != null)
            {
                DataView dv = Common.GlobalVariables.DtProject.DefaultView;
                dv.RowFilter = "DocId like '" + txtDocId.Text + "%'";

                DataTable dt = dv.ToTable();
                if (dt != null)
                {

                    dgvProjects.DataSource = dt;
                    dgvProjects.Columns[0].DataPropertyName = dt.Columns[0].ColumnName;
                }
            }
        }

    }
}
