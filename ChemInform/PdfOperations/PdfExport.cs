using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ChemInform.Dal;
using ChemInform.Bll;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using MarkupConverter;

namespace ChemInform.PdfOperations
{
    public class PdfExport
    {
        #region Constructor
        
        private IMarkupConverter markupConverter;
        public PdfExport()
        {
            markupConverter = new MarkupConverter.MarkupConverter();
        } 
        
        #endregion

        float rowHeight = 100f;
        StyleSheet styles;

        #region Pdf Color settings

        BaseColor bgcolTANInfo = new BaseColor(204, 255, 204);

        BaseColor bgcolRxnNo = new BaseColor(255, 239, 213);
        BaseColor bgcolNumSeq = new BaseColor(209, 238, 238);//(255, 215, 0);
        BaseColor bgcolPageInfo = new BaseColor(238, 245, 238);
        BaseColor bgcolProduct = new BaseColor(255, 204, 153);//(255, 215, 0);
        BaseColor bgcolReactant = new BaseColor(255, 239, 213);
        BaseColor bgcolRctNumStage = new BaseColor(255, 239, 213);
        BaseColor bgcolRxnPartpnt = new BaseColor(245, 255, 250);

        private iTextSharp.text.Font fontTinyItalic = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL);

        #endregion

        #region Public variables

        PdfPCell pcInfo = null;
        PdfPCell pcCmntsHdr = null;
        PdfPCell pcComments = null;
        PdfPCell pcTAN = null;
        PdfPCell pcCAN = null;
        PdfPCell pcBatch = null;
        PdfPCell pcNum = null;
        PdfPCell prdYieldCell = null;

        #endregion

        MDL.Draw.Renditor.Renditor ChemRenditor = new MDL.Draw.Renditor.Renditor();

