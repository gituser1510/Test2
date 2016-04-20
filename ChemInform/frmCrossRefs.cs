using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChemInform
{
    public partial class frmCrossRefs : Form
    {
        public frmCrossRefs()
        {
            InitializeComponent();
        }

        public DataTable CrossRefsData { get; set; }

        private void frmCrossRefs_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCrossRefs.AutoGenerateColumns = false;
                dgvCrossRefs.DataSource = CrossRefsData;
                colRxnSNo.DataPropertyName = "REACTION_SNO";
                colPrecRxnNo.DataPropertyName = "PRECEEDING";
                colSuccRxnNo.DataPropertyName = "SUCCEEDING";
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvCrossRefs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvCrossRefs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvCrossRefs.Font);

                if (dgvCrossRefs.RowHeadersWidth < (int)(size.Width + 20)) dgvCrossRefs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
    }
}
