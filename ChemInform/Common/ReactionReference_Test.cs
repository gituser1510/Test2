using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ChemInform.Dal;

namespace ChemInform.Common
{
    class ReactionReference_Test
    {
        public DataTable GetReactionRefData(int shipmentRefID)
        {
            DataTable rxnRefData = null;
            try
            {
                if (shipmentRefID > 0)
                {
                    DataSet dsRxns = ReactionCurationDB.GetReactionsForExportOnDocID(shipmentRefID);
                    if (dsRxns != null)
                    {
                        if (dsRxns.Tables.Count == 8)
                        {
                            rxnRefData = new DataTable();
                            rxnRefData.Columns.Add("RxnNo", typeof(Int32));
                            rxnRefData.Columns.Add("PathNo", typeof(string));
                            rxnRefData.Columns.Add("Path", typeof(string));
                            rxnRefData.Columns.Add("Step", typeof(string));

                            DataTable dtDocMaster = dsRxns.Tables[0];
                            DataTable dtReactions = dsRxns.Tables[1];
                            DataTable dtRxnRefs = dsRxns.Tables[2];
                            DataTable dtCrossRefs = dsRxns.Tables[3];
                            DataTable dtRxnSteps = dsRxns.Tables[4];
                            DataTable dtConditions = dsRxns.Tables[5];
                            DataTable dtParticipants = dsRxns.Tables[6];
                            DataTable dtProducts = dsRxns.Tables[7];

                            string rxnsRefNo = dtDocMaster.Rows[0]["REFERENCE_NAME"].ToString();                           
                            int reactionID = 0;

                            foreach (DataRow drow in dtReactions.Rows)
                            {
                                reactionID = Convert.ToInt32(drow["REACTION_ID"]);

                                //Get Products on ReactionID
                                DataTable rxnProducts = GetReactionProductsOnRxnID(reactionID, dtProducts);
                                if (rxnProducts != null)
                                {
                                    string prodInchi = rxnProducts.Rows[0]["INCHI_KEY"].ToString();

                                    //Test for Single Product -//For each Product, check if it used as Reactant in other reactions
                                    DataTable othRxnReactants = GetReactantsAsProductsOnRxnID(reactionID, prodInchi, dtParticipants);
                                    if (othRxnReactants != null)
                                    {
                                        for (int rctIndx = 0; rctIndx < othRxnReactants.Rows.Count; rctIndx++)
                                        {
                                            int othReactionID = Convert.ToInt32(othRxnReactants.Rows[rctIndx]["REACTION_ID"]);
                                        }
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
            return null;
        }

        private DataTable GetReactionProductsOnRxnID(int reactionID, DataTable productsData)
        {
            DataTable rxnProducts = null;
            try
            {
                if (productsData != null && reactionID > 0)
                {
                    var rows = from r in productsData.AsEnumerable()
                               where r.Field<Int64>("REACTION_ID") == reactionID
                               select r;

                    rxnProducts = rows.Any() ? rows.CopyToDataTable() : productsData.Clone();
                }
            }
            catch (Exception)
            {                
                throw;
            }
            return rxnProducts;
        }

        private DataTable GetReactantsAsProductsOnRxnID(int reactionID, string productInchi, DataTable participantsData)
        {
            DataTable reatants = null;
            try
            {
                if (participantsData != null && reactionID > 0)
                {
                    var rows = from r in participantsData.AsEnumerable()
                               where r.Field<Int64>("REACTION_ID") != reactionID && r.Field<string>("INCHI_KEY") == productInchi && r.Field<string>("PRPNT_TYPE") == "REACTANT"
                               select r;

                    reatants = rows.Any() ? rows.CopyToDataTable() : participantsData.Clone();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return reatants;
        }
    }
}
