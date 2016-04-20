using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using ChemInform.Bll;

namespace ChemInform.Dal
{
    public class ShipmentManagementDB
    {
        public static DataTable GetShipmentTasks(int shipmentID)
        {
            DataTable dtShipments = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SHIPMENT_MANAGEMENT.GET_UNASSGINED_DOC_DLTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_ID", OracleDbType.Int32, 30).Value = shipmentID;
                        oraCmd.Parameters.Add("PORC_UNASSINGNED_DOC_DLTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtShipments = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtShipments);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtShipments;
        }

        public static DataTable GetAllShipments()
        {
            DataTable dtShipments = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SHIPMENT_MANAGEMENT.GET_SHIPMENT_DLTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PORC_SHIPMENTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtShipments = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtShipments);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtShipments;
        }

        public static DataTable GetShipmentsOnModule(string module)
        {
            DataTable dtShipments = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "TASK_MANAGEMENT.GET_MODULE_SHIPMENTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = module;
                        oraCmd.Parameters.Add("PORC_SHIPMENTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtShipments = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtShipments);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtShipments;
        }

        public static DataTable GetReferenceDetailsOnRefID(int shipmentRefID)
        {
            DataTable dtRefDtls = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SHIPMENT_MANAGEMENT.GET_SHIPMENT_REFERENCES_DLTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32).Value = shipmentRefID;
                        oraCmd.Parameters.Add("PORC_SHIPMENT_REFERENCES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtRefDtls = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtRefDtls);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtRefDtls;
        }

        public static bool ValidateTaskPreparation(List<int> lstSelTANs, int shipmentId, int validateUrId)
        {
            string strTemp = null;
            bool blStatus = false;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "TASK_MANAGEMENT.UPDATE_VALIDATION_STATUS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                       
                        OracleParameter opRefIDs = new OracleParameter();
                        opRefIDs.OracleDbType = OracleDbType.Int32;
                        opRefIDs.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        opRefIDs.ParameterName = "PIAN_SHPT_REFS";
                        opRefIDs.Direction = ParameterDirection.Input;
                        if (lstSelTANs.Count == 0)
                        {
                            opRefIDs.Size = 0;
                            opRefIDs.Value = new string[1] { "" };
                        }
                        else
                        {
                            opRefIDs.Size = lstSelTANs.Count;
                            opRefIDs.Value = lstSelTANs.ToArray();
                        }
                        oraCmd.Parameters.Add(opRefIDs);

                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32, 30).Value = validateUrId;

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oraCmd.Parameters.Add(paramStatus);

                        oraCon.Open();
                        oraCmd.ExecuteNonQuery();
                        oraCon.Close();

                        if (paramStatus.Value != null)
                        {
                            if (paramStatus.Value.ToString().Length > 0)
                            {
                                strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
                                if (strTemp.ToUpper() == "SUCCESS")
                                {
                                    blStatus = true;
                                }
                                else
                                {
                                    blStatus = false;
                                }
                            }
                        }
                        return blStatus;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetShipmentStatusReport(int shipmentID)
        {
            DataTable dtReport = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REPORTS.SHIPMENT_SUMMARY_REPORT";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_ID", OracleDbType.Int32, 30).Value = shipmentID;
                        oraCmd.Parameters.Add("PORC_REPORT", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtReport = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtReport);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtReport;
        }

        public static DataSet GetDeliveryDataOnYearAndClassType(int shipmentYear, string classType)
        {
            DataSet dsDeliveryData = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "DELIVERY_PKG.EXPORT_SHIPMENT_REFERENCES";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_YEAR", OracleDbType.Int32).Value = shipmentYear;
                        oraCmd.Parameters.Add("PIC_CLASS_TYPE", OracleDbType.Varchar2, 30).Value = classType;
                        oraCmd.Parameters.Add("PORC_REPORT", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_SOL_CATS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dsDeliveryData = new DataSet();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dsDeliveryData);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsDeliveryData;
        }
    }
}
