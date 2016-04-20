using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.UserControls;
using ChemInform.Common;
using ChemInform.Dal;
using chemaxon.struc;
using chemaxon.reaction;
using chemaxon.util;
using chemaxon.marvin.modules;
using chemaxon.formats;
using System.Text.RegularExpressions;
using ChemInform.Export;
using System.IO;
using System.Diagnostics;
using MDL.Draw.Modules.Editor;
using MDL.Draw.StructureConversion;

namespace ChemInform
{
    public partial class frmReactionCuration_Journal : Form
    {
        #region Constructor

        public frmReactionCuration_Journal()
        {
            InitializeComponent();
        }

        #endregion

        #region Public variables

        public DataTable ReactionsTable { get; set; }
        public DataTable ReactionRefData { get; set; }
        public DataTable CrossRefData { get; set; }

        private DataTable _dtProducts = new DataTable();
        private DataTable _dtRxnSteps = new DataTable();
        private DataTable _dtRxnRef = new DataTable();
        private DataTable _dtCrossRef = new DataTable();
        private DataTable _dtConditions = new DataTable();
        private DataTable _dtParticipants = new DataTable();

        bool blEditCrossRef = false;
        int crossRefEditRowIndx = -1;
        int rxnRefEditRowIndx = -1;
        bool blEditRef = false;
      
        public bool blEditProduct = false;
        public int editRowIndxProduct = -1;

        public int ShipmentRefID { get; set; }
        public int ReactionId { get; set; }
        public string AbstractRefNo { get; set; }
        public int TaskID { get; set; }
        public int TaskAllocationID { get; set; }
        public string ShipmentYear { get; set; }
        
        #endregion
                
