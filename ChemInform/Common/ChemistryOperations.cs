using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chemaxon.struc;
using chemaxon.util;
using chemaxon.reaction;
using System.Diagnostics;
using System.Text.RegularExpressions;
using chemaxon.formats;
using System.Collections;
using System.IO;
using java.io;
using System.Data;
using chemaxon.marvin.modules;
using chemaxon.sss.search;

namespace ChemInform.Common
{
    public static class ChemistryOperations
    {
        public static string GetStandardizedMolecule(string strMolFile, out bool isChiral_Out)
        {
            string strStandMol = "";
            bool blIsChiral = false;
            try
            {
                chemaxon.util.MolHandler molHandler = new MolHandler(strMolFile);
                Molecule molObj = molHandler.getMolecule();
                Molecule molObj_Stand = StandardizeMolecule(molObj, out blIsChiral);
                strStandMol = molObj_Stand.toFormat("mol");

                isChiral_Out = blIsChiral;
                return strStandMol;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }

            isChiral_Out = blIsChiral;
            return strStandMol;
        }

        private static Molecule StandardizeMolecule(Molecule mol, out bool ischiral_out)
        {
            Molecule molChem = null;
            bool blIsChiral = false;
            try
            {
                Standardizer molSdz = new Standardizer("absolutestereo:set");
                molChem = molSdz.standardize(mol);

                blIsChiral = molChem.isAbsStereo();

                #region Code Commented
                //string strDirPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
                //string strXmlPath = strDirPath + "chiral.xml";
                //StandardizerConfiguration sconfing = new StandardizerConfiguration();
                //sconfing.read(strXmlPath);
                //Standardizer sdz = sconfing.getStandardizer();
                //molChem = sdz.standardize(mol);                               
                //Standardizer sdz = new Standardizer(new File(strXmlPath)); 
                #endregion

                ischiral_out = blIsChiral;
                return molChem;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            ischiral_out = blIsChiral;
            return molChem;
        }

        public static bool GetStructureFromCompoundName(string strCompName, out string molstring_out, out bool ischiral_out, out string errmessage_out)
        {
            bool blStatus = false;
            string strMolString = "";
            string strErrMessage = "";
            bool blIsChiral = false;
            try
            {
                string strDirPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
                string strExePath = strDirPath + "nam2mol.exe";

                string strInputFileName = "CompName.txt";
                string strOutputFileName = "CompStructure.mol";

                if (System.IO.File.Exists(strDirPath + strInputFileName))
                {
                    System.IO.File.Delete(strDirPath + strInputFileName);
                }
                System.IO.StreamWriter sWriter = new System.IO.StreamWriter(strDirPath + strInputFileName);
                sWriter.WriteLine(strCompName.Trim());
                sWriter.Close();
                sWriter.Dispose();

                if (System.IO.File.Exists(strDirPath + strOutputFileName))
                {
                    System.IO.File.Delete(strDirPath + strOutputFileName);
                }

                //ProcessStartInfo class
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardError = true;
                startInfo.FileName = @"" + strExePath + "";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = @"-in """ + strDirPath + strInputFileName + @"""  -out """ + strDirPath + strOutputFileName + @""" -depict true";
                //startInfo.Arguments = @"-in """ + strDirPath + strInputFileName + @""" -depict true";

                string strErrMsg = "";
                try
                {
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        strErrMsg = exeProcess.StandardError.ReadToEnd();
                        exeProcess.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandling.WriteErrorLog(ex.ToString());
                }

                //Read Output molecule from outputfile
                StreamReader sReader = new StreamReader(strDirPath + strOutputFileName);
                string newMolfileString;
                newMolfileString = sReader.ReadToEnd();

                //Standardize the molecule
                string strStandMol = GetStandardizedMolecule(newMolfileString, out blIsChiral);

                sReader.Close();
                sReader.Dispose();

                if (newMolfileString != "")
                {
                    strMolString = strStandMol;
                    molstring_out = strMolString;
                    errmessage_out = "";
                    ischiral_out = blIsChiral;
                    blStatus = true;
                    return blStatus;
                }
                else
                {
                    strErrMessage = strErrMsg;
                    molstring_out = "";
                    ischiral_out = blIsChiral;
                    errmessage_out = strErrMessage;
                    blStatus = false;
                    return blStatus;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            molstring_out = "";
            ischiral_out = blIsChiral;
            errmessage_out = strErrMessage;
            return blStatus;
        }

        public static string GetMoleculeWeightAndMolFormula(string molstring, out string molformula_out)
        {
            string strMolWeight = "";
            string strMolFormula = "";
            try
            {
                MolHandler mHandler = new MolHandler(molstring);
                float fltMolWeight = mHandler.calcMolWeight();

                strMolFormula = mHandler.calcMolFormula();
                strMolWeight = fltMolWeight.ToString();

                molformula_out = strMolFormula;
                return strMolWeight;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            molformula_out = strMolFormula;
            return strMolWeight;
        }

        public static bool GetIUPACNameFromStructure(string molfilestring, out string iupacname_out, out string errmessage_out)
        {
            bool blStatus = false;
            string strIUPACName = "";
            string strErrMessage = "";
            try
            {
                string strDirPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
                string strExePath = strDirPath + "mol2nam.exe";

                string strInputFileName = "MolFile.mol";
                //string strOutputFileName = "MolName.txt";

                if (System.IO.File.Exists(strDirPath + strInputFileName))
                {
                    System.IO.File.Delete(strDirPath + strInputFileName);
                }
                System.IO.StreamWriter sWriter = new System.IO.StreamWriter(strDirPath + strInputFileName);
                sWriter.WriteLine(molfilestring);
                sWriter.Close();
                sWriter.Dispose();

                //if (System.IO.File.Exists(strDirPath + strOutputFileName))
                //{
                //    System.IO.File.Delete(strDirPath + strOutputFileName);
                //}

                //ProcessStartInfo class
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = @"" + strExePath + "";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //startInfo.Arguments = @"-in """ + strDirPath + strInputFileName + @"""  -out """ + strDirPath + strOutputFileName + @""" -capitalize true";
                startInfo.Arguments = @"-in """ + @"" + strDirPath + strInputFileName + @""" -nobanner";

                string strErrMsg = "";
                string strIUPACName_Out = "";

                try
                {
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        strIUPACName_Out = exeProcess.StandardOutput.ReadToEnd();
                        strErrMsg = exeProcess.StandardError.ReadToEnd();
                        exeProcess.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandling.WriteErrorLog(ex.ToString());
                }

                //StreamReader sr = new StreamReader(strDirPath + strOutputFileName);
                //string IUPACName = "";
                //IUPACName = sr.ReadToEnd();
                //sr.Close();
                //sr.Dispose();

                if (strIUPACName_Out != "")
                {
                    strIUPACName = strIUPACName_Out;
                    strErrMessage = "";
                    blStatus = true;
                }
                else
                {
                    strIUPACName = "";
                    strErrMessage = strErrMsg;
                    blStatus = false;
                }

                iupacname_out = strIUPACName;
                errmessage_out = strErrMessage;
                return blStatus;

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }

            iupacname_out = strIUPACName;
            errmessage_out = strErrMessage;
            return blStatus;
        }

        public static bool CheckForV3000Format(string molfilestring)
        {
            bool blIsV3000 = false;
            try
            {
                if (molfilestring != "")
                {
                    int v3000 = molfilestring.IndexOf("V3000");
                    if (v3000 == -1)
                    {
                        blIsV3000 = false;
                    }
                    else
                    {
                        blIsV3000 = true;
                    }

                    #region Code Commented
                    //MolHandler mHandler = new MolHandler(molfilestring);
                    //int atomCnt = mHandler.getAtomCount();
                    //if (atomCnt > 999)
                    //{
                    //    blIsV3000 = true;
                    //}
                    //else
                    //{
                    //    blIsV3000 = false;
                    //}
                    #endregion
                }
                return blIsV3000;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blIsV3000;
        }

        public static bool CheckForDuplicateStructure(string filename, string qrymolfile, int recindex, out Molecule mol_out)
        {
            bool blStatus = false;
            try
            {
                bool blIsChiral = false;

                MolHandler mHandler = new MolHandler(qrymolfile);
                Molecule qryMol = mHandler.getMolecule();
                qryMol = StandardizeMolecule(qryMol, out blIsChiral);

                string strqryMolInchi = qryMol.toFormat("inchi:key");
                strqryMolInchi = GetInchiKeyFromInchiString(strqryMolInchi);

                //Specify input file to MolInputStream object
                MolInputStream molInStream = new MolInputStream(new FileInputStream(filename));
                MolImporter molImp = new MolImporter(molInStream);
                Molecule objMol = new Molecule();

                blIsChiral = false;
                string strInchiKey = "";
                int intRecIndx = 0;

                Molecule molObj_Stand = null;
                while (molImp.read(objMol))
                {
                    molObj_Stand = StandardizeMolecule(objMol, out blIsChiral);

                    strInchiKey = objMol.toFormat("inchi:key");
                    strInchiKey = GetInchiKeyFromInchiString(strInchiKey);

                    intRecIndx++;

                    if ((strInchiKey == strqryMolInchi) && (intRecIndx != recindex))
                    {
                        blStatus = true;
                        mol_out = objMol;
                        return blStatus;
                    }
                }

                molImp.close();
                // molInStream.close();

            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            mol_out = null;
            return blStatus;
        }

        public static bool DeleteAllDuplicateStructures(string filename, out int totalreccnt, out int dupreccnt)
        {
            bool blStatus = false;
            int intDupRecCnt = 0;
            int intTotalRecCnt = 0;
            try
            {
                MolInputStream molInStream = new MolInputStream(new FileInputStream(filename));
                MolImporter molImp = new MolImporter(molInStream);
                Molecule objMol = new Molecule();

                DataOutputStream dOutStream = new DataOutputStream(new FileOutputStream(filename));
                MolExporter molExpt = new MolExporter(dOutStream, "sdf");

                bool blIsChiral = false;
                string strInchiKey = "";

                ArrayList molInchiList = new ArrayList();

                while (molImp.read(objMol))
                {
                    objMol = StandardizeMolecule(objMol, out blIsChiral);

                    strInchiKey = objMol.toFormat("inchi:key");
                    strInchiKey = GetInchiKeyFromInchiString(strInchiKey);

                    if (!molInchiList.Contains(strInchiKey))
                    {
                        molInchiList.Add(strInchiKey);
                        molExpt.write(objMol);
                    }
                    else
                    {
                        intDupRecCnt++;
                    }
                    intTotalRecCnt++;
                }
                //Close all the import & export objects
                molImp.close();
                molInStream.close();
                dOutStream.close();
                molExpt.close();

                blStatus = true;
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            totalreccnt = intTotalRecCnt;
            dupreccnt = intDupRecCnt;
            return blStatus;
        }

        public static int GetDuplicateRecordsCount(string filename, out int totalreccnt)
        {
            int intDupRecCnt = 0;
            int intTotalRecCnt = 0;

            try
            {
                MolInputStream molInStream = new MolInputStream(new FileInputStream(filename));
                MolImporter molImp = new MolImporter(molInStream);
                Molecule objMol = new Molecule();

                bool blIsChiral = false;
                string strInchiKey = "";

                ArrayList molInchiList = new ArrayList();

                while (molImp.read(objMol))
                {
                    objMol = StandardizeMolecule(objMol, out blIsChiral);

                    strInchiKey = objMol.toFormat("inchi:key");
                    strInchiKey = GetInchiKeyFromInchiString(strInchiKey);

                    if (!molInchiList.Contains(strInchiKey))
                    {
                        molInchiList.Add(strInchiKey);
                    }
                    else
                    {
                        intDupRecCnt++;
                    }
                    intTotalRecCnt++;
                }

                molImp.close();
                //molInStream.close();
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            totalreccnt = intTotalRecCnt;
            return intDupRecCnt;
        }

        public static string GetStructureInchiKey(string _molfilestring)
        {
            string strInchiKey = "Inchi Not generated";
            try
            {
                MolHandler mHandler = new MolHandler(_molfilestring);
                Molecule mol = mHandler.getMolecule();
                try
                {
                    strInchiKey = mol.toFormat("inchi:key");
                }
                catch //Exception is inchi not generated
                {
                    // if inchi not generated
                    SetMolAbsStereo_Inchi_NotGenerated(ref mol);

                    strInchiKey = mol.toFormat("inchi:key");
                }
                if (!string.IsNullOrEmpty(strInchiKey))
                {
                    strInchiKey = GetInchiKeyFromInchiString(strInchiKey);
                }

                //MOSFIJXAXDLOML-UHFFFAOYSA-N is a place holder for non-succesful INCHIKey conversion accroding to JCHEM
                if (strInchiKey.ToUpper().Trim() == "MOSFIJXAXDLOML-UHFFFAOYSA-N")
                {
                    strInchiKey = "";
                }
                
                return strInchiKey;
            }
            catch (Exception ex)
            {
                //PepsiLiteErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strInchiKey;
        }

        private static void SetMolAbsStereo_Inchi_NotGenerated(ref Molecule _molobj)
        {
            try
            {
                int atno = 0;
                MolAtom ma = null;
                for (int i = 0; i < (_molobj.getAtomCount() - 1); i++)
                {
                    atno = _molobj.getAtom(i).getAtno();
                    if (atno > 109)
                    {
                        ma = _molobj.getAtom(i);
                        ma.setAtno(6);
                    }
                }
                bool flag1 = _molobj.ungroupSgroups();
                bool flag2 = _molobj.hydrogenize(false);
                if (_molobj.isAbsStereo())
                {
                    _molobj.setAbsStereo(true);
                }
                _molobj.aromatize(false);
            }
            catch (Exception ex)
            {
                //PepsiLiteErrorHandling.WriteErrorLog(ex.ToString());
            }
        }

        public static double GetStructureMolWeight_MolFormula(string _molfilestring, out string _molformula)
        {
            double dblMolWeight = 0.0;
            string strMolFormula = "";
            try
            {
                MolHandler mHandler = new MolHandler(_molfilestring);
                dblMolWeight = mHandler.calcMolWeight();

                strMolFormula = mHandler.calcMolFormula();

                _molformula = strMolFormula;
                return dblMolWeight;
            }
            catch (Exception ex)
            {

            }
            _molformula = strMolFormula;
            return dblMolWeight;
        }

        public static string GetInchiKeyFromInchiString(string inchistring)
        {
            string strInchikey = "";
            try
            {
                if (inchistring.Trim() != "")
                {
                    string[] splitter = { "InChIKey=" };
                    string[] strInchiArr = inchistring.Trim().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                    if (strInchiArr != null)
                    {
                        if (strInchiArr.Length == 2)
                        {
                            strInchikey = strInchiArr[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strInchikey;
        }

        public static string RemoveSMILESFromIUPACName(string iupacname)
        {
            string strIUPACName = iupacname;
            try
            {
                if (iupacname.Trim() != "")
                {
                    string[] strSplitter = { " " };
                    string[] strSplitVals = iupacname.Split(strSplitter, StringSplitOptions.RemoveEmptyEntries);
                    if (strSplitVals != null)
                    {
                        if (strSplitVals.Length > 1)
                        {

                            //strIUPACName = strSplitVals[1].Trim();
                            //return strIUPACName;

                            strSplitVals[0] = "";
                            strIUPACName = String.Join(" ", strSplitVals);
                            return strIUPACName.Trim();
                        }
                        else if (strSplitVals.Length == 1)
                        {
                            strIUPACName = String.Join(" ", strSplitVals);
                            return strIUPACName.Trim();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strIUPACName;
        }

        public static string GetConvertedIUPACName(string iupacname)
        {
            string strIUPACName = "";
            try
            {
                if (iupacname.Trim() != "")
                {
                    int intHashCode = 0;
                    foreach (Char c in iupacname.Trim())
                    {
                        intHashCode = c.GetHashCode();
                        switch (intHashCode)
                        {
                            case 913:

                                strIUPACName = strIUPACName + ".alpha.";
                                break;

                            case 914:

                                strIUPACName = strIUPACName + ".beta.";
                                break;

                            case 915:

                                strIUPACName = strIUPACName + ".gamma.";
                                break;

                            case 916:

                                strIUPACName = strIUPACName + ".delta.";
                                break;

                            case 917:

                                strIUPACName = strIUPACName + ".epsilon.";
                                break;

                            default:
                                strIUPACName = strIUPACName + c;
                                break;
                        }
                    }
                    return strIUPACName;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return strIUPACName;
        }

        public static bool CheckStructureInSolventAgentsMaster(string structInchi)
        {
            bool blStatus = true;
            try               
            {
                if (GlobalVariables.SolvCatalystMaster != null && !string.IsNullOrEmpty(structInchi))
                {
                    //valid restriction that connection tables consisting of hydrogen only are not allowed; this applies to H2, H+, and H-
                    if (!structInchi.ToUpper().Equals("KLGZELKXQMTEMM-UHFFFAOYSA-N") && 
                        !structInchi.ToUpper().Equals("GPRLSGONYQIRFK-UHFFFAOYSA-N") && 
                        !structInchi.ToUpper().Equals("UFHFLCQGNIYNRP-UHFFFAOYSA-N"))//H-,H+,H2
                    {
                        var query = from r in GlobalVariables.SolvCatalystMaster.AsEnumerable()
                                    where r.Field<string>("INCHI_KEY") == structInchi
                                    select new
                                    {
                                        molFile = r["MOL_FILE"].ToString()
                                    };

                        if (query.Count() == 0)
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

        public static bool CheckStructureIsHydrogenOnly(string structInchi)
        {
            bool blStatus = false;
            try
            {
                if (!string.IsNullOrEmpty(structInchi))
                {
                    //valid restriction that connection tables consisting of hydrogen only are not allowed; this applies to H2, H+, and H-
                    if (structInchi.ToUpper().Equals("KLGZELKXQMTEMM-UHFFFAOYSA-N") || 
                        structInchi.ToUpper().Equals("GPRLSGONYQIRFK-UHFFFAOYSA-N") ||
                        structInchi.ToUpper().Equals("UFHFLCQGNIYNRP-UHFFFAOYSA-N"))//H-,H+,H2
                    {
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

        public static bool CheckStructureInDeliveredSolventCatalysts(string structInchi)
        {
            bool blStatus = true;
            try
            {
                if (GlobalVariables.DeliveredSolvCatalysts != null && !string.IsNullOrEmpty(structInchi))
                {
                    var query = from r in GlobalVariables.DeliveredSolvCatalysts.AsEnumerable()
                                where r.Field<string>("MOL_INCHI_KEY") == structInchi
                                select new
                                {
                                    molFile = r["MOL_FILE"].ToString()
                                };

                    if (query.Count() == 0)
                    {
                        blStatus = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }

        public static string GetReactionSchemeFromReactionTable(DataTable rxnData, bool atomAutoMap)
        {
            string strMolFile = "";
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
                    if (atomAutoMap)
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

                    //MolHandler mh = new MolHandler(rxnMolecule.toFormat("mol"));
                    //mh.clean(true, "2D");
                    //strMolFile = mh.toFormat("mol");// reaction.toFormat("mol");

                    strMolFile = rxnMolecule.toFormat("mol");

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
            return strMolFile;
        }

        public static bool ValidateReactantsAndProductsWithReactionScheme(DataTable rxnData, string rxnScheme, out string errMsg)
        {
            bool blStatus = true;
            string strErrMsg = "";
            try
            {
                if (!string.IsNullOrEmpty(rxnScheme) && rxnData != null)
                {                   
                    RxnMolecule rxnMolecule = RxnMolecule.getReaction(MolImporter.importMol(rxnScheme));
                    if (rxnMolecule != null)
                    {
                        int reactantsCnt = rxnMolecule.getReactantCount();
                        int productsCnt = rxnMolecule.getProductCount();
                        Molecule molReactant = null;
                                               
                        int rctMatchCnt = 0;
                        string schReactInchi = "";
                        string tblReactInchi = "";

                        Molecule molProduct = null;
                        int prodMatchCnt = 0;
                        string schProdInchi = "";
                        string tblProdInchi = "";
                                                
                        //Get Reactants count
                        int tblRctCnt = (from r in rxnData.AsEnumerable()
                                   where r.Field<string>("PRPNT_TYPE") == "REACTANT"
                                   select r).Count();
                        
                        //Get Products Count
                        int tblProdCnt = (from r in rxnData.AsEnumerable()
                                      where r.Field<string>("PRPNT_TYPE") == "PRODUCT"
                                      select r).Count();

                        //Reactants
                        for (int rctIndx = 0; rctIndx < reactantsCnt; rctIndx++)
                        {
                            molReactant = rxnMolecule.getReactant(rctIndx);
                            schReactInchi = GetStructureInchiKey(molReactant.toFormat("mol"));

                            for (int rxnIndx = 0; rxnIndx < rxnData.Rows.Count; rxnIndx++)
                            {
                                if (rxnData.Rows[rxnIndx]["PRPNT_TYPE"].ToString() == "REACTANT")
                                {
                                    tblReactInchi = GetStructureInchiKey(rxnData.Rows[rxnIndx]["PRPNT_STRUCTURE"].ToString());
                                    if (schReactInchi == tblReactInchi)
                                    {
                                        rctMatchCnt++;
                                        break;
                                    }
                                }
                            }
                        }

                        //Products
                        for (int prodIndx = 0; prodIndx < productsCnt; prodIndx++)
                        {
                            molProduct = rxnMolecule.getProduct(prodIndx);
                            schProdInchi = GetStructureInchiKey(molProduct.toFormat("mol"));

                            for (int rxnIndx = 0; rxnIndx < rxnData.Rows.Count; rxnIndx++)
                            {
                                if (rxnData.Rows[rxnIndx]["PRPNT_TYPE"].ToString() == "PRODUCT")
                                {
                                    tblProdInchi = GetStructureInchiKey(rxnData.Rows[rxnIndx]["PRPNT_STRUCTURE"].ToString());
                                    if (schProdInchi == tblProdInchi)
                                    {
                                        prodMatchCnt++;
                                        break;
                                    }
                                }
                            }
                        }

                        //Reactants count matching
                        if (tblRctCnt != reactantsCnt)
                        {
                            blStatus = false;
                            strErrMsg = "Scheme reactants count not matching with reaction reactants";
                        }

                        //Products count matching
                        if (tblProdCnt != productsCnt)
                        {
                            blStatus = false;
                            strErrMsg = "Scheme products count not matching with reaction products";
                        }

                        if (rctMatchCnt != reactantsCnt)
                        {
                            blStatus = false;
                            strErrMsg = "Scheme reactants are not matching with reaction reactants";
                        }
                        if (prodMatchCnt != productsCnt)
                        {
                            blStatus = false;
                            strErrMsg = strErrMsg.Trim() + "\r\n" + "Scheme products are not matching with reaction products";
                        }
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

        public static bool CheckStructureIsInV3000Format(string molfilestring)
        {
            bool blStatus = false;
            try
            {
                if (!string.IsNullOrEmpty(molfilestring))
                {
                    MolHandler mHandler = new MolHandler(molfilestring);
                    int molCnt = mHandler.getAtomCount();
                    if (molCnt > 999)//upto 999 is V2000 format, else V3000 format
                    {
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

        public static bool MoleculeComparisonTest(string mol1, string mol2)
        {
            bool blStatus = false;
            try
            {
                string testMol1 = @"
                          ACCLDraw01081514282D

                         22 23  0  0  0  0  0  0  0  0999 V2000
                            8.7283   -2.9723    0.0000 C   0  0  0  0  0  0  0  0  0  8  0  0
                            5.6037   -2.9121    0.0000 C   0  0  0  0  0  0  0  0  0 11  0  0
                            6.7270   -2.5471    0.0000 O   0  0  0  0  0  0  0  0  0 10  0  0
                            7.6048   -3.3374    0.0000 C   0  0  0  0  0  0  0  0  0  9  0  0
                            5.9904   -6.0131    0.0000 C   0  0  0  0  0  0  0  0  0 14  0  0
                            6.2360   -4.8578    0.0000 O   0  0  0  0  0  0  0  0  0 13  0  0
                            7.3593   -4.4927    0.0000 C   0  0  0  0  0  0  0  0  0 12  0  0
                            8.8692   -7.2288    0.0000 C   0  0  0  0  0  0  0  0  0 17  0  0
                            7.9915   -6.4384    0.0000 O   0  0  0  0  0  0  0  0  0 16  0  0
                            8.2371   -5.2831    0.0000 C   0  0  0  0  0  0  0  0  0 15  0  0
                            9.3604   -4.9180    0.0000 C   0  0  0  0  0  0  0  0  0 18  0  0
                            9.6059   -3.7626    0.0000 C   0  0  0  0  0  0  0  0  0  7  0  0
                           12.2755   -2.2744    0.0000 N   0  0  0  0  0  0  0  0  0  4  0  0
                           11.0943   -2.2744    0.0000 N   0  0  0  0  0  0  0  0  0  5  0  0
                           10.7293   -3.3978    0.0000 C   0  0  0  0  0  0  0  0  0  6  0  0
                           11.6848   -4.0921    0.0000 N   0  0  3  0  0  0  0  0  0  1  0  0
                           12.6405   -3.3978    0.0000 C   0  0  0  0  0  0  0  0  0  2  0  0
                           13.7638   -3.7626    0.0000 S   0  0  0  0  0  0  0  0  0  3  0  0
                           14.6416   -2.9723    0.0000 C   0  0  0  0  0  0  0  0  0 20  0  0
                           16.0106   -4.4927    0.0000 O   0  0  0  0  0  0  0  0  0 22  0  0
                           15.7649   -3.3374    0.0000 C   0  0  0  0  0  0  0  0  0 21  0  0
                           16.6427   -2.5471    0.0000 O   0  0  0  0  0  0  0  0  0 23  0  0
                         12  1  1  0  0  0  2
                          1  4  2  0  0  0  2
                          3  2  1  0  0  0  2
                          4  3  1  0  0  0  2
                          4  7  1  0  0  0  2
                          6  5  1  0  0  0  2
                          7  6  1  0  0  0  2
                          7 10  2  0  0  0  2
                          9  8  1  0  0  0  2
                         10  9  1  0  0  0  2
                         10 11  1  0  0  0  2
                         11 12  2  0  0  0  2
                         15 12  1  0  0  0  2
                         17 13  2  0  0  0  8
                         13 14  1  0  0  0  8
                         14 15  2  0  0  0  8
                         15 16  1  0  0  0  8
                         16 17  1  0  0  0  8
                         17 18  1  0  0  0  8
                         18 19  1  0  0  0  4
                         19 21  1  0  0  0  2
                         21 20  2  0  0  0  2
                         21 22  1  0  0  0  2
                        M  END
                        ";

                string testMol2 = @"
                          ACCLDraw01081514312D

                         21 22  0  0  0  0  0  0  0  0999 V2000
                            9.0242   -4.6483    0.0000 N   0  0  0  0  0  0  0  0  0  9  0  0
                           10.2054   -4.6483    0.0000 N   0  0  3  0  0  0  0  0  0  8  0  0
                           14.5726   -4.9211    0.0000 O   0  0  0  0  0  0  0  0  0  0  0  0
                           13.9404   -6.8668    0.0000 O   0  0  0  0  0  0  0  0  0  6  0  0
                           13.6947   -5.7114    0.0000 C   0  0  0  0  0  0  0  0  0  5  0  0
                           12.5714   -5.3464    0.0000 C   0  0  0  0  0  0  0  0  0  4  0  0
                           11.6936   -6.1367    0.0000 S   0  0  0  0  0  0  0  0  0  3  0  0
                           10.5703   -5.7718    0.0000 C   0  0  0  0  0  0  0  0  0  2  0  0
                            9.6148   -6.4660    0.0000 N   0  0  0  0  0  0  0  0  0  1  0  0
                            8.6592   -5.7718    0.0000 C   0  0  0  0  0  0  0  0  0 10  0  0
                            6.6580   -5.3464    0.0000 C   0  0  0  0  0  0  0  0  0 12  0  0
                            7.5359   -6.1367    0.0000 C   0  0  0  0  0  0  0  0  0 11  0  0
                            7.2902   -7.2921    0.0000 C   0  0  0  0  0  0  0  0  0 22  0  0
                            5.9214   -8.8123    0.0000 O   0  0  0  0  0  0  0  0  0 20  0  0
                            6.1669   -7.6571    0.0000 C   0  0  0  0  0  0  0  0  0 19  0  0
                            3.9203   -8.3871    0.0000 C   0  0  0  0  0  0  0  0  0 18  0  0
                            4.1658   -7.2317    0.0000 O   0  0  0  0  0  0  0  0  0 17  0  0
                            5.2891   -6.8666    0.0000 C   0  0  0  0  0  0  0  0  0 16  0  0
                            5.5347   -5.7114    0.0000 C   0  0  0  0  0  0  0  0  0 13  0  0
                            4.6570   -4.9211    0.0000 O   0  0  0  0  0  0  0  0  0 14  0  0
                            3.5336   -5.2860    0.0000 C   0  0  0  0  0  0  0  0  0 15  0  0
                         10  1  2  0  0  0  2
                          1  2  1  0  0  0  2
                          2  8  1  0  0  0  2
                          5  3  1  0  0  0  4
                          5  4  2  0  0  0  2
                          6  5  1  0  0  0  2
                          7  6  1  0  0  0  2
                          8  7  1  0  0  0  2
                          8  9  2  0  0  0  2
                          9 10  1  0  0  0  2
                         10 12  1  0  0  0  2
                         11 19  2  0  0  0  2
                         12 11  1  0  0  0  2
                         13 12  2  0  0  0  2
                         15 13  1  0  0  0  2
                         15 14  1  0  0  0  2
                         18 15  2  0  0  0  2
                         17 16  1  0  0  0  2
                         18 17  1  0  0  0  2
                         19 18  1  0  0  0  2
                         19 20  1  0  0  0  2
                         20 21  1  0  0  0  2
                        M  END
                        ";

                Molecule Molecule1 = MolImporter.importMol(testMol1);
                Molecule Molecule2 = MolImporter.importMol(testMol2);


                MolSearch s = new MolSearch();
                s.setQuery(Molecule1);
                s.setTarget(Molecule2);

                if (s.isMatching())
                { 
               
                }

            }
            catch (Exception)
            {                
                throw;
            }
            return blStatus;
        }

        
    }
}
