using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChemInform.Bll;
using chemaxon.formats;
using chemaxon.util;
using chemaxon.struc;
using java.io;

namespace ChemInform.Export
{
    public static class SpectralExport
    {
        public static bool ExportToSDF(SpectralInfo compSpectralData, string outputFolderPath)
        {
            bool blStatus = false;
            try
            {
                if (compSpectralData != null && !string.IsNullOrEmpty(outputFolderPath))
                {
                    MolHandler objMolHandler = null;
                    Molecule objMol = null;

                    int intMolRegNo = 0;
                    string strOutFileName = "";

                    //NMR Spectral

                    for (int i = 0; i < compSpectralData.NMRSpectralList.Count; i++)
                    {                      

                        intMolRegNo = intMolRegNo + 1;
                        
                        strOutFileName = strOutFileName + "_" + compSpectralData.NMRSpectralList[i].Nucleus + ".sdf";

                        FileOutputStream fOutStream = new FileOutputStream(strOutFileName, true);
                        MolExporter objmExporter = new MolExporter(fOutStream, "sdf");
                        
                        //Compound Molecule
                        objMolHandler = new MolHandler(compSpectralData.CompoundInformation.Compound.ToString());
                        objMol = objMolHandler.getMolecule();

                        //Article Information
                        objMol.setProperty("journal name", compSpectralData.ArticleInformation.JournalName);
                        objMol.setProperty("article doi", compSpectralData.ArticleInformation.DOI);
                        objMol.setProperty("authors", compSpectralData.ArticleInformation.Authors);  

                        //Compound Information
                        objMol.setProperty("MOLREGNO", intMolRegNo.ToString());
                        objMol.setProperty("chemical name", compSpectralData.CompoundInformation.IUPACName);
                        objMol.setProperty("mol comments", compSpectralData.CompoundInformation.Comments);
                        objMol.setProperty("pagenumber", compSpectralData.CompoundInformation.PageNo);

                       //NMR information
                        objMol.setProperty("nmr spectrometer", compSpectralData.NMRSpectralList[i].SpectroMeter);
                        objMol.setProperty("nucleus", compSpectralData.NMRSpectralList[i].Nucleus);
                        objMol.setProperty("solvent", compSpectralData.NMRSpectralList[i].Solvent);
                        objMol.setProperty("nmr frequency", compSpectralData.NMRSpectralList[i].Frequency);
                        objMol.setProperty("nmr shift values", compSpectralData.NMRSpectralList[i].ShiftValues);
                        objMol.setProperty("nmr standard", compSpectralData.NMRSpectralList[i].StdSolvent);

                        objmExporter.write(objMol);

                        fOutStream.close();
                        objmExporter.close();
                    }

                    //Other Spectral
                    for (int i = 0; i < compSpectralData.OtherSpectralList.Count; i++)
                    {
                        intMolRegNo = intMolRegNo + 1;
                        
                        strOutFileName = strOutFileName + "_" + compSpectralData.OtherSpectralList[i].ValueType + ".sdf";

                        FileOutputStream fOutStream = new FileOutputStream(strOutFileName, true);
                        MolExporter objmExporter = new MolExporter(fOutStream, "sdf");

                        //Compound Molecule
                        objMolHandler = new MolHandler(compSpectralData.CompoundInformation.Compound.ToString());
                        objMol = objMolHandler.getMolecule();

                        //Article Information
                        objMol.setProperty("journal name", compSpectralData.ArticleInformation.JournalName);
                        objMol.setProperty("article doi", compSpectralData.ArticleInformation.DOI);
                        objMol.setProperty("authors", compSpectralData.ArticleInformation.Authors);

                        //Compound Information
                        objMol.setProperty("MOLREGNO", intMolRegNo.ToString());
                        objMol.setProperty("chemical name", compSpectralData.CompoundInformation.IUPACName);
                        objMol.setProperty("mol comments", compSpectralData.CompoundInformation.Comments);
                        objMol.setProperty("pagenumber", compSpectralData.CompoundInformation.PageNo);

                        //IR information
                        if (compSpectralData.OtherSpectralList[i].ValueType.ToUpper() == "IR")
                        {
                            objMol.setProperty("ir spectrometer", compSpectralData.OtherSpectralList[i].SpectroMeter);
                            objMol.setProperty("ir spectral peaks", compSpectralData.OtherSpectralList[i].PeakValues);
                            objMol.setProperty("sample prep", compSpectralData.OtherSpectralList[i].SamplePreparation);
                        }

                        //Mass information
                        if (compSpectralData.OtherSpectralList[i].ValueType.ToUpper() == "MASS")
                        {
                            objMol.setProperty("mass spectrometer", compSpectralData.OtherSpectralList[i].SpectroMeter);
                            objMol.setProperty("mass spectral peaks", compSpectralData.OtherSpectralList[i].PeakValues);
                            objMol.setProperty("mass.method", compSpectralData.OtherSpectralList[i].Method);
                            objMol.setProperty("eV", compSpectralData.OtherSpectralList[i].ElectronVolts);
                        }

                        //UV information
                        if (compSpectralData.OtherSpectralList[i].ValueType.ToUpper() == "UV")
                        {
                            objMol.setProperty("mass spectrometer", compSpectralData.OtherSpectralList[i].SpectroMeter);
                            objMol.setProperty("mass spectral peaks", compSpectralData.OtherSpectralList[i].PeakValues);
                            objMol.setProperty("comments", compSpectralData.OtherSpectralList[i].Comments);                           
                        }

                        objmExporter.write(objMol);

                        fOutStream.close();
                        objmExporter.close();
                    } 

                    blStatus = true;                    
                }
            }
            catch (Exception ex)
            {                
               ErrorHandling.WriteErrorLog(ex.ToString());
            }
            return blStatus;
        }
    }
}
