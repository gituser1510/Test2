using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Dal;
using ChemInform.Common;

namespace ChemInform
{
    public partial class FrmExportXml : Form
    {

        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;
        string OutPutFolderPath = null;

        public FrmExportXml()
        {
            InitializeComponent();
        }

        private void cmbShipmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvExportXml.AutoGenerateColumns = false;
                ColDocName.DataPropertyName = "colUnAssignedDocName";
                ColXmlStatus.DataPropertyName = "colUnAssignedDocStatus";
                dgvExportXml.DataSource = DataOperations.GetNotAssignedDocsToTLBasedOnShipments();//GetDocmentsToExportsBasedOnShipments();

                TotalCheckBoxes = dgvExportXml.RowCount;
                TotalCheckedCheckBoxes = 0;
                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void FrmExportXml_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            AddHeaderCheckBox();
            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dgvExportXml.CellValueChanged += new DataGridViewCellEventHandler(dgvExportXml_CellValueChanged);
            dgvExportXml.CurrentCellDirtyStateChanged += new EventHandler(dgvExportXml_CurrentCellDirtyStateChanged);
            dgvExportXml.CellPainting += new DataGridViewCellPaintingEventHandler(dgvExportXml_CellPainting);

            BindAllShipments();


        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);

            //Add the CheckBox into the DataGridView
            this.dgvExportXml.Controls.Add(HeaderCheckBox);
        }

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

        #region Row Post Paint

        private void dgvExportXml_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvExportXml.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvExportXml.Font);

                if (dgvExportXml.RowHeadersWidth < (int)(size.Width + 20)) dgvExportXml.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        #endregion

        #region Selection of GridView rows

        private void RowCheckBoxClick(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox != null)
            {
                //Modifiy Counter;            
                if ((bool)RCheckBox.Value && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                //Change state of the header CheckBox.
                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
        }
        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.dgvExportXml.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }
        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            try
            {
                IsHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow Row in dgvExportXml.Rows)
                    ((DataGridViewCheckBoxCell)Row.Cells["chkBxSelect"]).Value = HCheckBox.Checked;

                dgvExportXml.RefreshEdit();

                TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

                IsHeaderCheckBoxClicked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }
        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                HeaderCheckBoxClick((CheckBox)sender);
        }
        private void dgvExportXml_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
                if (e.ColumnIndex == 0)
                {
                    RowCheckBoxClick((DataGridViewCheckBoxCell)dgvExportXml[e.ColumnIndex, e.RowIndex]);
                }
        }
        private void dgvExportXml_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvExportXml.CurrentCell is DataGridViewCheckBoxCell)
                dgvExportXml.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvExportXml_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        #endregion

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fb = new FolderBrowserDialog();
                // if (dgvRefIdXml.Rows.Count > 0)
                {
                    if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        txtFolderPath.Text = fb.SelectedPath;
                        OutPutFolderPath = txtFolderPath.Text;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnExportToXml_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {

                    for (int i = 0; i < dgvExportXml.Rows.Count; i++)
                    {
                        bool XmlGeneratedStatus = false;
                        if (((DataGridViewCheckBoxCell)dgvExportXml.Rows[i].Cells["chkBxSelect"]).Value != null)
                        {
                            if ((bool)((DataGridViewCheckBoxCell)dgvExportXml.Rows[i].Cells["chkBxSelect"]).Value)
                            {
                                // TODO: Export xml.
                                dgvExportXml.Rows[i].Cells["ColXmlStatus"].Value = "Generated";
                                XmlGeneratedStatus = true;
                            }
                        }
                        if (XmlGeneratedStatus)
                            MessageBox.Show("Xml Generated Successfully", GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region Validate inputControls

        private bool ValidateUserInputs(out string _errmsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (cmbShipmentName.SelectedItem == null)
                {
                    strErrMsg = String.Format("{0}\r\n Please select Shipment Name", strErrMsg.Trim());
                    blStatus = false;
                }
                if (txtFolderPath.Text.Trim() == "")
                {
                    strErrMsg = String.Format("{0}\r\n Select out put folder path.", strErrMsg.Trim());
                    blStatus = false;
                }
                if (TotalCheckedCheckBoxes == 0)
                {
                    strErrMsg = String.Format("{0}\r\n Select atleast one record to Export.", strErrMsg.Trim());
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
