using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChemInform.Bll;
using ChemInform.Common;
using ChemInform.Dal;

namespace ChemInform
{
    public partial class FrmSpectralCuration : Form
    {
        #region Constructor

        public FrmSpectralCuration()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Variables

        public int DocumentID { get; set; }

        public DataTable DocumentInfo { get; set; }

        public DataTable DocCompounds { get; set; }

        public DataSet SpectralData { get; set; }

        int currRecIndex = 0;
        int MaxRecCnt = 0;
        bool blValidComp = false;

        #endregion

        private void FrmSpectralCuration_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                EnableDisableNavigationControls(false);

                if (DocumentInfo != null)
                {
                    if (DocumentInfo.Rows.Count > 0)
                    {
                        DocumentID = Convert.ToInt32(DocumentInfo.Rows[0]["DOC_ID"].ToString());

                        //Bind Article information to controls
                        BindArticleInformationToControls(DocumentInfo);

                        //Get Compounds on DocID
                        DocCompounds = Dal.SpectralCurationDB.GetCompoundsOnDocumentID(DocumentID);
                        if (DocCompounds != null)
                        {
                            //Disable UpDown buttons
                            numGotoRecord.Controls[0].Enabled = false;
                            MaxRecCnt = DocCompounds.Rows.Count;
                            numGotoRecord.Maximum = MaxRecCnt;

                            if (DocCompounds.Rows.Count > 0)
                            {
                                blValidComp = true;//Set to true in the Page load, check in Compound navigation whether Compound is valid or not

                                EnableDisableNavigationControls(true);

                                currRecIndex = 1;
                                numGotoRecord.Minimum = 1;
                            }
                            else
                            {
                                EnableDisableNavigationControls(false);

                                numGotoRecord.Minimum = 0;
                                currRecIndex = 0;
                            }

                            numGotoRecord.Value = currRecIndex;
                        }
                    }
                }                
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void EnableDisableNavigationControls(bool status)
        {
            try
            {
                btnFirstComp.Enabled = status;
                btnNextComp.Enabled = status;
                btnPrevComp.Enabled = status;
                btnLastComp.Enabled = status;
                numGotoRecord.Enabled = status;
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void BindArticleInformationToControls(DataTable articleData)
        {
            try
            {
                if (articleData != null)
                {
                    txtJournalName.Text = articleData.Rows[0]["JOURNAL_NAME"].ToString();
                    txtIssue.Text = articleData.Rows[0]["ISSUE"].ToString();
                    txtDOI.Text = articleData.Rows[0]["DOI"].ToString();
                    txtAuthors.Text = articleData.Rows[0]["AUTHORS"].ToString();
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private bool ValidateAndSaveCompoundData()
        {
            bool blStatus = false;
            try
            {
                string strErrMsg = "";

                //Validate Spectral curation controls
                if (ValidateUserInputs(ref strErrMsg))
                {
                    //Save Compound Information
                    CompoundInfo objCompInfo = ucSpectral.GetCompoundInformation();
                    if (objCompInfo != null)
                    {
                        SpectralCurationDB.UpdateCompoundInformation(objCompInfo, GlobalVariables.LogInUserInfo);                        
                    }

                    //Save NMR Spectral Information
                    List<NMRSpectralInfo> lstNMRSpectrals = ucSpectral.GetNMRSpectralInformation();
                    if (lstNMRSpectrals != null)
                    {
                        for (int i = 0; i < lstNMRSpectrals.Count; i++)
                        {
                            SpectralCurationDB.UpdateNMRSpectralInformation(lstNMRSpectrals[i], GlobalVariables.LogInUserInfo);
                        }                      
                    }

                    //Save Other Spectral Information
                    List<OtherSpectralInfo> lstOtherSpectrals = ucSpectral.GetOtherSpectralInformation();
                    if (lstOtherSpectrals != null)
                    {
                        for (int i = 0; i < lstOtherSpectrals.Count; i++)
                        {
                            SpectralCurationDB.UpdateOtherSpectralInformation(lstOtherSpectrals[i], GlobalVariables.LogInUserInfo);
                        }
                    }

                    blStatus = true;
                }
                else
                {
                    MessageBox.Show(strErrMsg.Trim(), "ChemInform",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }                
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        private bool ValidateUserInputs(ref string errMsg)
        {
            bool blStatus = true;
            try
            {
                if (string.IsNullOrEmpty(txtJournalName.Text.Trim()))
                {
                    blStatus = false;
                    errMsg = errMsg + "\r\n" + "Journal Name can't be null";
                }

                if (string.IsNullOrEmpty(txtIssue.Text.Trim()))
                {
                    blStatus = false;
                    errMsg = errMsg + "\r\n" + "Issue can't be null";
                }

                if (string.IsNullOrEmpty(txtDOI.Text.Trim()))
                {
                    blStatus = false;
                    errMsg = errMsg + "\r\n" + "DOI can't be null";
                }

                if (string.IsNullOrEmpty(txtAuthors.Text.Trim()))
                {
                    blStatus = false;
                    errMsg = errMsg + "\r\n" + "Authors can't be null";
                }

                if (!ucSpectral.ValidateSpectralDataControlValues(ref errMsg))
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateAndSaveCompoundData();
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        } 
        
        private void AddNewRecordToCompoundsTable(int docID, int compoundID)
        {
            try
            {
                if (DocCompounds == null)
                {
                    DocCompounds = new DataTable();
                    DocCompounds.Columns.Add("DOC_ID", typeof(Int32));
                    DocCompounds.Columns.Add("COMPOUND_ID", typeof(Int32));
                    DocCompounds.Columns.Add("CREATED_BY", typeof(Int32));                    
                }

                DataRow dRow = DocCompounds.NewRow();
                dRow["DOC_ID"] = docID;
                dRow["COMPOUND_ID"] = compoundID;
                dRow["CREATED_BY"] = GlobalVariables.LogInUserInfo.UserID;
                DocCompounds.Rows.Add(dRow);            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool GetCompoundDataFromTableAndBindToControls(int recordIndex)
        {
            bool blStatus = false;
            try
            {
                if (recordIndex >= 0)
                {
                    if (DocCompounds != null)
                    {
                        if (DocCompounds.Rows.Count > 0)
                        {
                            ucSpectral.txtCompNo.Text = recordIndex.ToString();

                            int intCompId = 0;
                            if (int.TryParse(DocCompounds.Rows[recordIndex]["COMPOUND_ID"].ToString(), out intCompId))
                            {
                                CompoundInfo objCompInfo = new CompoundInfo();
                                objCompInfo.CompoundID = intCompId;

                                DataSet dsCompData = Dal.SpectralCurationDB.GetCompoundDataOnID(objCompInfo);

                                if (dsCompData != null)
                                {
                                    SpectralInfo objSpectralInfo = ConvertToUserDefinedLists.ConvertToSpectralData(dsCompData);
                                    if (objSpectralInfo != null)
                                    {
                                        ////Bind Artilce information
                                        //BindArticleInformationToControls(objSpectralInfo.ArticleInformation);

                                        //Bind Spectral information
                                        ucSpectral.BindSpectralInfoToControls(objSpectralInfo);
                                    }
                                }
                            }
                        }
                    }

                    blStatus = true;
                    return blStatus;
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        private void btnAddCompound_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate and save the existing compound information
                if (ValidateAndSaveCompoundData())
                {
                    DialogResult diaRes = MessageBox.Show("Do you want to create a new compound?", "ChemInform", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Reset control values
                        ucSpectral.ResetAllControlValues();

                        //Get new Compound ID from database
                        int intNewCompoundID = Dal.SpectralCurationDB.GetNewCompoundIDOnDocumentID(DocumentID);
                        AddNewRecordToCompoundsTable(DocumentID, intNewCompoundID);

                        MaxRecCnt = DocCompounds.Rows.Count;
                        numGotoRecord.Maximum = MaxRecCnt;

                        numGotoRecord.Value = currRecIndex;
                        if (numGotoRecord.Value == currRecIndex)
                        {
                            numGotoRecord_ValueChanged(null, null);
                        }

                        //Disable NewCompound button
                        btnAddCompound.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        private void btnDeleteCompound_Click(object sender, EventArgs e)
        {
            try
            {
                CompoundInfo objCompInfo = ucSpectral.GetCompoundInformation();
                if (objCompInfo != null)
                {
                    if (objCompInfo.CompoundID > 0)
                    {
                        DialogResult diaRes = MessageBox.Show("Do you want to delete the compound?", "ChemInform", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (diaRes == System.Windows.Forms.DialogResult.Yes)
                        {
                            //Delete compound information in the database on CompoundID
                            if (SpectralCurationDB.DeleteCompoundDataOnID(objCompInfo))
                            {
                                //Reset control values
                                ucSpectral.ResetAllControlValues();
                                                               
                                //Refresh Document Compounds after Compound deleted
                                DocCompounds = Dal.SpectralCurationDB.GetCompoundsOnDocumentID(DocumentID);
                                
                                MaxRecCnt = DocCompounds.Rows.Count;
                                numGotoRecord.Maximum = MaxRecCnt;

                                if (currRecIndex < MaxRecCnt && currRecIndex > 1)
                                {
                                    currRecIndex = currRecIndex - 1;
                                }
                                else if (currRecIndex == MaxRecCnt && MaxRecCnt > 1)
                                {
                                    currRecIndex = currRecIndex; //currRecIndex - 1;
                                }
                                else if (currRecIndex < MaxRecCnt && currRecIndex == 1)
                                {
                                    currRecIndex = currRecIndex + 1;
                                }
                                else if (currRecIndex > MaxRecCnt)//New condition on 13th Sep 2011
                                {
                                    currRecIndex = MaxRecCnt;
                                }

                                blValidComp = true;
                                numGotoRecord.Value = currRecIndex;
                                btnAddCompound.Enabled = true;

                                MessageBox.Show("Compound deleted successfully", "ChemInform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error in compound delete", "ChemInform", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
              
        #region Navigation Buttons Events

        private void numGotoRecord_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (blValidComp)
                {
                    if (numGotoRecord.Value > 0)
                    {
                        Cursor = Cursors.WaitCursor;

                        currRecIndex = Convert.ToInt32(numGotoRecord.Value);

                        GetCompoundDataFromTableAndBindToControls(Convert.ToInt32(currRecIndex - 1));            
                    }                    
                }                

                //Show Total No.of Reactions with current Reaction index
                lblRxnCnt.Text = currRecIndex + " / " + numGotoRecord.Maximum.ToString();
                lblRxnCnt.Refresh();

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFirstComp_Click(object sender, EventArgs e)
        {
            try
            {

                blValidComp = false;
                if (ValidateAndSaveCompoundData())
                {
                    blValidComp = true;

                    currRecIndex = 1;
                    numGotoRecord.Value = currRecIndex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnPrevComp_Click(object sender, EventArgs e)
        {
            try
            {
                blValidComp = false;

                if (ValidateAndSaveCompoundData())
                {
                    blValidComp = true;

                    if (currRecIndex <= MaxRecCnt && currRecIndex > 1)
                    {
                        currRecIndex = (currRecIndex - 1);
                    }

                    numGotoRecord.Value = currRecIndex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNextComp_Click(object sender, EventArgs e)
        {
            try
            {
                blValidComp = false;

                if (ValidateAndSaveCompoundData())
                {
                    blValidComp = true;

                    if (currRecIndex < MaxRecCnt)
                    {
                        currRecIndex = currRecIndex + 1;
                    }
                    else if (currRecIndex == MaxRecCnt)
                    {
                        currRecIndex = MaxRecCnt;
                    }

                    numGotoRecord.Value = currRecIndex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLastComp_Click(object sender, EventArgs e)
        {
            try
            {
                blValidComp = false;
                if (ValidateAndSaveCompoundData())
                {
                    blValidComp = true;

                    currRecIndex = MaxRecCnt;
                    numGotoRecord.Value = currRecIndex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        
        #endregion
    }
}
