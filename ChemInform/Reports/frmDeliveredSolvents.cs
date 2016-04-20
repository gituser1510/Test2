using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Common;
using System.Threading;
using ChemInform.Dal;

namespace ChemInform.Reports
{
    public partial class frmDeliveredSolvents : Form
    {
        public frmDeliveredSolvents()
        {
            InitializeComponent();
        }

        private void frmDeliveredSolvents_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                if (GlobalVariables.DeliveredSolvCatalysts == null)
                {
                    Thread trdDictionary = new Thread(delegate()
                    {
                        GlobalVariables.DeliveredSolvCatalysts = DeliveriesDB.GetDeliveredSolventCatalysts();
                    });

                    trdDictionary.IsBackground = true;
                    trdDictionary.Start();
                }

                BindDeliverySolventsToGrid(GlobalVariables.DeliveredSolvCatalysts);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDeliverySolventsToGrid(DataTable deliverySolvCats)
        {
            try
            {
                if (deliverySolvCats != null && deliverySolvCats.Rows.Count > 0)
                {
                    dgvDeliverySolvents.AutoGenerateColumns = false;
                    dgvDeliverySolvents.DataSource = deliverySolvCats;

                    colDeliveryName.DataPropertyName = "DELIVERY_NAME";
                    colShipmentRef_Solv.DataPropertyName = "REFERENCE_NAME";
                    colSolventName_Solv.DataPropertyName = "MOL_NAME";
                    colSolventMolFile.DataPropertyName = "MOL_FILE";
                }
                else
                {
                    dgvDeliverySolvents.DataSource = null;
                    solventRenderer.MolfileString = "";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvDeliverySolvents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    solventRenderer.MolfileString = dgvDeliverySolvents.Rows[e.RowIndex].Cells[colSolventMolFile.Name].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvDeliverySolvents_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvDeliverySolvents.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvDeliverySolvents.Font);

                if (dgvDeliverySolvents.RowHeadersWidth < (int)(size.Width + 20)) dgvDeliverySolvents.RowHeadersWidth = (int)(size.Width + 20);

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
