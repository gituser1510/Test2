using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChemInform.Bll;
using Oracle.DataAccess.Client;
using System.Data;

namespace ChemInform.Dal
{
    public class ReactionCurationDB
    {
        #region Update Methods

        public static bool SaveReactionProduct(ProductInfo prodInfo, out DataTable dtResult)
        {
            bool blStatus = false;
            string strTemp = String.Empty;
            DataTable dtReactions = new DataTable();
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.DML_PRODUCTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_PRODUCT_ID", OracleDbType.Int32).Value = prodInfo.ProductID;
                        oraCmd.Parameters.Add("PIN_REACTION_ID", OracleDbType.Int32).Value = prodInfo.ReactionID;
                        oraCmd.Parameters.Add("PIC_PROD_STRUCTURE", OracleDbType.Clob).Value = prodInfo.Structure;
                        oraCmd.Parameters.Add("PIC_INCHI_KEY", OracleDbType.Varchar2).Value = prodInfo.InchiKey;
                        oraCmd.Parameters.Add("PIC_PRODUCT_NAME", OracleDbType.Varchar2).Value = prodInfo.ProductName;
                        oraCmd.Parameters.Add("PIC_STRUCTURE_NO", OracleDbType.Varchar2).Value = prodInfo.StructureNo;
                        oraCmd.Parameters.Add("PIC_YIELD", OracleDbType.Varchar2).Value = prodInfo.Yield;
                        oraCmd.Parameters.Add("PIC_CHEMO_SELECTIVITY", OracleDbType.Varchar2).Value = prodInfo.CS;
                        oraCmd.Parameters.Add("PIC_DIASTEREO_SELECTIVITY", OracleDbType.Varchar2).Value = prodInfo.DS;
                        oraCmd.Parameters.Add("PIC_DIASTEREOMERIC_EXCESS", OracleDbType.Varchar2).Value = prodInfo.DE;
                        oraCmd.Parameters.Add("PIC_ENANTIOMERIC_EXCESS", OracleDbType.Varchar2).Value = prodInfo.EE;
                        oraCmd.Parameters.Add("PIC_GRADE", OracleDbType.Varchar2).Value = prodInfo.ProductGrade;
                        oraCmd.Parameters.Add("PIC_OPTION", OracleDbType.Varchar2).Value = prodInfo.Option;

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oraCmd.Parameters.Add(paramStatus);

                        oraCmd.Parameters.Add("PORC_PROUCTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        //TODO: Need to discuss with sairam to add UR_ID.
                        // oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {
                            dataAdapter.Fill(dtReactions);
                        }
                        if (paramStatus.Value != null)
                        {
                            if (paramStatus.Value.ToString().Length > 0)
                            {
                                strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
                                if (strTemp.ToUpper() == "UPDATE SUCCESS" || strTemp.ToUpper() == "INSERT SUCCESS" || strTemp.ToUpper() == "DELETE SUCCESS")
                                {
                                    blStatus = true;
                                }                               
                            }
                        }
                        dtResult = dtReactions;
                        return blStatus;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            dtResult = dtReactions;
            return blStatus;
        }

        public static bool SaveReactionReference(ReactionRefInfo rxnRef, out DataTable dtResult)
        {
            bool blStatus = false;
            string strTemp = String.Empty;
            DataTable dtReactions = new DataTable();
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.DML_REACTION_REFERENCE";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_RR_ID", OracleDbType.Int32).Value = rxnRef.ReactionRefId;
                        oraCmd.Parameters.Add("PIN_REACTION_ID", OracleDbType.Int32).Value = rxnRef.ReactionID;
                        oraCmd.Parameters.Add("PIC_EXTREG_ID", OracleDbType.Int32).Value = rxnRef.ExtRegNo;
                        oraCmd.Parameters.Add("PIC_RR_PATH", OracleDbType.Varchar2).Value = rxnRef.RefPath;
                        oraCmd.Parameters.Add("PIC_STEP", OracleDbType.Varchar2).Value = rxnRef.Step;
                        oraCmd.Parameters.Add("PIC_OPTION", OracleDbType.Varchar2).Value = rxnRef.Option.ToString();

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oraCmd.Parameters.Add(paramStatus);

