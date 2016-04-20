using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using ChemInform.Bll;

namespace ChemInform.Dal
{
    public class DeliveriesDB
    {
        public static DataTable GetDeliveryMasterDetails()
        {
            DataTable dtDeliveryMaster = null;           
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "DELIVERY_PKG.GET_DELIVERIES";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PORC_DELIVERIES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    dtDeliveryMaster = new DataTable();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dtDeliveryMaster);        
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtDeliveryMaster;
        }
        
        public static DataSet GetDeliverDetails(int deliveryId)
        {
            DataSet dsDeliveryDtls = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "DELIVERY_PKG.GET_DELIVERED_REFS";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PIN_DELIVERY_ID", OracleDbType.Int32).Value = deliveryId;
                    oraCmd.Parameters.Add("PORC_REFS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    oraCmd.Parameters.Add("PORC_SOL_CATS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    dsDeliveryDtls = new DataSet();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dsDeliveryDtls);                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsDeliveryDtls;
        }

        public static bool SaveDeliveryDetails(Delivery delivery, out DataTable deliveryMasterTbl)
        {    
            bool blStatus = false;
            DataTable dtDeliveryMaster = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "DELIVERY_PKG.DELIVERY_INSERTS";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                   
                    oraCmd.Parameters.Add("PIC_DELIVERY_NAME", OracleDbType.Varchar2, 100).Value = delivery.DeliveryName;                   
                    oraCmd.Parameters.Add("PIN_DELIVERED_REFS_CNT", OracleDbType.Int32).Value = delivery.DeliveryRefCount;
                    oraCmd.Parameters.Add("PIN_DELIVERED_REACTION_CNT", OracleDbType.Int32).Value = delivery.DeliveryRxnCount;
                    oraCmd.Parameters.Add("PIN_MDL_START_NO", OracleDbType.Int32).Value = delivery.MDLStartNo;
                    oraCmd.Parameters.Add("PIN_MDL_END_NO", OracleDbType.Int32).Value = delivery.MDLEndNo;

                    OracleParameter opRefIDs = new OracleParameter();
                    opRefIDs.OracleDbType = OracleDbType.Int32;
                    opRefIDs.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    opRefIDs.ParameterName = "PINA_SHIPMENT_REF_ID";
                    opRefIDs.Direction = ParameterDirection.Input;
                    if (delivery.DeliveryRefsList.Count == 0)
                    {
                        opRefIDs.Size = 0;
                        opRefIDs.Value = new string[1] { "" };
                    }
                    else
                    {
                        opRefIDs.Size = delivery.DeliveryRefsList.Count;
                        opRefIDs.Value = delivery.DeliveryRefsList.ToArray();
                    }
                    oraCmd.Parameters.Add(opRefIDs);

                    OracleParameter opRefMdlStart = new OracleParameter();
                    opRefMdlStart.OracleDbType = OracleDbType.Int32;
                    opRefMdlStart.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    opRefMdlStart.ParameterName = "PINA_MDL_START_NO";
                    opRefMdlStart.Direction = ParameterDirection.Input;
                    if (delivery.RefMdlStartNoList.Count == 0)
                    {
                        opRefMdlStart.Size = 0;
                        opRefMdlStart.Value = new string[1] { "" };
                    }
                    else
                    {
                        opRefMdlStart.Size = delivery.RefMdlStartNoList.Count;
                        opRefMdlStart.Value = delivery.RefMdlStartNoList.ToArray();
                    }
                    oraCmd.Parameters.Add(opRefMdlStart);

                    OracleParameter opRefMdlEnd = new OracleParameter();
                    opRefMdlEnd.OracleDbType = OracleDbType.Int32;
                    opRefMdlEnd.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    opRefMdlEnd.ParameterName = "PINA_MDL_END_NO";
                    opRefMdlEnd.Direction = ParameterDirection.Input;
                    if (delivery.RefMdlEndNoList.Count == 0)
                    {
                        opRefMdlEnd.Size = 0;
                        opRefMdlEnd.Value = new string[1] { "" };
                    }
                    else
                    {
                        opRefMdlEnd.Size = delivery.RefMdlEndNoList.Count;
                        opRefMdlEnd.Value = delivery.RefMdlEndNoList.ToArray();
                    }
                    oraCmd.Parameters.Add(opRefMdlEnd);

                    oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = delivery.Urid;
                    
                    OracleParameter paramStatus = new OracleParameter();
                    paramStatus.ParameterName = "POC_STATUS";
                    paramStatus.Direction = ParameterDirection.Output;
                    paramStatus.OracleDbType = OracleDbType.Varchar2;
                    paramStatus.Size = 300;
                    oraCmd.Parameters.Add(paramStatus);

                    oraCmd.Parameters.Add("PORC_DELIVERIES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    dtDeliveryMaster = new DataTable();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dtDeliveryMaster);
                    
                    if (paramStatus.Value != null)
                    {
                        if (!string.IsNullOrEmpty(paramStatus.Value.ToString()))
                        {                            
                            if (paramStatus.Value.ToString().ToUpper() == "SUCCESS")
                            {
                                blStatus = true;
                            }
                            else
                            {
                                blStatus = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            deliveryMasterTbl = dtDeliveryMaster;
            return blStatus;
        }

        public static bool SaveDeliverySolvCatsDetails(string deliveryName, int shipmentRefID, string molFile, string molName, string molInchiKey)
        {
            bool blStatus = false;            
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "DELIVERY_PKG.INSERT_DELIVERED_SOL_CATS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIC_DELIVERY_NAME", OracleDbType.Varchar2).Value = deliveryName;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32).Value = shipmentRefID;
                        oraCmd.Parameters.Add("PIC_MOL_NAME", OracleDbType.Varchar2).Value = molName;
                        oraCmd.Parameters.Add("PIL_MOL_FILE", OracleDbType.Clob).Value = molFile;
                        oraCmd.Parameters.Add("PIC_MOL_INCHI_KEY", OracleDbType.Varchar2).Value = molInchiKey;
                        oraCon.Open();
                        oraCmd.ExecuteNonQuery();
                        oraCon.Close();

                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
            return blStatus;
        }

        public static DataTable GetDeliveredSolventCatalysts()
        {
            DataTable dtSolvCats = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "DELIVERY_PKG.GET_DELIVERED_SOL_CATS";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PORC_SOL_CATS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    dtSolvCats = new DataTable();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dtSolvCats);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtSolvCats;
        }

        public static int GetNextMDLNumber()
        {
            int mdlNo = 0;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "DELIVERY_PKG.GET_NEXT_MDL_NO";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PON_MDL_NO", OracleDbType.Int32).Direction = ParameterDirection.Output;
                        oraCon.Open();
                        oraCmd.ExecuteScalar();
                        oraCon.Close();

                        if (oraCmd.Parameters["PON_MDL_NO"].Value != null)
                        {
                            mdlNo = Convert.ToInt32(oraCmd.Parameters["PON_MDL_NO"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mdlNo;
        }
    }
}