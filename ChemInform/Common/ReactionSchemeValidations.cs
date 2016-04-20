using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ChemInform.Dal;
using chemaxon.struc;
using chemaxon.formats;
using chemaxon.sss.search;
using chemaxon.sss;

namespace ChemInform.Common
{
    public static class ReactionSchemeValidations
    {
        public static DataTable ValidateSchemeProductsAndReactantsChain(DataTable crossRefsData)
        {
            DataTable dtRxnChainValidStatus = null;
            try
            {
                if (crossRefsData != null)
                {
                    //Get Unique Path Nos
                    var distPathNos = (from DataRow dRow in crossRefsData.Rows
                                        select new { pathNo = dRow["EXT_REG_NO"] }).Distinct();

                    //Get Unique PathNames
                    var distPathNames = (from DataRow dRow in crossRefsData.Rows
                                       select new { PathName = dRow["PATH_LETTER"] }).Distinct();

                    DataTable dtRxnChain = null;

                  

                    foreach (var pNo in distPathNos)
                    {                      
                        foreach (var pName in distPathNames)
                        {
                            DataView dvTemp = crossRefsData.Copy().DefaultView;
                            dvTemp.RowFilter = "EXT_REG_NO = " + pNo.pathNo + " and PATH_LETTER = '" + pName.PathName.ToString() + "'";
                            dtRxnChain = dvTemp.ToTable();

                            ////Get ReactionChain table on pathNo and pathName
                            //dtRxnChain = (from DataRow dr in crossRefsData.Rows
                            //                        where dr["EXT_REG_NO"] == pNo.pathNo && dr["PATH_LETTER"] == pName.PathName.ToString()
                            //                        select dr).CopyToDataTable();

                            //EnumerableRowCollection<DataRow> query = from order in crossRefsData.AsEnumerable()
                            //                                         where order.Field<Decimal>("EXT_REG_NO") =pNo.pathNo && order.Field<string>("PATH_LETTER") = pName.PathName.ToString()
                            //                                         select order;

                            //dtRxnChain = query.AsDataView().ToTable();

                            if (dtRxnChain != null)
                            {
                                dtRxnChain.Columns.Add("STATUS", typeof(string));

                                if (dtRxnChainValidStatus == null)
                                {
                                    dtRxnChainValidStatus = dtRxnChain.Clone();
                                }

                                if (dtRxnChain.Rows.Count > 1)
                                {
                                    for (int i = 1; i < dtRxnChain.Rows.Count; i++)
                                    {
                                        //Get Product of first row
                                        DataTable productData = ReactionCurationDB.GetReactionDataOnReactionID(Convert.ToInt32(dtRxnChain.Rows[i - 1]["REACTION_ID"]));

                                        //Get Reactants of second row
                                        DataTable reactantData = ReactionCurationDB.GetReactionDataOnReactionID(Convert.ToInt32(dtRxnChain.Rows[i]["REACTION_ID"]));

                                        if (CompareProductsAndReactantsInTables(productData, reactantData))
                                        {
                                            dtRxnChain.Rows[i - 1]["STATUS"] = dtRxnChain.Rows[i]["STATUS"].ToString() != "Valid" ? "Valid" : dtRxnChain.Rows[i]["STATUS"].ToString();
                                            dtRxnChain.Rows[i]["STATUS"] = dtRxnChain.Rows[i]["STATUS"].ToString() != "Valid" ? "Valid" : dtRxnChain.Rows[i]["STATUS"].ToString();
                                        }
                                        else
                                        {
                                            dtRxnChain.Rows[i - 1]["STATUS"] = dtRxnChain.Rows[i]["STATUS"].ToString() != "Valid" ? "Valid" : dtRxnChain.Rows[i]["STATUS"].ToString();
                                            dtRxnChain.Rows[i]["STATUS"] = "In-Valid";
                                        }
                                    }
                                    
                                    //Import Rows to new table
                                    if (dtRxnChain.Rows.Count > 0)
                                    {
                                        if (dtRxnChainValidStatus == null)
                                        {
                                            dtRxnChainValidStatus = dtRxnChain.Clone();
                                        }

                                        foreach (DataRow dr in dtRxnChain.Rows)
                                        {
                                            DataRow drNew = dtRxnChainValidStatus.NewRow();
                                            drNew.ItemArray = dr.ItemArray;
                                            dtRxnChainValidStatus.Rows.Add(drNew);

                                        }
                                    }
                                }
                            }                        
                        }                        
                    }
                    
                    #region MyRegion
                    //foreach pathNo in Unique Paths
                    //{
                    //foreach pathName in unique PathNames
                    //{
                    //Get ReactionChain table on pathNo and pathName

                    //foreach row in ReactionChain
                    //{
                    //Get Product of first row
                    //Get Reactants of second row
                    //Compare Product with reactant
                    //If matching, set second row as valid else invalid
                    //}
                    //}
                    //}      
                    #endregion                                    
                }
            }
            catch (Exception)
            {                
                throw;
            }
            return dtRxnChainValidStatus;
        }

