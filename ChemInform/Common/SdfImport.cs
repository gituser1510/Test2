using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using java.io;
using chemaxon.formats;
using chemaxon.struc;

namespace ChemInform.Common
{
    public class SdfImport
    {
        public static void ImportAgentsMaster(string filePath)
        {
            DataTable dtSolvAgents = null;
            try
            {
                if (GlobalVariables.SolvCatalystMaster == null)
                {

                    FileInputStream fInStream = new FileInputStream(filePath);
                    MolImporter molImp = new MolImporter(fInStream, "sdf");
                    Molecule objMol = new Molecule();

                    GlobalVariables.SolvCatalystMaster = new DataTable();

                    GlobalVariables.SolvCatalystMaster.Columns.Add("MOL_FILE");
                    GlobalVariables.SolvCatalystMaster.Columns.Add("IUPAC_NAME");
                    GlobalVariables.SolvCatalystMaster.Columns.Add("INCHI_KEY");
                    GlobalVariables.SolvCatalystMaster.Columns.Add("OTHER_NAMES");

                    while (molImp.read(objMol))
                    {
                        DataRow dRow = GlobalVariables.SolvCatalystMaster.NewRow();
                        dRow["MOL_FILE"] = objMol.toFormat("mol");
                        dRow["IUPAC_NAME"] = objMol.getProperty("MOL:SYMBOL(1)");
                        dRow["INCHI_KEY"] = objMol.getProperty("MOL:INCHIKEY");

                        int propCnt = objMol.getPropertyCount();
                        string strOtherName = "";
                        for (int i = 0; i < propCnt; i++)
                        {
                            string propName = objMol.getPropertyKey(i);
                            if (propName.ToUpper() != "MOL:SYMBOL(1)" && propName.ToUpper().StartsWith("MOL:SYMBOL("))
                            {
                                strOtherName = string.IsNullOrEmpty(strOtherName) ? objMol.getPropertyObject(propName).ToString() : strOtherName.Trim() + "," + objMol.getPropertyObject(propName).ToString();
                            }
                        }

                        dRow["OTHER_NAMES"] = strOtherName;
                        GlobalVariables.SolvCatalystMaster.Rows.Add(dRow);
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }
           // return dtSolvAgents;
        }


    }
}