        public bool ExportReferenceDataToPdf(int shipmentRefID, string outFilePath)
        {
            bool blStatus = false;
            try
            {
                if (shipmentRefID > 0)
                {
                    DataTable dtRxnRefs = null;
                    DataTable dtCrossRefs = null;

                    DataSet dsRxn_CrossRefs = ReactionCurationDB.GetRxnAndCrossReferencesOnShipmentRefID(shipmentRefID);
                    if (dsRxn_CrossRefs != null)
                    {
                        if (dsRxn_CrossRefs.Tables.Count == 2)
                        {
                            dtCrossRefs = dsRxn_CrossRefs.Tables[0];
                            dtRxnRefs = dsRxn_CrossRefs.Tables[1];
                        }
                    }

                    DataSet dsRxns = ReactionCurationDB.GetReactionsForExportOnDocID(shipmentRefID);
                    if (dsRxns != null)
                    {
                        if (dsRxns.Tables.Count == 8)
                        {
                            DataTable dtDocMaster = dsRxns.Tables[0];
                            DataTable dtReactions = dsRxns.Tables[1];
                            //DataTable dtRxnRefs = dsRxns.Tables[2];
                            //DataTable dtCrossRefs = dsRxns.Tables[3];
                            DataTable dtRxnSteps = dsRxns.Tables[4];
                            DataTable dtConditions = dsRxns.Tables[5];
                            DataTable dtParticipants = dsRxns.Tables[6];
                            DataTable dtProducts = dsRxns.Tables[7];

                            string rxnsRefNo = dtDocMaster.Rows[0]["REFERENCE_NAME"].ToString();
                            string sysText = dtDocMaster.Rows[0]["SYS_TEXT"].ToString();
                            string sysNo = dtDocMaster.Rows[0]["SYS_NO"].ToString();
                            string outFileName = outFilePath;// Path.Combine(outFilePath, rxnsRefNo + ".pdf");

                            List<ReactionInfo> lstRxnInfo = new List<ReactionInfo>();
                            int reactionID = 0;
                            //Unique ID for reaction (serial number); format: RXCInnnnnnnn;n=numerical range for backfiles is 70000001...89999999.
                            int mdlNo = 70000000;
                            foreach (DataRow drow in dtReactions.Rows)
                            {
                                //increment MDL Numer
                                mdlNo++;

                                reactionID = Convert.ToInt32(drow["REACTION_ID"]);

                                ReactionInfo rxnInfo = new ReactionInfo();
                                rxnInfo.ShipmentRefID = shipmentRefID;
                                rxnInfo.ReactionID = reactionID;
                                rxnInfo.SysNo = dtDocMaster.Rows[0]["SYS_NO"].ToString();
                                rxnInfo.SysText = dtDocMaster.Rows[0]["SYS_TEXT"].ToString();
                                rxnInfo.RxnMDLNo = "RXCI" + mdlNo;
                                rxnInfo.ReactionScheme = drow["REACTION_SCHEME"];
                                rxnInfo.ReactionSNo = Convert.ToInt32(drow["REACTION_SNO"]);
                                rxnInfo.RxnRef = GetRxnRefInfoFromTableOnReactionID(dtRxnRefs, reactionID);
                                rxnInfo.RxnCrossRef = GetCrossRefInfoFromTableOnReactionID(dtCrossRefs, reactionID);

                                DataTable dtRxnStages = GetStepsOnReactionID(dtRxnSteps, reactionID);
                                DataTable participantsData = GetParticipantsForProdFormation(dtParticipants, dtConditions, dtRxnStages);

                                rxnInfo.ParticipantsForPdf = participantsData;// GetReactionStepsInfoFromTableOnReactionID(dtRxnSteps, dtParticipants, dtConditions, reactionID);
                                //Add to list
                                lstRxnInfo.Add(rxnInfo);
                            }

                            if (lstRxnInfo != null)
                            {
                                if (dtReactions.Rows.Count > 0)
                                {
                                    using (iTextSharp.text.Document doc = new iTextSharp.text.Document())
                                    {
                                        iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new System.IO.FileStream(outFileName, FileMode.Create));
                                        doc.Open();

                                        //Declare Reaction Participants tables
                                        #region MyRegion
                                        DataTable dtProdTbl = null;
                                        DataTable dtReactantTbl = null;
                                        DataTable dtPartpntTbl = null;
                                        DataTable dtCondsTbl = null;                                       
                                        DataTable dtStagesTbl = null;                                      
                                        #endregion

                                        iTextSharp.text.Image chemimg = null;
                                        iTextSharp.text.Font georgia = FontFactory.GetFont("georgia", 10f);

                                        //Define variables
                                        #region MyRegion
                                        
                                        int intProdCnt = 0;
                                        int intReactCnt = 0;

                                        string strRxnHdr = "";
                                        PdfPTable PdfTable = null;
                                        PdfPCell rxnCell = null;
                                       
                                        #endregion

                                        //Define font style
                                        #region MyRegion
                                        styles = new StyleSheet();
                                        styles.LoadTagStyle("th", "size", "8px");
                                        styles.LoadTagStyle("th", "face", "helvetica");
                                        styles.LoadTagStyle("span", "size", "7px");
                                        styles.LoadTagStyle("span", "face", "helvetica");
                                        styles.LoadTagStyle("td", "size", "7px");
                                        styles.LoadTagStyle("td", "face", "helvetica");
                                        #endregion
                                                                               
                                        PdfPTable pTRxnRef = null;
                                        PdfPTable pTCrossRef = null;

                                        PdfPCell pcRxnRef = null;
                                        PdfPCell pcCrossRef = null;

                                        //Add Pdf Header to document
                                        PdfPTable ptHeader = GetPdfHeaderTable(rxnsRefNo, sysNo);
                                        doc.Add(ptHeader);

                                        //Define Participants elements
                                        List<IElement> lstPartpnt = null;
                                        
                                        foreach (ReactionInfo rxnInfo in lstRxnInfo)
                                        {
                                            //Create instance of the pdf table and set the number of column in that table
                                            PdfTable = new PdfPTable(1);
                                            PdfTable.SpacingAfter = 4f;
                                            PdfTable.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right                                
                                            PdfTable.TotalWidth = 800f;// doc.PageSize.Width;
                                            PdfTable.WidthPercentage = 100;

                                            //Add Reaction Header to Pdf Table
                                            strRxnHdr = "Reaction - " + rxnInfo.ReactionSNo.ToString();
                                            rxnCell = new PdfPCell(new Phrase(strRxnHdr, fontTinyItalic));
                                            rxnCell.Colspan = intProdCnt + intReactCnt;
                                            rxnCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;// 0; //0=Left, 1=Centre, 2=Right
                                            rxnCell.VerticalAlignment = PdfPCell.ALIGN_TOP;
                                            rxnCell.BackgroundColor = bgcolRxnNo;
                                            PdfTable.AddCell(rxnCell);
                                                  
                                            //Reaction Reference Info   
                                            pTRxnRef = GetReactionReferecneTable(rxnInfo);
                                            if (pTRxnRef != null)
                                            {
                                                pcRxnRef = new PdfPCell(pTRxnRef);
                                                pcRxnRef.Border = PdfPCell.NO_BORDER;
                                                //pcRxnRef.BackgroundColor = bgcolRctNumStage;
                                                PdfTable.AddCell(pcRxnRef);
                                            }

                                            //Cross Reference Info
                                            pTCrossRef = GetCrossReferecneTable(rxnInfo);
                                            if (pTCrossRef != null)
                                            {
                                                pcCrossRef = new PdfPCell(pTCrossRef);
                                                pcCrossRef.Border = PdfPCell.NO_BORDER;
                                                //pcRxnRef.BackgroundColor = bgcolRctNumStage;
                                                PdfTable.AddCell(pcCrossRef);
                                            }

                                            if (rxnInfo.ReactionScheme != null)
                                            {                                               
                                                System.Drawing.Image img = GetStructureImage(rxnInfo.ReactionScheme.ToString());
                                                chemimg = iTextSharp.text.Image.GetInstance(img as System.Drawing.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                if (chemimg != null)
                                                {
                                                    chemimg.ScaleToFit(450f, 150f);
                                                    //chemimg.ScaleAbsolute((float)600f, (float)250f);
                                                    chemimg.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_CENTER;

                                                    //pdfCell = new PdfPCell(chemimg, true);                                                   
                                                }
                                                else
                                                {

                                                    //pdfCell = new PdfPCell(new Phrase("Structure generation error", fontTinyItalic));
                                                }
                                               
                                                PdfTable.AddCell(chemimg);
                                            }

                                            //Product Yield, CS, DS and Other information

                                            //Get Participatns text from RichTextBox object                                          
                                            string strRtf = GetPartpntsDataBindToRichTextBox(rxnInfo.ParticipantsForPdf);

                                            //Get Participants elements from RichTextBox Rtf and convert to HTML
                                            lstPartpnt = HTMLWorker.ParseToList(new StringReader(markupConverter.ConvertRtfToHtml(strRtf)), styles);

                                            //Add Participants string in a row cell to Pdf Table
                                            PdfPCell pcPartpnt = new PdfPCell();
                                            foreach (IElement iEle in lstPartpnt)
                                            {
                                                pcPartpnt.AddElement(iEle);
                                            }
                                            pcPartpnt.Colspan = 1;// intProdCnt + intReactCnt;
                                            //pcPartpnt.BackgroundColor =  bgcolRxnPartpnt;
                                            pcPartpnt.VerticalAlignment = Element.ALIGN_TOP;
                                            pcPartpnt.HorizontalAlignment = 0;// Element.ALIGN_LEFT; //0=Left, 1=Centre, 2=Right                                   
                                            PdfTable.AddCell(pcPartpnt);
                                           

                                            doc.Add(PdfTable);
                                        }

                                        doc.Close();
                                        blStatus = true;
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
            return blStatus;
        }

        private static List<ReactionRefInfo> GetRxnRefInfoFromTableOnReactionID(DataTable rxnRefData, int reactionID)
        {
            List<ReactionRefInfo> lstRxnRef = null;
            try
            {
                if (rxnRefData != null && rxnRefData.Rows.Count > 0)
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
                        rxnRef.RefPath = drow["PATH_LETTER"].ToString();

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
                if (crossRefData != null && crossRefData.Rows.Count > 0 && reactionID > 0) 
                {                  
                    EnumerableRowCollection<DataRow> rows = from row in crossRefData.AsEnumerable()
                                                            where row.Field<Int64>("REACTION_ID") == reactionID
                                                            select row;

                    lstCrossRef = new List<CrossRefInfo>();
                    //int crossRefIndx = 0;
                    foreach (DataRow drow in rows)
                    {
                        //crossRefIndx++;

                        CrossRefInfo crossRef = new CrossRefInfo();
                        crossRef.ReactionID = reactionID;
                        //crossRef.CrossRefID = Convert.ToInt32(drow["CR_ID"]);
                        //crossRef.CrossRefNo = crossRefIndx;               
                        crossRef.PrevReactionNo = drow["PRECEEDING"].ToString();
                        crossRef.SuccReactionNo = drow["SUCCEEDING"].ToString();

                        lstCrossRef.Add(crossRef);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return lstCrossRef;
        }

        private System.Drawing.Image GetStructureImage(string molFile)
        {
            System.Drawing.Image structImg = null;
            try
            {
                ChemRenditor.MolfileString = molFile;
                ChemRenditor.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                ChemRenditor.Size = new System.Drawing.Size(900, 300);
                ChemRenditor.Preferences.AtomAtomMappingDisplay = true;
               
                //ChemRenditor.Image.Save("D:\\Test123.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //strImg =  ImageExt.Resize(ChemRenditor.Image, 0, 0, ChemRenditor.Image.Width, ChemRenditor.Image.Height, 400, 200);
                //strImg = rs.ResizePicture(ChemRenditor.Image, new System.Drawing.Size(200, 300));
                structImg = ChemRenditor.Image;

                //StructureDrawingInfo drawingInfo = new StructureDrawingInfo(new Size(width, height));
                //JChemMolecule molecule = new JChemMolecule(new MoleculeData(molfile, MoleculeFormat.Unknown));
                //molecule.CheckNull("molecule").Renderer.Settings = new JChemMoleculeRenderingSettings(drawingInfo);
                //Image moleculeImage = molecule.Renderer.RenderToImage(ImageFormat.Png);

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return structImg;
        }

        private PdfPTable GetReactionReferecneTable(ReactionInfo rxnInfo)
        {
            PdfPTable ptRxnRef = null;
            try
            {
                if (rxnInfo.RxnRef != null)
                {
                    if (rxnInfo.RxnRef.Count > 0)
                    {
                        ptRxnRef = new PdfPTable(4);
                        ptRxnRef.AddCell(new PdfPCell(new Phrase("Reaction Reference", fontTinyItalic)));
                        ptRxnRef.AddCell(new PdfPCell(new Phrase("Path No", fontTinyItalic)));
                        ptRxnRef.AddCell(new PdfPCell(new Phrase("Path", fontTinyItalic)));
                        ptRxnRef.AddCell(new PdfPCell(new Phrase("Step", fontTinyItalic)));

                        for (int i = 0; i < rxnInfo.RxnRef.Count; i++)
                        {
                            ptRxnRef.AddCell(new PdfPCell(new Phrase("", fontTinyItalic)));
                            ptRxnRef.AddCell(new PdfPCell(new Phrase(rxnInfo.RxnRef[i].ExtRegNo.ToString(), fontTinyItalic)));
                            ptRxnRef.AddCell(new PdfPCell(new Phrase(rxnInfo.RxnRef[i].RefPath.ToString(), fontTinyItalic)));
                            ptRxnRef.AddCell(new PdfPCell(new Phrase(rxnInfo.RxnRef[i].Step.ToString(), fontTinyItalic)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return ptRxnRef;
        }

        private PdfPTable GetCrossReferecneTable(ReactionInfo rxnInfo)
        {
            PdfPTable ptCrossRef = null;
            try
            {
                if (rxnInfo.RxnCrossRef != null)
                {
                    if (rxnInfo.RxnCrossRef.Count > 0)
                    {
                        ptCrossRef = new PdfPTable(4);
                        ptCrossRef.AddCell(new PdfPCell(new Phrase("Cross Reference", fontTinyItalic)));
                        ptCrossRef.AddCell(new PdfPCell(new Phrase("Prec.To Reaction", fontTinyItalic)));
                        ptCrossRef.AddCell(new PdfPCell(new Phrase("Succ.To Reaction", fontTinyItalic)));
                        ptCrossRef.AddCell(new PdfPCell(new Phrase("", fontTinyItalic)));

                        for (int i = 0; i < rxnInfo.RxnCrossRef.Count; i++)
                        {
                            ptCrossRef.AddCell(new PdfPCell(new Phrase("", fontTinyItalic)));
                            ptCrossRef.AddCell(new PdfPCell(new Phrase(rxnInfo.RxnCrossRef[i].PrevReactionNo != "0" ? rxnInfo.RxnCrossRef[i].PrevReactionNo.ToString() : "", fontTinyItalic)));
                            ptCrossRef.AddCell(new PdfPCell(new Phrase(rxnInfo.RxnCrossRef[i].SuccReactionNo != "0" ? rxnInfo.RxnCrossRef[i].SuccReactionNo.ToString() : "", fontTinyItalic)));
                            ptCrossRef.AddCell(new PdfPCell(new Phrase("", fontTinyItalic)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return ptCrossRef;
        }
        
        //Get PDF Header table
        private PdfPTable GetPdfHeaderTable(string shipmentRefName, string sysNo)
        {
            PdfPTable ptHdr = null;
            try
            {
                if (!string.IsNullOrEmpty(shipmentRefName))
                {
                    ptHdr = new PdfPTable(1);
                    ptHdr.WidthPercentage = 100;
                    ptHdr.SpacingAfter = 8f;

                    pcInfo = new PdfPCell(new Phrase("GVKBio Sciences Pvt. Ltd Internal document", fontTinyItalic));
                    pcInfo.Colspan = 3;
                    pcInfo.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    pcInfo.BackgroundColor = bgcolTANInfo;// new BaseColor(255, 160, 122);
                    ptHdr.AddCell(pcInfo);
                                       
                    pcTAN = new PdfPCell(new Phrase("Abstract - " + shipmentRefName, fontTinyItalic));
                    pcCAN = new PdfPCell(new Phrase("SysNo - " + sysNo, fontTinyItalic));                
                    //pcBatch = new PdfPCell(new Phrase("Batch - " + BatchName, fontTinyItalic));

                    pcTAN.BackgroundColor = bgcolRxnNo;
                    pcCAN.Colspan = 2;
                    pcCAN.BackgroundColor = bgcolRxnNo;
                    //pcDOI.BackgroundColor = bgcolPageInfo;
                    //pcBatch.BackgroundColor = bgcolRxnNo;
                                       
                    ptHdr.AddCell(pcTAN);
                    ptHdr.AddCell(pcCAN);
                    //ptHdr.AddCell(pcDOI);
                   // ptHdr.AddCell(pcBatch);
                                  
                    return ptHdr;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return ptHdr;
        }
             
        private DataTable GetStepParticipantsDataOnRxnStepID(DataTable partpntsData, int rxnstepID)
        {
            DataTable dtStepPartpnts = null;
            try
            {
                if (partpntsData != null)
                {
                    if (partpntsData.Rows.Count > 0)
                    {
                        dtStepPartpnts = partpntsData.Copy();
                        DataView dvTemp = dtStepPartpnts.DefaultView;
                        dvTemp.RowFilter = "RXN_STEP_ID = " + rxnstepID + " and PRPNT_TYPE <> 'REACTANT'";
                        //dvTemp.Sort = "rxn_stage_id asc";
                        dtStepPartpnts = dvTemp.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtStepPartpnts;
        }

        private DataTable GetStepConditionsDataOnRxnStepID(DataTable conditionsData, int rxnstepID)
        {
            DataTable dtStepConds = null;
            try
            {
                if (conditionsData != null)
                {
                    if (conditionsData.Rows.Count > 0)
                    {
                        dtStepConds = conditionsData.Copy();
                        DataView dvTemp = dtStepConds.DefaultView;
                        dvTemp.RowFilter = "RXN_STEP_ID = " + rxnstepID;                       
                        dtStepConds = dvTemp.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtStepConds;
        }

        private DataTable GetStepsOnReactionID(DataTable stepsData, int _rxnID)
        {
            DataTable dtStages = null;
            try
            {
                if (stepsData != null)
                {
                    if (stepsData.Rows.Count > 0)
                    {
                        dtStages = stepsData.Copy();
                        DataView dvTemp = dtStages.DefaultView;
                        dvTemp.RowFilter = "REACTION_ID = " + _rxnID;
                        //dvTemp.Sort = "stageid asc";
                        dtStages = dvTemp.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtStages;
        }

        private DataTable GetParticipantsForProdFormation(DataTable partpntsData, DataTable condsData, DataTable stepsData)
        {
            DataTable dtPartpnts = null;
            try
            {
                if (stepsData != null)
                {
                    if (stepsData.Rows.Count > 0)
                    {
                        dtPartpnts = new DataTable();
                        dtPartpnts.Columns.Add("Stage", typeof(string));
                        dtPartpnts.Columns.Add("Agents", typeof(string));
                        dtPartpnts.Columns.Add("Solvents", typeof(string));
                        dtPartpnts.Columns.Add("Catalysts", typeof(string));
                        dtPartpnts.Columns.Add("Temperature", typeof(string));
                        dtPartpnts.Columns.Add("Time", typeof(string));
                        dtPartpnts.Columns.Add("Pressure", typeof(string));
                        dtPartpnts.Columns.Add("pH", typeof(string));
                        dtPartpnts.Columns.Add("WarmUp", typeof(string));
                        dtPartpnts.Columns.Add("CoolDown", typeof(string));
                        dtPartpnts.Columns.Add("Reflux", typeof(string));
                                 
                        string strAgent = "";
                        string strSolvent = "";
                        string strCatalyst = "";
                        string strTemp = "";
                        string strTime = "";
                        string strPressure = "";
                        string strPh = "";

                        string strWarmup = "";
                        string strCoolDown = "";
                        string strReflux = "";

                        int intStepID = 0;
                        string stepName = "";

                        DataTable dtAgent = null;
                        DataTable dtSolvent = null;
                        DataTable dtCatalyst = null;
                        DataTable dtConditions = null;

                        for (int i = 0; i < stepsData.Rows.Count; i++)
                        {
                            intStepID = Convert.ToInt32(stepsData.Rows[i]["RXN_STEP_ID"].ToString());
                            stepName = stepsData.Rows[i]["RXN_STEP_SNO"].ToString() != "0" ? "Step" + stepsData.Rows[i]["RXN_STEP_SNO"].ToString() : "Step" + (i + 1).ToString();

                            dtAgent = GetPartpantDataFromTableOnStageID(partpntsData, intStepID, "AGENT");
                            dtSolvent = GetPartpantDataFromTableOnStageID(partpntsData, intStepID, "SOLVENT");
                            dtCatalyst = GetPartpantDataFromTableOnStageID(partpntsData, intStepID, "CATALYST");
                            dtConditions = GetPartpantDataFromTableOnStageID(condsData, intStepID, "");

                            strAgent = GetParticipantStringFromTable(dtAgent, "AGENT");
                            strSolvent = GetParticipantStringFromTable(dtSolvent, "SOLVENT");
                            strCatalyst = GetParticipantStringFromTable(dtCatalyst, "CATALYST");
                            strTemp = GetCondtionsStringFromTable(dtConditions, out strTime, out strPressure, out strPh, out strWarmup, out strCoolDown, out strReflux);
                                                        
                            DataRow dtRow = dtPartpnts.NewRow();
                            dtRow["Stage"] = stepName;
                            dtRow["Agents"] = strAgent;
                            dtRow["Solvents"] = strSolvent;
                            dtRow["Catalysts"] = strCatalyst;
                            dtRow["Temperature"] = strTemp;
                            dtRow["Time"] = strTime;
                            dtRow["Pressure"] = strPressure;
                            dtRow["pH"] = strPh;
                            dtRow["WarmUp"] = strWarmup;
                            dtRow["CoolDown"] = strCoolDown;
                            dtRow["Reflux"] = strReflux;

                            dtPartpnts.Rows.Add(dtRow);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtPartpnts;
        }

        private DataTable GetPartpantDataFromTableOnStageID(DataTable _partpnttbl, int _stepID, string _partpnttype)
        {
            DataTable dtpatpnt = null;
            try
            {
                if (_partpnttbl != null)
                {
                    if (_partpnttbl.Rows.Count > 0 && _stepID > 0)
                    {
                        DataView dvTemp = _partpnttbl.DefaultView;
                        if (!string.IsNullOrEmpty(_partpnttype.Trim()))
                        {
                            dvTemp.RowFilter = "RXN_STEP_ID = " + _stepID + " and PRPNT_TYPE = '" + _partpnttype + "'";
                        }
                        else
                        {
                            dvTemp.RowFilter = "RXN_STEP_ID = " + _stepID;
                        }
                        dtpatpnt = dvTemp.ToTable();
                        return dtpatpnt;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return dtpatpnt;
        }

        private string GetParticipantStringFromTable(DataTable partpnttbl, string partpnt)
        {
            string strPartpnt = "";
            string strValue = "";
            try
            {
                string strTemp = "";
                if (partpnt == "AGENT")
                {
                    strTemp = "NO AGENT";
                }
                else if (partpnt == "SOLVENT")
                {
                    strTemp = "NO SOLVENT";
                }
                else if (partpnt == "CATALYST")
                {
                    strTemp = "NO CATALYST";
                }

                if (partpnttbl != null)
                {
                    if (partpnttbl.Rows.Count > 0)
                    {
                        for (int i = 0; i < partpnttbl.Rows.Count; i++)
                        {
                            strValue = "";

                            if (!string.IsNullOrEmpty(partpnttbl.Rows[i]["PRPNT_NAME"].ToString().Trim()))
                            {
                                if (partpnttbl.Rows[i]["PRPNT_NAME"].ToString().Trim().ToUpper() != strTemp)
                                {
                                    strValue = partpnttbl.Rows[i]["PRPNT_NAME"].ToString().Trim();
                                }                                
                            }                            
                            if (!string.IsNullOrEmpty(strValue.Trim()))
                            {
                                strPartpnt = string.IsNullOrEmpty(strPartpnt.Trim()) ? partpnt + "= " + strValue : strPartpnt + ", " + strValue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strPartpnt;
        }

        private string GetCondtionsStringFromTable(DataTable condstbl, out string time_out, out string pressure_out, out string ph_out, out string warmUp_out, out string coolDown_out, out string reflux_out)
        {
            string strTemp = "";
            string strTime = "";
            string strPressure = "";
            string strPH = "";
            string strWarmUp = "";
            string strCoolDown = "";
            string strReflux = "";

            try
            {
                if (condstbl != null)
                {
                    if (condstbl.Rows.Count > 0)
                    {
                        for (int i = 0; i < condstbl.Rows.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(condstbl.Rows[i]["TEMPERATURE"].ToString().Trim()))
                            {
                                string temp = condstbl.Rows[i]["TEMPERATURE"].ToString() + "(" + condstbl.Rows[i]["TEMPERATURE_UNIT"].ToString() + ")";
                                strTemp = string.IsNullOrEmpty(strTemp.Trim()) ? "TP: " + temp : strTemp + "," + temp;
                            }

                            if (!string.IsNullOrEmpty(condstbl.Rows[i]["COND_TIME"].ToString().Trim()))
                            {
                                string tempTime = condstbl.Rows[i]["COND_TIME"].ToString() + "(" + condstbl.Rows[i]["COND_TIME_UNIT"].ToString() + ")";
                                strTime = string.IsNullOrEmpty(strTime.Trim()) ? "TM: " + tempTime : strTime + "," + tempTime;
                            }

                            if (!string.IsNullOrEmpty(condstbl.Rows[i]["PRESSURE"].ToString().Trim()))
                            {
                                string pres = condstbl.Rows[i]["PRESSURE"].ToString() + "(" + condstbl.Rows[i]["PRESSURE_UNIT"].ToString() + ")";
                                strPressure = string.IsNullOrEmpty(strPressure.Trim()) ? "PR: " + pres : strPressure + "," + pres;
                            }

                            if (!string.IsNullOrEmpty(condstbl.Rows[i]["PH"].ToString().Trim()))
                            {
                                strPH = string.IsNullOrEmpty(strPH.Trim()) ? "PH: " + condstbl.Rows[i]["PH"].ToString() : strPH + "," + condstbl.Rows[i]["PH"].ToString();
                            }

                            //WarmUp
                            if (condstbl.Rows[i]["IS_WARMUP"].ToString().ToUpper() == "Y")
                            {
                                strWarmUp = string.IsNullOrEmpty(strWarmUp.Trim()) ? "WARMUP: Yes" : strWarmUp + ",WARMUP: Yes";
                            }

                            //CoolDown
                            if (condstbl.Rows[i]["IS_COOL_DOWN"].ToString().ToUpper() == "Y")
                            {
                                strCoolDown = string.IsNullOrEmpty(strCoolDown.Trim()) ? "COOLDOWN: Yes" : strCoolDown + "," + "COOLDOWN: Yes";
                            }

                            //Reflux
                            if (condstbl.Rows[i]["IS_REFLUX"].ToString().ToUpper() == "Y")
                            {
                                strReflux = string.IsNullOrEmpty(strReflux.Trim()) ? "REFLUX: Yes" : strReflux + "," + "REFLUX: Yes";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            time_out = strTime;
            pressure_out = strPressure;
            ph_out = strPH;
            warmUp_out = strWarmUp;
            coolDown_out = strCoolDown;
            reflux_out = strReflux;
            return strTemp;
        }

        private string GetPartpntsDataBindToRichTextBox(DataTable participantsData)
        {         
            string rtf = "";
            try
            {
                using (RichTextBox rtbPartpnts = new RichTextBox())
                {
                    //Participants, Conditions and RSN Information
                    rtbPartpnts.Text = GetParticipantsStringFromTable(participantsData);

                    //Replace New line with junk characters before coloring and replace the same with new line after coloring
                    rtbPartpnts.Rtf = rtbPartpnts.Rtf.Replace("\r\n", "_|0|_");
                    ColourRichTextBoxText(rtbPartpnts);
                    rtbPartpnts.Rtf = rtbPartpnts.Rtf.Replace("_|0|_", "\r\n");
                    rtf = rtbPartpnts.Rtf;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return rtf;
        }

        private string GetParticipantsStringFromTable(DataTable participantsData)
        {
            string strPartpnt = "";
            try
            {
                if (participantsData != null)
                {
                    if (participantsData.Rows.Count > 0)
                    {
                        for (int i = 0; i < participantsData.Rows.Count; i++)
                        {
                            if (participantsData.Rows[i]["Agents"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["Solvents"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["Catalysts"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["Temperature"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["Time"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["Pressure"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["pH"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["WarmUp"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["CoolDown"].ToString().Trim() != "" ||
                                participantsData.Rows[i]["Reflux"].ToString().Trim() != "")
                            {
                                strPartpnt = string.IsNullOrEmpty(strPartpnt.Trim()) ? participantsData.Rows[i]["Stage"].ToString() + " - " : strPartpnt + "\r\n" + participantsData.Rows[i]["Stage"].ToString() + " - ";

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["Agents"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["Agents"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["Solvents"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["Solvents"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["Catalysts"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["Catalysts"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["Temperature"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["Temperature"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["Time"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["Time"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["Pressure"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["Pressure"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["pH"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["pH"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["WarmUp"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["WarmUp"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["CoolDown"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["CoolDown"].ToString().Trim();
                                }

                                if (!string.IsNullOrEmpty(participantsData.Rows[i]["Reflux"].ToString().Trim()))
                                {
                                    strPartpnt = strPartpnt.Trim() + "  " + participantsData.Rows[i]["Reflux"].ToString().Trim();
                                }
                            }
                            else//No Agent/Solvent/Catalyst/Conditions are available
                            {
                                strPartpnt = string.IsNullOrEmpty(strPartpnt.Trim()) ? participantsData.Rows[i]["Stage"].ToString() + " - " : strPartpnt + "\r\n" + participantsData.Rows[i]["Stage"].ToString() + " - ";

                                strPartpnt = strPartpnt + " No Agent / Catalyst / Solent / Conditions are available";
                            }                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strPartpnt;
        }

        private void ColourRichTextBoxText(RichTextBox rtb)
        {
            try
            {
                Regex regEx_Stg = new Regex("Step[0-9]{0,3}");
                foreach (Match match in regEx_Stg.Matches(rtb.Text))
                {
                    rtb.Select(match.Index, match.Length);
                    rtb.SelectionColor = Color.DarkOrange;
                }

                Regex regEx_Empty = new Regex("No Agent / Catalyst / Solent / Conditions are available");
                foreach (Match match in regEx_Empty.Matches(rtb.Text))
                {
                    rtb.Select(match.Index, match.Length);
                    rtb.SelectionColor = Color.LightGray;
                }

                Regex regEx_C = new Regex("TP:|TM:|PR:|PH:");
                foreach (Match match in regEx_C.Matches(rtb.Text))
                {
                    rtb.Select(match.Index, match.Length);
                    rtb.SelectionColor = Color.Red;
                }

                Regex regEx_P = new Regex("AGENT|SOLVENT|CATALYST");
                foreach (Match match in regEx_P.Matches(rtb.Text))
                {
                    rtb.Select(match.Index, match.Length);
                    rtb.SelectionColor = Color.LimeGreen;
                }

                Regex regEx_R = new Regex("WARMUP|COOLDOWN|REFLUX");
                foreach (Match match in regEx_R.Matches(rtb.Text))
                {
                    rtb.Select(match.Index, match.Length);
                    rtb.SelectionColor = Color.DarkViolet;
                }

                //Regex regEx_CVT = new Regex("CVT|FREE");
                //foreach (Match match in regEx_CVT.Matches(rtb.Text))
                //{
                //    rtb.Select(match.Index, match.Length);
                //    rtb.SelectionColor = Color.DeepPink;
                //}
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }
    }
}
