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
using System.Threading;
using ChemInform.Bll;

namespace ChemInform.Export
{
    public partial class frmShipmentDelivery : Form
    {
        public frmShipmentDelivery()
        {
            InitializeComponent();
        }

        private void frmShipmentDelivery_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.DeliveredSolvCatalysts == null)
                {
                    Thread trdDictionary = new Thread(delegate()
                    {
                        GlobalVariables.DeliveredSolvCatalysts = DeliveriesDB.GetDeliveredSolventCatalysts();
                    });

                    trdDictionary.IsBackground = true;
                    trdDictionary.Start();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        int shipmentYear = 0;
        private void btnGetShipmentRefs_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtShipmentYear.Text.Trim()) && !string.IsNullOrEmpty(txtClassType.Text.Trim()))
                {                    
                    int.TryParse(txtShipmentYear.Text.Trim(), out shipmentYear);

                    if (shipmentYear > 0)
                    {
                        DataSet dsDeliveryData = ShipmentManagementDB.GetDeliveryDataOnYearAndClassType(shipmentYear, txtClassType.Text.Trim());
                        if (dsDeliveryData != null && dsDeliveryData.Tables.Count == 2)
                        {
                            //Bind Delivery Shipment References to grid
                            BindDeliveryDataToGrid(dsDeliveryData.Tables[0]);

                            //Bind Delivery Solvents to grid
                            BindDeliverySolventsToGrid(dsDeliveryData.Tables[1]);

                            //Get Next Mdl No
                            txtMDLNo.Text = DeliveriesDB.GetNextMDLNumber().ToString();
                        }
                    }
                }
                else
                {
                    dgvRDFRefs.DataSource = null;
                    dgvSolvents.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDeliveryDataToGrid(DataTable deliveryData)
        {
            try
            {
                if (deliveryData != null)
                {
                    dgvRDFRefs.AutoGenerateColumns = false;
                    dgvRDFRefs.DataSource = deliveryData;

                    colShipmentRefID.DataPropertyName = "SHIPMENT_REF_ID";
                    colReferenceName.DataPropertyName = "REFERENCE_NAME";
                    colSysNo.DataPropertyName = "SYS_NO";
                    colSysText.DataPropertyName = "SYS_TEXT";
                    colShipmentName.DataPropertyName = "SHIPMENT_NAME";
                    colRxnCnt.DataPropertyName = "REACTION_CNT";
                    colRefStatus.DataPropertyName = "TASK_STATUS";
                    colIsDelivered.DataPropertyName = "IS_DELIVERED";

                    SetDeliveryStatusLabels(deliveryData);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDeliverySolventsToGrid(DataTable deliverySolvents)
        {
            try
            {
                if (deliverySolvents != null)
                {
                    dgvSolvents.AutoGenerateColumns = false;
                    dgvSolvents.DataSource = deliverySolvents;
                                        
                    colShipmentRef_Solv.DataPropertyName = "REFERENCE_NAME";
                    colSolventName_Solv.DataPropertyName = "PRPNT_NAME";
                    colSolventMolFile.DataPropertyName = "PRPNT_STRUCTURE";                                 
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void SetDeliveryStatusLabels(DataTable deliveryData)
        {
            try
            {
                if (deliveryData != null)
                {
                    //Reactions count
                    object objRxnsCnt = deliveryData.Compute("sum([REACTION_CNT])", "[REACTION_CNT] is not null");
                    if (objRxnsCnt != null)
                    {
                        lblRxnsCnt.Text = objRxnsCnt.ToString();
                    }

                    //No.of References
                    lblRefsCount.Text = deliveryData.Rows.Count.ToString();          
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
                if (dgvRDFRefs.Rows.Count == 0)
                {
                    strErrMsg = strErrMsg.Trim() + Environment.NewLine + "No references are available";
                    blStatus = false;
                }

                if (string.IsNullOrEmpty(txtDeliveryName.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + Environment.NewLine + "Delivery name is mandatory";
                    blStatus = false;
                }

                if (string.IsNullOrEmpty(txtFolderPath.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + Environment.NewLine + "Output folder path is mandatory";
                    blStatus = false;
                }
                                
                if (string.IsNullOrEmpty(txtMDLNo.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + Environment.NewLine + "MDL No. is mandatory";
                    blStatus = false;
                }
                else
                {
                    int mdlNo = 0;
                    if (!int.TryParse(txtMDLNo.Text.Trim(), out mdlNo))
                    {
                        strErrMsg = strErrMsg.Trim() + Environment.NewLine + "MDL No. should be integer";
                        blStatus = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errMsg = strErrMsg;
            return blStatus;
        }

        private void btnGenerateRDF_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {
                    bool blClientDelivery = false;
                    
                    if (chkExpClientDelivery.Checked)
                    {
                        DialogResult diaRes = MessageBox.Show("Do you want to export for client's delivery?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (diaRes == System.Windows.Forms.DialogResult.Yes)
                        {
                            blClientDelivery = true;
                        }
                        else
                        {
                            chkExpClientDelivery.Checked = false;
                            blClientDelivery = false;
                        }
                    }
                    
                    int twodigYear = shipmentYear > 0 ? Convert.ToInt32(shipmentYear.ToString().Substring(2, 2)) : 0;                    
                    
                    DataTable dtTemp = dgvRDFRefs.DataSource as DataTable;
                    DataRow[] rows = dtTemp.Select();
                    List<int> lstSelRefs = Array.ConvertAll(rows, row => Convert.ToInt32(row["SHIPMENT_REF_ID"])).ToList();
                    
                    if (lstSelRefs != null && lstSelRefs.Count > 0)
                    {
                        int startMDLNo = Convert.ToInt32(txtMDLNo.Text.Trim());
                        Delivery objDelivery = new Delivery();
                        List<DeliverySolvCats> lstDeliverySovCats = null;
                        if (ShipmentExport.ExportReactionsForClientDelivery(lstSelRefs, twodigYear.ToString(), txtFolderPath.Text, startMDLNo, out objDelivery, out lstDeliverySovCats))
                        {
                            //Update Delivery details in the database
                            if (objDelivery != null && blClientDelivery)
                            {
                                objDelivery.DeliveryName = txtDeliveryName.Text.Trim();
                                objDelivery.Urid = GlobalVariables.UR_ID;

                                DataTable dtDeliveryTbl = null;
                                //Save delivery details in database
                                if (DeliveriesDB.SaveDeliveryDetails(objDelivery, out dtDeliveryTbl))
                                {                                                                       
                                   //Save delivered Solvents
                                    if (SaveDeliverySolvCatsInDatabase(lstDeliverySovCats, txtDeliveryName.Text.Trim()))
                                    {
                                        MessageBox.Show("Export to RDFs and delivery details saving are done successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvRDFRefs.DataSource = null;
                                        dgvSolvents.DataSource = null;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error in saving delivery details in the database", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Exported to RDFs successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }             
                        }
                        else
                        {
                            MessageBox.Show("Error in RDF export", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(strErrMsg.Trim(), GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool SaveDeliverySolvCatsInDatabase(List<DeliverySolvCats> deliverySovCatsList, string deliveryName)
        {
            bool blStatus = true;
            try
            {
                if (deliverySovCatsList != null && !string.IsNullOrEmpty(deliveryName))
                {
                    foreach (DeliverySolvCats delSolv in deliverySovCatsList)
                    {
                        foreach (NewSolvents newSolv in delSolv.RefNewSolvents)
                        {
                            DeliveriesDB.SaveDeliverySolvCatsDetails(deliveryName, delSolv.ShipmentRefID, newSolv.StructureMolFile.ToString(), newSolv.StructureName, newSolv.StructureInchiKey);
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbdIpBrowse = new FolderBrowserDialog())
                {
                    if (fbdIpBrowse.ShowDialog() == DialogResult.OK)
                    {
                        txtFolderPath.Text = fbdIpBrowse.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        
        private void dgvSolvents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    solventRenderer.MolfileString = dgvSolvents.Rows[e.RowIndex].Cells[colSolventMolFile.Name].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region GridView Row PostPaint Events
        
        private void dgvRDFRefs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvRDFRefs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvRDFRefs.Font);

                if (dgvRDFRefs.RowHeadersWidth < (int)(size.Width + 20)) dgvRDFRefs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvSolvents_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                while (strRowNumber.Length < dgvSolvents.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvSolvents.Font);

                if (dgvSolvents.RowHeadersWidth < (int)(size.Width + 20)) dgvSolvents.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        } 
        
        #endregion

        private void chkExpClientDelivery_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