                        oraCmd.Parameters.Add("PORC_REACT_REFERECNCES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        //TODO: Need to discuss with sairam to add UR_ID.
                        // oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {
                            dataAdapter.Fill(dtReactions);
                        }
                        if (paramStatus.Value != null)
                        {
                            if (paramStatus.Value.ToString().Length > 0)
                            {
                                strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
                                if (strTemp.ToUpper() == "UPDATE SUCCESS" || strTemp.ToUpper() == "INSERT SUCCESS" || strTemp.ToUpper() == "DELETE SUCCESS")
                                {
                                    blStatus = true;
                                }                                
                            }
                        }
                        dtResult = dtReactions;
                        return blStatus;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            dtResult = dtReactions;
            return blStatus;
        }

        public static bool SaveCrossReference(CrossRefInfo crossRef, out DataTable dtResult)
        {
            bool blStatus = false;
            string strTemp = String.Empty;
            DataTable dtCrossRef = new DataTable();

            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.DML_CROSS_REFERENCES";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_CR_ID", OracleDbType.Int32).Value = crossRef.CrossRefID;
                        oraCmd.Parameters.Add("PIN_REACTION_ID", OracleDbType.Int32).Value = crossRef.ReactionID;
                        oraCmd.Parameters.Add("PIN_PRE_RXN_SNO", OracleDbType.Int32).Value = crossRef.PrevReactionNo;
                        oraCmd.Parameters.Add("PIN_SUCC_RXN_SNO", OracleDbType.Int32).Value = crossRef.SuccReactionNo;
                        oraCmd.Parameters.Add("PIC_OPTION", OracleDbType.Varchar2).Value = crossRef.Option;

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oraCmd.Parameters.Add(paramStatus);

