using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChemInform.Bll;
using System.Data;
using ChemInform.Dal;

namespace ChemInform.Export
{
    class ShipmentExport
    {
        public static bool ExportReactions(List<int> RefIDsList, string shipmentYear, string outputPath,int mdlStartNo, out Delivery deliveryDtls)
        {
            bool blStatus = false;
            Delivery objDelivery = null;
            
            try
            {
                int mdlNo = mdlStartNo;//70000000;
                List<string> lstUniqSolvInchi = new List<string>();

                DeliverySolvCats delvSovCats = new DeliverySolvCats();

                //Define Delivery class
                objDelivery = new Delivery();
                objDelivery.DeliveryDate = DateTime.Now;
                objDelivery.MDLStartNo = mdlStartNo;
                objDelivery.DeliveryRefCount = RefIDsList.Count;

                List<int> lstDelRefs = new List<int>();
                List<int> lstDelRefMDLStNo = new List<int>();
                List<int> lstDelRefMDLEndNo = new List<int>();
                int deliveredRxnCnt = 0;               

                foreach (int shipRefID in RefIDsList)
                {
                    DataSet dsRxns = ReactionCurationDB.GetReactionsForExportOnDocID(shipRefID);
                    DataTable dtRxnRefs = null;
                    DataTable dtCrossRefs = null;

                    //Automated Export
                    DataSet dsRxn_CrossRefs = ReactionCurationDB.GetRxnAndCrossReferencesOnShipmentRefID(shipRefID);
                    if (dsRxn_CrossRefs != null)
                    {
                        if (dsRxn_CrossRefs.Tables.Count == 2)
                        {
                            dtCrossRefs = dsRxn_CrossRefs.Tables[0];
                            dtRxnRefs = dsRxn_CrossRefs.Tables[1];                
                        }
                    }
                    
                    if (dsRxns != null)
                    {
                        if (dsRxns.Tables.Count == 8)
                        {
                            DataTable dtDocMaster = dsRxns.Tables[0];
                            DataTable dtReactions = dsRxns.Tables[1];
                            //Manual Export
                            //DataTable dtRxnRefs = dsRxns.Tables[2];
                            //DataTable dtCrossRefs = dsRxns.Tables[3];
                            DataTable dtRxnSteps = dsRxns.Tables[4];
                            DataTable dtConditions = dsRxns.Tables[5];
                            DataTable dtParticipants = dsRxns.Tables[6];
                            DataTable dtProducts = dsRxns.Tables[7];

                            FullArticleInfo objFullArtInfo = GetFullArticleDetailsOnShipmentRefID(Convert.ToInt32(dtDocMaster.Rows[0]["SHIPMENT_REF_ID"].ToString()));
                                                      
                            string shipementRefName = dtDocMaster.Rows[0]["REFERENCE_NAME"].ToString();
                            List<ReactionInfo> lstRxnInfo = new List<ReactionInfo>();
                            int reactionID = 0;                           

                            //Add Reference Name and MDL Start No
                            lstDelRefs.Add(shipRefID);
                            lstDelRefMDLStNo.Add(mdlNo);

                            //Unique ID for reaction (serial number); format: RXCInnnnnnnn;n=numerical range for backfiles is 70000001...89999999.
                            //Feedback on 28th Oct 2014
                            //General: Please assign MDLnumbers according to the year, i.e. issues from 1981 should have MDLnumbers RXCI81nnnnnn, to avoid duplicates

                            foreach (DataRow drow in dtReactions.Rows)
                            {                                                  
                                reactionID = Convert.ToInt32(drow["REACTION_ID"]);

                                ReactionInfo rxnInfo = new ReactionInfo();
                                rxnInfo.ShipmentRefID = shipRefID;
                                rxnInfo.ReactionID = reactionID;
                                rxnInfo.SysNo = dtDocMaster.Rows[0]["SYS_NO"].ToString();
                                rxnInfo.SysText = dtDocMaster.Rows[0]["SYS_TEXT"].ToString();
                                rxnInfo.RxnMDLNo = "RXCI" + shipmentYear + mdlNo.ToString("000000");//RXCI81nnnnnn
                                rxnInfo.ReactionScheme = drow["REACTION_SCHEME"];
                                rxnInfo.ReactionSNo = Convert.ToInt32(drow["REACTION_SNO"]);
                                rxnInfo.RxnComments = drow["RXN_COMMENTS"].ToString();
                                rxnInfo.IsImportantRxn = drow["IS_IMPORTANT"].ToString();
                                rxnInfo.RxnRef = GetRxnRefInfoFromTableOnReactionID(dtRxnRefs, reactionID);
                                rxnInfo.RxnCrossRef = GetCrossRefInfoFromTableOnReactionID(dtCrossRefs, reactionID);
                                rxnInfo.RxnProducts = GetProductsFromTableOnReactionID(dtProducts, reactionID);
                                rxnInfo.RxnSteps = GetStepsInfoFromTableOnReactionID(dtRxnSteps, dtParticipants, dtConditions, reactionID);

                                //Add to list
                                lstRxnInfo.Add(rxnInfo);

                                //increment MDL Numer
                                mdlNo++;

                                //Count delivery Rxns
                                deliveredRxnCnt++;
                            }

                            //Add Reference MDL End No
                            lstDelRefMDLEndNo.Add(mdlNo);
                            
                            if (lstRxnInfo != null)
                            {
                                ReactionExport.ExportToRDFile(lstRxnInfo, objFullArtInfo, shipementRefName, outputPath, ref lstUniqSolvInchi, ref delvSovCats);
                                blStatus = true;
                            }
                        }
                    }
                }

                //Delivery references and Mdl Nos
                objDelivery.DeliveryRefsList = lstDelRefs;
                objDelivery.RefMdlStartNoList = lstDelRefMDLStNo;
                objDelivery.RefMdlEndNoList = lstDelRefMDLEndNo;
                objDelivery.DeliveryRxnCount = deliveredRxnCnt;
                objDelivery.MDLEndNo = mdlStartNo + deliveredRxnCnt;
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            deliveryDtls = objDelivery;            
            return blStatus;
        }

        private static FullArticleInfo GetFullArticleDetailsOnShipmentRefID(int shipmentRefID)
        {
            FullArticleInfo objFullArtInfo = null;
            try
            {
                if (shipmentRefID > 0)
                {
                    objFullArtInfo = new FullArticleInfo();
                    objFullArtInfo.ShipmentRefID = shipmentRefID;

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
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return objFullArtInfo;
        }

        /// <summary>
        /// Export Reactions for client delivery
        /// </summary>
        /// <param name="RefIDsList"></param>
        /// <param name="shipmentYear"></param>
        /// <param name="outputPath"></param>
        /// <param name="mdlStartNo"></param>
        /// <param name="deliveryDtls"></param>
        /// <param name="delivSovCats"></param>
        /// <returns></returns>
        public static bool ExportReactionsForClientDelivery(List<int> RefIDsList, string shipmentYear, string outputPath, int mdlStartNo, out Delivery deliveryDtls, out List<DeliverySolvCats> delivSovCatsList)
        {
            bool blStatus = false;
            Delivery objDelivery = null;
            List<DeliverySolvCats> lstDeliverySovCats = null;
            try
            {
                int mdlNo = mdlStartNo;//70000000;
                List<string> lstUniqSolvInchi = new List<string>();

                //Define Delivery class
                objDelivery = new Delivery();
                objDelivery.DeliveryDate = DateTime.Now;
                objDelivery.MDLStartNo = mdlStartNo;
                objDelivery.DeliveryRefCount = RefIDsList.Count;

                List<int> lstDelRefs = new List<int>();
                List<int> lstDelRefMDLStNo = new List<int>();
                List<int> lstDelRefMDLEndNo = new List<int>();
                int deliveredRxnCnt = 0;

                lstDeliverySovCats = new List<DeliverySolvCats>();

                foreach (int shipRefID in RefIDsList)
                {
                    DataSet dsRxns = ReactionCurationDB.GetReactionsForExportOnDocID(shipRefID);
                    DataTable dtRxnRefs = null;
                    DataTable dtCrossRefs = null;

                    //Automated Export
                    DataSet dsRxn_CrossRefs = ReactionCurationDB.GetRxnAndCrossReferencesOnShipmentRefID(shipRefID);
                    if (dsRxn_CrossRefs != null)
                    {
                        if (dsRxn_CrossRefs.Tables.Count == 2)
                        {
                            dtCrossRefs = dsRxn_CrossRefs.Tables[0];
                            dtRxnRefs = dsRxn_CrossRefs.Tables[1];
                        }
                    }

                    if (dsRxns != null)
                    {
                        if (dsRxns.Tables.Count == 8)
                        {
                            DataTable dtDocMaster = dsRxns.Tables[0];
                            DataTable dtReactions = dsRxns.Tables[1];
                            //Manual Export
                            //DataTable dtRxnRefs = dsRxns.Tables[2];
                            //DataTable dtCrossRefs = dsRxns.Tables[3];
                            DataTable dtRxnSteps = dsRxns.Tables[4];
                            DataTable dtConditions = dsRxns.Tables[5];
                            DataTable dtParticipants = dsRxns.Tables[6];
                            DataTable dtProducts = dsRxns.Tables[7];

                           // FullArticleInfo articleInfo =  GetArticleInfoFromTable(dtDocMaster);

                            FullArticleInfo articleInfo = GetFullArticleDetailsOnShipmentRefID(Convert.ToInt32(dtDocMaster.Rows[0]["SHIPMENT_REF_ID"].ToString()));

                            string shipementRefName = dtDocMaster.Rows[0]["REFERENCE_NAME"].ToString();
                            List<ReactionInfo> lstRxnInfo = new List<ReactionInfo>();
                            int reactionID = 0;

                            //Add Reference Name and MDL Start No
                            lstDelRefs.Add(shipRefID);
                            lstDelRefMDLStNo.Add(mdlNo);
                                                        
                            //Unique ID for reaction (serial number); format: RXCInnnnnnnn;n=numerical range for backfiles is 70000001...89999999.
                            //Feedback on 28th Oct 2014
                            //General: Please assign MDLnumbers according to the year, i.e. issues from 1981 should have MDLnumbers RXCI81nnnnnn, to avoid duplicates

                            foreach (DataRow drow in dtReactions.Rows)
                            {
                                reactionID = Convert.ToInt32(drow["REACTION_ID"]);

                                ReactionInfo rxnInfo = new ReactionInfo();
                                rxnInfo.ShipmentRefID = shipRefID;
                                rxnInfo.ReactionID = reactionID;
                                rxnInfo.SysNo = dtDocMaster.Rows[0]["SYS_NO"].ToString();
                                rxnInfo.SysText = dtDocMaster.Rows[0]["SYS_TEXT"].ToString();
                                rxnInfo.RxnMDLNo = "RXCI" + shipmentYear + mdlNo.ToString("000000");//RXCI81nnnnnn
                                rxnInfo.ReactionScheme = drow["REACTION_SCHEME"];
                                rxnInfo.ReactionSNo = Convert.ToInt32(drow["REACTION_SNO"]);
                                rxnInfo.RxnComments = drow["RXN_COMMENTS"].ToString();
                                rxnInfo.RxnRef = GetRxnRefInfoFromTableOnReactionID(dtRxnRefs, reactionID);
                                rxnInfo.RxnCrossRef = GetCrossRefInfoFromTableOnReactionID(dtCrossRefs, reactionID);
                                rxnInfo.RxnProducts = GetProductsFromTableOnReactionID(dtProducts, reactionID);
                                rxnInfo.RxnSteps = GetStepsInfoFromTableOnReactionID(dtRxnSteps, dtParticipants, dtConditions, reactionID);

                                //Add to list
                                lstRxnInfo.Add(rxnInfo);

                                //increment MDL Numer
                                mdlNo++;

                                //Count delivery Rxns
                                deliveredRxnCnt++;
                            }

                            //Add Reference MDL End No
                            lstDelRefMDLEndNo.Add(mdlNo);

                            if (lstRxnInfo != null)
                            {
                                DeliverySolvCats refSovCats = new DeliverySolvCats();
                                if (ReactionExport.ExportToRDFile(lstRxnInfo, articleInfo, shipementRefName, outputPath, ref lstUniqSolvInchi, ref refSovCats))
                                {
                                    blStatus = true;

                                    if (refSovCats.RefNewSolvents != null)
                                    {
                                        refSovCats.ShipmentRefID = shipRefID;

                                        //Add Refs and SolvCats to List
                                        lstDeliverySovCats.Add(refSovCats);
                                    }
                                }
                            }
                        }
                    }
                }

                //Delivery references and Mdl Nos
                objDelivery.DeliveryRefsList = lstDelRefs;
                objDelivery.RefMdlStartNoList = lstDelRefMDLStNo;
                objDelivery.RefMdlEndNoList = lstDelRefMDLEndNo;
                objDelivery.DeliveryRxnCount = deliveredRxnCnt;
                objDelivery.MDLEndNo = (mdlStartNo + deliveredRxnCnt) - 1;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            deliveryDtls = objDelivery;
            delivSovCatsList = lstDeliverySovCats;
            return blStatus;
        }

        private static FullArticleInfo GetArticleInfoFromTable(DataTable articleData)
        {
            FullArticleInfo articleInfo = null;
            try
            {
                if (articleData != null && articleData.Rows.Count > 0)
                {
                    articleInfo = new FullArticleInfo();
                    articleInfo.ArticleType = articleData.Rows[0]["DOC_TYPE"].ToString();
                    articleInfo.JournalDOI = articleData.Rows[0]["DOI"].ToString();
                    articleInfo.JournalName = articleData.Rows[0]["JOURNAL_NAME"].ToString();
                    articleInfo.JournalStartPage = articleData.Rows[0]["START_PAGE"].ToString();
                    articleInfo.JournalEndPage = articleData.Rows[0]["END_PAGE"].ToString();
                    int journalYear = 0;
                    int.TryParse(articleData.Rows[0]["JOURNAL_YEAR"].ToString(), out journalYear);
                    articleInfo.JournalYear = journalYear;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return articleInfo;
        }
        
        private static List<ReactionRefInfo> GetRxnRefInfoFromTableOnReactionID(DataTable rxnRefData, int reactionID)
        {
            List<ReactionRefInfo> lstRxnRef = null;
            try
            {
                if (rxnRefData != null)
                {
                    EnumerableRowCollection<DataRow> rows = from row in rxnRefData.AsEnumerable()
                                                            where row.Field<Int64>("REACTION_ID") == reactionID
                                                            select row;

                    lstRxnRef = new List<ReactionRefInfo>();
                    foreach (DataRow drow in rows)
                    {
                        ReactionRefInfo rxnRef = new ReactionRefInfo();
                        rxnRef.ReactionID = reactionID;
                        //rxnRef.ReactionRefId = Convert.ToInt32(drow["RR_ID"]);
                        rxnRef.ExtRegNo = Convert.ToInt32(drow["EXT_REG_NO"]);
                        rxnRef.Step = drow["STEP"].ToString();
                        //rxnRef.RefPath = drow["RR_PATH"].ToString();//Manual Export
                        rxnRef.RefPath = drow["PATH_LETTER"].ToString();//Automated Export

                        lstRxnRef.Add(rxnRef);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstRxnRef;
        }

        private static List<CrossRefInfo> GetCrossRefInfoFromTableOnReactionID(DataTable crossRefData, int reactionID)
        {
            List<CrossRefInfo> lstCrossRef = null;
            try
            {
                if (crossRefData != null)
                {
                    EnumerableRowCollection<DataRow> rows = from row in crossRefData.AsEnumerable()
                                                            where row.Field<Int64>("REACTION_ID") == reactionID
                                                            select row;

                    lstCrossRef = new List<CrossRefInfo>();
                    //int crossRefIndx = 0;
                    foreach (DataRow drow in rows)
                    {
                        //crossRefIndx++;

                        //Manual Export - Code commented on 22nd Nov 2014
                        //CrossRefInfo crossRef = new CrossRefInfo();
                        //crossRef.ReactionID = reactionID;              
                        //crossRef.CrossRefID = Convert.ToInt32(drow["CR_ID"]);
                        ////crossRef.CrossRefNo = crossRefIndx;
                        //crossRef.PrevReactionNo = !string.IsNullOrEmpty(drow["PRE_RXN_SNO"].ToString()) ? Convert.ToInt32(drow["PRE_RXN_SNO"]) : 0;
                        //crossRef.SuccReactionNo = !string.IsNullOrEmpty(drow["SUCC_RXN_SNO"].ToString()) ? Convert.ToInt32(drow["SUCC_RXN_SNO"]) : 0;
                        //lstCrossRef.Add(crossRef);

                        //Automated Export
                        string[] saPreceeding = drow["PRECEEDING"].ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                        if (saPreceeding != null)
                        {
                            foreach (string prerxn in saPreceeding)
                            {
                                if (!string.IsNullOrEmpty(prerxn.Trim()))
                                {
                                    CrossRefInfo crossRef = new CrossRefInfo();
                                    crossRef.ReactionID = reactionID;
                                    crossRef.PrevReactionNo = prerxn.Trim();
                                    //crossRef.CrossRefType = "PRE";
                                    lstCrossRef.Add(crossRef);
                                }
                            }
                        }
                        string[] saSucceeding = drow["SUCCEEDING"].ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                        if (saSucceeding != null)
                        {
                            foreach (string succrxn in saSucceeding)
                            {
                                if (!string.IsNullOrEmpty(succrxn.Trim()))
                                {
                                    CrossRefInfo crossRef = new CrossRefInfo();
                                    crossRef.ReactionID = reactionID;
                                    crossRef.SuccReactionNo = succrxn.Trim();
                                    //crossRef.CrossRefType = "SUC";
                                    lstCrossRef.Add(crossRef);
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
            return lstCrossRef;
        }

        private static List<ProductInfo> GetProductsFromTableOnReactionID(DataTable productsData, int reactionID)
        {
            List<ProductInfo> lstProducts = null;
            try
            {
                if (productsData != null)
                {
                    EnumerableRowCollection<DataRow> rows = from row in productsData.AsEnumerable()
                                                            where row.Field<Int64>("REACTION_ID") == reactionID
                                                            select row;

                    lstProducts = new List<ProductInfo>();
                    foreach (DataRow drow in rows)
                    {
                        ProductInfo prodInfo = new ProductInfo();
                        prodInfo.ReactionID = reactionID;
                        prodInfo.ProductID = Convert.ToInt32(drow["PRODUCT_ID"]);
                        prodInfo.ProductName = drow["PRODUCT_NAME"].ToString();
                        prodInfo.Structure = drow["PROD_STRUCTURE"];
                        prodInfo.StructureNo = drow["STRUCTURE_NO"].ToString();
                        prodInfo.Yield = drow["YIELD"].ToString();
                        prodInfo.CS = drow["CHEMO_SELECTIVITY"].ToString();
                        prodInfo.EE = drow["ENANTIOMERIC_EXCESS"].ToString();
                        prodInfo.DS = drow["DIASTEREO_SELECTIVITY"].ToString();
                        prodInfo.DE = drow["DIASTEREOMERIC_EXCESS"].ToString();
                        lstProducts.Add(prodInfo);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstProducts;
        }

        private static List<StepInfo> GetStepsInfoFromTableOnReactionID(DataTable stepsData, DataTable partpntsData, DataTable conditionsData, int reactionID)
        {
            List<StepInfo> lstSteps = null;
            try
            {
                if (stepsData != null)
                {
                    EnumerableRowCollection<DataRow> rows = from row in stepsData.AsEnumerable()
                                                            where row.Field<Int64>("REACTION_ID") == reactionID
                                                            select row;

                    lstSteps = new List<StepInfo>();

                    foreach (DataRow drow in rows)
                    {
                        StepInfo stepInfo = new StepInfo();
                        stepInfo.ReactionID = reactionID;
                        stepInfo.StepID = Convert.ToInt32(drow["RXN_STEP_ID"]);
                        stepInfo.StepYield = drow["YIELD"].ToString();
                        stepInfo.SerialNo = Convert.ToInt32(drow["RXN_STEP_SNO"].ToString());
                        stepInfo.StepParticipants = GetParticipantsFromTableOnStepID(partpntsData, Convert.ToInt32(drow["RXN_STEP_ID"]));
                        stepInfo.StepConditions = GetConditionsFromTableOnStepID(conditionsData, Convert.ToInt32(drow["RXN_STEP_ID"]));
                        lstSteps.Add(stepInfo);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstSteps;
        }

        private static List<ParticipantInfo> GetParticipantsFromTableOnStepID(DataTable partpntsData, int rxnStepID)
        {
            List<ParticipantInfo> lstPartpnts = null;
            try
            {
                if (partpntsData != null)
                {
                    EnumerableRowCollection<DataRow> rows = from row in partpntsData.AsEnumerable()
                                                            where row.Field<Int64>("RXN_STEP_ID") == rxnStepID
                                                            select row;

                    lstPartpnts = new List<ParticipantInfo>();
                    foreach (DataRow drow in rows)
                    {
                        ParticipantInfo partpntInfo = new ParticipantInfo();
                        //partpntInfo.ReactionID = reactionID;
                        partpntInfo.RxnStepID = rxnStepID;
                        partpntInfo.ParticipantID = Convert.ToInt32(drow["PRPNT_ID"]);
                        partpntInfo.ParticipantName = drow["PRPNT_NAME"].ToString();
                        partpntInfo.ParticipantType = drow["PRPNT_TYPE"].ToString();
                        partpntInfo.Structure = drow["PRPNT_STRUCTURE"];
                        partpntInfo.StructureNo = drow["STRUCTURE_NO"].ToString();
                        partpntInfo.InchiKey = drow["INCHI_KEY"].ToString();
                        partpntInfo.Grade = drow["GRADE"].ToString();
                        lstPartpnts.Add(partpntInfo);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstPartpnts;
        }

        private static List<ConditionInfo> GetConditionsFromTableOnStepID(DataTable conditionsData, int rxnStepID)
        {
            List<ConditionInfo> lstConditions = null;
            try
            {
                if (conditionsData != null)
                {
                    EnumerableRowCollection<DataRow> rows = from row in conditionsData.AsEnumerable()
                                                            where row.Field<Int64>("RXN_STEP_ID") == rxnStepID
                                                            select row;

                    lstConditions = new List<ConditionInfo>();
                    foreach (DataRow drow in rows)
                    {
                        ConditionInfo condInfo = new ConditionInfo();
                        //partpntInfo.ReactionID = reactionID;
                        condInfo.RxnStepID = rxnStepID;
                        condInfo.ConditionID = Convert.ToInt32(drow["CONDITION_ID"]);
                        condInfo.Time = drow["COND_TIME"].ToString().Trim();
                        condInfo.TimeUnits = drow["COND_TIME_UNIT"].ToString();
                        condInfo.Temperature = drow["TEMPERATURE"].ToString().Trim();
                        condInfo.TempUnits = drow["TEMPERATURE_UNIT"].ToString();
                        condInfo.Pressure = drow["PRESSURE"].ToString().Trim();
                        condInfo.PressureUnits = drow["PRESSURE_UNIT"].ToString();
                        condInfo.PH = drow["PH"].ToString();
                        condInfo.Other = drow["OTHER_CONDITIONS"].ToString();
                        condInfo.Operation = drow["OPERATION"].ToString();
                        condInfo.CoolDown = drow["IS_COOL_DOWN"].ToString() == "Y" ? true : false;
                        condInfo.Reflux = drow["IS_REFLUX"].ToString() == "Y" ? true : false;
                        condInfo.WarmUp = drow["IS_WARMUP"].ToString() == "Y" ? true : false;
                        lstConditions.Add(condInfo);
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstConditions;
        }
    }
}
