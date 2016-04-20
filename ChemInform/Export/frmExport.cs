using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DataGridViewAutoFilter;
using ChemInform;
using ChemInform.Common;
using ChemInform.Dal;
using ChemInform.Export;
using ChemInform.Bll;

namespace ChemInform
{
    public partial class frmExport : Form
    {
        #region Constructor

        public frmExport()
        {
            InitializeComponent();           
        }

        #endregion

        #region Local variables

        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;

        BindingSource bsDocsList; // = new BindingSource();
        DataTable dtShipments;

        public DataTable ShipmentDocs { get; set; }
        int TotalDocs = 0;

        #endregion
               
        private void frmExport_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
                
        private void BindShipmentsToComboBox(DataTable shipments)
        {
            try
            {
                if (shipments != null)
                {
                    cmbShipment.DataSource = shipments;
                    cmbShipment.DisplayMember = "SHIPMENT_NAME_INTL";
                    cmbShipment.ValueMember = "SHIPMENT_ID";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
               
        private bool ValidateUserInputs(out string errMsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (string.IsNullOrEmpty(cmbShipment.Text))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select shipment";
                    blStatus = false;
                }

                if (string.IsNullOrEmpty(txtFolderPath.Text))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Output files folder path can not be null";
                    blStatus = false;
                }
                if (dgvShipmentDocs.Rows.Count == 0)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "No TANs are available for export";
                    blStatus = false;
                }
                else
                {
                    List<int> lstRefIds = GetSelectedReferencesFromGrid();

                    if (lstRefIds == null)
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "No TANs selected for export";
                        blStatus = false;
                    }
                    else if (lstRefIds.Count == 0)
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "No TANs selected for export";
                        blStatus = false;
                    }
                    //else if (lstSelTANs.Count == 0)
                    //{
                    //    strErrMsg = strErrMsg.Trim() + "\r\n" + "No TANs are selected for export";
                    //    blStatus = false;
                    //}
                    else if (!ValidateSelectedDocsStatusForExport())
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "'NOT ASSIGNED' TANs are not eligible for export";
                        blStatus = false;
                    }
                }

                if (string.IsNullOrEmpty(txtMDLNo.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Strat MDL No. should be mentioned";
                    blStatus = false;
                }
                else
                {
                    Int64 mdlNo = 0;
                    if (!Int64.TryParse(txtMDLNo.Text.Trim(), out mdlNo))
                    {
                        strErrMsg = strErrMsg.Trim() + "\r\n" + "Strat MDL No. should be integer";
                        blStatus = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errMsg = strErrMsg.Trim();
            return blStatus;
        }

        private List<int> GetSelectedReferencesFromGrid()
        {
            List<int> lstSelRefs = null;
            try
            {
                lstSelRefs = new List<int>();
                foreach (DataGridViewRow row in dgvShipmentDocs.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[colSelect.Name].Value))
                    {
                        lstSelRefs.Add(Convert.ToInt32(row.Cells[1].Value));
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstSelRefs;
        }

        private bool ValidateSelectedDocsStatusForExport()
        {
            bool blStatus = true;
            try
            {
                if (dgvShipmentDocs.DataSource != null)
                {
                    if (dgvShipmentDocs.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgvShipmentDocs.Rows.Count; i++)
                        {
                            if (dgvShipmentDocs.Rows[i].Cells[colSelect.Name].Value != null)
                            {
                                if (Convert.ToBoolean(dgvShipmentDocs.Rows[i].Cells[colSelect.Name].Value.ToString()) &&
                                     dgvShipmentDocs.Rows[i].Cells[colReferenceStatus.Name].Value.ToString().ToUpper() == "Y")
                                {
                                    blStatus = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }
                
        private void btnFolderSel_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFolderPath.Text = fb.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {               
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {                    
                   //Get selected Documents
                    List<int> lstSelRefs = GetSelectedReferencesFromGrid();

                    int twodigYear = 0;
                    if (shipmentYear > 0)
                    {
                        twodigYear = Convert.ToInt32(shipmentYear.ToString().Substring(2, 2));
                    }

                    if (lstSelRefs != null && lstSelRefs.Count > 0)
                    {                       
                        int startMDLNo = Convert.ToInt32(txtMDLNo.Text.Trim());
                        Delivery objdelivery = null;
                        if (ShipmentExport.ExportReactions(lstSelRefs, twodigYear.ToString(), txtFolderPath.Text, startMDLNo, out objdelivery))
                        {
                            MessageBox.Show("Export to RDF successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error in RDF export", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }          
                    }
                }
                else
                {
                    MessageBox.Show(strErrMsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }      
         
        private void dgvShipmentDocs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvShipmentDocs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvShipmentDocs.Font);

                if (dgvShipmentDocs.RowHeadersWidth < (int)(size.Width + 20)) dgvShipmentDocs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Select All - Event Args
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(80, 21);
            HeaderCheckBox.Text = "Select All";
            HeaderCheckBox.BackColor = System.Drawing.Color.Transparent;
            HeaderCheckBox.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            HeaderCheckBox.TabIndex = 2;

            //Add the CheckBox into the DataGridView
            this.dgvShipmentDocs.Controls.Add(HeaderCheckBox);
        }

        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.dgvShipmentDocs.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }

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

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dgvShipmentDocs.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells[colSelect.Name]).Value = HCheckBox.Checked;

            dgvShipmentDocs.RefreshEdit();

            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            IsHeaderCheckBoxClicked = false;
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


        private void dgvShipmentTANs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
            {
                if (e.RowIndex != -1)
                    RowCheckBoxClick((DataGridViewCheckBoxCell)dgvShipmentDocs[e.ColumnIndex, e.RowIndex]);
            }
        }

        private void dgvShipmentTANs_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvShipmentDocs.CurrentCell is DataGridViewCheckBoxCell)
                dgvShipmentDocs.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvShipmentTANs_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        #endregion
                                    
                     
        private void lnklblClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //  lnklblClearFilter.Visible = false;

                DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvShipmentDocs);

                //bsTansList.DataSource = ShipmentTANs;
                //dgvShipmentTANs.DataSource = bsTansList;

                if (HeaderCheckBox.Checked)
                    HeaderCheckBox.Checked = false;

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }          
                
        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Get Shipments on Module
                dtShipments = ShipmentManagementDB.GetShipmentsOnModule(GetSelectedModuleCode());
                if (dtShipments != null)
                {
                    dgvShipmentDocs.DataSource = null;

                    cmbShipment.DataSource = dtShipments;
                    cmbShipment.DisplayMember = "SHIPMENT_NAME";
                    cmbShipment.ValueMember = "SHIPMENT_ID";
                }
                else
                {
                    cmbShipment.DataSource = null;
                    dgvShipmentDocs.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private string GetSelectedModuleCode()
        {
            string moduleCode = "";
            try
            {
                if (cmbModule.SelectedItem != null)
                {
                    moduleCode = cmbModule.Text.ToUpper();
                    if (moduleCode.ToUpper() == "TASK PREPARATION")
                    {
                        moduleCode = "TP";
                    }
                    else if (moduleCode.ToUpper() == "REACTION ANALYSIS")
                    {
                        moduleCode = "RA";
                    }
                    else
                    {
                        moduleCode = "SA";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return moduleCode;
        }

        int shipmentID = 0;
        int shipmentYear = 0;
        private void cmbShipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbShipment.SelectedIndex != -1)
                {
                    DataTable shipmentData = ShipmentManagementDB.GetShipmentStatusReport(Convert.ToInt32(cmbShipment.SelectedValue));
                    if (shipmentData != null)
                    {
                        //Get Shipment Year on ShipmentID
                        shipmentYear = GetShipmentYearOnShipmentID(Convert.ToInt32(cmbShipment.SelectedValue));

                        dgvShipmentDocs.AutoGenerateColumns = false;
                        dgvShipmentDocs.DataSource = shipmentData;
                        colShipmentRefID.DataPropertyName = "SHIPMENT_REF_ID";
                        colReferenceName.DataPropertyName = "REFERENCE_NAME";
                        colReferenceStatus.DataPropertyName = "TASK_STATUS";
                    }
                }
                else
                {
                    MessageBox.Show("Please select shipment.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private int GetShipmentYearOnShipmentID(int shipmentID)
        {
            int shipmentYear = 0;
            try
            {
                if (shipmentID > 0 && dtShipments != null)
                {
                    var rows = from r in dtShipments.AsEnumerable()
                                where r.Field<Int64>("SHIPMENT_ID") == shipmentID
                                select new
                                {                                    
                                    year = r["SHIPMENT_YEAR"].ToString()
                                };

                    if (rows != null)
                    {
                        foreach (var r in rows)
                        {
                            shipmentYear = !string.IsNullOrEmpty(r.year) ? Convert.ToInt32(r.year) : 0;                            
                        }
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return shipmentYear;
        }
    }
}