                        oraCmd.Parameters.Add("PORC_CROSS_REACTIONS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        //TODO: Need to discuss with sairam to add UR_ID.
                        // oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {
                            dataAdapter.Fill(dtCrossRef);
                        }
                        if (paramStatus.Value != null)
                        {
                            if (paramStatus.Value.ToString().Length > 0)
                            {
                                strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
                                if (strTemp.ToUpper() == "UPDATE SUCCESS" || strTemp.ToUpper() == "INSERT SUCCESS" ||  strTemp.ToUpper() == "DELETE SUCCESS")
                                {
                                    blStatus = true;
                                }                               
                            }
                        }
                        dtResult = dtCrossRef;
                        return blStatus;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            dtResult = dtCrossRef;
            return blStatus;
        }

        public static bool SaveReactionInfo(DmlOperations dmlEnum, ReactionInfo rxnInfo, out DataTable dtResult)
        {
            bool blStatus = false;
            string strTemp = String.Empty;
            DataTable dtReactions = new DataTable();
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.DML_REACTIONS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_REACTION_ID", OracleDbType.Int32).Value = rxnInfo.ReactionID;
                        oraCmd.Parameters.Add("PIN_DOC_ID", OracleDbType.Int32).Value = rxnInfo.ShipmentRefID;
                        oraCmd.Parameters.Add("PIC_REACTION_SCHEME", OracleDbType.Clob).Value = rxnInfo.ReactionScheme;
                        oraCmd.Parameters.Add("PIN_REACTION_SNO", OracleDbType.Int32).Value = rxnInfo.ReactionSNo;
                        oraCmd.Parameters.Add("PIC_OPTION", OracleDbType.Varchar2).Value = dmlEnum.ToString();
                        oraCmd.Parameters.Add("PIC_RXN_COMMENTS", OracleDbType.Varchar2).Value = rxnInfo.RxnComments;
                        oraCmd.Parameters.Add("PIC_RXN_MAPPING_TYPE", OracleDbType.Varchar2).Value = rxnInfo.AtomMappingType;

                        oraCmd.Parameters.Add("PIC_COMPLETED_STATUS", OracleDbType.Varchar2).Value = rxnInfo.RxnCompleteStatus;
                        oraCmd.Parameters.Add("PIC_ROLE_NAME", OracleDbType.Varchar2).Value = rxnInfo.RoleName;
                        oraCmd.Parameters.Add("PIC_IS_IMPORTANT", OracleDbType.Varchar2).Value = rxnInfo.IsImportantRxn;
                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = rxnInfo.UR_ID;    

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oraCmd.Parameters.Add(paramStatus);


                        oraCmd.Parameters.Add("PORC_REACTIONS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        //TODO: Need to discuss with sairam to add UR_ID.
                        // oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {
                            dataAdapter.Fill(dtReactions);
                        }
                        if (paramStatus.Value != null)
                        {
                            if (paramStatus.Value.ToString().Length > 0)
                            {
                                strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
                                if (strTemp.ToUpper() == "UPDATE SUCCESS" && dmlEnum == DmlOperations.UPDATE)
                                {
                                    blStatus = true;
                                }
                                else if (strTemp.ToUpper() == "INSERT SUCCESS" && dmlEnum == DmlOperations.INSERT)
                                {
                                    blStatus = true;
                                }
                                else if (strTemp.ToUpper() == "DELETE SUCCESS" && dmlEnum == DmlOperations.DELETE)
                                {
                                    blStatus = true;
                                }
                            }
                        }
                        dtResult = dtReactions;
                        return blStatus;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return blStatus;
        }

        public static bool SaveReactionStepsInfo(DmlOperations dmlEnum, StepInfo rxnStep, out DataTable dtResult)
        {
            bool blStatus = false;
            string strTemp = String.Empty;
            DataTable dtReactions = new DataTable();
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.DML_REACTION_STEPS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_RXN_STEP_ID", OracleDbType.Int32).Value = rxnStep.StepID;
                        oraCmd.Parameters.Add("PIN_REACTION_ID", OracleDbType.Int32).Value = rxnStep.ReactionID;
                        oraCmd.Parameters.Add("PIN_RXN_STEP_SNO", OracleDbType.Int32).Value = rxnStep.SerialNo;
                        oraCmd.Parameters.Add("PIN_YIELD", OracleDbType.Varchar2).Value = rxnStep.StepYield;
                        oraCmd.Parameters.Add("PIC_OPTION", OracleDbType.Varchar2).Value = dmlEnum.ToString();

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oraCmd.Parameters.Add(paramStatus);


                        oraCmd.Parameters.Add("PORC_REACTIONS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        //TODO: Need to discuss with sairam to add UR_ID.
                        // oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {
                            dataAdapter.Fill(dtReactions);
                        }
                        if (paramStatus.Value != null)
                        {
                            strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
                            if (strTemp.ToUpper() == "UPDATE SUCCESS" && dmlEnum == DmlOperations.UPDATE)
                            {
                                blStatus = true;
                            }
                            else if (strTemp.ToUpper() == "INSERT SUCCESS" && dmlEnum == DmlOperations.INSERT)
                            {
                                blStatus = true;
                            }
                            else if (strTemp.ToUpper() == "DELETE SUCCESS" && dmlEnum == DmlOperations.DELETE)
                            {
                                blStatus = true;
                            }
                        }
                        dtResult = dtReactions;
                        return blStatus;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            dtResult = dtReactions;
            return blStatus;
        }

        public static bool SaveReactionConditions(ConditionInfo rxnCond, out DataTable dtResult)
        {
            bool blStatus = false;
            string strTemp = String.Empty;
            DataTable dtRxnConds = new DataTable();
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.DML_CONDITIONS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_CONDITION_ID", OracleDbType.Int32).Value = rxnCond.ConditionID;
                        oraCmd.Parameters.Add("PIN_REACTION_ID", OracleDbType.Int32).Value = rxnCond.ReactionID;
                        oraCmd.Parameters.Add("PIN_RXN_STEP_ID", OracleDbType.Int32).Value = rxnCond.RxnStepID;
                        oraCmd.Parameters.Add("PIC_COND_TIME", OracleDbType.Varchar2).Value = rxnCond.Time;
                        oraCmd.Parameters.Add("PIC_TEMPERATURE", OracleDbType.Varchar2).Value = rxnCond.Temperature;
                        oraCmd.Parameters.Add("PIC_PRESSURE", OracleDbType.Varchar2).Value = rxnCond.Pressure;
                        oraCmd.Parameters.Add("PIC_PH", OracleDbType.Varchar2).Value = rxnCond.PH;
                        oraCmd.Parameters.Add("PIC_IS_WARMUP", OracleDbType.Char).Value = rxnCond.WarmUp ? 'Y' : 'N';
                        oraCmd.Parameters.Add("PIC_IS_COOL_DOWN", OracleDbType.Char).Value = rxnCond.CoolDown ? 'Y' : 'N';
                        oraCmd.Parameters.Add("PIC_IS_REFLUX", OracleDbType.Char).Value = rxnCond.Reflux ? 'Y' : 'N';
                        oraCmd.Parameters.Add("PIC_OTHER_CONDITIONS", OracleDbType.Varchar2).Value = rxnCond.Other;
                        oraCmd.Parameters.Add("PIC_OPERATION", OracleDbType.Varchar2).Value = rxnCond.Operation;
                        oraCmd.Parameters.Add("PIC_OPTION", OracleDbType.Varchar2).Value = rxnCond.Option.ToString();
                        oraCmd.Parameters.Add("PIC_COND_TIME_UNIT", OracleDbType.Varchar2).Value = rxnCond.TimeUnits;
                        oraCmd.Parameters.Add("PIC_TEMPERATURE_UNIT", OracleDbType.Varchar2).Value = rxnCond.TempUnits;
                        oraCmd.Parameters.Add("PIC_PRESSURE_UNIT", OracleDbType.Varchar2).Value = rxnCond.PressureUnits;

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oraCmd.Parameters.Add(paramStatus);


                        oraCmd.Parameters.Add("PORC_CONDITIONS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        //TODO: Need to discuss with sairam to add UR_ID.
                        // oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {
                            dataAdapter.Fill(dtRxnConds);
                        }
                        if (paramStatus.Value != null)
                        {
                            if (paramStatus.Value.ToString().Length > 0)
                            {
                                strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
                                if (strTemp.ToUpper() == "UPDATE SUCCESS" || strTemp.ToUpper() == "INSERT SUCCESS" || strTemp.ToUpper() == "DELETE SUCCESS")
                                {
                                    blStatus = true;
                                }                               
                            }
                        }
                        dtResult = dtRxnConds;
                        return blStatus;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            dtResult = dtRxnConds;
            return blStatus;
        }

        public static bool SaveReactionParticipants(ParticipantInfo rxnPartpnt, out DataTable dtResult)
        {
            bool blStatus = false;
            string strTemp = String.Empty;
            DataTable dtReactions = new DataTable();
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.DML_PARTICIPANTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_PRPNT_ID", OracleDbType.Int32).Value = rxnPartpnt.ParticipantID;
                        oraCmd.Parameters.Add("PIN_REACTION_ID", OracleDbType.Int32).Value = rxnPartpnt.ReactionID;
                        oraCmd.Parameters.Add("PIN_RXN_STEP_ID", OracleDbType.Int32).Value = rxnPartpnt.RxnStepID;
                        oraCmd.Parameters.Add("PIC_PRPNT_TYPE", OracleDbType.Varchar2).Value = rxnPartpnt.ParticipantType;
                        oraCmd.Parameters.Add("PIC_PRPNT_STRUCTURE", OracleDbType.Clob).Value = rxnPartpnt.Structure;
                        oraCmd.Parameters.Add("PIC_INCHI_KEY", OracleDbType.Varchar2).Value = rxnPartpnt.InchiKey;
                        oraCmd.Parameters.Add("PIC_PRPNT_NAME", OracleDbType.Varchar2).Value = rxnPartpnt.ParticipantName;
                        oraCmd.Parameters.Add("PIC_STRUCTURE_NO", OracleDbType.Varchar2).Value = rxnPartpnt.StructureNo;
                        oraCmd.Parameters.Add("PIC_GRADE", OracleDbType.Varchar2).Value = rxnPartpnt.Grade;

                        oraCmd.Parameters.Add("PIC_OPTION", OracleDbType.Varchar2).Value = rxnPartpnt.Option.ToString();

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oraCmd.Parameters.Add(paramStatus);


                        oraCmd.Parameters.Add("PORC_PARITCIPANTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        //TODO: Need to discuss with sairam to add UR_ID.
                        // oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = usrInfo.UserID;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {

                            dataAdapter.Fill(dtReactions);
                        }
                        if (paramStatus.Value != null)
                        {
                            if (paramStatus.Value.ToString().Length > 0)
                            {
                                strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
                                if (strTemp.ToUpper() == "UPDATE SUCCESS" ||strTemp.ToUpper() == "INSERT SUCCESS"  || strTemp.ToUpper() == "DELETE SUCCESS")
                                {
                                    blStatus = true;
                                }                                
                            }
                        }
                        dtResult = dtReactions;
                        return blStatus;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            dtResult = dtReactions;
            return blStatus;
        }

        public static DataSet GetReactionsForExportOnDocID(int docID)
        {
            DataSet dsReactions = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.GET_REACTIONS_ON_DOC_ID";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_DOC_ID", OracleDbType.Int32).Value = docID;

                        oraCmd.Parameters.Add("PORC_DOCUMENTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_REACTIONS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_REACT_REFERECNCES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_CROSS_REACTIONS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_REACITON_STEPS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_CONDITIONS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_PARITCIPANTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_PRODUCTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        dsReactions = new DataSet();
                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {
                            dataAdapter.Fill(dsReactions);
                        }                        
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dsReactions;
        }

        public static DataSet GetSysNoClassificationMasterDetails()
        {
            DataSet dsSysNo = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SHIPMENT_MANAGEMENT.GET_CLASSFICATION_DLTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PORC_CLASSFICATION_DLTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_SYSNO_DLTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        
                        dsSysNo = new DataSet();
                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {
                            dataAdapter.Fill(dsSysNo);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dsSysNo;
        }

        #endregion

        public static DataSet GetReactionDataOnID(ReactionInfo rxnInfo)
        {
            DataSet dsRxnData = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "GET_REACTION_DATA";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_RXN_ID", OracleDbType.Int32).Value = rxnInfo.ReactionID;
                        oraCmd.Parameters.Add("PORC_RXN", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dsRxnData = new DataSet();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dsRxnData);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dsRxnData;
        }

        public static DataTable GetCrossReferencesOnShipmentRefID(int shipmentRefID)
        {
            DataTable crossRefs = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "GET_CROSS_REFERENCES";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHP_REF_ID", OracleDbType.Int32).Value = shipmentRefID;
                        oraCmd.Parameters.Add("PORC_CROSS_REFS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        crossRefs = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(crossRefs);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return crossRefs;
        }

        public static DataTable GetReactionReferencesOnShipmentRefID(int shipmentRefID)
        {
            DataTable crossRefs = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_CROSS_REFERENCE.GET_REACTION_REFERENCES";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32).Value = shipmentRefID;
                        oraCmd.Parameters.Add("PORC_CROSS_REFERENCES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        crossRefs = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(crossRefs);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return crossRefs;
        }

        public static DataSet GetRxnAndCrossReferencesOnShipmentRefID(int shipmentRefID)
        {
            DataSet dsRxn_CrossRefs = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_CROSS_REFERENCE.GET_RXN_CROSS_REFERENCES";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32).Value = shipmentRefID;
                        oraCmd.Parameters.Add("PORC_CROSS_REFERENCES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCmd.Parameters.Add("PORC_RXN_REFERENCES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dsRxn_CrossRefs = new DataSet();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dsRxn_CrossRefs);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dsRxn_CrossRefs;
        }

        public static DataTable GetProductsOnShipmentRefID(int shipmentRefID)
        {
            DataTable dtRefProducts = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "GET_REF_PRODUCTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32).Value = shipmentRefID;
                        oraCmd.Parameters.Add("PORC_REF_PRODUCTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtRefProducts = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtRefProducts);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dtRefProducts;
        }

        public static int DuplicateReactionData(int shipmentRefID, int dupRxnID, int newRxnSno, int created_by)
        {
            int rxn_ID = 0;           
            try
            {
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oCmd = new OracleCommand())
                    {
                        oCmd.CommandText = "REACTION_ANALYSIS.DUPLICATE_REACTION_DATA";
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Connection = dbCon;

                        oCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32, shipmentRefID, ParameterDirection.Input);
                        oCmd.Parameters.Add("PIN_REACTION_ID", OracleDbType.Int32, dupRxnID, ParameterDirection.Input);
                        oCmd.Parameters.Add("PIN_REACTION_SNO", OracleDbType.Int32, newRxnSno, ParameterDirection.Input);
                        oCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32, created_by, ParameterDirection.Input);
                        oCmd.Parameters.Add("PON_REACTION_ID_NEW", OracleDbType.Int32, ParameterDirection.Output);

                        dbCon.Open();
                        oCmd.ExecuteNonQuery();
                        rxn_ID = oCmd.Parameters["PON_REACTION_ID_NEW"].Value != null ? Convert.ToInt32(oCmd.Parameters["PON_REACTION_ID_NEW"].Value.ToString()) : 0;                      
                        dbCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }          
            return rxn_ID;           
        }

        public static DataTable GetReactionDataOnReactionID(int reactionID)
        {
            DataTable dtRxnData = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.GET_REACTION_DATA_ON_RXN_ID";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_RXN_ID", OracleDbType.Int32).Value = reactionID;
                        oraCmd.Parameters.Add("PORC_RXN_DATA", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtRxnData = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtRxnData);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dtRxnData;
        }

        public static bool UpdateReactionsQCCompleteStatus(int shipmentRefID, List<int> lstSelRxnIDs, int UrId)
        {            
            bool blStatus = false;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.UPDATE_QC_COMPLETED_STATUS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_DOC_ID", OracleDbType.Int32, 30).Value = shipmentRefID;

                        OracleParameter opRefIDs = new OracleParameter();
                        opRefIDs.OracleDbType = OracleDbType.Int32;
                        opRefIDs.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        opRefIDs.ParameterName = "PINA_RXN_IDS";
                        opRefIDs.Direction = ParameterDirection.Input;
                        if (lstSelRxnIDs.Count == 0)
                        {
                            opRefIDs.Size = 0;
                            opRefIDs.Value = new string[1] { "" };
                        }
                        else
                        {
                            opRefIDs.Size = lstSelRxnIDs.Count;
                            opRefIDs.Value = lstSelRxnIDs.ToArray();
                        }
                        oraCmd.Parameters.Add(opRefIDs);


                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32, 30).Value = UrId;

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
                                string strTemp = Convert.ToString(oraCmd.Parameters["POC_STATUS"].Value);
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

        public static DataTable CheckForDuplicateReaction(int shipmentRefID, int reactionSNo)
        {
            DataTable dtDupRxnData = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.CHECK_DUPLICATE_REACTIONS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32).Value = shipmentRefID;
                        oraCmd.Parameters.Add("PIN_REACTION_SNO", OracleDbType.Int32).Value = reactionSNo;
                        oraCmd.Parameters.Add("PORC_DUPLICATION_REACTIONS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtDupRxnData = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtDupRxnData);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dtDupRxnData;
        }

        public static DataTable SaveFullArticleInfo(FullArticleInfo articleInfo)
        {           
            string strTemp = String.Empty;
            DataTable dtFullArticleInfo = null;

            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "SHIPMENT_MANAGEMENT.UPDATE_BIBLIOGRAPHY_INFO";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32).Value = articleInfo.ShipmentRefID;
                        oraCmd.Parameters.Add("PIC_JOURNAL_NAME", OracleDbType.Varchar2).Value = articleInfo.JournalName;
                        oraCmd.Parameters.Add("PIN_JOURNAL_YEAR", OracleDbType.Int32).Value = articleInfo.JournalYear;
                        oraCmd.Parameters.Add("PIC_VOLUME", OracleDbType.Varchar2).Value = articleInfo.JournalVolume;
                        oraCmd.Parameters.Add("PIC_ISSUE", OracleDbType.Varchar2).Value = "";
                        oraCmd.Parameters.Add("PIC_START_PAGE", OracleDbType.Varchar2).Value = articleInfo.JournalStartPage;
                        oraCmd.Parameters.Add("PIC_END_PAGE", OracleDbType.Varchar2).Value = articleInfo.JournalEndPage;
                        oraCmd.Parameters.Add("PIC_DOI", OracleDbType.Varchar2).Value = articleInfo.JournalDOI;

                        oraCmd.Parameters.Add("PORC_SHIPMENT_REFERENCES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        dtFullArticleInfo = new DataTable();
                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oraCmd))
                        {                            
                            dataAdapter.Fill(dtFullArticleInfo);
                        }              
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dtFullArticleInfo;
        }
    }
}
