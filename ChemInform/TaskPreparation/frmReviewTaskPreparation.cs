using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DataGridViewAutoFilter;
using ChemInform.Dal;
using ChemInform.Bll;
using ChemInform.Common;

namespace ChemInform
{
    public partial class frmReviewTaskPreparation : Form
    {
        #region Constructor

        public frmReviewTaskPreparation()
        {
            InitializeComponent();
            dgvTasks.BindingContextChanged += new EventHandler(dgvShipmentTANs_BindingContextChanged);
        }

        #endregion

        #region Local variables

        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        CheckBox hcbValidated = null;
        bool IsHeaderCheckBoxClicked = false;

        BindingSource bsTansList; // = new BindingSource();
        BindingSource bsValidatedList; // = new BindingSource();
        DataTable dtShipments = new DataTable();

        public DataTable ShipmentTANs { get; set; }
        public DataTable ValidatedTANs { get; set; }
        int TotalTANs = 0;
        #endregion

        #region Methods

        private void frmReviewTaskPreparation_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dtShipMents = new DataTable();
                dtShipments = DataOperations.GetAllShipments();
                BindShipmentsToComboBox(dtShipments);

                cmbShipment.SelectedIndex = 0;
                lnklblClearFilter.Visible = false;

                #region Select All - Check Box addition

                AddHeaderCheckBox();

                HeaderCheckBox.KeyUp -= new KeyEventHandler(HeaderCheckBox_KeyUp);
                HeaderCheckBox.MouseClick -= new MouseEventHandler(HeaderCheckBox_MouseClick);
                dgvTasks.CellValueChanged -= new DataGridViewCellEventHandler(dgvShipmentTANs_CellValueChanged);
                dgvTasks.CurrentCellDirtyStateChanged -= new EventHandler(dgvShipmentTANs_CurrentCellDirtyStateChanged);
                dgvTasks.CellPainting -= new DataGridViewCellPaintingEventHandler(dgvShipmentTANs_CellPainting);

                HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
                HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
                dgvTasks.CellValueChanged += new DataGridViewCellEventHandler(dgvShipmentTANs_CellValueChanged);
                dgvTasks.CurrentCellDirtyStateChanged += new EventHandler(dgvShipmentTANs_CurrentCellDirtyStateChanged);
                dgvTasks.CellPainting += new DataGridViewCellPaintingEventHandler(dgvShipmentTANs_CellPainting);

                #endregion

