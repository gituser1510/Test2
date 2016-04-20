using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Collections;
using System.IO;
using ChemInform.Common;
using ChemInform.Dal;
using ChemInform.Export;
using ChemInform.Bll;
using System.Threading;

namespace ChemInform
{
    public partial class frmBatchExport : Form
    {
        public frmBatchExport()
        {
            InitializeComponent();
        }

        #region Property Procedures

        public DataTable Batch_Refs
        { get; set; }       
               
        public string FilePath
        { get; set; }
                
       
        public string[] SelectedTANs
        { get; set; }

        DataTable dtShipments;

        private DataTable _dtavailrefs = null;
        public DataTable AvailableRefsTbl
        {
            get
            {
                return _dtavailrefs;
            }
            set
            {
                _dtavailrefs = value;
            }
        }

        private DataTable _dtselectedrefs = null;
        public DataTable SelectedRefsTbl
        {
            get
            {
                return _dtselectedrefs;
            }
            set
            {
                _dtselectedrefs = value;
            }
        }

        public DataTable ReferencesForRDF
        { get; set; }

        #endregion

        private void frmBatchXml_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                if (GlobalVariables.RoleName.ToUpper() == "ADMINISTRATOR" || GlobalVariables.RoleName.ToUpper() == "TOOL MANAGER")
                {
                    chkSkipQcCheck.Visible = true;
                }

                if (GlobalVariables.DeliveredSolvCatalysts == null)
                {
                    Thread trdDictionary = new Thread(delegate()
                    {
                        GlobalVariables.DeliveredSolvCatalysts = DeliveriesDB.GetDeliveredSolventCatalysts();
                    });

                    trdDictionary.IsBackground = true;
                    trdDictionary.Start();
                }

                //Get Shipment Names and Set Autofill
                GetShipmentNamesAndSetToUserNameTxtBox_AutoComplete();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
                