        private void FrmReactionCuration_Load(object sender, EventArgs e)
        {
            try
            {                            
                if (ShipmentRefID > 0)
                {                                       
                    
                    GlobalVariables.ShipmentRefID = ShipmentRefID;

                    this.WindowState = FormWindowState.Maximized;
                    numGoToRxn.Enabled = false;

                    //Get Master details and bind to master controls
                    GetFullArticleDetailsAndBindToControls();

                    //Hide buttons on User Role
                    HideButtonsOnUserRole(GlobalVariables.RoleName);
                                        
                    ////Get Shipment Reference info                       
                    //DataTable dtRefDtls = ShipmentManagementDB.GetReferenceDetailsOnRefID(ShipmentRefID);
                    //BindReferenceDetailsToControls(dtRefDtls);

                    //Get Document Reactions on DocumentID
                    ReactionInfo objReactionInfo = new ReactionInfo();
                    objReactionInfo.ShipmentRefID = ShipmentRefID;
                    DataTable dtReaction = new DataTable();
                    ReactionCurationDB.SaveReactionInfo(DmlOperations.SELECT, objReactionInfo, out dtReaction);
                    ReactionsTable = dtReaction;
                    BindReactionsTreeView();
                    
                    MaxRxnCnt = ReactionsTable.Rows.Count;
                    if (numGoToRxn.Maximum > 0)
                    {
                        numGoToRxn.Select();
                        numGoToRxn.Enabled = true;
                    }

                    //Disable UpDown buttons
                    numGoToRxn.Controls[0].Enabled = false;
                    blValidRxn = true;

                    numGoToRxn.Maximum = MaxRxnCnt;
                    currRxnIndex = 1;
                    numGoToRxn.Minimum = 1;
                    numGoToRxn.Value = currRxnIndex;

                    #region Code commented
                    //objReactionInfo.ReactionSNo = Convert.ToInt32(dtReaction.Rows[0]["REACTION_SNO"]);
                    //objReactionInfo.DocID = Convert.ToInt32(dtReaction.Rows[0]["DOC_ID"]);
                    //objReactionInfo.ReactionScheme = Convert.ToString(dtReaction.Rows[0]["REACTION_SCHEME"]);

                    //ChemRenditor.Preferences.AtomAtomDisplayMode = MDL.Draw.Renderer.Preferences.AtomAtomMappingDisplayMode.On;
                    //ChemRenditor.MolfileString = Convert.ToString(dtReaction.Rows[0]["REACTION_SCHEME"]);

                    //ReactionId = 1;//TODO: remove reaction id.
                    //txtRxnSNo.Text = Convert.ToString(objReactionInfo.ReactionSNo);
                    //DocId = Convert.ToInt32(objReactionInfo.DocID);

                    ////TODO: Reaction scheme- Convert.ToString(objReactionInfo.ReactionScheme);
                    //LoadProducts();
                    //LoadReactionRefs();
                    //LoadCrossRefs();
                    //LoadReactionSteps(); 
                    #endregion
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void HideButtonsOnUserRole(string userRole)
        {
            try
            {
                if (!string.IsNullOrEmpty(userRole))
                {
                    //btnRejectTAN.Visible = false;
                    btnRefComplete.Visible = false;
                    chkRxnComplete.Visible = false;

                    if ((userRole.ToUpper() == RolesMaster.ANALYST.ToUpper() || userRole.ToUpper() == RolesMaster.REV_ANALYST.ToUpper()
                        || userRole.ToUpper() == RolesMaster.QC_ANALYST.ToUpper()) && TaskID > 0)
                    {
                        //btnRejectTAN.Visible = userRole.ToUpper() == RolesMaster.ANALYST.ToUpper() ? false : true;
                        btnRefComplete.Visible = true;
                        chkRxnComplete.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
               
        private void BindReactionsTreeView()
        {
            try
            {
                if (ReactionsTable != null)
                {
                    //Clear Nodes, if any
                    tvReactions.Nodes.Clear();

                    if (ReactionsTable.Rows.Count > 0)
                    {
                        tvReactions.Nodes.Add(AbstractRefNo);

                        TreeNode tnRxn = null;

                        for (int i = 0; i < ReactionsTable.Rows.Count; i++)
                        {
                            tnRxn = new TreeNode();

                            tnRxn.Name = ReactionsTable.Rows[i]["REACTION_ID"].ToString();
                            tnRxn.Tag = ReactionsTable.Rows[i]["REACTION_ID"].ToString();
                            tnRxn.ToolTipText = ReactionsTable.Rows[i]["REACTION_SNO"].ToString();
                            tnRxn.Text = ReactionsTable.Rows[i]["REACTION_SNO"].ToString(); 

                            if (GlobalVariables.RoleName.ToUpper() == RolesMaster.ANALYST.ToUpper())
                            {
                                tnRxn.ImageIndex = !string.IsNullOrEmpty(ReactionsTable.Rows[i]["CURATED_BY"].ToString()) ? 0 : 1;
                            }
                            if (GlobalVariables.RoleName.ToUpper() == RolesMaster.REV_ANALYST.ToUpper())
                            {                                
                                tnRxn.ImageIndex = !string.IsNullOrEmpty(ReactionsTable.Rows[i]["REVIEWED_BY"].ToString()) ? 0 : 1;
                            }
                            if (GlobalVariables.RoleName.ToUpper() == RolesMaster.QC_ANALYST.ToUpper())
                            {                                
                                tnRxn.ImageIndex = !string.IsNullOrEmpty(ReactionsTable.Rows[i]["QC_BY"].ToString()) ? 0 : 1;
                            }

                            tvReactions.Nodes[0].Nodes.Add(tnRxn);
                        }
                    }
                    tvReactions.ExpandAll();                    
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindReferenceDetailsToControls(DataTable refDetails)
        {
            try
            {
                if (refDetails != null)
                {
                    txtYear.Text = refDetails.Rows[0]["SYS_NO"].ToString();
                    txtJournalName.Text = refDetails.Rows[0]["SYS_TEXT"].ToString();
                    txtVolume.Text = refDetails.Rows[0]["REFERENCE_NAME"].ToString();

                    ShipmentYear = refDetails.Rows[0]["SHIPMENT_YEAR"].ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void GetFullArticleDetailsAndBindToControls()
        {
            try
            {
                if (objFullArtInfo == null)
                {
                    objFullArtInfo = new FullArticleInfo();
                }
                objFullArtInfo.ShipmentRefID = ShipmentRefID;

                DataTable dtArticleInfo = ReactionCurationDB.SaveFullArticleInfo(objFullArtInfo);

                if (dtArticleInfo != null && dtArticleInfo.Rows.Count > 0)
                {
                    objFullArtInfo.ArticleType = dtArticleInfo.Rows[0]["REFERENCE_TYPE"].ToString();
                    objFullArtInfo.JournalDOI = dtArticleInfo.Rows[0]["DOI"].ToString();
                    objFullArtInfo.JournalName = dtArticleInfo.Rows[0]["JOURNAL_NAME"].ToString();
                    objFullArtInfo.JournalRefNo = dtArticleInfo.Rows[0]["REFERENCE_NAME"].ToString();
                    objFullArtInfo.JournalVolume = dtArticleInfo.Rows[0]["VOLUME"].ToString();
                    int journalYear = 0;
                    int.TryParse(dtArticleInfo.Rows[0]["JOURNAL_YEAR"].ToString(), out journalYear);
                    objFullArtInfo.JournalYear = journalYear;
                    objFullArtInfo.JournalStartPage = dtArticleInfo.Rows[0]["START_PAGE"].ToString();
                    objFullArtInfo.JournalEndPage = dtArticleInfo.Rows[0]["END_PAGE"].ToString();
                   
                    //Bind Article info to controls
                    BindJournalInfoToControls(objFullArtInfo);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindJournalInfoToControls(FullArticleInfo fullArtInfo)
        {
            try
            {
                if (fullArtInfo != null)
                {
                    txtDOI.Text = objFullArtInfo.JournalDOI;
                    txtJournalName.Text = objFullArtInfo.JournalName;
                    txtVolume.Text = objFullArtInfo.JournalVolume;
                    txtYear.Text = objFullArtInfo.JournalYear.ToString();
                    txtStartPage.Text = objFullArtInfo.JournalStartPage;
                    txtEndPage.Text = objFullArtInfo.JournalEndPage;
                    txtRefNo.Text = objFullArtInfo.JournalRefNo;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void LoadReactionSteps()
        {
            try
            {
                if (ReactionId != 0)
                {
                    StepInfo objStepInfo = new StepInfo();
                    objStepInfo.ReactionID = ReactionId;
                    ReactionCurationDB.SaveReactionStepsInfo(DmlOperations.SELECT, objStepInfo, out _dtCrossRef);
                    if (_dtCrossRef != null)
                    {
                        if (_dtCrossRef.Rows.Count > 0)
                        {
                            tcRxnSteps.Controls.Clear();
                            for (int i = 0; i < _dtCrossRef.Rows.Count; i++)
                            {
                                string title = "Step " + (tcRxnSteps.TabCount + 1).ToString();
                                TabPage tpNewStep = new TabPage(title);

                                ucRxnParticipants objucRxnCuration = new ucRxnParticipants();
                                objucRxnCuration.ReactionID = ReactionId;
                                objucRxnCuration.StepID = Convert.ToInt32(_dtCrossRef.Rows[i]["RXN_STEP_ID"]);
                                objucRxnCuration.Yield = Convert.ToString(_dtCrossRef.Rows[i]["YIELD"]);
                                objucRxnCuration.SerialNo = Convert.ToInt32(_dtCrossRef.Rows[i]["RXN_STEP_SNO"]);
                                objucRxnCuration.Dock = DockStyle.Fill;
                                tpNewStep.Controls.Add(objucRxnCuration);
                                tcRxnSteps.TabPages.Add(tpNewStep);

                                DataTable dtParticipants = GetParticipants(ReactionId, objucRxnCuration.StepID);
                                if (dtParticipants != null)
                                {
                                    if (dtParticipants.Rows.Count > 0)
                                    {
                                        objucRxnCuration.BindDataToParticipantsGrid(dtParticipants);
                                    }

                                }
                                DataTable dtConditions = GetConditions(ReactionId, objucRxnCuration.StepID);
                                if (dtConditions != null)
                                {
                                    if (dtConditions.Rows.Count > 0)
                                    {
                                        objucRxnCuration.BindDataToConditionsGrid(dtConditions);
                                    }
                                }
                                //tcRxnSteps.SelectTab(tpNewStep);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
        }

        private DataTable GetConditions(int ReactionId, int StepId)
        {
            try
            {
                if (ReactionId != 0 && StepId != 0)
                {
                    ConditionInfo objConditions = new ConditionInfo();
                    objConditions.ReactionID = ReactionId;
                    objConditions.Option = DmlOperations.SELECT.ToString();
                    ReactionCurationDB.SaveReactionConditions(objConditions, out _dtConditions);
                    return _dtConditions;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return (new DataTable());
        }

        private DataTable GetParticipants(int ReactionId, int StepId)
        {
            try
            {
                if (ReactionId != 0)
                {
                    ParticipantInfo objParticipants = new ParticipantInfo();
                    objParticipants.ReactionID = ReactionId;
                    objParticipants.Option = DmlOperations.SELECT.ToString();
                    ReactionCurationDB.SaveReactionParticipants(objParticipants, out _dtParticipants);
                    return _dtParticipants;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return (new DataTable());
        }       
        
        public void RefreshProductsGrid()
        {
            //if (blEditProduct)
            {

                dgvProduct.ClearSelection();
                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.DataSource = null;
                colProductName.DataPropertyName = "Product";
                colProductStructNo.DataPropertyName = "StructNo";
                colProductCs.DataPropertyName = "CS";
                colProductDE.DataPropertyName = "DE";
                colProductDs.DataPropertyName = "DS";
                colProductEE.DataPropertyName = "EE";
                colProductYield.DataPropertyName = "Yield";
                //dgvproduct.DataSource = GlobalVariables.lstProductions;
                dgvProduct.RefreshEdit();
            }
        }

        private void newRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cntMnuAddNewRow.SourceControl.Name == "dgvproduct")
            {
                using (FrmEditProduct fProduct = new FrmEditProduct())
                {
                    fProduct.ShowDialog();
                }
                RefreshProductsGrid();
            }
        }

        private void btnAddRxnRef_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateRxnRefControls(ref strErrMsg))
                {
                    ReactionRefInfo objRxnRef = new ReactionRefInfo();
                    objRxnRef.ExtRegNo = !string.IsNullOrEmpty(txtExtRegNo.Text) ? Convert.ToInt32(txtExtRegNo.Text.Trim()) : 0;
                    objRxnRef.RefPath = txtRxnPath.Text.Trim();
                    objRxnRef.Step = txtStepInfo.Text.Trim();
                    objRxnRef.ReactionID = ReactionId;
                    objRxnRef.ReactionRefId = rxnRefEditRowIndx >= 0 ? Convert.ToInt32(dgvRxnRef.Rows[rxnRefEditRowIndx].Cells[colRxnRefID.Name].Value) : 0;
                    objRxnRef.Option = rxnRefEditRowIndx >= 0 ? DmlOperations.UPDATE.ToString() : DmlOperations.INSERT.ToString();
                    DataTable dtReferences = new DataTable();
                    
                    if (ReactionCurationDB.SaveReactionReference(objRxnRef, out dtReferences))
                    {
                        MessageBox.Show("Reference updated successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindDataToReactionReferenceGrid(dtReferences);

                        ResetRxnRefControls();

                    }
                    else
                    {
                        MessageBox.Show("Error accured in reference updated.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAddCrossRef_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateCrossRefControls(ref strErrMsg))
                {
                    CrossRefInfo objCrossRef = new CrossRefInfo();
                    objCrossRef.ReactionID = ReactionId;
                    objCrossRef.PrevReactionNo = txtPreRxn.Text.Trim();
                    objCrossRef.SuccReactionNo = txtSuccRxn.Text.Trim();                    
                    objCrossRef.CrossRefID = crossRefEditRowIndx >= 0 ? Convert.ToInt32(dgvCrossRef.Rows[crossRefEditRowIndx].Cells[colCrossRefID.Name].Value) : 0;
                    objCrossRef.Option = crossRefEditRowIndx >= 0 ? DmlOperations.UPDATE.ToString() : DmlOperations.INSERT.ToString();
                    
                    DataTable dtCrossRef = new DataTable();
                    if (ReactionCurationDB.SaveCrossReference(objCrossRef, out dtCrossRef))
                    {
                        MessageBox.Show("Cross reference saved successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Bind Cross Ref to Grid
                        BindDataToCrossReferenceGrid(dtCrossRef);

                        //Reset controls
                        ResetCrossRefControls();
                    }
                    else
                    {
                        MessageBox.Show("Error in cross reference update.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReactionId > 0)
                {
                    FrmEditProduct objEditProduct = new FrmEditProduct();
                    if (objEditProduct.ShowDialog() == DialogResult.OK)
                    {
                        if (objEditProduct.ProductData != null)
                        {
                            ProductInfo objProdInfo = objEditProduct.ProductData;
                            objProdInfo.ReactionID = ReactionId;
                            objProdInfo.Option = objProdInfo.ProductID == 0 ? DmlOperations.INSERT.ToString() : DmlOperations.UPDATE.ToString();
                            DataTable dtProducts = new DataTable();
                                                       
                            if (ReactionCurationDB.SaveReactionProduct(objProdInfo, out dtProducts))
                            {
                                MessageBox.Show("Product updated successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                BindDataToProductGrid(dtProducts);
                                blEditProduct = false;
                            }
                            else
                            {
                                MessageBox.Show("Error in product update.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Reaction must be there before adding Product", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        int MaxRxnCnt = 0;
        int currRxnIndex = 0;
        private void btnAddRxn_Click(object sender, EventArgs e)
        {
            try
            {       
                //New code added by Sairam on 5th Oct 2014
                //Validate and Save existing reation
                string errMsg = "";
                if (ValidateAndSaveCurrentReaction(ref errMsg))
                {
                    using (frmNewReaction frmNewRxn = new frmNewReaction())
                    {
                        frmNewRxn.ReactionsTbl = ReactionsTable;
                        frmNewRxn.CurrentRxnID = ReactionId;
                        frmNewRxn.ShipmentRefID = ShipmentRefID;

                        if (frmNewRxn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (!frmNewRxn.DuplicateRxn)//new reaction
                            {
                                ReactionsTable = frmNewRxn.ReactionsTbl;
                                BindReactionsTreeView();

                                #region Old code commented on 6th Nov 2014
                                ////Get new reactionID
                                //ReactionInfo rxnInfo = new ReactionInfo();
                                //rxnInfo.ShipmentRefID = ShipmentRefID;

                                //int rxnSNo = ReactionsTable != null ?  ReactionsTable.Rows.Count + 1 : 1;

                                //rxnInfo.ReactionSNo = rxnSNo;
                                //DataTable dtReactions = null;
                                //ReactionCurationDB.DmlReaction(DmlOperations.INSERT, rxnInfo, out dtReactions);                    
                                //ReactionsTable = dtReactions; 
                                #endregion

                                //Create one Step by default
                                DataTable dtRxnSteps = null;
                                StepInfo stpInfo = new StepInfo();
                                stpInfo.ReactionID = frmNewRxn.NewRxnID;
                                stpInfo.SerialNo = 1;
                                ReactionCurationDB.SaveReactionStepsInfo(DmlOperations.INSERT, stpInfo, out dtRxnSteps);
                            }
                            else//Duplicate reaction
                            {
                                ReactionInfo rxnInfo = new ReactionInfo();
                                rxnInfo.ShipmentRefID = ShipmentRefID;

                                DataTable dtReaction = new DataTable();
                                ReactionCurationDB.SaveReactionInfo(DmlOperations.SELECT, rxnInfo, out dtReaction);
                                ReactionsTable = dtReaction;

                                lblStatus.Text = "Reaction duplicated successfully";
                            }

                            //Clear existing Reaction data
                            ClearCurrentReactionControls();

                            MaxRxnCnt = ReactionsTable.Rows.Count;
                            numGoToRxn.Maximum = MaxRxnCnt;
                            numGoToRxn.Minimum = 1;

                            numGoToRxn.Value = frmNewRxn.NewRxnSNo;//(currRxnIndex + 1) < ReactionsTable.Rows.Count ? currRxnIndex + 1 : ReactionsTable.Rows.Count;
                            if (numGoToRxn.Value == currRxnIndex)
                            {
                                numGoToRxn_ValueChanged(null, null);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errMsg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ClearCurrentReactionControls()
        {
            try
            {
                RenditorRxnScheme.MolfileString = null;
                txtRxnSNo.Clear();
                _dtProducts = null;
                tcRxnSteps.TabPages.Clear();
                dgvCrossRef.DataSource = null;
                dgvRxnRef.DataSource = null;
                dgvProduct.DataSource = null;
            }
            catch (Exception ex)
            {
                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnDeleteRxn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReactionId > 0)
                {
                    DialogResult diaRes = MessageBox.Show("Do you want to delete the reaction?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes == DialogResult.Yes)
                    {
                        ReactionInfo rxnInfo = new ReactionInfo();
                        rxnInfo.ReactionID = ReactionId;
                        rxnInfo.ShipmentRefID = ShipmentRefID;
                        DataTable dtReactions = null;

                        if (ReactionCurationDB.SaveReactionInfo(DmlOperations.DELETE, rxnInfo, out dtReactions))
                        {
                            MessageBox.Show("Reaction deleted successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ReactionId = 0;//Reset ReactionID
                            //Refresh Reactions Table after Reaction deleted
                          
                            ReactionsTable = dtReactions;                            
                            BindReactionsTreeView();

                            MaxRxnCnt = ReactionsTable.Rows.Count;
                            numGoToRxn.Maximum = MaxRxnCnt;

                            if (currRxnIndex < MaxRxnCnt && currRxnIndex > 1)
                            {
                                currRxnIndex = currRxnIndex - 1;
                            }
                            else if (currRxnIndex == MaxRxnCnt && MaxRxnCnt > 1)
                            {
                                currRxnIndex = currRxnIndex; //currRecIndex - 1;
                                
                                //Call the event
                                numGoToRxn_ValueChanged(null, null);
                            }
                            else if (currRxnIndex < MaxRxnCnt && currRxnIndex == 1)
                            {
                                currRxnIndex = currRxnIndex + 1;
                            }
                            else if (currRxnIndex > MaxRxnCnt)//New condition on 13th Sep 2011
                            {
                                currRxnIndex = MaxRxnCnt;
                            }

                            blValidRxn = true;
                            numGoToRxn.Value = currRxnIndex;
                            btnAddReaction.Enabled = true;                
                        }
                        else
                        {
                            MessageBox.Show("Error in reaction delete", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void UpdateRowRefGrid(int editRowIndxRef)
        {
            int RowIndex = editRowIndxRef;
            dgvRxnRef.Rows[RowIndex].Cells["colExtReg"].Value = txtExtRegNo.Text;
            dgvRxnRef.Rows[RowIndex].Cells["colRxnPath"].Value = txtRxnPath.Text;
            dgvRxnRef.Rows[RowIndex].Cells["colRxnStep"].Value = txtMultiStep1.Text;
        }

        private void InsertIntoRefGrid()
        {
            dgvRxnRef.Rows.Add();
            int RowIndex = dgvRxnRef.Rows.Count - 1;
            dgvRxnRef.Rows[RowIndex].Cells["colExtReg"].Value = txtExtRegNo.Text;
            dgvRxnRef.Rows[RowIndex].Cells["colRxnPath"].Value = txtRxnPath.Text;
            dgvRxnRef.Rows[RowIndex].Cells["colRxnStep"].Value = txtMultiStep1.Text;
        }

        #region Validate Control Values

        private bool ValidateReactionData(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {
                if (ReactionsTable.Rows.Count > 0)
                {
                    if (string.IsNullOrEmpty(txtYear.Text.Trim()))
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "Journal Year can't be null";
                    }
                    if (string.IsNullOrEmpty(txtJournalName.Text.Trim()))
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "Journal Name can't be null";
                    }
                    if (string.IsNullOrEmpty(txtVolume.Text.Trim()))
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "Volume can't be null";
                    }

                    if (string.IsNullOrEmpty(txtDOI.Text.Trim()))
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "DOI can't be null";
                    }

                    if (string.IsNullOrEmpty(txtStartPage.Text.Trim()))
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "Start Page can't be null";
                    }

                    if (string.IsNullOrEmpty(txtEndPage.Text.Trim()))
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "End Page can't be null";
                    }

                    //Reaction Scheme
                    if (string.IsNullOrEmpty(RenditorRxnScheme.MolfileString))
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "Reaction Scheme can't be null";
                    }
                    else if (ChemistryOperations.CheckStructureIsInV3000Format(RenditorRxnScheme.MolfileString))
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "Reaction Scheme is in V3000 format";
                    }

                    //Products
                    if (dgvProduct.Rows.Count == 0)
                    {
                        blStatus = false;
                        errmsg_out += Environment.NewLine + "Product can't be null";
                    }                    
                }                
                
                //Reactants & Products reverse validation on 12th Nov 2014
                if (!string.IsNullOrEmpty(RenditorRxnScheme.MolfileString))
                {
                    DataTable dtRxnData = GetReactionDataFromReaction();            
                    string strRxnErr = "";
                    if (!ChemistryOperations.ValidateReactantsAndProductsWithReactionScheme(dtRxnData, RenditorRxnScheme.MolfileString, out strRxnErr))
                    {
                        errmsg_out += Environment.NewLine + strRxnErr;
                        blStatus = false;
                    }
                }

                //Check for duplicate reaction
                if (ShipmentRefID > 0 && !string.IsNullOrEmpty(txtRxnSNo.Text.Trim()))
                {
                    DataTable dupRxnData = ReactionCurationDB.CheckForDuplicateReaction(ShipmentRefID, Convert.ToInt32(txtRxnSNo.Text.Trim()));
                    if (dupRxnData != null && dupRxnData.Rows.Count > 0)
                    {
                        errmsg_out += Environment.NewLine + "Reaction duplicate with the Rxn S.No -" + dupRxnData.Rows[0][0].ToString();
                        blStatus = false;
                    }
                } 
 
                //Step Yeild '%' is not allowed - New validation on 10th March 2015
                if (!ValidateStepYield(ref errmsg_out))
                {
                    blStatus = false;
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        private bool ValidateStepYield(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {
                ucRxnParticipants ucPartpnt;              
                foreach (TabPage tp in tcRxnSteps.TabPages)
                {
                    ucPartpnt = tp.Controls[0] as ucRxnParticipants;
                    if (ucPartpnt != null)
                    {
                        if(ucPartpnt.txtStepYield.Text.Trim().Contains("%"))
                        {
                            errmsg_out += Environment.NewLine + "% is not allowed in the " + ucPartpnt.StepName + " Step Yield";
                            blStatus = false;
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

        private bool ValidatieReactionsCompleteStatus()
        {
            bool blStatus = true;
            try
            {
                if (ReactionsTable != null)
                {
                    if (ReactionsTable.Rows.Count > 0)
                    {
                        DataTable dtTemp = null;

                        #region Old code commented
                        //if (GlobalVariables.RoleName.ToUpper() == RolesMaster.ANALYST.ToUpper())
                        //{
                        //    var rows = TAN_Reactions.AsEnumerable()
                        //                 .Where(r => r.Field<Int64?>("CURATED_BY") == GlobalVariables.URID);
                        //    dtTemp = rows.Any() ? rows.CopyToDataTable() : TAN_Reactions.Clone();
                        //}
                        //else if (GlobalVariables.RoleName.ToUpper() == RolesMaster.REV_ANALYST.ToUpper())
                        //{
                        //    var rows = TAN_Reactions.AsEnumerable()
                        //                     .Where(r => r.Field<Int64?>("REVIEWED_BY") == GlobalVariables.URID);
                        //    dtTemp = rows.Any() ? rows.CopyToDataTable() : TAN_Reactions.Clone();
                        //}
                        //else if (GlobalVariables.RoleName.ToUpper() == RolesMaster.QC_ANALYST.ToUpper())
                        //{
                        //    var rows = TAN_Reactions.AsEnumerable()
                        //                     .Where(r => r.Field<Int64?>("QC_BY") == GlobalVariables.URID);
                        //    dtTemp = rows.Any() ? rows.CopyToDataTable() : TAN_Reactions.Clone();
                        //} 
                        #endregion

                        if (GlobalVariables.RoleName.ToUpper() == RolesMaster.ANALYST.ToUpper())
                        {
                            var rows = ReactionsTable.AsEnumerable()
                                         .Where(r => r.Field<Int64?>("CURATED_BY") == null);
                            dtTemp = rows.Any() ? rows.CopyToDataTable() : ReactionsTable.Clone();
                        }
                        else if (GlobalVariables.RoleName.ToUpper() == RolesMaster.REV_ANALYST.ToUpper())
                        {
                            var rows = ReactionsTable.AsEnumerable()
                                             .Where(r => r.Field<Int64?>("REVIEWED_BY") == null);
                            dtTemp = rows.Any() ? rows.CopyToDataTable() : ReactionsTable.Clone();
                        }
                        else if (GlobalVariables.RoleName.ToUpper() == RolesMaster.QC_ANALYST.ToUpper())
                        {
                            var rows = ReactionsTable.AsEnumerable()
                                             .Where(r => r.Field<Int64?>("QC_BY") == null);
                            dtTemp = rows.Any() ? rows.CopyToDataTable() : ReactionsTable.Clone();
                        }

                        int rowCnt = dtTemp != null ? dtTemp.Rows.Count : 0;
                        if (rowCnt > 0)
                        {
                            blStatus = false;
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

        private bool ValidateRxnRefControls(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {
                if (string.IsNullOrEmpty(txtExtRegNo.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Path No can't be null";
                }

                if (string.IsNullOrEmpty(txtRxnPath.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Reaction Path Label can't be null";
                }
                else if (!Regex.IsMatch(txtRxnPath.Text.Trim(), @"[A-Z]"))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Step should be A-Z";
                }

                if (string.IsNullOrEmpty(txtStepInfo.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Step Information can't be null";
                }                
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        private bool ValidateCrossRefControls(ref string errmsg_out)
        {
            bool blStatus = true;
            try
            {
                if (string.IsNullOrEmpty(txtRxnSNo.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Cross Ref Rxn No can't be null";
                }
                if (string.IsNullOrEmpty(txtPreRxn.Text.Trim()) && string.IsNullOrEmpty(txtSuccRxn.Text.Trim()))
                {
                    blStatus = false;
                    errmsg_out += "\r\n" + "Pre Reaction & Succ. Reaction can't be null";
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        #endregion

        #region Reset Control Values

        private void ResetCrossRefControls()
        {
            try
            {              
                txtPreRxn.Clear();
                txtSuccRxn.Clear();
                crossRefEditRowIndx = -1;
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ResetRxnRefControls()
        {
            try
            {
                txtExtRegNo.Clear();
                txtRxnPath.Clear();
                txtMultiStep1.Clear();

                rxnRefEditRowIndx = -1;
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        private bool DeleteRefRowFromTable(string strFieldVal)
        {
            throw new NotImplementedException();
        }

        private bool DeleteProductRowFromTable(int p)
        {
            throw new NotImplementedException();
        }

        #region Grid CellClick Events

        private void dgvRxnRef_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    ReactionRefInfo rxnRefInfo = new ReactionRefInfo();
                    if (dgvRxnRef.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        txtExtRegNo.Text = Convert.ToString(dgvRxnRef.Rows[e.RowIndex].Cells[colExtReg.Name].Value);
                        txtRxnPath.Text = Convert.ToString(dgvRxnRef.Rows[e.RowIndex].Cells[colRxnPath.Name].Value);
                        string strStepInfo = Convert.ToString(dgvRxnRef.Rows[e.RowIndex].Cells[colRxnStep.Name].Value);
                        
                        if (strStepInfo.ToUpper().Equals("1 STEP"))
                        {
                            txtStepInfo.Text = strStepInfo;
                            rbnSingleStep.Checked = true;
                        }
                        else
                        {
                            string[] saSteps = strStepInfo.ToUpper().Split(new string[] { "OF" }, StringSplitOptions.RemoveEmptyEntries);
                            if (saSteps.Length == 2)
                            {
                                rbnMultiStep.Checked = true;

                                txtMultiStep1.Text = saSteps[0].Trim();
                                txtMultiStep2.Text = saSteps[1].Trim();
                            }
                        }
                        

                        rxnRefEditRowIndx = e.RowIndex;
                        blEditRef = true;
                    }
                    else if (dgvRxnRef.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "DELETE")
                    {
                        rxnRefInfo.ReactionRefId = Convert.ToInt32(dgvRxnRef.Rows[e.RowIndex].Cells[colRxnRefID.Name].Value);
                        rxnRefInfo.ReactionID = ReactionId;
                        rxnRefInfo.Option = DmlOperations.DELETE.ToString();

                        if (MessageBox.Show("Do you want to delete this row ?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DataTable dtRef = new DataTable();
                            if (ReactionCurationDB.SaveReactionReference(rxnRefInfo, out dtRef))
                            {
                                MessageBox.Show("Deleted value successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BindDataToReactionReferenceGrid(dtRef);
                            }
                            else
                            {
                                MessageBox.Show("Error in deleting value", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvCrossRef_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    CrossRefInfo objCrossRefInfo = new CrossRefInfo();
                    if (dgvCrossRef.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "EDIT")
                    {
                        //txtRxnSNo.Text = (string)dgvCrossRef.Rows[e.RowIndex].Cells["colId"].Value;
                        txtPreRxn.Text = dgvCrossRef.Rows[e.RowIndex].Cells["colCrossRefPreRxn"].Value.ToString();
                        txtSuccRxn.Text = dgvCrossRef.Rows[e.RowIndex].Cells["colCrossRefSuccRxn"].Value.ToString();

                        crossRefEditRowIndx = e.RowIndex;
                        blEditCrossRef = true;
                    }
                    else if (dgvCrossRef.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "DELETE")
                    {
                        if (MessageBox.Show("Do you want to delete this row ?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            objCrossRefInfo.ReactionID = ReactionId;
                            objCrossRefInfo.CrossRefID = Convert.ToInt32(dgvCrossRef.Rows[e.RowIndex].Cells["colCrossRefID"].Value.ToString());
                            objCrossRefInfo.Option = DmlOperations.DELETE.ToString(); 
                            DataTable dtCrossRef = new DataTable();

                            if (ReactionCurationDB.SaveCrossReference(objCrossRefInfo, out dtCrossRef))
                            {
                                MessageBox.Show("Deleted value successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BindDataToCrossReferenceGrid(dtCrossRef);
                            }
                            else
                            {
                                MessageBox.Show("Error in deleting value", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cntMnuAddNewRow.Show(dgvProduct, new Point(e.X, e.Y));
            }
        }

        private bool DeleteCrossRefRowFromTable(string strFieldVal)
        {
            throw new NotImplementedException();
        }

        private void btnCrossRefAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMsg = "";
                if (ValidateCrossRefControls(ref strErrMsg))
                {
                    if (blEditCrossRef)
                    {
                        UpdateRowCrossRef(crossRefEditRowIndx);
                    }
                    else
                    {
                        InsertIntoCrossRef();
                    }
                    ResetCrossRefControls();
                }
                else
                {
                    MessageBox.Show(strErrMsg, "Reaction Data Curation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }

        }

        private void InsertIntoCrossRef()
        {
            try
            {
                dgvCrossRef.Rows.Add();
                int RowIndex = dgvCrossRef.Rows.Count - 1;
                dgvCrossRef.Rows[RowIndex].Cells["colId"].Value = txtRxnSNo.Text;
                dgvCrossRef.Rows[RowIndex].Cells["colPreRxn"].Value = txtPreRxn.Text;
                dgvCrossRef.Rows[RowIndex].Cells["colSuccRxn"].Value = txtSuccRxn.Text;
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void UpdateRowCrossRef(int editRowIndxNmr)
        {
            try
            {
                int RowIndex = editRowIndxNmr;
                dgvCrossRef.Rows[RowIndex].Cells["colId"].Value = txtRxnSNo.Text;
                dgvCrossRef.Rows[RowIndex].Cells["colPreRxn"].Value = txtPreRxn.Text;
                dgvCrossRef.Rows[RowIndex].Cells["colSuccRxn"].Value = txtSuccRxn.Text;
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void tbSteps_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    cntMnuAddNewStep.Show(tcRxnSteps, new Point(e.X, e.Y));
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void addStepTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                #region Kranthi code commented by Sairam on 7th Oct 2014
                //string title = "Step " + (tcRxnSteps.TabCount + 1).ToString();
                //TabPage tpNewStep = new TabPage(title);

                //ucRxnParticipants objucRxnCuration = new ucRxnParticipants();
                //objucRxnCuration.Dock = DockStyle.Fill;

                //tpNewStep.Controls.Add(objucRxnCuration);
                //tcRxnSteps.TabPages.Add(tpNewStep);
                //tcRxnSteps.SelectTab(tpNewStep);
                //StepInfo objStepInfo = new StepInfo();
                //objStepInfo.ReactionID = ReactionId;
                //DataTable dtStepRef = new DataTable();
                //if (ReactionCurationDB.DmlReactionSteps(DmlOperations.INSERT, objStepInfo, out dtStepRef))
                //{
                //    MessageBox.Show("Step added successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Error accured in adding step.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //LoadReactionSteps(); 
                #endregion

                if (ReactionId > 0 && tcRxnSteps.TabCount >= 1)
                {
                    StepInfo objStepInfo = new StepInfo();
                    objStepInfo.ReactionID = ReactionId;
                    objStepInfo.SerialNo = tcRxnSteps.TabCount + 1;
                    DataTable dtRxnSteps = new DataTable();
                    if (ReactionCurationDB.SaveReactionStepsInfo(DmlOperations.INSERT, objStepInfo, out dtRxnSteps))
                    {
                        if (dtRxnSteps != null)
                        {
                            if (dtRxnSteps.Rows.Count > 0)
                            {
                                int newStageID = Convert.ToInt32(dtRxnSteps.Rows[dtRxnSteps.Rows.Count - 1]["RXN_STEP_ID"]);

                                TabPage tp = null;
                                int tabindex = tcRxnSteps.SelectedIndex;

                                string strStgName = "Stage " + (tabindex + 1).ToString();
                                tp = new TabPage(strStgName);
                                tcRxnSteps.TabPages.Insert(tabindex + 1, tp);

                                ucRxnParticipants ucRxnPartpnt = new ucRxnParticipants();
                                ucRxnPartpnt.Dock = DockStyle.Fill;
                                ucRxnPartpnt.AutoScroll = true;

                                ucRxnPartpnt.StepName = "Step " + (tcRxnSteps.TabCount + 1).ToString();
                                ucRxnPartpnt.StepID = newStageID;
                                ucRxnPartpnt.ReactionID = ReactionId;

                                tp.Controls.Add(ucRxnPartpnt);
                                tcRxnSteps.SelectTab(tp);

                                //Reset Tabpage text
                                ResetTabPageText();
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

        private void deleteStepTSMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcRxnSteps.TabCount > 1)
                {
                    TabPage tpSelected = tcRxnSteps.SelectedTab;
                    if (tpSelected != null)
                    {
                        DialogResult diaRes = MessageBox.Show("Do you want to delete the step?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (diaRes == DialogResult.Yes)
                        {
                            ucRxnParticipants ucParpnts = (ucRxnParticipants)tpSelected.Controls[0];
                            if (ucParpnts != null)
                            {
                                int intStageID = ucParpnts.StepID;
                                if (intStageID > 0)
                                {
                                    StepInfo objStepInfo = new StepInfo();
                                    objStepInfo.ReactionID = ReactionId;
                                    objStepInfo.StepID = intStageID;
                                    DataTable dtStepRef = new DataTable();
                                    if (ReactionCurationDB.SaveReactionStepsInfo(DmlOperations.DELETE, objStepInfo, out dtStepRef))
                                    {
                                        MessageBox.Show("Step deleted successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tcRxnSteps.TabPages.Remove(tpSelected);

                                        ResetTabPageText();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error accured in step deletion.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            #region Kranthi code commented
                            //tcRxnSteps.TabPages.Remove(tpSelected);
                            //StepInfo objStepInfo = new StepInfo();
                            //objStepInfo.ReactionID = ReactionId;

                            //for (int i = 0; i < tpSelected.Controls.Count; i++)
                            //{
                            //    Control c = tpSelected.Controls[i];
                            //    if (c.GetType().BaseType.Name.ToString().ToUpper() == "USERCONTROL")
                            //    {
                            //        ucRxnParticipants uc = (ucRxnParticipants)c;
                            //        objStepInfo.StepID = uc.StepID;
                            //        DataTable dtStepRef = new DataTable();
                            //        if (ReactionCurationDB.DmlReactionSteps(DmlOperations.DELETE, objStepInfo, out dtStepRef))
                            //        {
                            //            MessageBox.Show("Step deleted successfully.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //        }
                            //        else
                            //        {
                            //            MessageBox.Show("Error accured in step deletion.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //        }
                            //        LoadReactionSteps();
                            //    }
                            //} 
                            #endregion
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ResetTabPageText()
        {
            try
            {
                if (tcRxnSteps.TabPages.Count >= 1)
                {
                    ucRxnParticipants ucprt = null;
                    for (int i = 0; i < tcRxnSteps.TabPages.Count; i++)
                    {
                        tcRxnSteps.TabPages[i].Text = "Stage " + (i + 1);
                        ucprt = (ucRxnParticipants)tcRxnSteps.TabPages[i].Controls["ucParticipants"];
                        if (ucprt != null)
                        {
                            ucprt.StepName = "Stage " + (i + 1);
                        }
                    }
                    tcRxnSteps.Refresh();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCurrentReaction();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        FullArticleInfo objFullArtInfo;
        private void SaveCurrentReaction()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string strErrMsg = "";
                if (ValidateReactionData(ref strErrMsg))
                {
                    //Save Full Article details
                    objFullArtInfo = new FullArticleInfo();
                    objFullArtInfo.ShipmentRefID = ShipmentRefID;
                    objFullArtInfo.JournalDOI = txtDOI.Text.Trim();
                    objFullArtInfo.JournalName = txtJournalName.Text.Trim();
                    objFullArtInfo.JournalVolume = txtVolume.Text.Trim();
                    objFullArtInfo.ArticleType = "JOURNAL";
                    objFullArtInfo.JournalRefNo = txtRefNo.Text.Trim();
                    int journalYear = 0;
                    int.TryParse(txtYear.Text.Trim(), out journalYear);
                    objFullArtInfo.JournalYear = journalYear;

                    objFullArtInfo.JournalStartPage = txtStartPage.Text.Trim();
                    objFullArtInfo.JournalEndPage = txtEndPage.Text.Trim();
                    DataTable dtArticleInfo = ReactionCurationDB.SaveFullArticleInfo(objFullArtInfo);

                    //Bind Full Article info to controls
                    BindJournalInfoToControls(objFullArtInfo);                    

                    //Save Step Yield
                    if (SaveReactionStepYield())
                    {
                        ReactionInfo rxnInfo = new ReactionInfo();
                        rxnInfo.ShipmentRefID = ShipmentRefID;
                        rxnInfo.ReactionID = ReactionId;
                        rxnInfo.ReactionScheme = RenditorRxnScheme.MolfileString;
                        rxnInfo.ReactionSNo = !string.IsNullOrEmpty(txtRxnSNo.Text.Trim()) ? Convert.ToInt32(txtRxnSNo.Text.Trim()) : 1;
                        rxnInfo.RxnComments = txtRxnComments.Text.Trim();
                        
                        //string atomMapType = rbnAutoMapping.Checked ? "AUTO" : "MANUAL";
                        rxnInfo.AtomMappingType = rbnAutoMapping.Checked ? "AUTO" : "MANUAL";

                        rxnInfo.UR_ID = GlobalVariables.UR_ID;
                        rxnInfo.RoleName = GlobalVariables.RoleName;

                        //Reaction complete status
                        rxnInfo.RxnCompleteStatus = chkRxnComplete.Checked && chkRxnComplete.Enabled ? "Y" : "N";
                        rxnInfo.IsImportantRxn = chkImpReaction.Checked ? "Y" : "N";
                        
                        DataTable dtReaction = new DataTable();
                        if (ReactionCurationDB.SaveReactionInfo(DmlOperations.UPDATE, rxnInfo, out dtReaction))
                        {
                            lblStatus.Text = "Reaction saved successfully";
                            ReactionsTable = dtReaction;

                            //Refresh Reactions Treeview
                            BindReactionsTreeView();

                            Cursor = Cursors.Default;
                        }
                        else
                        {
                            lblStatus.Text = "Error in saving reaction";
                            Cursor = Cursors.Default;
                        }
                    }
                    else
                    {
                        lblStatus.Text = "Error in saving reaction step yield";
                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
                Cursor = Cursors.Default;
            }
        }

        private bool SaveReactionStepYield()
        {
            bool blStatus = true;
            try
            {
                ucRxnParticipants ucPartpnt;
                DataTable dtRxnSteps = null;
                StepInfo objStepInfo = null;
                foreach (TabPage tp in tcRxnSteps.TabPages)
                {
                    ucPartpnt = tp.Controls[0] as ucRxnParticipants;
                    if (ucPartpnt != null)
                    {
                        objStepInfo = new StepInfo();
                        objStepInfo.ReactionID = ReactionId;
                        objStepInfo.StepYield = ucPartpnt.txtStepYield.Text.Trim();
                        objStepInfo.StepID = ucPartpnt.StepID;
                        //objStepInfo.SerialNo = ucPartpnt.st
                        dtRxnSteps = new DataTable();
                        if (!ReactionCurationDB.SaveReactionStepsInfo(DmlOperations.UPDATE, objStepInfo, out dtRxnSteps))
                        {
                            blStatus = false;
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

        private bool ValidateAndSaveCurrentReaction(ref string errMsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (ValidateReactionData(ref strErrMsg))
                {
                    //Save Step Yield
                    if (!SaveReactionStepYield())
                    {
                        strErrMsg = "Error in saving reaction steps";
                        blStatus = false;
                        return blStatus;
                    }

                    ReactionInfo rxnInfo = new ReactionInfo();
                    rxnInfo.ShipmentRefID = ShipmentRefID;
                    rxnInfo.ReactionID = ReactionId;
                    rxnInfo.ReactionScheme = RenditorRxnScheme.MolfileString;
                    rxnInfo.ReactionSNo = !string.IsNullOrEmpty(txtRxnSNo.Text.Trim()) ? Convert.ToInt32(txtRxnSNo.Text.Trim()) : 1;
                    rxnInfo.RxnComments = txtRxnComments.Text.Trim();

                    //Reaction Mapping type
                    string atomMapType = rbnAutoMapping.Checked ? "AUTO" : "MANUAL";
                    rxnInfo.AtomMappingType = atomMapType;

                    rxnInfo.UR_ID = GlobalVariables.UR_ID;
                    rxnInfo.RoleName = GlobalVariables.RoleName;
                    //Reaction complete status
                    rxnInfo.RxnCompleteStatus = chkRxnComplete.Checked && chkRxnComplete.Enabled ? "Y" : "N";
                    rxnInfo.IsImportantRxn = chkImpReaction.Checked ? "Y" : "N";

                    DataTable dtReaction = new DataTable();
                    if (ReactionCurationDB.SaveReactionInfo(DmlOperations.UPDATE, rxnInfo, out dtReaction))
                    {
                        ReactionsTable = dtReaction;
                    }
                    else
                    {
                        strErrMsg = "Error in saving existing reaction";
                        blStatus = false;
                    }
                }
                else
                {
                    errMsg = strErrMsg;
                    blStatus = false;
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            errMsg = strErrMsg;
            return blStatus;
        }

        #region Navigation Controls Events

        private void GetReactionParticipants_ProductsOnReactionID(int reactionID)
        {
            try
            {
                if (reactionID > 0)
                {
                    //Reaction Products
                    DataTable dtProduct = null;
                    ProductInfo prodInfo = new ProductInfo();
                    prodInfo.ReactionID = reactionID;
                    prodInfo.Option = DmlOperations.SELECT.ToString();
                    ReactionCurationDB.SaveReactionProduct(prodInfo, out dtProduct);
                    _dtProducts = dtProduct;

                    //Reactions Steps
                    DataTable dtSteps = null;
                    StepInfo stepsInfo = new StepInfo();
                    stepsInfo.ReactionID = reactionID;
                    ReactionCurationDB.SaveReactionStepsInfo(DmlOperations.SELECT, stepsInfo, out dtSteps);
                    _dtRxnSteps = dtSteps;

                    //Reaction Reference
                    DataTable dtRxnRef = null;
                    ReactionRefInfo rxnRefInfo = new ReactionRefInfo();
                    rxnRefInfo.ReactionID = reactionID;
                    rxnRefInfo.Option = DmlOperations.SELECT.ToString();
                    ReactionCurationDB.SaveReactionReference(rxnRefInfo, out dtRxnRef);
                    _dtRxnRef = dtRxnRef;
                    
                    //Cross Reference
                    DataTable dtCrossRef = null;
                    CrossRefInfo crossRefInfo = new CrossRefInfo();
                    crossRefInfo.ReactionID = reactionID;
                    crossRefInfo.Option = DmlOperations.SELECT.ToString();
                    ReactionCurationDB.SaveCrossReference(crossRefInfo, out dtCrossRef);
                    _dtCrossRef = dtCrossRef;

                    //Reaction Participants
                    DataTable dtParticipants = null;
                    ParticipantInfo patpnInfo = new ParticipantInfo();
                    patpnInfo.ReactionID = reactionID;
                    patpnInfo.Option = DmlOperations.SELECT.ToString();
                    ReactionCurationDB.SaveReactionParticipants(patpnInfo, out dtParticipants);
                    _dtParticipants = dtParticipants;

                    //Reaction Conditions
                    DataTable dtConds = null;
                    ConditionInfo condInfo = new ConditionInfo();
                    condInfo.ReactionID = reactionID;
                    condInfo.Option = DmlOperations.SELECT.ToString();
                    ReactionCurationDB.SaveReactionConditions(condInfo, out dtConds);
                    _dtConditions = dtConds;
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            } 
        }

        bool blValidRxn = false;
        private void numGoToRxn_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (blValidRxn)
                {
                    if (numGoToRxn.Value > 0 && currRxnIndex > 0 && ReactionsTable != null && ReactionsTable.Rows.Count > 0)
                    {
                        Cursor = Cursors.WaitCursor;                        
                       
                        currRxnIndex = Convert.ToInt32(numGoToRxn.Value);

                        ReactionId = Convert.ToInt32(ReactionsTable.Rows[currRxnIndex - 1]["REACTION_ID"]);
                            
                        //Get Reaction data on ReactionID
                        DataTable dtRxnData = ReactionCurationDB.GetReactionDataOnReactionID(ReactionId);
                        if (dtRxnData != null)
                        {
                            RenditorRxnScheme.Preferences.AtomAtomDisplayMode = MDL.Draw.Renderer.Preferences.AtomAtomMappingDisplayMode.On;
                            RenditorRxnScheme.MolfileString = dtRxnData.Rows[0]["REACTION_SCHEME"].ToString();
                            txtRxnSNo.Text = dtRxnData.Rows[0]["REACTION_SNO"].ToString();
                            txtRxnComments.Text = dtRxnData.Rows[0]["RXN_COMMENTS"].ToString();

                            string atomMapType = dtRxnData.Rows[0]["RXN_MAPPING_TYPE"].ToString();
                            if (atomMapType.ToUpper() == "AUTO")
                            {
                                rbnAutoMapping.Checked = true;
                            }
                            else if (atomMapType.ToUpper() == "MANUAL")
                            {
                                rbnManualMapping.Checked = true;
                            }

                            //Important reaction
                            chkImpReaction.Checked = dtRxnData.Rows[0]["IS_IMPORTANT"].ToString() == "Y" ? true : false;
                            
                            //Get Reaction Products/Paticipants/Steps/RxnRef/CrossRef/Conditions
                            GetReactionParticipants_ProductsOnReactionID(ReactionId);

                            //Bind Product Data
                            if (_dtProducts != null)
                            {
                                BindDataToProductGrid(_dtProducts);
                            }

                            //Bind Reaction Reference Data
                            if (_dtRxnRef != null)
                            {
                                BindDataToReactionReferenceGrid(_dtRxnRef);
                            }

                            //Bind Cross Reference Data
                            if (_dtCrossRef != null)
                            {
                                BindDataToCrossReferenceGrid(_dtCrossRef);
                            }

                            //Create Reaction Steps
                            CreateReactionStepsAndBindDataToUserControl();

                            //Show Total No.of Reactions with current Reaction index
                            lblRxnCnt.Text = currRxnIndex + " / " + numGoToRxn.Maximum.ToString();
                            lblRxnCnt.Refresh();

                            lblStatus.Text = "";

                            chkRxnComplete.Enabled = true;
                            chkRxnComplete.Checked = false;

                            //New feature on 10th Dec 2014
                            if (GlobalVariables.RoleName.ToUpper() == "ANALYST")
                            {
                                if (!string.IsNullOrEmpty(dtRxnData.Rows[0]["CURATED_BY"].ToString()))
                                {
                                    chkRxnComplete.Checked = true;
                                    chkRxnComplete.Enabled = false;
                                }
                            }
                            if (GlobalVariables.RoleName.ToUpper() == "REVIEW ANALYST")
                            {
                                if (!string.IsNullOrEmpty(dtRxnData.Rows[0]["REVIEWED_BY"].ToString()))
                                {
                                    chkRxnComplete.Checked = true;
                                    chkRxnComplete.Enabled = false;
                                }
                            }
                            else if (GlobalVariables.RoleName.ToUpper() == "QUALITY ANALYST")
                            {
                                if (!string.IsNullOrEmpty(dtRxnData.Rows[0]["QC_BY"].ToString()))
                                {
                                    chkRxnComplete.Checked = true;
                                    chkRxnComplete.Enabled = false;
                                }
                            }

                            //Select Node In The TreeView
                            SelectReactionNodeInTheTreeView(currRxnIndex - 1);

                            Cursor = Cursors.Default;
                        }
                    }
                    else
                    {
                        _dtProducts = null;
                        dgvProduct.DataSource = null;
                        tcRxnSteps.TabPages.Clear();

                        //Show Total No.of Reactions with current Reaction index
                        lblRxnCnt.Text = currRxnIndex + " / " + numGoToRxn.Maximum.ToString();
                        lblRxnCnt.Refresh();

                        if (ReactionsTable.Rows.Count == 0)
                        {
                            lblRxnCnt.Text = "0 / 0";
                            lblRxnCnt.Refresh();                            
                        }

                        lblStatus.Text = "";

                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    //Show Total No.of Reactions with current Reaction index
                    lblRxnCnt.Text = currRxnIndex + " / " + numGoToRxn.Maximum.ToString();
                    lblRxnCnt.Refresh();

                    if (ReactionsTable.Rows.Count == 0)
                    {
                        lblRxnCnt.Text = "0 / 0";
                        lblRxnCnt.Refresh();                       
                    }

                    lblStatus.Text = "";

                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void numGoToRxn_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)//On Enter click
                {
                    string strErrMSg = "";
                    blValidRxn = false;

                    if (ValidateAndSaveCurrentReaction(ref strErrMSg))
                    {
                        blValidRxn = true;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(strErrMSg.Trim()))
                        {
                            MessageBox.Show("Errors in the Reaction. Clear the below errors before moving to another reaction\r\n\r\n" + strErrMSg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Handled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void CreateReactionStepsAndBindDataToUserControl()
        {
            try
            {                
                if (_dtRxnSteps != null)
                {
                    if (_dtRxnSteps.Rows.Count > 0)
                    {
                        int stageID = 0;
                        ucRxnParticipants ucParpnt = null;
                        TabPage tPage = null;
                        DataTable dtParpnts = null;
     
                        int stgIndx = 0;
                        for (stgIndx = 0; stgIndx < _dtRxnSteps.Rows.Count; stgIndx++)
                        {
                            if (stgIndx < tcRxnSteps.TabPages.Count)
                            {
                                if (tcRxnSteps.TabPages[stgIndx].Controls.Count > 0)
                                {
                                    tcRxnSteps.TabPages[stgIndx].Text = "Stage " + (stgIndx + 1);
                                    ucParpnt = (ucRxnParticipants)tcRxnSteps.TabPages[stgIndx].Controls[0];

                                    stageID = Convert.ToInt32(_dtRxnSteps.Rows[stgIndx][0]);

                                    dtParpnts = _dtParticipants.Copy();

                                    string strFilterCond = "RXN_STEP_ID = " + stageID + "";
                                    string strSort = "PRPNT_ID asc";

                                    //Participants
                                    DataView dvPartpnt = dtParpnts.DefaultView;
                                    dvPartpnt.RowFilter = strFilterCond;
                                    dvPartpnt.Sort = strSort;
                                    dtParpnts = dvPartpnt.ToTable();

                                    //Conditions                                  
                                    DataView dvConds = _dtConditions.DefaultView;
                                    dvConds.RowFilter = strFilterCond;
                                    //dvConds.Sort = strSort;
                                    DataTable dtConds = dvConds.ToTable();

                                    ucParpnt.StepID = stageID;
                                    ucParpnt.StepName = "Stage " + (stgIndx + 1);
                                    ucParpnt.ReactionID = ReactionId;
                                    ucParpnt.txtStepYield.Text = _dtRxnSteps.Rows[stgIndx]["YIELD"].ToString();
                                    ucParpnt.BindDataToParticipantsGrid(dtParpnts);
                                    ucParpnt.BindDataToConditionsGrid(dtConds);

                                    tcRxnSteps.TabPages[stgIndx].Refresh();                                    
                                }
                                else
                                {
                                    tcRxnSteps.TabPages[stgIndx].Text = "Stage " + (stgIndx + 1);
                                    stageID = Convert.ToInt32(_dtRxnSteps.Rows[stgIndx][0]);

                                    ucParpnt = new ucRxnParticipants();
                                    ucParpnt.Dock = DockStyle.Fill;
                                    ucParpnt.AutoScroll = true;
                                    ucParpnt.StepID = stageID;
                                    ucParpnt.StepName = "Stage " + (stgIndx + 1);
                                    ucParpnt.ReactionID = ReactionId;
                                    ucParpnt.txtStepYield.Text = _dtRxnSteps.Rows[stgIndx]["YIELD"].ToString();
                                    dtParpnts = _dtParticipants.Copy();

                                    string strFilterCond = "RXN_STEP_ID = " + stageID + "";
                                    string strSort = "PRPNT_ID asc";

                                    DataView dvPartpnt = dtParpnts.DefaultView;
                                    dvPartpnt.RowFilter = strFilterCond;
                                    dvPartpnt.Sort = strSort;
                                    dtParpnts = dvPartpnt.ToTable();

                                    //Conditions                                  
                                    DataView dvConds = _dtConditions.DefaultView;
                                    dvConds.RowFilter = strFilterCond;
                                   // dvConds.Sort = strSort;
                                    DataTable dtConds = dvConds.ToTable();

                                    ucParpnt.BindDataToParticipantsGrid(dtParpnts);
                                    ucParpnt.BindDataToConditionsGrid(dtConds);

                                    tcRxnSteps.TabPages[stgIndx].Controls.Add(ucParpnt);                                    
                                }
                            }
                            else if (stgIndx > tcRxnSteps.TabPages.Count - 1)
                            {
                                tPage = new TabPage("Stage " + (stgIndx + 1));
                                stageID = Convert.ToInt32(_dtRxnSteps.Rows[stgIndx][0]);

                                ucParpnt = new ucRxnParticipants();
                                ucParpnt.Dock = DockStyle.Fill;
                                ucParpnt.AutoScroll = true;
                                ucParpnt.StepID = stageID;
                                ucParpnt.StepName = "Stage " + (stgIndx + 1);
                                ucParpnt.ReactionID = ReactionId;
                                ucParpnt.txtStepYield.Text = _dtRxnSteps.Rows[stgIndx]["YIELD"].ToString();

                                dtParpnts = _dtParticipants.Copy();

                                string strFilterCond = "RXN_STEP_ID = " + stageID + "";
                                string strSort = "PRPNT_ID asc";

                                DataView dvPartpnt = dtParpnts.DefaultView;
                                dvPartpnt.RowFilter = strFilterCond;
                                dvPartpnt.Sort = strSort;
                                dtParpnts = dvPartpnt.ToTable();

                                //Conditions                                  
                                DataView dvConds = _dtConditions.DefaultView;
                                dvConds.RowFilter = strFilterCond;
                                //dvConds.Sort = strSort;
                                DataTable dtConds = dvConds.ToTable();

                                ucParpnt.BindDataToParticipantsGrid(dtParpnts);
                                ucParpnt.BindDataToConditionsGrid(dtConds);

                                tPage.Controls.Add(ucParpnt);
                                tcRxnSteps.TabPages.Add(tPage);                                
                            }
                        }

                        //Delete if more stages are there previously
                        if (stgIndx < tcRxnSteps.TabPages.Count)
                        {
                            do
                            {
                                tcRxnSteps.TabPages.RemoveAt(stgIndx);
                            }
                            while (stgIndx != tcRxnSteps.TabPages.Count);
                        }

                        //Default selected tab is tabpage1
                        tcRxnSteps.SelectTab(tcRxnSteps.TabPages[0]);
                        tcRxnSteps.Refresh();                       
                    }
                    else //No Stages are available
                    {                      
                        tcRxnSteps.TabPages.Clear();
                        MessageBox.Show("No Stages are available", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnFirstRxn_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMSg = "";             
                blValidRxn = false;

                if (ValidateAndSaveCurrentReaction(ref strErrMSg))
                {
                    blValidRxn = true;

                    currRxnIndex = 1;
                    numGoToRxn.Value = currRxnIndex;                    
                }
                else
                {
                    if (!string.IsNullOrEmpty(strErrMSg.Trim()))
                    {
                        MessageBox.Show("Errors in the Reaction. Clear the below errors before moving to other reaction\r\n\r\n" + strErrMSg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnPrevRxn_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMSg = "";
                blValidRxn = false;

                if (ValidateAndSaveCurrentReaction(ref strErrMSg))
                {
                    blValidRxn = true;
                    if (currRxnIndex <= MaxRxnCnt && currRxnIndex > 1)
                    {
                        currRxnIndex = (currRxnIndex - 1);
                    }
                    numGoToRxn.Value = currRxnIndex;                  
                }
                else
                {
                    if (!string.IsNullOrEmpty(strErrMSg.Trim()))
                    {
                        MessageBox.Show("Errors in the Reaction. Clear the below errors before moving to other reaction\r\n\r\n" + strErrMSg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnNextRxn_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMSg = "";                
                blValidRxn = false;

                if (ValidateAndSaveCurrentReaction(ref strErrMSg))
                {
                    blValidRxn = true;

                    if (currRxnIndex < MaxRxnCnt)
                    {
                        currRxnIndex = currRxnIndex + 1;
                    }
                    else if (currRxnIndex == MaxRxnCnt)
                    {
                        currRxnIndex = MaxRxnCnt;
                    }
                    numGoToRxn.Value = currRxnIndex;                    
                }
                else
                {
                    if (!string.IsNullOrEmpty(strErrMSg.Trim()))
                    {
                        MessageBox.Show("Errors in the Reaction. Clear the below errors before moving to other reaction\r\n\r\n" + strErrMSg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnLastRxn_Click(object sender, EventArgs e)
        {
            try
            {
                string strErrMSg = "";               
                blValidRxn = false;

                if (ValidateAndSaveCurrentReaction(ref strErrMSg))
                {
                    blValidRxn = true;

                    currRxnIndex = MaxRxnCnt;
                    numGoToRxn.Value = currRxnIndex;
                }
                else
                {
                    if (!string.IsNullOrEmpty(strErrMSg.Trim()))
                    {
                        MessageBox.Show("Errors in the Reaction. Clear the below errors before moving to other reaction\r\n\r\n" + strErrMSg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Bind data to Grids using BindingSource

        BindingSource bsProduct;
        private void BindDataToProductGrid(DataTable dtProducts)
        {
            try
            {
                if (dtProducts != null)
                {
                    if (dtProducts.Rows.Count > 0)
                    {
                        if (bsProduct == null)
                        {
                            bsProduct = new BindingSource();
                            bsProduct.AllowNew = true;
                        }
                       
                        _dtProducts = dtProducts;
                        bsProduct.DataSource = dtProducts;

                        colProductID.DataPropertyName = "PRODUCT_ID";
                        colProductName.DataPropertyName = "PRODUCT_NAME";
                        colProductCs.DataPropertyName = "CHEMO_SELECTIVITY";
                        colProductDE.DataPropertyName = "DIASTEREOMERIC_EXCESS";
                        colProductDs.DataPropertyName = "DIASTEREO_SELECTIVITY";
                        colProductEE.DataPropertyName = "ENANTIOMERIC_EXCESS";
                        colProductStructure.DataPropertyName = "PROD_STRUCTURE";                       
                        colProductStructNo.DataPropertyName = "STRUCTURE_NO";
                        colProductYield.DataPropertyName = "YIELD";
                        colInchiKey.DataPropertyName = "INCHI_KEY";
                        colGrade.DataPropertyName = "GRADE";
                        dgvProduct.AutoGenerateColumns = false;
                        dgvProduct.DataSource = bsProduct;
                    }
                    else
                    {
                        productRenderer.MolfileString = "";

                        dgvProduct.AutoGenerateColumns = false;
                        dgvProduct.DataSource = dtProducts;
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        BindingSource bsRxnRef;
        private void BindDataToReactionReferenceGrid(DataTable dtReferences)
        {
            try
            {
                if (dtReferences != null)
                {
                    if (bsRxnRef == null)
                    {
                        bsRxnRef = new BindingSource();
                        bsRxnRef.AllowNew = true;
                    }

                    bsRxnRef.DataSource = dtReferences;

                    colRxnRefID.DataPropertyName = "RR_ID";
                    colRxnPath.DataPropertyName = "RR_PATH";
                    colRxnStep.DataPropertyName = "STEP";
                    colExtReg.DataPropertyName = "EXT_REG_NO";

                    dgvRxnRef.AutoGenerateColumns = false;
                    dgvRxnRef.DataSource = bsRxnRef;


                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        BindingSource bsCrossRef;
        private void BindDataToCrossReferenceGrid(DataTable dtCrossRef)
        {
            try
            {
                if (dtCrossRef != null)
                {
                    if (dtCrossRef.Rows.Count > 0)
                    {
                        if (bsCrossRef == null)
                        {
                            bsCrossRef = new BindingSource();
                            bsCrossRef.AllowNew = true;
                        }

                        bsCrossRef.DataSource = dtCrossRef;

                        colCrossRefID.DataPropertyName = "CR_ID";
                        colCrossRefPreRxn.DataPropertyName = "PRE_RXN_SNO";
                        colCrossRefSuccRxn.DataPropertyName = "SUCC_RXN_SNO";

                        dgvCrossRef.AutoGenerateColumns = false;
                        dgvCrossRef.DataSource = bsCrossRef;
                    }
                    else
                    {
                        dgvCrossRef.AutoGenerateColumns = false;
                        dgvCrossRef.DataSource = null;
                    }

                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        #endregion

        #region Grid PostPaint Events

        private void dgvProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string strRowNumber = (e.RowIndex + 1).ToString();

                while (strRowNumber.Length < dgvProduct.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

                SizeF size = e.Graphics.MeasureString(strRowNumber, dgvProduct.Font);

                if (dgvProduct.RowHeadersWidth < (int)(size.Width + 20)) dgvProduct.RowHeadersWidth = (int)(size.Width + 20);

                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

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

        private void txtRxnExtRegNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.General.AllowOnlyNumbers(e);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void txtPreRxn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.General.AllowOnlyNumbers(e);
        }

        private void txtSuccRxn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.General.AllowOnlyNumbers(e);
        }

        private DataTable GetReactionDataFromReaction()
        {
            DataTable dtRxnData = null;
            try
            {
                if (_dtProducts != null)
                {
                    dtRxnData = new DataTable();
                    dtRxnData.Columns.Add("PRPNT_TYPE", typeof(string));
                    dtRxnData.Columns.Add("PRPNT_STRUCTURE", typeof(object));

                    foreach (DataRow drow in _dtProducts.Rows)
                    {
                        DataRow dr = dtRxnData.NewRow();
                        dr["PRPNT_TYPE"] = "PRODUCT";
                        dr["PRPNT_STRUCTURE"] = drow["PROD_STRUCTURE"];
                        dtRxnData.Rows.Add(dr);
                    }

                    for (int i = 0; i < tcRxnSteps.TabCount; i++)
                    {
                        ucRxnParticipants rxnPartpnts = tcRxnSteps.TabPages[i].Controls[0] as ucRxnParticipants;
                        if (rxnPartpnts != null)
                        {
                            //BindingSource bsPartpnts = rxnPartpnts.dgvParticipants.DataSource as BindingSource;
                            //if (bsPartpnts != null)
                            //{
                            DataTable dtPartpnts = rxnPartpnts.dgvParticipants.DataSource as DataTable;
                            if (dtPartpnts != null)
                            {
                                foreach (DataRow drow in dtPartpnts.Rows)
                                {
                                    if (drow["PRPNT_TYPE"].ToString().ToUpper() == "REACTANT")
                                    {
                                        DataRow dr = dtRxnData.NewRow();
                                        dr["PRPNT_TYPE"] = "REACTANT";
                                        dr["PRPNT_STRUCTURE"] = drow["PRPNT_STRUCTURE"];
                                        dtRxnData.Rows.Add(dr);
                                    }
                                }
                            }
                            //}
                        }
                    }
                }
            }
            catch (Exception ex)
            {

               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtRxnData;
        }

        private void BuildReactionSchemeFromReactionTable(DataTable rxnData)
        {
            try
            {

                if (rxnData != null)
                {
                    RxnMolecule rxnMol = new RxnMolecule();
                    MolHandler mHandler1;

                    //Add Reactants to RxnMol
                    for (int i = 0; i < rxnData.Rows.Count; i++)
                    {
                        if (rxnData.Rows[i]["PRPNT_TYPE"].ToString().ToUpper() == "REACTANT")
                        {
                            mHandler1 = new MolHandler(rxnData.Rows[i]["PRPNT_STRUCTURE"].ToString());
                            rxnMol.addComponent(mHandler1.getMolecule(), 0, true);
                        }
                    }

                    //Add Products to RxnMol
                    for (int i = 0; i < rxnData.Rows.Count; i++)
                    {
                        if (rxnData.Rows[i]["PRPNT_TYPE"].ToString().ToUpper() == "PRODUCT")
                        {
                            mHandler1 = new MolHandler(rxnData.Rows[i]["PRPNT_STRUCTURE"].ToString());
                            rxnMol.addComponent(mHandler1.getMolecule(), 1, true);
                        }
                    }
                    
                    //string strSmiles = rxnMol.exportToFormat("smiles");
                    RxnMolecule rxnMolecule = RxnMolecule.getReaction(MolImporter.importMol(rxnMol.toFormat("mol")));

                    //If Auto mapping is checked
                    if (rbnAutoMapping.Checked)
                    {
                        AutoMapper mapper = new AutoMapper();
                        mapper.setMappingStyle(AutoMapper.MATCHING);
                        try
                        {
                            mapper.map(rxnMolecule);
                        }
                        catch
                        {

                        }
                    }

                    MolHandler mh = new MolHandler(rxnMolecule.toFormat("mol"));
                    mh.clean(true, "2D");

                    RenditorRxnScheme.MolfileString = mh.toFormat("mol");// reaction.toFormat("mol");

                    #region Code commented
                    //AutoMapper mapper = new AutoMapper();
                    ////Molecule mol = MolImporter.importMol(rxnMol.exportToFormat("smiles"));
                    //// RxnMolecule rm = RxnMolecule.getReaction(mol);
                    //mapper.setReaction(rxnMol);
                    //mapper.setMappingStyle(AutoMapper.CHANGING);
                    //mapper.map(rxnMol, true);

                    //AutoMapper.mapReaction(rxnMol);

                    //MolImporter importer = new MolImporter("unmapped.smiles");
                    //MolExporter exporter = new MolExporter("mapped.mol", "sdf");
                    //AutoMapper.mapReaction(importer, exporter);
                    //importer.close();
                    //exporter.close();

                    //MDL.Draw.Modules.Editor.Actions.Calcs.
                    //GenericEditorModule mod = RenditorRxnScheme;
                    //MDL.Draw.Modules.Editor.Actions.Calcs.AutoMapAction mp = new MDL.Draw.Modules.Editor.Actions.Calcs.AutoMapAction();
                    //mp.Editor.AppendStructureToEditor(rxnMol.toFormat("mol"));

                    //RenditorRxnScheme.Preferences.AtomAtomDisplayMode = MDL.Draw.Renderer.Preferences.AtomAtomMappingDisplayMode.On;
                    //RenditorRxnScheme.Preferences.AtomChargeDisplay = true;
                    //RenditorRxnScheme.Preferences.StereoChemistryMode = MDL.Draw.Renderer.Preferences.StereoChemistryModeEnum.Absolute;

                    //RenditorRxnScheme.Preferences.ReactionCenterSize = 5.5;

                    //RenditorRxnScheme.Preferences.
                    //RenditorRxnScheme.MolfileString = rxnMol.toFormat("mol"); 
                    #endregion
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnRefreshRxnScheme_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult diaRes = MessageBox.Show("Do you want to refresh the reaction scheme?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes == System.Windows.Forms.DialogResult.Yes)
                {
                    DataTable dtRxnData = GetReactionDataFromReaction();
                    if (dtRxnData != null)
                    {
                        RenditorRxnScheme.MolfileString = ChemistryOperations.GetReactionSchemeFromReactionTable(dtRxnData, rbnAutoMapping.Checked);                        
                    }
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
                using (FolderBrowserDialog fldDialog = new FolderBrowserDialog())
                {
                    if (fldDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;

                        List<int> lstDocIDs = new List<int>();
                        lstDocIDs.Add(ShipmentRefID);

                        int mdlNo = 000001;
                        //string strShipmentYear = !string.IsNullOrEmpty(txtYear.Text.Trim()) ? ShipmentYear.Trim().Substring(2) : "";
                        string strShipmentYear = !string.IsNullOrEmpty(txtYear.Text.Trim()) ? txtYear.Text.Trim() : "1";
                        Delivery objDeliv = null;
                        if (ShipmentExport.ExportReactions(lstDocIDs, strShipmentYear, fldDialog.SelectedPath, mdlNo, out objDeliv))
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("Export to RDF successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("Error in RDF export", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnRefComplete_Click(object sender, EventArgs e)
        {
            try
            {
                 string strErrMsg = "";
                 bool blValidRef = true;

                 if (ValidateReactionData(ref strErrMsg))
                 {
                     if (GlobalVariables.RoleName.ToUpper() == RolesMaster.ANALYST.ToUpper() || GlobalVariables.RoleName.ToUpper() == RolesMaster.REV_ANALYST.ToUpper())
                     {
                         //Check for In-complete reactions
                         if (!ValidatieReactionsCompleteStatus())
                         {
                             blValidRef = false;
                             MessageBox.Show("Some reactions are not completed", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                             return;
                         }
                     }
                     else if (GlobalVariables.RoleName.ToUpper() == RolesMaster.QC_ANALYST.ToUpper())
                     {
                         DataTable nonQCRxns = GetQcNotCompletedReactionsFromTable(ReactionsTable);
                         if (nonQCRxns != null && nonQCRxns.Rows.Count > 0)
                         {
                             frmQCNotDoneRxns objNonQcQRxns = new frmQCNotDoneRxns();
                             objNonQcQRxns.NonQcRxns = nonQCRxns;
                             objNonQcQRxns.ShipmentRefID = ShipmentRefID;
                             if (objNonQcQRxns.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                             {
                                 blValidRef = true;
                             }
                         }
                         else
                         {
                             blValidRef = true;
                         }
                     }
                     
                     Cursor = Cursors.WaitCursor;

                     if (blValidRef)
                     {
                         //Save Step Yield
                         if (SaveReactionStepYield())
                         {
                             if (TaskID > 0 && TaskAllocationID > 0)
                             {
                                 DialogResult diaRes = MessageBox.Show("Do you want to complete the reference?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                 if (diaRes == DialogResult.Yes)
                                 {
                                     #region MyRegion
                                     //using (frmTaskComments taskComments = new frmTaskComments())
                                     //{
                                     //    taskComments.TAN_Name = TAN_Name;
                                     //    taskComments.TAN_Reactions = ReactionsTbl;
                                     //    taskComments.TAN_ID = TAN_ID;

                                     //    if (taskComments.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                     //    { 
                                     #endregion
                                     //Update Task Status and Close TAN
                                     TaskStatus tskStatus = new TaskStatus();
                                     tskStatus.TaskComments = "Abstract Completed";//taskComments.txtTaskComments.Text.Trim();
                                     tskStatus.Task_ID = TaskID;
                                     tskStatus.Role_ID = GlobalVariables.RoleId;
                                     tskStatus.UR_ID = GlobalVariables.UR_ID;
                                     tskStatus.TaskAllocation_ID = TaskAllocationID;
                                     tskStatus.TaskStatusName = "SET COMPLETE";
                                     if (TaskManagementDB.UpdateUserTaskStatus(tskStatus))
                                     {
                                         //Delete Reference Pdf
                                         DeleteAbstractPdfFile(AbstractRefNo);
                                         this.Close();
                                     }
                                     else
                                     {
                                         MessageBox.Show("Error in Abstract complete", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                     }
                                 }
                             }
                         }
                         else
                         {
                             lblStatus.Text = "Error in saving reaction step yield";
                             Cursor = Cursors.Default;
                         }
                     }
                 }
                 else
                 {
                     Cursor = Cursors.Default;
                     MessageBox.Show(strErrMsg, GlobalVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private DataTable GetQcNotCompletedReactionsFromTable(DataTable reactionsData)
        {
            DataTable dtNocQCRxns = null;
            try
            {
                if (reactionsData != null)
                {
                    var rows = reactionsData.AsEnumerable()
                                                 .Where(r => r.Field<Int64?>("QC_BY") == null);
                    dtNocQCRxns = rows.Any() ? rows.CopyToDataTable() : reactionsData.Clone();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtNocQCRxns;
        }

        private void DeleteAbstractPdfFile(string absRef)
        {
            try
            {
                if (!string.IsNullOrEmpty(absRef))
                {
                    string strAppPath = Application.StartupPath.ToString();
                    string strPdfDirPath = strAppPath + "\\ABSTRACT_PDFs";

                    string strPdfPath = strPdfDirPath + "\\" + absRef.Trim() + ".pdf";

                    if (File.Exists(strPdfPath))
                    {
                        string strAdobeTitle = "Adobe Reader - [" + absRef.Trim() + ".pdf]";
                        string strAdbTitle = absRef.Trim() + ".pdf";
                        string strFoxitTitle = absRef.Trim() + ".pdf" + " - Foxit Reader - [" + absRef.Trim() + ".pdf]";

                        Process[] procArr = Process.GetProcesses();
                        foreach (Process process in procArr)
                        {
                            string strPName = process.ProcessName;
                            if (strPName.CompareTo("AcroRd32") == 0 && process.MainWindowTitle == strAdobeTitle)
                            {
                                process.Kill();
                                break;
                            }
                            else if (strPName.CompareTo("AcroRd32") == 0 && process.MainWindowTitle == strAdbTitle)
                            {
                                process.Kill();
                                break;
                            }
                            else if (strPName.CompareTo("Foxit Reader") == 0 && process.MainWindowTitle == strFoxitTitle)
                            {
                                process.Kill();
                                break;
                            }
                        }

                        File.Delete(strPdfPath);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnCrossRef_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShipmentRefID > 0)
                {
                    DataTable dtCrossRefs = ReactionCurationDB.GetCrossReferencesOnShipmentRefID(ShipmentRefID);
                    if (dtCrossRefs != null)
                    {
                        if (dtCrossRefs.Rows.Count > 0)
                        {
                            frmCrossRefs crossRefs = new frmCrossRefs();
                            crossRefs.CrossRefsData = dtCrossRefs;
                            crossRefs.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShipmentRefID > 0)
                {
                    using (FolderBrowserDialog fldDialog = new FolderBrowserDialog())
                    {
                        if (fldDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            Cursor = Cursors.WaitCursor;

                            string outFileName = Path.Combine(fldDialog.SelectedPath, txtJournalName.Text.Trim() + "_Export.pdf"); 

                           PdfOperations.PdfExport pdfExp = new PdfOperations.PdfExport();
                           if (pdfExp.ExportReferenceDataToPdf(ShipmentRefID, outFileName))
                           {
                               Process.Start(outFileName);
                           }
                           Cursor = Cursors.Default;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
                Cursor = Cursors.Default;
            }
        }

        private void btnRxn_CrossRef_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShipmentRefID > 0)
                {
                    Cursor = Cursors.WaitCursor;

                    DataSet dsRxn_CrossRefs = ReactionCurationDB.GetRxnAndCrossReferencesOnShipmentRefID(ShipmentRefID);
                    if (dsRxn_CrossRefs != null)
                    {
                        if (dsRxn_CrossRefs.Tables.Count == 2)
                        {
                            //DataTable dtRxnRefs = ReactionCurationDB.GetReactionReferencesOnShipmentRefID(ShipmentRefID);
                            //DataTable dtCrossRefs = ReactionCurationDB.GetCrossReferencesOnShipmentRefID(ShipmentRefID);

                            frmRxnReference rxnRef = new frmRxnReference();
                            rxnRef.CrossRefData = dsRxn_CrossRefs.Tables[0];
                            rxnRef.RxnsRefData = dsRxn_CrossRefs.Tables[1];
                            rxnRef.ShowDialog();

                            Cursor = Cursors.Default;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void rbnMultiStep_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetStepInformation();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void SetStepInformation()
        {
            try
            {
                if (rbnSingleStep.Checked)
                {
                    txtStepInfo.Text = "1 STEP";
                    txtMultiStep1.Enabled = false;
                    txtMultiStep2.Enabled = false;
                    txtMultiStep1.Clear();
                    txtMultiStep2.Clear();
                }
                else if (rbnMultiStep.Checked)
                {
                    txtStepInfo.Clear();
                    txtMultiStep1.Enabled = true;
                    txtMultiStep2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void SetMultiStepInformation()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMultiStep1.Text.Trim()) && !string.IsNullOrEmpty(txtMultiStep2.Text.Trim()))
                {
                    txtStepInfo.Text = txtMultiStep1.Text.Trim() + " OF " + txtMultiStep2.Text.Trim();
                }
                else
                {
                    txtStepInfo.Clear();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void txtMultiStep1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SetMultiStepInformation();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnResetRxnRef_Click(object sender, EventArgs e)
        {
            try
            {
                rxnRefEditRowIndx = -1;
                txtExtRegNo.Clear();
                txtRxnPath.Clear();
                txtStepInfo.Clear();
                txtMultiStep1.Clear();
                txtMultiStep2.Clear();
                rbnSingleStep.Checked = true;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnResetCrossRef_Click(object sender, EventArgs e)
        {
            try
            {
                crossRefEditRowIndx = -1;
                txtPreRxn.Clear();
                txtSuccRxn.Clear();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShipmentRefID > 0)
                {
                    DataTable dtRxnRefs = ReactionCurationDB.GetReactionReferencesOnShipmentRefID(ShipmentRefID);

                    List<object> pathsList;
                    DataTable dtrRxnPaths = GetReactionPathTableFromRxnRef(dtRxnRefs, out pathsList);

                    TestForm tstForm = new TestForm();
                    tstForm.RxnsPathData = dtrRxnPaths;
                    tstForm.Paths = pathsList;
                    tstForm.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private DataTable GetReactionPathTableFromRxnRef(DataTable rxnRefData, out List<object> pathslist)
        {
            DataTable pathTable = null;
            List<object> lstPaths = null;
            try
            {
                if (rxnRefData != null)
                {
                    pathTable = new DataTable();
                    pathTable.Columns.Add("Path");
                    pathTable.Columns.Add("RxnNo");
                    pathTable.Columns.Add("ParentRxnNo");
                    pathTable.Columns.Add("Paths");
                    pathTable.Columns.Add("Steps");

                    //Get Distinct Paths
                    var distinctRows = (from DataRow dRow in rxnRefData.Rows
                                        select dRow["EXT_REG_NO"]).Distinct().ToList();

                    lstPaths = distinctRows;

                    List<Int32> lstRxnNos = new List<Int32>();

                    foreach (decimal pathNo in distinctRows)
                    {
                        var rows = from r in rxnRefData.AsEnumerable()
                                   where r.Field<decimal>("EXT_REG_NO") == pathNo
                                   select r;

                        DataTable pathRxns = rows.Any() ? rows.CopyToDataTable() : rxnRefData.Clone();

                        string strSteps = "";
                        string strPaths = "";

                        for (int i = 0; i < pathRxns.Rows.Count;i++ )
                        {
                            if (!lstRxnNos.Contains(Convert.ToInt32(pathRxns.Rows[i]["REACTION_SNO"].ToString())))
                            {
                                lstRxnNos.Add(Convert.ToInt32(pathRxns.Rows[i]["REACTION_SNO"].ToString()));

                                DataRow ptRxn = pathTable.NewRow();
                                ptRxn["Path"] = pathNo;
                                ptRxn["RxnNo"] = pathRxns.Rows[i]["REACTION_SNO"].ToString();
                                ptRxn["ParentRxnNo"] = (i == 0) ? "" : pathRxns.Rows[i - 1]["REACTION_SNO"].ToString();

                                //Get Paths & Steps on RxnNo
                                strPaths = GetPathsAndStepsOnRxnNo(rxnRefData, Convert.ToInt32(pathRxns.Rows[i]["REACTION_SNO"].ToString()), out strSteps);
                                ptRxn["Paths"] = strPaths;
                                ptRxn["Steps"] = strSteps;

                                pathTable.Rows.Add(ptRxn);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            pathslist = lstPaths;
            return pathTable;
        }

        private string GetPathsAndStepsOnRxnNo(DataTable rxnRefData, int rxnNo, out string pathSteps)
        {
            string strPaths = "";
            string strSteps = "";
            try
            {
                if (rxnRefData != null)
                {
                    var rows = from r in rxnRefData.AsEnumerable()
                               where r.Field<Int32>("REACTION_SNO") == rxnNo
                               select r;
                    DataTable pathRxns = rows.Any() ? rows.CopyToDataTable() : rxnRefData.Clone();
                    string strStepInfo = "";
                    foreach (DataRow dr in pathRxns.Rows)
                    {
                        if (dr["PATH_LETTER"] != null && dr["STEP"] != null)
                        {
                            strPaths = string.IsNullOrEmpty(strPaths.Trim()) ? dr["PATH_LETTER"].ToString() : strPaths.Trim() + ";" + dr["PATH_LETTER"].ToString();

                            strStepInfo = dr["PATH_LETTER"].ToString() + "-" + dr["STEP"].ToString();
                            strSteps = string.IsNullOrEmpty(strSteps.Trim()) ? strStepInfo : strSteps.Trim() + "\r\n" + strStepInfo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            pathSteps = strSteps;
            return strPaths;
        }

        private void dgvProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    productRenderer.MolfileString = dgvProduct.Rows[e.RowIndex].Cells[colProductStructure.Name].Value.ToString(); 
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void FrmReactionCuration_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    DataTable dtProducts = new DataTable();

                    ProductInfo objProdInfo = new ProductInfo();
                    objProdInfo.ReactionID = ReactionId;
                    objProdInfo.ProductID = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[colProductID.Name].Value.ToString());

                    if (dgvProduct.Columns[e.ColumnIndex].HeaderText.ToString().ToUpper() == "EDIT")
                    {
                        blEditProduct = true;
                        using (FrmEditProduct fProducts = new FrmEditProduct())
                        {
                            fProducts.ProductData = new ProductInfo();

                            objProdInfo.ProductName = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[colProductName.Name].Value);
                            objProdInfo.StructureNo = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[colProductStructNo.Name].Value);
                            objProdInfo.Structure = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[colProductStructure.Name].Value);
                            objProdInfo.Yield = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[colProductYield.Name].Value);
                            objProdInfo.CS = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[colProductCs.Name].Value);
                            objProdInfo.DS = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[colProductDs.Name].Value);
                            objProdInfo.DE = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[colProductDE.Name].Value);
                            objProdInfo.EE = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[colProductEE.Name].Value);
                            objProdInfo.ProductGrade = dgvProduct.Rows[e.RowIndex].Cells[colGrade.Name].Value.ToString();
                            editRowIndxProduct = e.RowIndex;
                            blEditProduct = true;

                            fProducts.ProductData = objProdInfo;
                            if (fProducts.ShowDialog() == DialogResult.OK)
                            {
                                fProducts.ProductData.ProductID = objProdInfo.ProductID;
                                fProducts.ProductData.ReactionID = objProdInfo.ReactionID;
                                objProdInfo = fProducts.ProductData;
                                objProdInfo.Option = DmlOperations.UPDATE.ToString();

                                if (ReactionCurationDB.SaveReactionProduct(objProdInfo, out dtProducts))
                                {
                                    MessageBox.Show("Product updated successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BindDataToProductGrid(dtProducts);
                                }
                                else
                                {
                                    MessageBox.Show("Error in product updation.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else if (dgvProduct.Columns[e.ColumnIndex].HeaderText.ToString().ToUpper() == "DELETE")
                    {
                        if (MessageBox.Show("Do you want to delete the selected product?", GlobalVariables.MessageCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            objProdInfo.ProductID = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[colProductID.Name].Value.ToString());
                            objProdInfo.ReactionID = ReactionId;
                            objProdInfo.Option = DmlOperations.DELETE.ToString();

                            if (ReactionCurationDB.SaveReactionProduct(objProdInfo, out dtProducts))
                            {
                                MessageBox.Show("Product deleted successfully", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BindDataToProductGrid(dtProducts);
                            }
                            else
                            {
                                MessageBox.Show("Error accured in product deletion.", GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        TreeNode tnSelected;
        private void SelectReactionNodeInTheTreeView(int curRecIndx)
        {
            try
            {
                if (curRecIndx >= 0 && curRecIndx <= tvReactions.Nodes[0].Nodes.Count && tvReactions.Nodes[0].Nodes.Count > 0)
                {
                    //Select Node in the Reactions TreeView
                    foreach (TreeNode tn in tvReactions.Nodes[0].Nodes)
                    {
                        // tn.ImageIndex = 0;
                        tn.ForeColor = Color.Blue;
                    }
                    tnSelected = tvReactions.Nodes[0].Nodes[curRecIndx];
                    tnSelected.ForeColor = Color.Red;
                    tnSelected.SelectedImageIndex = 2;
                    tvReactions.SelectedNode = tnSelected;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        int selectedNodeIndx = 0;
        int selectedRxnID = 0;
        TreeNode tn;
        private void tvReactions_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    string strErrMSg = "";
                    if (ValidateAndSaveCurrentReaction(ref strErrMSg))
                    {
                        tn = tvReactions.SelectedNode;

                        if (tn != null)
                        {
                            selectedNodeIndx = tn.Index + 1;

                            if (selectedNodeIndx == numGoToRxn.Value)
                            {
                                numGoToRxn.Value = selectedNodeIndx;
                                numGoToRxn_ValueChanged(null, null);
                            }
                            else
                            {
                                numGoToRxn.Value = selectedNodeIndx;
                            }
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(strErrMSg.Trim()))
                        {
                            MessageBox.Show("Errors in the Reaction. Clear the below errors before moving to other reaction\r\n\r\n" + strErrMSg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void tvReactions_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {                
                string strErrMSg = "";
                if (ValidateAndSaveCurrentReaction(ref strErrMSg))
                {
                    selectedNodeIndx = tvReactions.SelectedNode.Index + 1;

                    if (selectedNodeIndx == numGoToRxn.Value)
                    {
                        numGoToRxn.Value = selectedNodeIndx;
                        numGoToRxn_ValueChanged(null, null);
                    }
                    else
                    {
                        numGoToRxn.Value = selectedNodeIndx;
                    }                   
                }
                else
                {
                    if (!string.IsNullOrEmpty(strErrMSg.Trim()))
                    {
                        MessageBox.Show("Errors in the Reaction. Clear the below errors before moving to other reaction\r\n\r\n" + strErrMSg, GlobalVariables.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValidateTextBoxData(sender as TextBox);
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void ValidateTextBoxData(TextBox tb)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    tb.Text = tb.Text.Remove(tb.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
    }
}
