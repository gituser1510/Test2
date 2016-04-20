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
    public partial class frmRxnReference : Form
    {
        public frmRxnReference()
        {
            InitializeComponent();
        }

        public DataTable RxnsRefData { get; set; }

        public DataTable CrossRefData { get; set; }

        private void frmRxnReference_Load(object sender, EventArgs e)
        {
            try
            {
                BindReactionReferenceDataToGrid(RxnsRefData);

                BindCrossReferenceDataToGrid(CrossRefData);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindReactionReferenceDataToGrid(DataTable rxnRefData)
        {
            try
            {
                dgvRxnRef.AutoGenerateColumns = false;
                dgvRxnRef.DataSource = rxnRefData;

                colRxnSNo.DataPropertyName = "REACTION_SNO";
                colPathNo.DataPropertyName = "EXT_REG_NO";
                colPath.DataPropertyName = "PATH_LETTER";
                colStep.DataPropertyName = "STEP";
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindCrossReferenceDataToGrid(DataTable crossRefData)
        {
            try
            {
                dgvCrossRef.AutoGenerateColumns = false;
                dgvCrossRef.DataSource = crossRefData;

                colRxnSNo_CR.DataPropertyName = "REACTION_SNO";
                colPrevRxnNo_CR.DataPropertyName = "PRECEEDING";
                colSuccRxnNo_CR.DataPropertyName = "SUCCEEDING";                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Grid Row PostPaint Events

        private void dgvRxnRef_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvRxnRef.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvRxnRef.Font);

                if (dgvRxnRef.RowHeadersWidth < (int)(size.Width + 20)) dgvRxnRef.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvCrossRef_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvCrossRef.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvCrossRef.Font);

                if (dgvCrossRef.RowHeadersWidth < (int)(size.Width + 20)) dgvCrossRef.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              DataTable dtRxnChain = ChemInform.Common.ReactionSchemeValidations.ValidateSchemeProductsAndReactantsChain(RxnsRefData);
              dgvTest.DataSource = dtRxnChain;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
    }
}