        private void GetShipmentNamesAndSetToUserNameTxtBox_AutoComplete()
        {
            try
            {               
                dtShipments = ShipmentManagementDB.GetShipmentsOnModule("RA");
                if (dtShipments != null)
                {
                    if (dtShipments.Rows.Count > 0)
                    {
                        AutoCompleteStringCollection shipmentColl = new AutoCompleteStringCollection();

                        for (int i = 0; i < dtShipments.Rows.Count; i++)
                        {
                            shipmentColl.Add(dtShipments.Rows[i]["SHIPMENT_NAME"].ToString());
                        }

                        txtShipmentName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtShipmentName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtShipmentName.AutoCompleteCustomSource = shipmentColl;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private int GetShipmentIDOnShipmentName(string shipmentName)
        {
            int shipmentID = 0;
            try
            {
                if (!string.IsNullOrEmpty(shipmentName) && dtShipments != null)
                {
                    var rows = from r in dtShipments.AsEnumerable()
                               where r.Field<string>("SHIPMENT_NAME") == shipmentName
                               select new
                               {
                                   id = r["SHIPMENT_ID"].ToString()
                               };

                    if (rows != null)
                    {
                        foreach (var r in rows)
                        {
                            shipmentID = !string.IsNullOrEmpty(r.id) ? Convert.ToInt32(r.id) : 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return shipmentID;
        }
        
        private int GetShipmentYearOnShipmentName(string shipmentName)
        {
            int shipmentYear = 0;
            try
            {
                if (!string.IsNullOrEmpty(shipmentName.Trim()) && dtShipments != null)
                {
                    var rows = from r in dtShipments.AsEnumerable()
                               where r.Field<string>("SHIPMENT_Name") == shipmentName
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
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return shipmentYear;
        }

        string strShipmentName = "";       
        private void btnGetShipmentRefs_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                //Reset Status values
                ReSetStatusValues();

                int shipmentID = GetShipmentIDOnShipmentName(txtShipmentName.Text.Trim());
                     
                DataTable shipmentRefs = ShipmentManagementDB.GetShipmentStatusReport(shipmentID);
                if (shipmentRefs != null)
                {
                    if (shipmentRefs.Rows.Count > 0)
                    {
                        strShipmentName = txtShipmentName.Text.Trim();

                        AvailableRefsTbl = shipmentRefs;
                        //Bind Data to Available TANs grid
                        BindDataToAvailableReferencesGrid(AvailableRefsTbl);

                        dtselTans = null;
                        SelectedRefsTbl = null;

                        //Bind data to Selected TANs grid
                        BindDataToSelectedReferencesGrid(SelectedRefsTbl);                                             
                        
                        //Set Status Values
                        GetStatusValues_BindToControls(shipmentRefs);
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        AvailableRefsTbl = null;
                        BindDataToAvailableReferencesGrid(AvailableRefsTbl);

                        Cursor = Cursors.Default;
                        MessageBox.Show("No References found for the shipment",GlobalVariables.MessageCaption,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    AvailableRefsTbl = null;
                    BindDataToAvailableReferencesGrid(AvailableRefsTbl);

                    Cursor = Cursors.Default;
                    MessageBox.Show("No References found for the shipment", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
                Cursor = Cursors.Default;
            }
        }

        int shipmentID = 0;
        int shipmentYear = 0;
        private void btnGenerateRDF_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateUserInputs(out strErrMsg))
                {

                    //Get Shipment Year on ShipmentID
                    shipmentYear = GetShipmentYearOnShipmentName(txtShipmentName.Text.Trim());

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
                        Delivery objDelivery = null;
                        if (ShipmentExport.ExportReactions(lstSelRefs, twodigYear.ToString(), txtFolderPath.Text, startMDLNo, out objDelivery))
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

        private List<int> GetSelectedReferencesFromGrid()
        {
            List<int> lstSelRefs = null;
            try
            {
                lstSelRefs = new List<int>();
                foreach (DataGridViewRow row in dgvRDFRefs.Rows)
                {
                    lstSelRefs.Add(Convert.ToInt32(row.Cells[colRefID_RDF.Name].Value));
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstSelRefs;
        }

        private bool ValidateUserInputs(out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (dgvRDFRefs.Rows.Count == 0)
                {
                    strErrMsg = "No References are available to export";
                    blStatus = false;
                }
               
                if (string.IsNullOrEmpty(txtFolderPath.Text.Trim()))
                {
                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Please select output folder path";
                    blStatus = false;
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
            errmsg_out = strErrMsg.Trim();
            return blStatus;
        }

        private bool CheckReferenceStatusQCCompleted(DataGridViewSelectedRowCollection selectedrows, out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (!chkSkipQcCheck.Checked)//Skip QC
                {
                    if (selectedrows != null)
                    {
                        if (selectedrows.Count > 0)
                        {
                            for (int i = 0; i < selectedrows.Count; i++)
                            {
                                if (selectedrows[i].Cells[colRefStatus_Avail.Name].Value.ToString().ToUpper() != "QC - COMPLETED")
                                {
                                    blStatus = false;
                                    strErrMsg = string.IsNullOrEmpty(strErrMsg.Trim()) ? selectedrows[i].Cells[colRefName_Avail.Name].Value.ToString() : strErrMsg.Trim() + ", " + selectedrows[i].Cells[colRefName_Avail.Name].Value.ToString();
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
            errmsg_out = strErrMsg;
            return blStatus;
        }

        private bool CheckForDeliveredReferences(DataGridViewSelectedRowCollection selectedrows, out string errmsg_out)
        {
            bool blStatus = false;
            string strErrMsg = "";
            try
            {
                if (selectedrows != null)
                {
                    if (selectedrows.Count > 0)
                    {
                        for (int i = 0; i < selectedrows.Count; i++)
                        {
                            if (selectedrows[i].Cells[colIsDelivered_Avail.Name].Value.ToString().ToUpper() == "Y")
                            {
                                blStatus = true;
                                strErrMsg = string.IsNullOrEmpty(strErrMsg.Trim()) ? selectedrows[i].Cells[colRefName_Avail.Name].Value.ToString() : strErrMsg.Trim() + ", " + selectedrows[i].Cells[colRefName_Avail.Name].Value.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errmsg_out = strErrMsg;
            return blStatus;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (folderBrowserDialog1.SelectedPath.ToString() != "")
                    {
                        txtFolderPath.Text = folderBrowserDialog1.SelectedPath.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
        
        ArrayList availTANList = new ArrayList();
        ArrayList selTANList = new ArrayList();
        DataTable dtselTans = null;

        private void btnSelOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAvailableRefs.Rows.Count > 0)
                {
                    if (dgvAvailableRefs.SelectedRows.Count > 0)
                    {
                        if (dtselTans == null)
                        {
                            dtselTans = AvailableRefsTbl.Clone();
                        }
                        int rindex_out = 0;

                        DataGridViewSelectedRowCollection selRowColl = dgvAvailableRefs.SelectedRows;
                        if (selRowColl != null && selRowColl.Count > 0)
                        {
                            ArrayList alstRowIDs = new ArrayList();

                            string strErrMsg_Out = "";
                            if (CheckReferenceStatusQCCompleted(selRowColl, out strErrMsg_Out))
                            {
                                //Check for Delivered Status
                                if (CheckForDeliveredReferences(selRowColl, out strErrMsg_Out))
                                {
                                    DialogResult diaRes = MessageBox.Show("Below References are delivered. Do you want to continue?\r\n" + strErrMsg_Out, GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (diaRes == System.Windows.Forms.DialogResult.No)
                                    {
                                        return;
                                    }
                                }

                                for (int i = 0; i < selRowColl.Count; i++)
                                {
                                    dtselTans.ImportRow(GetSelectedRowFromMainTable(selRowColl[i].Cells[0].Value.ToString(), out rindex_out));
                                    if (!alstRowIDs.Contains(rindex_out))
                                    {
                                        alstRowIDs.Add(rindex_out);
                                    }
                                }

                                if (alstRowIDs != null)
                                {
                                    if (alstRowIDs.Count > 0)
                                    {
                                        for (int i = 0; i < alstRowIDs.Count; i++)
                                        {
                                            if (AvailableRefsTbl.Rows.Count > Convert.ToInt32(alstRowIDs[i]))
                                            {
                                                AvailableRefsTbl.Rows[Convert.ToInt32(alstRowIDs[i])].Delete();
                                            }
                                        }
                                        AvailableRefsTbl.AcceptChanges();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Below References status is not Quality Check Completed:\r\n" + strErrMsg_Out, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        DataView dvTemp = dtselTans.DefaultView;
                        dvTemp.Sort = "REFERENCE_NAME asc";// "bt_id asc";
                        dtselTans = dvTemp.ToTable();

                        SelectedRefsTbl = dtselTans;

                        //Bind data to Selected TANs grid
                        BindDataToSelectedReferencesGrid(dtselTans);

                        //Bind data to Available TANs grid
                        BindDataToAvailableReferencesGrid(AvailableRefsTbl);

                        txtRefSearch.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnDelOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSelectedRefs.Rows.Count > 0)
                {
                    if (dgvSelectedRefs.SelectedRows.Count > 0)
                    {
                        DataTable dtAvailTans = AvailableRefsTbl;
                        int selrowIndx = 0;

                        DataGridViewSelectedRowCollection selRowColl = dgvSelectedRefs.SelectedRows;
                        if (selRowColl != null && selRowColl.Count > 0)
                        {
                            ArrayList alstRowIDs = new ArrayList();

                            for (int i = 0; i < selRowColl.Count; i++)
                            {
                                if (selRowColl[i].Cells[0].Value != null)
                                {
                                    DataRow dRow = GetSelectedRowFromSelectedTANSTable(selRowColl[i].Cells[0].Value.ToString(), out selrowIndx);
                                    if (dRow != null)
                                    {
                                        dtAvailTans.ImportRow(dRow);
                                        if (!alstRowIDs.Contains(selrowIndx))
                                        {
                                            alstRowIDs.Add(selrowIndx);
                                        }
                                    }
                                }
                            }

                            if (alstRowIDs != null)
                            {
                                if (alstRowIDs.Count > 0)
                                {
                                    for (int i = 0; i < alstRowIDs.Count; i++)
                                    {
                                        if (SelectedRefsTbl.Rows.Count >= Convert.ToInt32(alstRowIDs[i]))
                                        {
                                            SelectedRefsTbl.Rows[Convert.ToInt32(alstRowIDs[i])].Delete();
                                        }
                                    }
                                    SelectedRefsTbl.AcceptChanges();
                                }
                            }
                        }

                        DataView dvTemp = dtAvailTans.DefaultView;
                        dvTemp.Sort = "REFERENCE_NAME asc"; 
                        dtAvailTans = dvTemp.ToTable();  

                        AvailableRefsTbl = dtAvailTans;

                        //Bind data to Available TANs grid
                        BindDataToAvailableReferencesGrid(dtAvailTans);

                        //Bind data to Selected TANs grid
                        BindDataToSelectedReferencesGrid(SelectedRefsTbl);

                        txtRefSearch.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }       
      
        private void BindDataToAvailableReferencesGrid(DataTable availableRefs)
        {
            try
            {

                if (availableRefs != null)
                {
                    dgvAvailableRefs.AutoGenerateColumns = false;
                    dgvAvailableRefs.DataSource = availableRefs;

                    colShipmentRefID_Avail.DataPropertyName = "SHIPMENT_REF_ID";
                    colRefName_Avail.DataPropertyName = "REFERENCE_NAME";
                    colSysClassType_Avail.DataPropertyName = "SYS_CLASS_TYPE";
                    colRxnCnt_Avail.DataPropertyName = "REACTION_CNT";
                    colRefStatus_Avail.DataPropertyName = "TASK_STATUS";
                    colIsDelivered_Avail.DataPropertyName = "IS_DELIVERED";

                    lblAvlRefCnt.Text = dgvAvailableRefs.Rows.Count.ToString();
                }
                else
                {
                    dgvAvailableRefs.DataSource = availableRefs;
                    lblAvlRefCnt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDataToSelectedReferencesGrid(DataTable selectedRefs)
        {
            try
            {
                if (selectedRefs != null)
                {
                    dgvSelectedRefs.AutoGenerateColumns = false;
                    dgvSelectedRefs.DataSource = selectedRefs;

                    colRefID_Sel.DataPropertyName = "SHIPMENT_REF_ID";
                    colReference_Sel.DataPropertyName = "REFERENCE_NAME";
                    colSysClassType_Sel.DataPropertyName = "SYS_CLASS_TYPE";
                    
                    colRxnCnt_Sel.DataPropertyName = "REACTION_CNT";                   
                    colRefStatus_Sel.DataPropertyName = "TASK_STATUS";
                    colIsDelivered_Sel.DataPropertyName = "IS_DELIVERED";

                    lblSelRefCnt.Text = dgvSelectedRefs.Rows.Count.ToString();
                }
                else
                {
                    dgvSelectedRefs.DataSource = selectedRefs;
                    lblSelRefCnt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDataToRdfReferecnesGrid(DataTable rdfRefs)
        {
            try
            {
                if (rdfRefs != null)
                {
                    dgvRDFRefs.AutoGenerateColumns = false;
                    dgvRDFRefs.DataSource = rdfRefs;

                    colRefID_RDF.DataPropertyName = "SHIPMENT_REF_ID";
                    colReference_RDF.DataPropertyName = "REFERENCE_NAME";                   
                    colRxnCnt_RDF.DataPropertyName = "REACTION_CNT";
                    colShipment_RDF.DataPropertyName = "SHIPMENT_NAME";
                    colSysClassType_Rdf.DataPropertyName = "SYS_CLASS_TYPE";
                    colRefStatus_RDF.DataPropertyName = "TASK_STATUS";
                    colIsDelivered_Rdf.DataPropertyName = "IS_DELIVERED";  
                    lblRdfRefCnt.Text = dgvRDFRefs.Rows.Count.ToString();
                }
                else
                {
                    dgvRDFRefs.DataSource = null;
                    lblRdfRefCnt.Text = dgvRDFRefs.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void GetStatusValues_BindToControls(DataTable shipmentRefs)
        {
            try
            {
                if (shipmentRefs != null)
                {
                    if (shipmentRefs.Rows.Count > 0)
                    {
                        //Curation Completed
                        DataView dv_Cur = shipmentRefs.Copy().DefaultView;
                        dv_Cur.RowFilter = "TASK_STATUS = 'Curation Completed'";
                        DataTable dt_Cur = dv_Cur.ToTable();
                        if (dt_Cur != null)
                        {
                            lblCur_Done_Cnt.Text = dt_Cur.Rows.Count.ToString();
                        }

                        //Review Completed
                        DataView dv_Rev = shipmentRefs.Copy().DefaultView;
                        dv_Rev.RowFilter = "TASK_STATUS = 'Review Completed'";
                        DataTable dt_Rev = dv_Rev.ToTable();
                        if (dt_Rev != null)
                        {
                            lblRev_Done_Cnt.Text = dt_Rev.Rows.Count.ToString();
                        }

                        //QC Completed
                        DataView dv_QC = shipmentRefs.Copy().DefaultView;
                        dv_QC.RowFilter = "TASK_STATUS = 'QC - COMPLETED'";
                        DataTable dt_QC = dv_QC.ToTable();
                        if (dt_QC != null)
                        {
                            lblQC_Done_Cnt.Text = dt_QC.Rows.Count.ToString();
                        }

                        //Assigned for Curation
                        DataView dv_AC = shipmentRefs.Copy().DefaultView;
                        dv_AC.RowFilter = "TASK_STATUS = 'CURATION - ASSIGNED'";
                        DataTable dt_AC = dv_AC.ToTable();
                        if (dt_AC != null)
                        {
                            lblAssCur_Cnt.Text = dt_AC.Rows.Count.ToString();
                        }

                        //Assigned for Review
                        DataView dv_AR = shipmentRefs.Copy().DefaultView;
                        dv_AR.RowFilter = "TASK_STATUS = 'REVIEW - ASSIGNED'";
                        DataTable dt_AR = dv_AR.ToTable();
                        if (dt_AR != null)
                        {
                            lblAssRev_Cnt.Text = dt_AR.Rows.Count.ToString();
                        }

                        //Assigned for Quality Check
                        DataView dv_AQC = shipmentRefs.Copy().DefaultView;
                        dv_AQC.RowFilter = "TASK_STATUS = 'QC - ASSIGNED'";
                        DataTable dt_AQC = dv_AQC.ToTable();
                        if (dt_AQC != null)
                        {
                            lblAssQC_Cnt.Text = dt_AQC.Rows.Count.ToString();
                        }

                        //Re-Assigned for Quality Check
                        DataView dv_RAQC = shipmentRefs.Copy().DefaultView;
                        dv_RAQC.RowFilter = "TASK_STATUS = 'Re-Assigned for Quality Check'";
                        DataTable dt_RAQC = dv_RAQC.ToTable();
                        if (dt_RAQC != null)
                        {
                            lblReAssQC_Cnt.Text = dt_RAQC.Rows.Count.ToString();
                        }

                        //Re-Assigned for Review
                        DataView dv_RAR = shipmentRefs.Copy().DefaultView;
                        dv_RAR.RowFilter = "TASK_STATUS = 'Re-Assigned for Review'";
                        DataTable dt_RAR = dv_RAR.ToTable();
                        if (dt_RAR != null)
                        {
                            lblReAssRev_Cnt.Text = dt_RAR.Rows.Count.ToString();
                        }

                        //Re-Assigned for Curation
                        DataView dv_RAC = shipmentRefs.Copy().DefaultView;
                        dv_RAC.RowFilter = "TASK_STATUS = 'Re-Assigned for Curation'";
                        DataTable dt_RAC = dv_RAC.ToTable();
                        if (dt_RAC != null)
                        {
                            lblReAssCur_Cnt.Text = dt_RAC.Rows.Count.ToString();
                        }

                        ////Freezed TANs
                        //DataView dv_FT = batchtansdata.Copy().DefaultView;
                        //dv_FT.RowFilter = "tan_freezed = true";
                        //DataTable dt_FT = dv_FT.ToTable();
                        //if (dt_FT != null)
                        //{
                        //    lblFreezeTAN_Cnt.Text = dt_FT.Rows.Count.ToString();
                        //}


                        ////Pending TANs
                        //DataView dv_Pend = batchtansdata.Copy().DefaultView;
                        //dv_Pend.RowFilter = "status = 'Pending'";
                        //DataTable dt_Pend = dv_Pend.ToTable();
                        //if (dt_Pend != null)
                        //{
                        //    lblPending_Val.Text = dt_Pend.Rows.Count.ToString();
                        //}

                        ////No.of Reactions
                        //object objRxnCnt = batchtansdata.Compute("sum([No.of Reactions])", "[No.of Reactions] is not null");
                        //if (objRxnCnt != null)
                        //{
                        //    lblRxns_Val.Text = objRxnCnt.ToString();
                        //}

                        ////No.of Extra Stages
                        //object objStgCnt = batchtansdata.Compute("sum([No.of Extra Stages])", "[No.of Extra Stages] is not null");
                        //if (objStgCnt != null)
                        //{
                        //    lblStages_Val.Text = objStgCnt.ToString();
                        //}

                        ////No.of TANs
                        //lblTANCnt.Text = batchtansdata.Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private DataRow GetSelectedRowFromMainTable(string _refName, out int _rowindex_out)
        {
            try
            {
                if (AvailableRefsTbl != null)
                {
                    if (AvailableRefsTbl.Rows.Count > 0)
                    {
                        DataRow dtRow = null;
                        for (int i = 0; i < AvailableRefsTbl.Rows.Count; i++)
                        {
                            if (AvailableRefsTbl.Rows[i]["SHIPMENT_REF_ID"].ToString() == _refName)
                            {
                                dtRow = AvailableRefsTbl.Rows[i];
                                _rowindex_out = i;
                                return dtRow;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            _rowindex_out = 0;
            return null;
        }

        private DataRow GetSelectedRowFromSelectedTANSTable(string _refName, out int _rowindex_out)
        {
            try
            {
                if (SelectedRefsTbl != null)
                {
                    if (SelectedRefsTbl.Rows.Count > 0)
                    {
                        DataRow dtRow = null;
                        for (int i = 0; i < SelectedRefsTbl.Rows.Count; i++)
                        {
                            if (SelectedRefsTbl.Rows[i].RowState != DataRowState.Deleted)
                            {
                                if (SelectedRefsTbl.Rows[i]["SHIPMENT_REF_ID"].ToString() == _refName)
                                {
                                    dtRow = SelectedRefsTbl.Rows[i];
                                    _rowindex_out = i;
                                    return dtRow;
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
            _rowindex_out = 0;
            return null;
        }

        private void txtRefSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AvailableRefsTbl != null)
                {
                    if (txtRefSearch.Text.Trim() != "")
                    {
                        string strFCond = GetFilterCondition(txtRefSearch.Text.Trim());

                        DataTable dtAllTANs = AvailableRefsTbl.Copy();
                        DataView dvTemp = dtAllTANs.DefaultView;
                        dvTemp.RowFilter = strFCond;
                        DataTable dtTANs = dvTemp.ToTable();
                        dgvAvailableRefs.DataSource = dtTANs;
                    }
                    else
                    {
                        DataTable dtAllTANs = AvailableRefsTbl.Copy();
                        dgvAvailableRefs.DataSource = dtAllTANs;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private string GetFilterCondition(string queryRef)
        {
            string strFCond = "";
            try
            {
                if (queryRef.Trim().Contains(";"))
                {
                    string[] splitter = { ";" };
                    string[] strArrTans = queryRef.Trim().Split(splitter, StringSplitOptions.RemoveEmptyEntries);

                    if (strArrTans != null)
                    {
                        if (strArrTans.Length > 0)
                        {
                            for (int i = 0; i < strArrTans.Length; i++)
                            {
                                if (i == 0)
                                {
                                    strFCond = "REFERENCE_NAME Like '" + strArrTans[i] + "%' ";
                                }
                                else
                                {
                                    strFCond += " OR" + " REFERENCE_NAME Like '" + strArrTans[i] + "%'";
                                }
                            }
                        }
                    }
                }
                else
                {
                    strFCond = "REFERENCE_NAME Like '" + queryRef.Trim() + "%'";
                }
                return strFCond;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strFCond;
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {

                string strErrMsg = "";
                //Validate Doc Class for ENP_BF & ENP_FF & ENJ
                if (ValidateShipmentYearInSelectedRefs(out strErrMsg))
                {
                    string strTAN = "";
                    for (int i = 0; i < dgvSelectedRefs.Rows.Count; i++)
                    {
                        strTAN = "";
                        if (ReferencesForRDF == null)
                        {
                            ReferencesForRDF = new DataTable();
                            ReferencesForRDF.Columns.Add("SHIPMENT_REF_ID", typeof(int));
                            ReferencesForRDF.Columns.Add("REFERENCE_NAME");                           
                            ReferencesForRDF.Columns.Add("REACTION_CNT");
                            ReferencesForRDF.Columns.Add("SHIPMENT_NAME");
                            ReferencesForRDF.Columns.Add("SYS_CLASS_TYPE");        
                            ReferencesForRDF.Columns.Add("TASK_STATUS");
                            ReferencesForRDF.Columns.Add("IS_DELIVERED");   
                        }

                        strTAN = dgvSelectedRefs.Rows[i].Cells[colReference_Sel.Name].Value.ToString().Trim(); 

                        //Check if TAN already exist in the Table
                        if (!CheckForRowInXmlTANsTable(strTAN))
                        {
                            DataRow dRow = ReferencesForRDF.NewRow();
                            dRow["SHIPMENT_REF_ID"] = Convert.ToInt32(dgvSelectedRefs.Rows[i].Cells[colRefID_Sel.Name].Value.ToString());
                            dRow["REFERENCE_NAME"] = strTAN;                           
                            dRow["REACTION_CNT"] = dgvSelectedRefs.Rows[i].Cells[colRxnCnt_Sel.Name].Value.ToString();
                            dRow["SYS_CLASS_TYPE"] = dgvSelectedRefs.Rows[i].Cells[colSysClassType_Sel.Name].Value.ToString();
                            dRow["SHIPMENT_NAME"] = strShipmentName;                           
                            dRow["TASK_STATUS"] = dgvSelectedRefs.Rows[i].Cells[colRefStatus_Sel.Name].Value;
                            dRow["IS_DELIVERED"] = dgvSelectedRefs.Rows[i].Cells[colIsDelivered_Sel.Name].Value;
                            
                            ReferencesForRDF.Rows.Add(dRow);
                        }
                        else
                        {
                            strErrMsg = string.IsNullOrEmpty(strErrMsg) ? strTAN : strErrMsg + ", " + strTAN;
                        }
                    }

                    if (strErrMsg.Trim() != "")
                    {
                        MessageBox.Show("Below References already exist in the RDF references grid.\r\n" + strErrMsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    SelectedRefsTbl = null;
                    dtselTans = null;
                    BindDataToSelectedReferencesGrid(SelectedRefsTbl);

                    //Bind Data to RDF Shipments grid
                    BindDataToRdfReferecnesGrid(ReferencesForRDF);
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

        private bool ValidateShipmentYearInSelectedRefs(out string errmsg_out)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                //if (dgvSelectedRefs.Rows.Count > 0)//dgvXmlTANs 
                //{
                //    DataTable dtSelectedTANs = dgvSelectedRefs.DataSource as DataTable;
                //    if (dtSelectedTANs != null)
                //    {
                //        string[] saDocCol = { "Doc_Class" };
                //        DataTable dttemp = dtSelectedTANs.DefaultView.ToTable(true, saDocCol);

                //        List<string> list = (from row in dttemp.AsEnumerable()
                //                             select row.Field<string>("Doc_Class")).ToList<string>();

                //        if (list != null)
                //        {
                //            if (list.Count > 1)
                //            {
                //                blStatus = false;
                //                strErrMsg = "Selected TANs contain mismatched Doc Class.";
                //            }
                //            else //Check with already appended tans
                //            {
                //                if (ReferencesForRDF != null)
                //                {                                   
                //                    dttemp = ReferencesForRDF.DefaultView.ToTable(true, saDocCol);

                //                    List<string>  lstDC_Xml = (from row in dttemp.AsEnumerable()
                //                                         select row.Field<string>("Doc_Class")).ToList<string>();
                //                    if (lstDC_Xml != null)
                //                    {
                //                        if (!CompareListsForMatch(list, lstDC_Xml))
                //                        {
                //                            blStatus = false;
                //                            strErrMsg = "Selected TANs contain mismatched Doc Class.";
                //                        }
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errmsg_out = strErrMsg;
            return blStatus;
        }

        private bool CompareListsForMatch(List<string> tans_sel, List<string> tans_xml)
        {
            return tans_sel.TrueForAll(tans_xml.Contains) && tans_xml.TrueForAll(tans_sel.Contains);
        }
        
        private bool CheckForRowInXmlTANsTable(string refName)
        {
            bool blStatus = false;           
            try
            {
                if (!string.IsNullOrEmpty(refName))
                {
                    if (ReferencesForRDF != null)
                    {
                        if (ReferencesForRDF.Rows.Count > 0)
                        {
                            for (int i = 0; i < ReferencesForRDF.Rows.Count; i++)
                            {
                                if (ReferencesForRDF.Rows[i]["REFERENCE_NAME"].ToString() == refName)
                                {
                                    blStatus = true;
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

        private void ReSetStatusValues()
        {
            try
            {
                dgvAvailableRefs.DataSource = null;
                dgvSelectedRefs.DataSource = null;
                dgvRDFRefs.DataSource = null;

                lblRdfRefCnt.Text = "0";
                lblAvlRefCnt.Text = "0";
                lblSelRefCnt.Text = "0";
                lblCur_Done_Cnt.Text = "0";
                lblRev_Done_Cnt.Text = "0";
                lblQC_Done_Cnt.Text = "0";

                lblAssQC_Cnt.Text = "0";
                lblAssRev_Cnt.Text = "0";
                lblAssCur_Cnt.Text = "0";

                lblReAssQC_Cnt.Text = "0";
                lblReAssRev_Cnt.Text = "0";
                lblReAssCur_Cnt.Text = "0";                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #region Grid Row Post Paint Events

        private void dgTANs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvAvailableRefs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvAvailableRefs.Font);

                if (dgvAvailableRefs.RowHeadersWidth < (int)(size.Width + 20)) dgvAvailableRefs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvSelectedTANs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvSelectedRefs.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvSelectedRefs.Font);

                if (dgvSelectedRefs.RowHeadersWidth < (int)(size.Width + 20)) dgvSelectedRefs.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void dgvXmlTANs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        #endregion        
                
        private bool ValidateMarkup_ExcessPdfFiles(string markupPdfsPath, DataTable batchTANs, out string errMsgOut)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (!string.IsNullOrEmpty(markupPdfsPath) && batchTANs != null)
                {
                    //Get TANs list from table
                    List<string> lstTANs = batchTANs.Rows.Cast<DataRow>()
                                            .Select(row => row["tan"].ToString())
                                            .ToList();

                    List<string> lstPdfs = GetDistinctTANsFromFolder(markupPdfsPath);

                    if (lstTANs != null && lstPdfs != null)
                    {
                        if (lstTANs.Count > 0 || lstPdfs.Count > 0)
                        {
                            //No Markups pdfs list
                            var noMarkups = lstTANs.Except(lstPdfs);

                            //Excess Markup pdfs list
                            var excessPdfs = lstPdfs.Except(lstTANs);

                            string noMarkup = "";
                            string excessPdf = "";

                            if (noMarkups != null)
                            {
                                if (noMarkups.Count() > 0)
                                {
                                    blStatus = false;

                                    noMarkup = String.Join(", ", noMarkups.ToArray());
                                    strErrMsg = "No markup pdfs available for the below TANs:\r\n" + noMarkup.Trim();
                                }
                            }
                            if (excessPdfs != null)
                            {
                                if (excessPdfs.Count() > 0)
                                {
                                    blStatus = false;

                                    excessPdf = String.Join(", ", excessPdfs.ToArray());
                                    strErrMsg = strErrMsg.Trim() + "\r\n" + "Excess pdfs in the Markups path:\r\n" + excessPdf.Trim();
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
            errMsgOut = strErrMsg;
            return blStatus;
        }

        private static List<string> GetDistinctTANsFromFolder(string pdfFolderPath)
        {
            List<string> lstTANs = null;
            try
            {
                if (!string.IsNullOrEmpty(pdfFolderPath))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(pdfFolderPath);
                    FileInfo[] faFiles = dirInfo.GetFiles("*.pdf", SearchOption.TopDirectoryOnly);
                    if (faFiles != null)
                    {
                        lstTANs = new List<string>();
                        //Filename format is TAN_Markup_N.pdf
                        foreach (FileInfo f in faFiles)
                        {
                            string[] saFileNames = f.Name.Split(new char[] { '_' });
                            if (saFileNames != null)
                            {
                                if (saFileNames.Length > 0)
                                {
                                    if (!string.IsNullOrEmpty(saFileNames[0].Trim().Replace(".pdf", "")))
                                    {
                                        if (!lstTANs.Contains(saFileNames[0].Trim().Replace(".pdf", "")))
                                        {
                                            lstTANs.Add(saFileNames[0].Trim().Replace(".pdf", ""));
                                        }
                                    }
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
    }
}