                cmbShipment_SelectionChangeCommitted(null, null);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Binds Shipments to ComboBox
        /// </summary>
        /// <param name="shipments"></param>
        private void BindShipmentsToComboBox(DataTable shipments)
        {
            try
            {
                if (shipments.Rows.Count > 0)
                {
                    cmbShipment.DisplayMember = "SHIPMENT_NAME";
                    cmbShipment.ValueMember = "SHIPMENT_ID";
                    cmbShipment.DataSource = shipments;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Bind Shipment TANs to Grid
        /// </summary>
        /// <param name="shipmentTANs"></param>
        private void BindShipmentTasksToGrid(DataTable shipmentTANs)
        {
            try
            {
                //if (HeaderCheckBox != null)
                //{
                //    HeaderCheckBox.Enabled = false;
                //    HeaderCheckBox.Checked = false;
                //}

                bsTansList = new BindingSource();
                bsTansList.RemoveFilter();

                if (shipmentTANs != null && shipmentTANs.Rows.Count > 0)
                {
                    ShipmentTANs = shipmentTANs;

                    dgvTasks.AutoGenerateColumns = false;
                    bsTansList.DataSource = ShipmentTANs;

                    colSRID_TP.DataPropertyName = "SHIPMENT_REF_ID";
                    colRefNo_TP.DataPropertyName = "REFERENCE_NAME";
                    colSysText_TP.DataPropertyName = "SYS_TEXT";
                    colSysNo_TP.DataPropertyName = "SYS_NO";
                    colClassType_TP.DataPropertyName = "SYS_CLASS_TYPE";
                    colIssue_TP.DataPropertyName = "ISSUE";
                    colDOI_TP.DataPropertyName = "DOI";
                    colNoRxn_TP.DataPropertyName = "ZERO_REACTIONS_STATUS";
                    colCreatedBy_TP.DataPropertyName = "";
                    colCreatedOn_TP.DataPropertyName = "";
                    colValidationStatus_TP.DataPropertyName = "VALIDATION_STATUS";
                    colTaskStatus_TP.DataPropertyName = "TASK_STATUS";

                    dgvTasks.DataSource = bsTansList;
                    dgvShipmentTANs_BindingContextChanged(null, null);
                    TotalTANs = dgvTasks.Rows.Count;

                    //if (HeaderCheckBox != null)
                    //{
                    //    HeaderCheckBox.Enabled = true;
                    //}
                }
                else
                {
                    bsTansList.DataSource = null;
                    dgvTasks.DataSource = bsTansList;
                }

                if (TotalTANs == dgvTasks.Rows.Count)
                {
                    lnklblClearFilter.Visible = false;
                }

                //Counters
                TotalCheckBoxes = dgvTasks.RowCount;
                TotalCheckedCheckBoxes = 0;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindValidatedShipmentTasksToGrid(DataTable validatedTANs)
        {
            try
            {
                //if (hcbValidated != null)
                //{
                //    hcbValidated.Enabled = false;
                //    hcbValidated.Checked = false;
                //}

                bsValidatedList = new BindingSource();
                bsValidatedList.RemoveFilter();

                if (validatedTANs != null && validatedTANs.Rows.Count > 0)
                {

                    dgvValidatedRefs.AutoGenerateColumns = false;
                    ValidatedTANs = validatedTANs;

                    bsValidatedList.DataSource = ValidatedTANs;
                    dgvValidatedRefs.DataSource = bsValidatedList;

                    dgvValidatedRefs_BindingContextChanged(null, null);
                    TotalTANs = dgvValidatedRefs.Rows.Count;

                    //if (hcbValidated != null)
                    //{
                    //    hcbValidated.Enabled = true;
                    //}
                }
                else
                {
                    bsValidatedList.DataSource = null;
                    dgvValidatedRefs.DataSource = bsValidatedList;
                }

                if (TotalTANs == dgvValidatedRefs.Rows.Count)
                {
                    lnkClearValidatedFilter.Visible = false;
                }

                ////Counters
                //TotalCheckBoxes = dgvValidatedRefs.RowCount;
                //TotalCheckedCheckBoxes = 0;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// Validates User Inputs
        /// </summary>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        private bool ValidateUserInputs(out string errMsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (cmbShipment.SelectedIndex == -1)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select shipment";
                    blStatus = false;
                }
                if (dgvTasks.Rows.Count == 0)
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "No References are selected for validate";
                    blStatus = false;
                }
                else
                {
                    List<int> lstSelRefs = GetSelectedTasksForValidate();
                    if (lstSelRefs != null)
                    {
                        if (lstSelRefs.Count == 0)
                        {
                            strErrMsg = strErrMsg.Trim() + "\r\n" + "No References are selected for validate";
                            blStatus = false;
                        }
                    }
                    //if (TotalCheckedCheckBoxes == 0)
                    //{
                    //    strErrMsg = strErrMsg.Trim() + "\r\n" + "No References are selected for validate";
                    //    blStatus = false;
                    //}
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errMsg = strErrMsg.Trim();
            return blStatus;
        }
         
        #endregion

        #region Events

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate user inputs
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {                   
                    //Get Selected TANs for Export
                    List<int> lstSelRefs = GetSelectedTasksForValidate();

                    if (lstSelRefs != null)
                    {
                        if (lstSelRefs.Count > 0)
                        {
                            if (ShipmentManagementDB.ValidateTaskPreparation(lstSelRefs, Convert.ToInt32(cmbShipment.SelectedValue), GlobalVariables.UR_ID))
                            {
                                MessageBox.Show("Selected Tasks validated successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmbShipment_SelectionChangeCommitted(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Error in task validation.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("No tasks are selected for validate", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// Gets Selected TANs list
        /// </summary>
        /// <returns></returns>
        private List<int> GetSelectedTasksForValidate()
        {
            List<int> lstTANs = null;           
            try
            {
                if (dgvTasks.DataSource != null)
                {
                    if (dgvTasks.Rows.Count > 0)
                    {
                        lstTANs = new List<int>();                       
                        for (int i = 0; i < dgvTasks.Rows.Count; i++)
                        {
                            if (dgvTasks.Rows[i].Cells[colSelect_TP.Name].Value != null)
                            {
                                if (Convert.ToBoolean(dgvTasks.Rows[i].Cells[colSelect_TP.Name].Value.ToString()))
                                {
                                    lstTANs.Add(Convert.ToInt32(dgvTasks.Rows[i].Cells[colSRID_TP.Name].Value));
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
            return lstTANs;
        }
 
        #endregion

        #region Grid RowPostPaint Events

        private void dgvShipmentTANs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvTasks.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvTasks.Font);

                if (dgvTasks.RowHeadersWidth < (int)(size.Width + 20)) dgvTasks.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvValidatedRefs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvValidatedRefs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvValidatedRefs.Font);

                if (dgvValidatedRefs.RowHeadersWidth < (int)(size.Width + 20)) dgvValidatedRefs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Select All - Event Args
        
        private void AddHeaderCheckBox()
        {
            try
            {
                HeaderCheckBox = new CheckBox();

                HeaderCheckBox.Size = new Size(80, 21);
                //HeaderCheckBox.Text = "Select All";
                HeaderCheckBox.BackColor = System.Drawing.Color.Transparent;
                HeaderCheckBox.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                HeaderCheckBox.TabIndex = 2;

                //Add the CheckBox into the DataGridView
                this.dgvTasks.Controls.Add(HeaderCheckBox);                
            }
            catch (Exception)
            {                
                throw;
            }
        }

        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.dgvTasks.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

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

            foreach (DataGridViewRow Row in dgvTasks.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells[colSelect_TP.Name]).Value = HCheckBox.Checked;

            dgvTasks.RefreshEdit();

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
                    RowCheckBoxClick((DataGridViewCheckBoxCell)dgvTasks[e.ColumnIndex, e.RowIndex]);
            }
        }

        private void dgvShipmentTANs_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentCell is DataGridViewCheckBoxCell)
                dgvTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvShipmentTANs_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        #endregion

        /// <summary>
        /// Filtering on column header.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvShipmentTANs_BindingContextChanged(object sender, EventArgs e)
        {
            try
            {
                // Continue only if the data source has been set.
                if (dgvTasks.DataSource == null)
                {
                    return;
                }

                // Add the AutoFilter header cell to each column.
                foreach (DataGridViewColumn col in dgvTasks.Columns)
                {
                    if (col.HeaderCell.ColumnIndex != 0)
                        col.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
                }

                // Format the OrderTotal column as currency. 
                // dgvDailyStatus.Columns["OrderTotal"].DefaultCellStyle.Format = "c";

                // Resize the columns to fit their contents.
                //  dgvUserTaskSheet.AutoResizeColumns();


            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// DataBindingComplete filter label status update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvShipmentTANs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                String filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dgvTasks);
                if (String.IsNullOrEmpty(filterStatus))
                {
                    lnklblClearFilter.Visible = false;
                }
                else
                {
                    lnklblClearFilter.Visible = true;
                }

                if (HeaderCheckBox.Checked)
                    HeaderCheckBox.Checked = false;
                TotalCheckBoxes = dgvTasks.RowCount;
                //TotalCheckedCheckBoxes = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Clear filter on data grid view - shows all records.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //  lnklblClearFilter.Visible = false;

                DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dgvTasks);

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

        private void dgvShipmentTANs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        int shipmentID = 0;
        /// <summary>
        /// Handles the SelectionChangeCommitted event of the cmbShipment control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbShipment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbShipment.SelectedIndex != -1)
                {
                    if (cmbShipment.SelectedItem != null)
                    {                      
                        int.TryParse(cmbShipment.SelectedValue.ToString(), out shipmentID);
                        
                        //shipmentID = Convert.ToInt32(cmbShipment.SelectedValue);
                        if (shipmentID > 0)
                        {
                            DataTable dtShipmentRefs = TaskManagementDB.GetTaskPreparationRefsOnShipment(shipmentID);
                            if (dtShipmentRefs != null)
                            {
                                //Bind Data to Task Preparation
                                DataView dvTaskPrep = dtShipmentRefs.DefaultView;
                                dvTaskPrep.RowFilter = "VALIDATION_STATUS = 'N'";
                                DataTable dtTaskPrep = dvTaskPrep.ToTable();
                                BindShipmentTasksToGrid(dtTaskPrep);

                                //Bind Data to Task Preparation
                                DataView dvTaskValid = dtShipmentRefs.DefaultView;
                                dvTaskValid.RowFilter = "VALIDATION_STATUS = 'Y'";
                                DataTable dtTaskValid = dvTaskValid.ToTable();
                                BindValidatedShipmentTasksToGrid(dtTaskValid);
                            }
                        }
                    }
                }               
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvShipmentTANs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    // tanInfo.ShipmentId = Convert.ToInt32(dgvTaskSheet.Rows[e.RowIndex].Cells[colShipmentId.Name].Value);
                    if (String.Equals(dgvTasks.Columns[e.ColumnIndex].Name, colRefNo_TP.Name, StringComparison.CurrentCultureIgnoreCase))
                    {
                        //TODO: Open Cropped pdf.
                        //MessageBox.Show(Convert.ToString(dgvTasks.Rows[e.RowIndex].Cells[colRefNum.Name].Value), GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private void dgvValidatedRefs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                String filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dgvValidatedRefs);
                if (String.IsNullOrEmpty(filterStatus))
                {
                    lnkClearValidatedFilter.Visible = false;
                }
                else
                {
                    lnkClearValidatedFilter.Visible = true;
                }

                if (HeaderCheckBox.Checked)
                    HeaderCheckBox.Checked = false;
                TotalCheckBoxes = dgvValidatedRefs.RowCount;
                TotalCheckedCheckBoxes = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvValidatedRefs_BindingContextChanged(object sender, EventArgs e)
        {
            try
            {
                // Continue only if the data source has been set.
                if (dgvValidatedRefs.DataSource == null)
                {
                    return;
                }

                // Add the AutoFilter header cell to each column.
                foreach (DataGridViewColumn col in dgvValidatedRefs.Columns)
                {
                    if (col.HeaderCell.ColumnIndex != 0)
                        col.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
                }

                // Format the OrderTotal column as currency. 
                // dgvDailyStatus.Columns["OrderTotal"].DefaultCellStyle.Format = "c";

                // Resize the columns to fit their contents.
                //  dgvUserTaskSheet.AutoResizeColumns();


            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
         

    }
}