        private static bool CompareProductsAndReactantsInTables(DataTable productData, DataTable reactantData)
        {
            bool blStatus = true;
            try
            {
                int productsCnt = 0;
                int reactantsCnt = 0;
                RxnMolecule prodRxnMolecule = null;
                RxnMolecule rctRxnMolecule = null;
                Molecule molReactant = null;
                Molecule molProduct = null;

                MolSearch srchMol = new MolSearch();
                MolSearchOptions so = new MolSearchOptions();//SearchConstants.DUPLICATE                               
                so.setQueryAbsoluteStereo(true);
                so.setChargeMatching(SearchConstants.__Fields.CHARGE_MATCHING_EXACT);
                so.setDoubleBondStereoMatchingMode(StereoConstants.__Fields.DBS_ALL);
                so.setImplicitHMatching(SearchConstants.__Fields.IMPLICIT_H_MATCHING_ENABLED);
                so.setExactBondMatching(true);
                so.setStereoSearchType(SearchConstants.__Fields.STEREO_EXACT);
                so.setTautomerSearch(true);
                so.setAttachedDataMatch(1);
                so.setOrderSensitiveSearch(true);
                so.setSearchType(5);

                srchMol.setSearchOptions(so);

                string rctInchi = "";
                string prodInchi = "";

                for (int prIndx = 0; prIndx < productData.Rows.Count; prIndx++)
                {
                    if (!string.IsNullOrEmpty(productData.Rows[prIndx]["REACTION_SCHEME"].ToString()))
                    {
                        prodRxnMolecule = RxnMolecule.getReaction(MolImporter.importMol(productData.Rows[prIndx]["REACTION_SCHEME"].ToString()));
                        productsCnt = prodRxnMolecule.getProductCount();
                    }
                                        
                    for (int rctIndx = 0; rctIndx < reactantData.Rows.Count; rctIndx++)
                    {
                        if (!string.IsNullOrEmpty(reactantData.Rows[rctIndx]["REACTION_SCHEME"].ToString()))
                        {
                            rctRxnMolecule = RxnMolecule.getReaction(MolImporter.importMol(reactantData.Rows[rctIndx]["REACTION_SCHEME"].ToString()));
                            reactantsCnt = rctRxnMolecule.getReactantCount();
                        }

                        int rctLoopCnt = productsCnt < reactantsCnt ? productsCnt : reactantsCnt;
                        
                        for (int p = 0; p < productsCnt; p++)
                        {
                            molProduct = prodRxnMolecule.getProduct(p);

                            for (int r = 0; r < rctLoopCnt; r++)
                            {
                                molReactant = rctRxnMolecule.getReactant(r);
                                                               
                               rctInchi = ChemistryOperations.GetStructureInchiKey(molReactant.toFormat("mol"));
                               prodInchi = ChemistryOperations.GetStructureInchiKey(molProduct.toFormat("mol"));

                               if (rctInchi == prodInchi)
                               {
                                   srchMol.setQuery(molReactant);
                                   srchMol.setTarget(molProduct);

                                   if (!srchMol.isMatching())
                                   {
                                       blStatus = false;
                                       return blStatus;
                                   }
                               }
                            }
                        }
                    }
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
