using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChemInform.Bll;
using chemaxon.formats;
using chemaxon.util;
using chemaxon.struc;
using chemaxon.struc.prop;
using java.io;
using System.Data;
using ChemInform.Common;
using System.IO;

namespace ChemInform.Export
{
    public class ReactionExport
    {
        #region MyRegion
        //Molecule mol = MolImporter.importMol("ccccc");
        //MHashProp hashProp = new MHashProp();
        //mol.setPropertyObject("ROOT", hashProp);
        //hashProp.put("CdId", new MStringProp("1"));
        //hashProp.put("Formula", new MStringProp("C5H10"));
        //MMoleculeProp secondaryStruc = new MMoleculeProp(MolImporter.importMol("cc"));
        //hashProp.put("secondStruct", secondaryStruc);
        //mol.setProperty("$REGNO", "MI24");
        //System.out.println(MolExporter.exportToFormat(mol, "rdf")); 
        #endregion
               
        public static void TestRDF()
        {
            try
            {
                FileOutputStream fOutStream = new FileOutputStream("D:\\TestProjects\\test12345.rdf");
                MolExporter objmExporter = new MolExporter(fOutStream, "rdf");

                Molecule mol = MolImporter.importMol("ccccc");
                MHashProp hashProp = new MHashProp();
                mol.setPropertyObject("RXN:VARIATION(1)", hashProp);
               
                hashProp.put("CdId", new MStringProp("1"));
                hashProp.put("Formula", new MStringProp("C5H10"));
                MMoleculeProp secondaryStruc = new MMoleculeProp(MolImporter.importMol("cc"));
                hashProp.put("solvent", secondaryStruc);

                MMoleculeProp secondaryStruc2 = new MMoleculeProp(MolImporter.importMol("cc"));
                hashProp.put("Catalyst", secondaryStruc2);

                mol.setProperty("$REGNO", "MI24");
                //System.out.println(MolExporter.exportToFormat(mol, "rdf"));

                objmExporter.write(mol);
                fOutStream.close();
                objmExporter.close();
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        public static bool ExportToRDFile(List<ReactionInfo> lstRxnsInfo, FullArticleInfo articleInfo, string shipmentRefNo, string outputFolderPath, ref List<string> lstUniqueInchiKeys, ref DeliverySolvCats refSolvCats)
        {
            bool blStatus = false;

            try
            {
                string strOutFileName = "";
                string strImpRdfOutFileName = "";
                MolHandler objMolHandler = null;
                Molecule molReaction = null;
                string strPropName = "";
                string strRefName = "";
                FileOutputStream fOutStreamImp = null;

                if (lstRxnsInfo != null && !string.IsNullOrEmpty(outputFolderPath) && articleInfo != null)
                {
                    strRefName = articleInfo.ArticleType == "ABSTRACT" ? shipmentRefNo : articleInfo.JournalName;

                    strOutFileName = Path.Combine(outputFolderPath, strRefName + ".rdf");

                    List<NewSolvents> lstRefNewSolvents = new List<NewSolvents>();

                    //Only Journal type references have Important RDF
                    if (articleInfo.ArticleType == "JOURNAL")
                    {
                        strImpRdfOutFileName = Path.Combine(outputFolderPath, strRefName + "_Important.rdf");
                        fOutStreamImp = new FileOutputStream(strImpRdfOutFileName, false);
                    }

                    //Create Exporter & OutputSteam objects
                    using (FileOutputStream fOutStream = new FileOutputStream(strOutFileName, false))
                    {
                        MolExporter objmExporter = new MolExporter(fOutStream, "rdf");
                        MolExporter objmExporterImp = null;
                        //Only Journal type references have Important RDF
                        if (articleInfo.ArticleType == "JOURNAL")
                        {
                            objmExporterImp = new MolExporter(fOutStreamImp, "rdf");
                        }

                        string strExtReg = "";
                        int rxnIndx = 0;

                        foreach (ReactionInfo rxnInfo in lstRxnsInfo)
                        {
                            rxnIndx++;

                            //Reaction Scheme Molecule
                            objMolHandler = new MolHandler(rxnInfo.ReactionScheme.ToString());
                            molReaction = objMolHandler.getMolecule();

                            //Create Property Hash
                            MHashProp hashProp = new MHashProp();
                            molReaction.setPropertyObject("RXN:VARIATION(1)", hashProp);

                            //Journal type reference
                            if (articleInfo.ArticleType == "JOURNAL")
                            {
                                //Journal Information
                                hashProp.put("LITREF(1):JOURNAL:JRNL", new MStringProp(articleInfo.JournalName));
                                hashProp.put("LITREF(1):JOURNAL:YEAR", new MStringProp(articleInfo.JournalYear.ToString()));
                                hashProp.put("LITREF(1):JOURNAL:VOL.", new MStringProp(articleInfo.JournalVolume.ToString()));
                                hashProp.put("LITREF(1):JOURNAL:DOI", new MStringProp(articleInfo.JournalDOI));
                                hashProp.put("LITREF(1):JOURNAL:PG.", new MStringProp(articleInfo.JournalStartPage + '-' + articleInfo.JournalEndPage));
                            }
                            else //ABSTRACT Type
                            {
                                //Reference Information 
                                //Multiple SysNos separated by ';'
                                string[] saSysNos = rxnInfo.SysNo.Trim().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                                if (saSysNos != null)
                                {
                                    if (saSysNos.Length == 1)
                                    {
                                        hashProp.put("SYSNO", new MStringProp(saSysNos[0].Trim()));
                                    }
                                    else if (saSysNos.Length > 1)
                                    {
                                        for (int i = 0; i < saSysNos.Length; i++)
                                        {
                                            hashProp.put("SYSNO(" + (i + 1) + ")", new MStringProp(saSysNos[i].Trim()));
                                        }
                                    }
                                }

                                //SysText is not required
                                //hashProp.put("SYSNO", new MStringProp(rxnInfo.SysNo));
                                //hashProp.put("SYSTEXT", new MStringProp(rxnInfo.SysText)); 
                            }

                            //17th Dec 2014 - Added Reaction Comments
                            if (!string.IsNullOrEmpty(rxnInfo.RxnComments))
                            {
                                hashProp.put("COMMENTS(1)", new MStringProp(rxnInfo.RxnComments));
                            }

                            hashProp.put("NSTEPS", new MStringProp(rxnInfo.RxnSteps.Count.ToString()));

                            //RxnRef Information
                            if (rxnInfo.RxnRef != null)
                            {
                                for (int rRefIndx = 0; rRefIndx < rxnInfo.RxnRef.Count; rRefIndx++)
                                {
                                    //ExtReg
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnRef[rRefIndx].ExtRegNo.ToString()))
                                    {
                                        strPropName = "RXNREF(" + (rRefIndx + 1) + "):EXTREG";
                                        strExtReg = shipmentRefNo.Trim().Replace("-", "") + rxnInfo.RxnRef[rRefIndx].ExtRegNo.ToString("00");
                                        hashProp.put(strPropName, new MStringProp(strExtReg));
                                    }

                                    //Path
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnRef[rRefIndx].RefPath))
                                    {
                                        strPropName = "RXNREF(" + (rRefIndx + 1) + "):PATH";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnRef[rRefIndx].RefPath));
                                    }

                                    //Step
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnRef[rRefIndx].Step))
                                    {
                                        strPropName = "RXNREF(" + (rRefIndx + 1) + "):STEP";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnRef[rRefIndx].Step.ToUpper()));
                                    }
                                }
                            }

                            //Add Reaction RefNo
                            strPropName = "CROSSREF:REFNO";
                            hashProp.put(strPropName, new MStringProp(shipmentRefNo.Replace("-", "").Trim()));

                            //CrossRef ID
                            strPropName = "CROSSREF:ID";
                            hashProp.put(strPropName, new MStringProp(rxnIndx.ToString()));

                            //CrossRef Information
                            if (rxnInfo.RxnCrossRef != null)
                            {
                                int prerxnIndx = 0;
                                int sucrxnIndx = 0;

                                for (int crefIndx = 0; crefIndx < rxnInfo.RxnCrossRef.Count; crefIndx++)
                                {
                                    #region MyRegion
                                    ////REFNO
                                    //if (!string.IsNullOrEmpty(rxnInfo.RxnCrossRef[crefIndx].CrossRefNo.ToString()))
                                    //{
                                    //    strPropName = "CROSSREF(" + (crefIndx + 1) + "):REFNO";
                                    //    hashProp.put(strPropName, new MStringProp(rxnInfo.RxnCrossRef[crefIndx].CrossRefNo.ToString()));
                                    //}

                                    ////ID
                                    //if (!string.IsNullOrEmpty(rxnInfo.RxnCrossRef[crefIndx].CrossRefID.ToString()))
                                    //{
                                    //    strPropName = "CROSSREF(" + (crefIndx + 1) + "):ID";
                                    //    hashProp.put(strPropName, new MStringProp(rxnInfo.RxnCrossRef[crefIndx].CrossRefNo.ToString()));
                                    //} 
                                    #endregion

                                    //SUCCRXN
                                    if (rxnInfo.RxnCrossRef[crefIndx].SuccReactionNo != null && rxnInfo.RxnCrossRef[crefIndx].SuccReactionNo != "0")
                                    {
                                        sucrxnIndx++;
                                        strPropName = "CROSSREF:SUCCRXN(" + (sucrxnIndx) + ")";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnCrossRef[crefIndx].SuccReactionNo.ToString()));
                                    }

                                    //PRERXN
                                    if (rxnInfo.RxnCrossRef[crefIndx].PrevReactionNo != null && rxnInfo.RxnCrossRef[crefIndx].PrevReactionNo != "0")
                                    {
                                        prerxnIndx++;
                                        strPropName = "CROSSREF:PRERXN(" + (prerxnIndx) + ")";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnCrossRef[crefIndx].PrevReactionNo.ToString()));
                                    }
                                }
                            }

                            //Product Information
                            if (rxnInfo.RxnProducts != null)
                            {
                                for (int prodIndx = 0; prodIndx < rxnInfo.RxnProducts.Count; prodIndx++)
                                {
                                    //Product Yield
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnProducts[prodIndx].Yield))
                                    {
                                        strPropName = "PRODUCT(" + (prodIndx + 1) + "):YIELD";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnProducts[prodIndx].Yield.Replace(" to ", "-")));
                                    }

                                    //Product CS
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnProducts[prodIndx].CS))
                                    {
                                        strPropName = "PRODUCT(" + (prodIndx + 1) + "):CS";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnProducts[prodIndx].CS));
                                    }

                                    //Product DS
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnProducts[prodIndx].DS))
                                    {
                                        strPropName = "PRODUCT(" + (prodIndx + 1) + "):DS";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnProducts[prodIndx].DS));
                                    }

                                    //Product DE
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnProducts[prodIndx].DE))
                                    {
                                        strPropName = "PRODUCT(" + (prodIndx + 1) + "):DE";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnProducts[prodIndx].DE));
                                    }

                                    //Product EE
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnProducts[prodIndx].EE))
                                    {
                                        strPropName = "PRODUCT(" + (prodIndx + 1) + "):EE";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnProducts[prodIndx].EE));
                                    }
                                }
                            }


                            int intPropIndx = 0;
                            MMoleculeProp partpntMol;
                            int intStep = 0;

                            int reactantIndx = 0;
                            //Reactant Information
                            if (rxnInfo.RxnSteps != null)
                            {
                                for (int stepIndx = 0; stepIndx < rxnInfo.RxnSteps.Count; stepIndx++)
                                {
                                    intStep = stepIndx + 1;

                                    if (rxnInfo.RxnSteps[stepIndx].StepParticipants != null)
                                    {
                                        for (int ppntIndx = 0; ppntIndx < rxnInfo.RxnSteps[stepIndx].StepParticipants.Count; ppntIndx++)
                                        {
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()) &&
                                                 rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantType.ToUpper() == "REACTANT")
                                            {
                                                reactantIndx++;

                                                //Reactant Grade 
                                                if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Grade))
                                                {
                                                    //Changed based on feedback on 27th Oct 2014
                                                    //Format error: DTYPE STEPNO(x):REACTANT(1):GRADE is invalid: it is REACTANT(1):GRADE directly under VARIATION
                                                    //strPropName = "STEPNO(" + intStep + "):" + "REACTANT(" + (ppntIndx + 1) + "):GRADE";

                                                    strPropName = "REACTANT(" + reactantIndx + "):GRADE";
                                                    hashProp.put(strPropName, new MStringProp(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Grade.ToString()));
                                                }

                                                //ADD.STEP Step no. in multistep sequence in which reactant is added
                                                if (intStep > 1)
                                                {
                                                    //Changed based on feedback on 27th Oct 2014
                                                    //Format error: several occurrences of REACTANT which is out of range: REACTANT(4):ADD.STEP where only 2 reactants exist (e.g. RXCI70000010)
                                                    //strPropName = "REACTANT(" + intStep + "):ADD.STEP";
                                                    strPropName = "REACTANT(" + reactantIndx + "):ADD.STEP";
                                                    hashProp.put(strPropName, new MStringProp(intStep.ToString()));
                                                }
                                            }
                                        }
                                    }
                                }

                                int catlyAgentIndx = 0;
                                int solventIndx = 0;

                                #region Code moved to Agents & Catalyst part on 4th Nov 2014
                                //for (int stepIndx = 0; stepIndx < rxnInfo.RxnSteps.Count; stepIndx++)
                                //{
                                //    intStep = stepIndx + 1;
                                //    solventIndx = 0;

                                //    if (rxnInfo.RxnSteps[stepIndx].StepParticipants != null)
                                //    {
                                //        for (int ppntIndx = 0; ppntIndx < rxnInfo.RxnSteps[stepIndx].StepParticipants.Count; ppntIndx++)
                                //        {
                                //            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()) &&
                                //                 rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantType.ToUpper() == "SOLVENT")
                                //            {
                                //                solventIndx = +1;

                                //                strPropName = "STEPNO(" + intStep + "):" + "SOLVENT(" + solventIndx + "):REGNO";
                                //                partpntMol = new MMoleculeProp(MolImporter.importMol(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()));
                                //                hashProp.put(strPropName, partpntMol);

                                //                //Check the Structure in the Solvents-Catalysts Master. If not there, export to new SDF 
                                //                if (rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey.ToUpper() != "INCHI NOT GENERATED")
                                //                {
                                //                    if (ChemistryOperations.CheckStructureInSolventAgentsMaster(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey))
                                //                    {
                                //                        NewSolvents objNewSolv = new NewSolvents();
                                //                        objNewSolv.StructureMolFile = rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString();
                                //                        objNewSolv.StructureName = rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantName;
                                //                        if (lstNewSolvents == null)
                                //                        {
                                //                            lstNewSolvents = new List<NewSolvents>();
                                //                        }
                                //                        lstNewSolvents.Add(objNewSolv);
                                //                    }
                                //                }
                                //            }
                                //        }
                                //    }
                                //} 
                                #endregion

                                intStep = 0;

                                //Solvents, Catalysts and Agents information      
                                for (int stepIndx = 0; stepIndx < rxnInfo.RxnSteps.Count; stepIndx++)
                                {
                                    intStep = stepIndx + 1;

                                    catlyAgentIndx = 0;
                                    solventIndx = 0;

                                    if (rxnInfo.RxnSteps[stepIndx].StepParticipants != null)
                                    {
                                        for (int ppntIndx = 0; ppntIndx < rxnInfo.RxnSteps[stepIndx].StepParticipants.Count; ppntIndx++)
                                        {
                                            //New modification on 19th June 2015 based on client feedback
                                            //if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()))
                                            //{
                                                ////Hydrogen only structures, connection tables are not allowed to export in RDF
                                                //if (!ChemistryOperations.CheckStructureIsHydrogenOnly(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey))
                                                //{
                                                    if (rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantType.ToUpper() == "CATALYST" ||
                                                        rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantType.ToUpper() == "AGENT")
                                                    {
                                                        catlyAgentIndx = catlyAgentIndx + 1;

                                                        strPropName = "STEPNO(" + intStep + "):" + "CATALYST(" + catlyAgentIndx + "):REGNO";
                                                        if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()))
                                                        {
                                                            partpntMol = new MMoleculeProp(MolImporter.importMol(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()));
                                                            hashProp.put(strPropName, partpntMol);
                                                        }
                                                        else 
                                                        {
                                                            //New modification on 19th June 2015 based on client feedback
                                                            //The SOLVCATS file also contains “no-structures”, molecules without connection table. If such items are used as catalyst or solvent they must be provided with their name (this was stated already in my email from Nov 3rd, 2014), e.g. for hydrogen as catalyst:
                                                            //$DTYPE RXN:VARIATION(1):STEPNO(1):CATALYST(1):REGNO
                                                            //$DATUM $MEREG H2
                                                            //where the “name” is “H2”  and is entered following the tag “$MEREG” (which means molecule external registry).
                                                            
                                                            string temp = "$MEREG " + rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantName.ToString();
                                                            hashProp.put(strPropName, new MStringProp(temp));
                                                        }
                                                       

                                                        if (rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantType.ToUpper() == "CATALYST")
                                                        {
                                                            //For Catalyst Additional Flag
                                                            strPropName = "STEPNO(" + intStep + "):" + "CATALYST(" + catlyAgentIndx + "):CAT";
                                                            hashProp.put(strPropName, new MStringProp("yes"));
                                                        }

                                                        ////Solvent/Agent/Catalyst Grade - new feature on 20th March 2015 for JOURNALS
                                                        //if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Grade))
                                                        //{
                                                        //    strPropName = "CATALYST(" + catlyAgentIndx + "):GRADE";
                                                        //    hashProp.put(strPropName, new MStringProp(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Grade.ToString()));
                                                        //}
                                                    }
                                                    else if (rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantType.ToUpper() == "SOLVENT")
                                                    {
                                                        solventIndx = solventIndx + 1;

                                                        strPropName = "STEPNO(" + intStep + "):" + "SOLVENT(" + solventIndx + "):REGNO";
                                                        partpntMol = new MMoleculeProp(MolImporter.importMol(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()));
                                                        hashProp.put(strPropName, partpntMol);

                                                        ////Solvent/Agent/Catalyst Grade - new feature on 20th March 2015 for JOURNALS
                                                        //if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Grade))
                                                        //{
                                                        //    strPropName = "SOLVENT(" + solventIndx + "):GRADE";
                                                        //    hashProp.put(strPropName, new MStringProp(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Grade.ToString()));
                                                        //}
                                                    }

                                                    //Check the Structure in the Solvents-Catalysts Master. If not there, export to new RDF 
                                                    if (rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantType.ToUpper() != "REACTANT" &&
                                                        rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey.ToUpper() != "INCHI NOT GENERATED")
                                                    {
                                                        //Check the Structure in the Solvents-Catalysts Master
                                                        if (!ChemistryOperations.CheckStructureInSolventAgentsMaster(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey))
                                                        {
                                                            //Check the Structure in the Delivered Solvents-Catalysts
                                                            if (!ChemistryOperations.CheckStructureInDeliveredSolventCatalysts(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey))
                                                            {
                                                                if (!lstUniqueInchiKeys.Contains(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey))
                                                                {
                                                                    //Add Inchi Key to Shipment wise Unique new Solvents 
                                                                    lstUniqueInchiKeys.Add(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey);

                                                                    NewSolvents objNewSolv = new NewSolvents();
                                                                    objNewSolv.StructureMolFile = rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString();
                                                                    objNewSolv.StructureName = rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantName;
                                                                    objNewSolv.StructureInchiKey = rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey;

                                                                    lstRefNewSolvents.Add(objNewSolv);

                                                                }
                                                            }
                                                        }
                                                    }
                                                //}                                                
                                           // }
                                        }
                                    }

                                    //Step Yeild - 22nd Dec 2014
                                    if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepYield.Trim()))
                                    {
                                        strPropName = "STEPNO(" + intStep + "):" + "ST.YLD";
                                        hashProp.put(strPropName, new MStringProp(rxnInfo.RxnSteps[stepIndx].StepYield.Trim()));
                                    }
                                }

                                intStep = 0;
                                //intPIndx = 0;

                                #region Code integrated in Catalyst part and code commented on 4th Nov 2014
                                ////AGENT information - If Agent, Property should be 'CATALYST' and not flag - 22Oct2014     
                                //for (int stepIndx = 0; stepIndx < rxnInfo.RxnSteps.Count; stepIndx++)
                                //{
                                //    intStep = stepIndx + 1;
                                //    //intPIndx = 0;

                                //    if (rxnInfo.RxnSteps[stepIndx].StepParticipants != null)
                                //    {
                                //        for (int ppntIndx = 0; ppntIndx < rxnInfo.RxnSteps[stepIndx].StepParticipants.Count; ppntIndx++)
                                //        {
                                //            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()) &&
                                //                 rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantType.ToUpper() == "AGENT")
                                //            {
                                //                intPIndx = intPIndx + 1;

                                //                strPropName = "STEPNO(" + intStep + "):" + "CATALYST(" + intPIndx + "):REGNO";
                                //                partpntMol = new MMoleculeProp(MolImporter.importMol(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString()));
                                //                hashProp.put(strPropName, partpntMol);

                                //                //Check the Structure in the Solvents-Catalysts Master. If not there, export to new SDF 
                                //                if (rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey.ToUpper() != "INCHI NOT GENERATED")
                                //                {
                                //                    if (ChemistryOperations.CheckStructureInSolventAgentsMaster(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].InchiKey))
                                //                    {
                                //                        NewSolvents objNewSolv = new NewSolvents();
                                //                        objNewSolv.StructureMolFile = rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].Structure.ToString();
                                //                        objNewSolv.StructureName = rxnInfo.RxnSteps[stepIndx].StepParticipants[ppntIndx].ParticipantName;
                                //                        if (lstNewSolvents == null)
                                //                        {
                                //                            lstNewSolvents = new List<NewSolvents>();
                                //                        }
                                //                        lstNewSolvents.Add(objNewSolv);
                                //                    }
                                //                }
                                //            }
                                //        }
                                //    }
                                //} 
                                #endregion

                                string condTime = "";
                                string condTemp = "";
                                string condPressure = "";
                                //Conditions
                                for (int stepIndx = 0; stepIndx < rxnInfo.RxnSteps.Count; stepIndx++)
                                {
                                    intStep = stepIndx + 1;
                                    catlyAgentIndx = 0;

                                    if (rxnInfo.RxnSteps[stepIndx].StepConditions != null)
                                    {
                                        condTime = "";
                                        condTemp = "";
                                        condPressure = "";
                                        for (int condIndx = 0; condIndx < rxnInfo.RxnSteps[stepIndx].StepConditions.Count; condIndx++)
                                        {
                                            intPropIndx = condIndx + 1;

                                            //Time
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Time))
                                            {
                                                strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):TIME";
                                                //condTime = rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Time + " " + rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].TimeUnits.ToUpper();
                                                condTime = GetConditionTimeInHours(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Time.Trim(), rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].TimeUnits.ToUpper());
                                                hashProp.put(strPropName, new MStringProp(condTime + " HR"));
                                            }

                                            //Temperature
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Temperature))
                                            {
                                                strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):TEMP";
                                                //condTemp = rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Temperature + " " + rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].TempUnits.ToUpper();
                                                condTemp = GetConditionTemperatureInDegrees(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Temperature.Trim(), rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].TempUnits.ToUpper());

                                                hashProp.put(strPropName, new MStringProp(condTemp + " DEG C"));
                                            }

                                            //Pressure
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Pressure))
                                            {
                                                strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):PRESSURE";
                                                condPressure = rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Pressure.Trim() + " " + rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].PressureUnits.ToUpper();
                                                condPressure = condPressure.Replace(" to ", "-");
                                                hashProp.put(strPropName, new MStringProp(condPressure));
                                            }

                                            //PH
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].PH))
                                            {
                                                strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):PH";
                                                hashProp.put(strPropName, new MStringProp(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].PH.Trim().Replace("to", "-")));
                                            }

                                            //WarmUp
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].WarmUp.ToString()))
                                            {
                                                if (rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].WarmUp == true)
                                                {
                                                    strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):WARMUP";
                                                    hashProp.put(strPropName, new MStringProp("yes"));
                                                }
                                            }

                                            //CoolDown
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].CoolDown.ToString()))
                                            {
                                                if (rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].CoolDown == true)
                                                {
                                                    strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):COOLDOWN";
                                                    hashProp.put(strPropName, new MStringProp("yes"));
                                                }
                                            }

                                            //Reflux
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Reflux.ToString()))
                                            {
                                                if (rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Reflux == true)
                                                {
                                                    strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):REFLUX";
                                                    hashProp.put(strPropName, new MStringProp("yes"));
                                                }
                                            }

                                            //Other
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Other.ToString()))
                                            {
                                                strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):OTHER";
                                                hashProp.put(strPropName, new MStringProp(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Other.ToString()));
                                            }

                                            //Operation
                                            if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Operation.ToString()))
                                            {
                                                //strPropName = "STEPNO(" + intStep + "):" + "CONDITIONS(" + intPropIndx + "):OPERATION";
                                                //operation data is coded in STEPNO(1):CONDITIONS(1):OPERATION, should be in STEPNO(1):OPERATION as on 11th Nov 2014
                                                strPropName = "STEPNO(" + intStep + "):OPERATION";
                                                hashProp.put(strPropName, new MStringProp(rxnInfo.RxnSteps[stepIndx].StepConditions[condIndx].Operation.ToString()));
                                            }
                                        }
                                    }
                                }

                                //CONDTEXT - Step wise Concatenation of Conditions
                                for (int stepIndx = 0; stepIndx < rxnInfo.RxnSteps.Count; stepIndx++)
                                {
                                    intStep = stepIndx + 1;
                                    catlyAgentIndx = 0;

                                    if (rxnInfo.RxnSteps[stepIndx].StepParticipants != null)
                                    {
                                        if (rxnInfo.RxnSteps[stepIndx].StepConditions.Count > 0)
                                        {
                                            for (int cndIndx = 0; cndIndx < rxnInfo.RxnSteps[stepIndx].StepConditions.Count; cndIndx++)
                                            {
                                                string condText = GetConditionTextFromCondInfo(rxnInfo.RxnSteps[stepIndx].StepConditions[cndIndx], rxnInfo.RxnSteps[stepIndx].StepYield);
                                                if (!string.IsNullOrEmpty(condText))
                                                {
                                                    catlyAgentIndx++;

                                                    strPropName = "STEPNO(" + intStep + "):CONDTEXT(" + catlyAgentIndx + ")";
                                                    hashProp.put(strPropName, new MStringProp(condText));
                                                }
                                            }
                                        }
                                        else if (!string.IsNullOrEmpty(rxnInfo.RxnSteps[stepIndx].StepYield))//If conditions not available and Step yield available
                                        {
                                            catlyAgentIndx++;                                           

                                            strPropName = "STEPNO(" + intStep + "):CONDTEXT(" + catlyAgentIndx + ")";
                                            hashProp.put(strPropName, new MStringProp("(" + rxnInfo.RxnSteps[stepIndx].StepYield + "%)"));
                                        }
                                    }
                                }

                                string rxnTextCat = "";
                                string rxnTextSolv = "";
                                //RXNTEXT - Step wise Concatenation of Agent, Solvents & Catalyst
                                for (int stepIndx = 0; stepIndx < rxnInfo.RxnSteps.Count; stepIndx++)
                                {
                                    intStep = stepIndx + 1;
                                    int rxnTextIndx = 0;

                                    if (rxnInfo.RxnSteps[stepIndx].StepParticipants != null)
                                    {
                                        rxnTextCat = "";
                                        rxnTextSolv = "";

                                        rxnTextCat = GetRxnTextFromStepParticipants(rxnInfo.RxnSteps[stepIndx].StepParticipants, out rxnTextSolv);

                                        //Catalyst RXNTEXT
                                        if (!string.IsNullOrEmpty(rxnTextCat))
                                        {
                                            rxnTextIndx++;
                                            strPropName = "STEPNO(" + intStep + "):RXNTEXT(" + rxnTextIndx + ")";
                                            hashProp.put(strPropName, new MStringProp(rxnTextCat));
                                        }

                                        //Solvent RXNTEXT
                                        if (!string.IsNullOrEmpty(rxnTextSolv))
                                        {
                                            rxnTextIndx++;
                                            strPropName = "STEPNO(" + intStep + "):RXNTEXT(" + rxnTextIndx + ")";
                                            hashProp.put(strPropName, new MStringProp(rxnTextSolv));
                                        }

                                        #region Code commented on 22nd Oct 2014
                                        //for (int ppIndx = 0; ppIndx < rxnInfo.RxnSteps[stepIndx].StepParticipants.Count; ppIndx++)
                                        //{
                                        //    string ppRxnText = GetRxnTextFromParticipantInfo(rxnInfo.RxnSteps[stepIndx].StepParticipants[ppIndx]);
                                        //    if (!string.IsNullOrEmpty(ppRxnText))
                                        //    {
                                        //        strPropName = "STEPNO(" + stepIndx + "):RXNTEXT(" + (ppIndx + 1) + ")";
                                        //        hashProp.put(strPropName, new MStringProp(ppRxnText));
                                        //    }
                                        //} 
                                        #endregion
                                    }
                                }
                            }

                            //Reaction MDLNUMBER Information
                            hashProp.put("MDLNUMBER", new MStringProp(rxnInfo.RxnMDLNo));

                            //Write Reaction molecule to exporter
                            objmExporter.write(molReaction);

                            //Write Important reactions to separate RDF
                            if (rxnInfo.IsImportantRxn == "Y" && articleInfo.ArticleType == "JOURNAL")//Journal type reference                            
                            {
                                objmExporterImp.write(molReaction);
                            }
                        }

                        //Close Exporter & OutSteam objects
                        objmExporter.close();
                        fOutStream.close();

                        //Close Exporter & OutSteam JOURNAL objects of Important reactions
                        if (articleInfo.ArticleType == "JOURNAL")
                        {
                            objmExporterImp.close();                           
                            fOutStreamImp.close();
                        }

                        //Export New Solvents to SDF
                        if (lstRefNewSolvents.Count > 0)
                        {
                            //Export new Solvents to Sd file
                            string newSolvsFileName = Path.Combine(outputFolderPath, strRefName + "_SOLVCATS.rdf");
                            ExportNewSolventsAgentsToRDFile(lstRefNewSolvents, newSolvsFileName);

                            //Add new solvents to Delivery solvents
                            refSolvCats.RefNewSolvents = lstRefNewSolvents;
                        }

                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }            
            return blStatus;
        }
           
        private static string GetConditionTextFromCondInfo(ConditionInfo condInfo, string stepYield)
        {
            string strCondText = "";
            try
            {
                if (condInfo != null)
                {
                    //Temperature
                    if (!string.IsNullOrEmpty(condInfo.Temperature))
                    {
                        strCondText = GetConditionTemperatureInDegrees(condInfo.Temperature.Trim(), condInfo.TempUnits.ToUpper());//condInfo.Temperature.Trim() + condInfo.TempUnits.ToUpper().Replace("DEG", "");
                        strCondText = strCondText + " C";
                    }

                    //Warmup
                    if (condInfo.WarmUp == true)
                    {
                        strCondText = string.IsNullOrEmpty(strCondText) ? "WARMUP" : strCondText.Trim() + "," + "WARMUP";
                    }

                    //Cooldown
                    if (condInfo.CoolDown == true)
                    {
                        strCondText = string.IsNullOrEmpty(strCondText) ? "COOLDOWN" : strCondText.Trim() + "," + "COOLDOWN";
                    }

                    //Reflux
                    if (condInfo.Reflux == true)
                    {
                        strCondText = string.IsNullOrEmpty(strCondText) ? "REFLUX" : strCondText.Trim() + "," + "REFLUX";
                    }

                    //Time
                    if (!string.IsNullOrEmpty(condInfo.Time))
                    {
                        string timeText = GetConditionTimeInHours(condInfo.Time.Trim(), condInfo.TimeUnits.Trim());//condInfo.Time.Trim() + " " + condInfo.TimeUnits.Trim().Replace("HR","HR");
                        timeText = timeText + " HR";

                        strCondText = string.IsNullOrEmpty(strCondText) ? timeText : strCondText.Trim() + "," + timeText;
                    }

                    //Pressure
                    if (!string.IsNullOrEmpty(condInfo.Pressure))
                    {
                        strCondText = string.IsNullOrEmpty(strCondText) ? condInfo.Pressure.Replace(" to ", "-") : strCondText.Trim() + "," + condInfo.Pressure.Replace(" to ", "-");
                    }

                    //pH
                    if (!string.IsNullOrEmpty(condInfo.PH))
                    {
                        strCondText = string.IsNullOrEmpty(strCondText) ? condInfo.PH.Replace(" to ", "-") : strCondText.Trim() + "," + condInfo.PH.Replace(" to ", "-");
                    }                    
                }

                //Code commented on 10th March 2015, Step is not required in the Condition Text
                //Step yield enabled on 12th June 2015 based on client feedback
                //Step Yield
                if (!string.IsNullOrEmpty(stepYield))
                {
                    string strYield = "(" + stepYield + "%)";

                    strCondText = string.IsNullOrEmpty(strCondText) ? strYield : strCondText.Trim() + "," + strYield;
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strCondText;
        }

        private static string GetRxnTextFromParticipantInfo(ParticipantInfo partpntInfo)
        {
            string strPPText = "";
            try
            {
                if (partpntInfo != null)
                {
                    if (partpntInfo.ParticipantType.ToUpper() == "AGENT" || partpntInfo.ParticipantType.ToUpper() == "SOLVENT")
                    {
                        if (!string.IsNullOrEmpty(partpntInfo.ParticipantName))
                        {
                            strPPText = string.IsNullOrEmpty(strPPText) ? partpntInfo.ParticipantName.Trim() : strPPText + "," + partpntInfo.ParticipantName.Trim();
                        }
                    }
                    else if(partpntInfo.ParticipantType.ToUpper() == "CATALYST")
                    {
                        if (!string.IsNullOrEmpty(partpntInfo.ParticipantName))
                        {
                           string catlName = partpntInfo.ParticipantName.Trim() + " (cat.)";
                           strPPText = string.IsNullOrEmpty(strPPText) ? catlName : strPPText + "," + catlName;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strPPText.Trim();
        }

        private static string GetRxnTextFromStepParticipants(List<ParticipantInfo> partpntInfoList, out string solvRxnText)
        {
            string rxnText_Cat = "";
            string rxnText_Solv = "";
            try
            {
                if (partpntInfoList != null)
                {
                    foreach (ParticipantInfo partpntInfo in partpntInfoList)
                    {

                        if (partpntInfo.ParticipantType.ToUpper() == "SOLVENT")
                        {
                            if (!string.IsNullOrEmpty(partpntInfo.ParticipantName))
                            {
                                rxnText_Solv = string.IsNullOrEmpty(rxnText_Solv) ? partpntInfo.ParticipantName.Trim() : rxnText_Solv + "/" + partpntInfo.ParticipantName.Trim();
                            }
                        }
                        else if (partpntInfo.ParticipantType.ToUpper() == "CATALYST" || partpntInfo.ParticipantType.ToUpper() == "AGENT")
                        {
                            if (!string.IsNullOrEmpty(partpntInfo.ParticipantName))
                            {
                                string catlName = partpntInfo.ParticipantType.ToUpper() == "CATALYST" ? partpntInfo.ParticipantName.Trim() + " (cat.)" : partpntInfo.ParticipantName.Trim();
                                
                                rxnText_Cat = string.IsNullOrEmpty(rxnText_Cat) ? catlName : rxnText_Cat + "/" + catlName;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            solvRxnText = rxnText_Solv;
            return rxnText_Cat.Trim();
        }

        private static bool ExportNewSolventsAgentsToRDFile(List<NewSolvents> newSolventsList, string outputFilePath)
        {
            bool blStatus = false;
            try
            {
                if (newSolventsList != null)
                {
                    using (FileOutputStream fOutStream = new FileOutputStream(outputFilePath, true))
                    {
                        MolExporter mExporter = new MolExporter(fOutStream, "rdf");
                        MolHandler objMolHandler;
                        Molecule objNewMol;

                        foreach (NewSolvents newSolv in newSolventsList)
                        {
                            //Reaction Scheme Molecule
                            objMolHandler = new MolHandler(newSolv.StructureMolFile.ToString());
                            objNewMol = objMolHandler.getMolecule();

                            objNewMol.setPropertyObject("MOL:SYMBOL(1)", newSolv.StructureName.ToString());

                            mExporter.write(objNewMol);
                        }

                        fOutStream.close();
                        mExporter.close();

                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        #region Time and Temperature Conversions

        private static string GetConditionTimeInHours(string timeValue, string timeUnits)
        {
            string timeInHrs = "";
            try
            {
                if (!String.IsNullOrEmpty(timeValue.Trim()) && !String.IsNullOrEmpty(timeUnits.Trim()))
                {
                    string[] saTime = timeValue.Trim().Split(new string[] { " to " }, StringSplitOptions.RemoveEmptyEntries);
                    string toHours = "";

                    if (saTime.Length == 1)
                    {
                        if (timeUnits.ToUpper() == "HR")
                        {
                            toHours = saTime[0].Trim();
                        }
                        else if (timeUnits.ToUpper() == "MINS")
                        {
                            toHours = DataConversions.ConvertMinutesToHours(saTime[0].Trim());
                        }
                        else if (timeUnits.ToUpper() == "SECS")
                        {
                            toHours = DataConversions.ConvertSecondsToHours(saTime[0].Trim());
                        }
                    }
                    else if (saTime.Length == 2)
                    {
                        if (timeUnits.ToUpper() == "HR")
                        {
                            toHours = saTime[0].Trim() + "-" + saTime[1].Trim();
                        }
                        else if (timeUnits.ToUpper() == "MINS")
                        {
                            toHours = Math.Round(TimeSpan.FromMinutes(Convert.ToDouble(saTime[0])).TotalHours, 3).ToString() + "-" +
                                      Math.Round(TimeSpan.FromMinutes(Convert.ToDouble(saTime[1])).TotalHours, 3).ToString();
                        }
                        else if (timeUnits.ToUpper() == "SECS")
                        {
                            toHours = DataConversions.ConvertSecondsToHours(saTime[0].Trim()) + "-" +
                                       DataConversions.ConvertSecondsToHours(saTime[1].Trim());
                        }
                    }
                    timeInHrs = toHours;             
                }                
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return timeInHrs;
        }

        private static string GetConditionTemperatureInDegrees(string tempValue, string tempUnits)
        {
            string tempInDeg = "";
            try
            {
                if (!String.IsNullOrEmpty(tempValue.Trim()) && !String.IsNullOrEmpty(tempUnits.Trim()))
                {
                    string toDegrees = string.Empty;
                    int count = tempValue.Split('-').Count();
                    string[] strTemp = new string[count];
                    strTemp = tempValue.Trim().Split(new string[] { " to " }, StringSplitOptions.RemoveEmptyEntries);

                    //string pattern = @"\d+";
                    //System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(pattern);
                    //string[] strSign = rgx.Split(tempValue.Trim());

                    #region To Recognize sign
                    //for (int i = 0; i < strSign.Count(); i++)
                    //{
                    //    if (i == 0)
                    //    {
                    //        if (strSign[i] == "")
                    //        {
                    //            strSign[i] = "";
                    //        }
                    //        else
                    //        {
                    //            strSign[i] = "-";
                    //        }
                    //    }
                    //    else
                    //    {
                    //        if (strSign[i] == "-")
                    //        {
                    //            strSign[i] = "";
                    //        }
                    //        else
                    //        {
                    //            strSign[i] = "-";
                    //        }
                    //    }
                    //}
                    #endregion

                    for (int i = 0; i < strTemp.Count() && i < 2; i++)
                    {
                        if (tempUnits.ToUpper() == "DEG C")
                        {
                            toDegrees += strTemp[i];
                        }
                        else if (tempUnits.ToUpper() == "FAHRENHEIT")
                        {
                            toDegrees += DataConversions.ConvertFahrenheitToDegress(strTemp[i]);
                        }
                        else if (tempUnits.ToUpper() == "KELVIN")
                        {
                            toDegrees += DataConversions.ConvertKelvinsToDegress(strTemp[i]);
                        }
                        if (i + 1 < strTemp.Count() && i + 1 < 2)
                        {
                            toDegrees += "-";
                        }
                    }
                    tempInDeg = toDegrees;
                }
                else
                {
                    tempInDeg = "0";
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return tempInDeg;
        }

        #endregion
               
    }
}
