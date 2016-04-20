using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ChemInform.Bll;
using Oracle.DataAccess.Client;

namespace ChemInform.Dal
{
    public static class DataOperations
    {
        public static DataTable GetAllUsersInformation()
        {
            DataTable dtUserNames = null;
            //dtUserNames.Columns.Add("ROLE_NAME", typeof(string));
            //dtUserNames.Columns.Add("ROLE_ID", typeof(Int32));
            //dtUserNames.Rows.Add("
            return dtUserNames;
        }

        public static DataTable GetAllShipments()
        {
            try
            {
                DataTable dtResult = null;

                using (OracleConnection conn = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "SHIPMENT_MANAGEMENT.GET_SHIPMENT_DLTS";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("PORC_SHIPMENTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                        {
                            dtResult = new DataTable("Shipments");
                            try
                            {
                                dataAdapter.Fill(dtResult);
                            }
                            catch (OracleException)
                            {
                                throw;
                            }
                        }
                    }
                }
                return dtResult;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable GetAllCuratorsUnderTeamLead()
        {

            try
            {
                DataTable dtCurators = new DataTable();
                dtCurators.Columns.Add("Curator_name", typeof(string));
                dtCurators.Columns.Add("Curator_ID", typeof(Int32));

                dtCurators.Rows.Add("Curator1", 1);
                dtCurators.Rows.Add("Curator2", 2);
                dtCurators.Rows.Add("Curator3", 3);
                dtCurators.Rows.Add("Curator4", 4);
                dtCurators.Rows.Add("Curator5", 5);
                dtCurators.Rows.Add("Curator6", 6);
                dtCurators.Rows.Add("Curator7", 7);
                return dtCurators;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable RolesUnderTeamLead()
        {
            try
            {
                DataTable dtRoles = new DataTable();
                dtRoles.Columns.Add("RoleName_name", typeof(string));
                dtRoles.Columns.Add("Role_ID", typeof(Int32));

                dtRoles.Rows.Add("Curator", 1);
                dtRoles.Rows.Add("Reviewer", 2);
                dtRoles.Rows.Add("Quality Check", 3);
                return dtRoles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable GetAllReviewersUnderTeamLead()
        {
            try
            {
                DataTable dtRoles = new DataTable();
                dtRoles.Columns.Add("Reviewer_name", typeof(string));
                dtRoles.Columns.Add("Reviewer_ID", typeof(Int32));

                dtRoles.Rows.Add("Reviewer 1", 1);
                dtRoles.Rows.Add("Reviewer 2", 2);
                dtRoles.Rows.Add("Reviewer 3", 3);
                return dtRoles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable GetAllQcUnderTeamLead()
        {
            try
            {
                DataTable dtQc = new DataTable();
                dtQc.Columns.Add("Qc_name", typeof(string));
                dtQc.Columns.Add("Qc_ID", typeof(Int32));

                dtQc.Rows.Add("Quality check 1", 1);
                dtQc.Rows.Add("Quality check 2", 2);
                dtQc.Rows.Add("Quality check 3", 3);
                return dtQc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public static DataTable GetAllUserRoles()
        //{
        //    DataTable dtUserRoles = null;
        //    try
        //    {
        //        using (OracleCommand oraCmd = new OracleCommand())
        //        {
        //            oraCmd.Connection = DataConnection.GetOracleConnection();
        //            oraCmd.CommandText = "GET_USER_ROLES";
        //            oraCmd.CommandType = CommandType.StoredProcedure;
        //            oraCmd.Parameters.Add("PORC_ROLES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //            DataSet dsResults = new DataSet();
        //            OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
        //            oraAdpt.Fill(dsResults);
        //            if (dsResults != null)
        //            {
        //                if (dsResults.Tables.Count > 0)
        //                {
        //                    if (dsResults.Tables[0] != null)
        //                    {
        //                        dtUserRoles = dsResults.Tables[0];
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return dtUserRoles;
        //}

        public static DataTable GetModuleHeads()
        {
            try
            {
                DataTable dtUserNames = new DataTable();
                dtUserNames.Columns.Add("ModuleHead_Name", typeof(string));
                dtUserNames.Columns.Add("ModuleHead_Id", typeof(Int32));

                dtUserNames.Rows.Add("MH Reaction Analysis", 1);
                dtUserNames.Rows.Add("MH Spectral Analysis", 2);
                return dtUserNames;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable GetTaskPrepateUserNames()
        {
            try
            {

                DataTable dt = new DataTable();

                dt.Columns.Add("TaskPreapareUserName", typeof(string));
                dt.Columns.Add("TaskPreapareUserId", typeof(int));
                dt.Rows.Add("user1", 001);
                dt.Rows.Add("user2", 002);
                dt.Rows.Add("user3", 003);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static DataTable GetAllTeamLeads()
        {
            try
            {
                DataTable dtTeamLeads = new DataTable();
                dtTeamLeads.Columns.Add("TeamLead_Name", typeof(string));
                dtTeamLeads.Columns.Add("TeamLead_Id", typeof(Int32));

                dtTeamLeads.Rows.Add("Team Lead 1", 1);
                dtTeamLeads.Rows.Add("Team Lead 2", 2);
                dtTeamLeads.Rows.Add("Team Lead 3", 3);

                return dtTeamLeads;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable GetNotAssignedDocsToDMBasedOnShipments()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("colUnAssignedDocName", typeof(string));
            dt.Columns.Add("colUnAssignedDocStatus", typeof(string));
            DataRow dr;
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc1";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc2";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc3";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc4";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc5";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            return dt;
        }

        public static DataTable GetNotAssignedDocsToTPBasedOnShipments()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("colUnAssignedDocName", typeof(string));
            dt.Columns.Add("colUnAssignedDocStatus", typeof(string));
            DataRow dr;
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc1";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc2";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc3";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc4";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc5";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            return dt;
        }

        public static DataTable GetNotAssignedDocsToMHBasedOnShipments()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("colUnAssignedDocName", typeof(string));
            dt.Columns.Add("colUnAssignedDocStatus", typeof(string));
            DataRow dr;
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc1";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc2";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc3";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc4";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc5";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            return dt;
        }

        public static DataTable GetNotAssignedDocsToTLBasedOnShipments()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("colUnAssignedDocName", typeof(string));
            dt.Columns.Add("colUnAssignedDocStatus", typeof(string));
            DataRow dr;
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc1";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc2";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc3";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc4";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc5";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            return dt;
        }

        public static DataTable GetNotAssignedDocsToCurRevQcBasedOnShipments()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("colUnAssignedDocName", typeof(string));
            dt.Columns.Add("colUnAssignedDocStatus", typeof(string));
            DataRow dr;
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc1";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc2";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc3";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc4";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc5";
            dr["colUnAssignedDocStatus"] = "Not Assigned";
            dt.Rows.Add(dr);
            return dt;
        }

        public static string GetUserMappingByCurator(int CuratorId)
        {
            // TODO: get mapping based on curatorId.
            return "Curator1 --> Reviewer1---> Qc 1";
        }

        public static DataTable GetAllUserRoles()
        {
            try
            {
                DataTable dtUserNames = new DataTable();
                dtUserNames.Columns.Add("ROLE_NAME", typeof(string));
                dtUserNames.Columns.Add("ROLE_ID", typeof(Int32));
                //dtUserNames.Rows.Add("Administrator", 1);
                dtUserNames.Rows.Add("Administrator", 1);
                dtUserNames.Rows.Add("Project Manager", 2);
                dtUserNames.Rows.Add("Delivery Manger", 3);
                dtUserNames.Rows.Add("Task Preparation", 4);
                dtUserNames.Rows.Add("Module Head", 5);
                dtUserNames.Rows.Add("Team Leader", 6);
                dtUserNames.Rows.Add("QC Analyst", 7);
                dtUserNames.Rows.Add("Review Analyst", 8);
                dtUserNames.Rows.Add("Analyst", 9);
                return dtUserNames;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable GetDocmentsToExportsBasedOnShipments()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("colUnAssignedDocName", typeof(string));
            dt.Columns.Add("colUnAssignedDocStatus", typeof(string));
            dt.Columns.Add("colDocXmlStatus", typeof(string));
            DataRow dr;
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc1";
            dr["colUnAssignedDocStatus"] = "Curation Completed";
            dr["colDocXmlStatus"] = "Not Generated";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc2";
            dr["colUnAssignedDocStatus"] = "Review completed";
            dr["colDocXmlStatus"] = "Not Generated";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc3";
            dr["colUnAssignedDocStatus"] = "Qc complted";
            dr["colDocXmlStatus"] = "Not Generated";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc4";
            dr["colUnAssignedDocStatus"] = "Qc complted";
            dr["colDocXmlStatus"] = "Not Generated";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["colUnAssignedDocName"] = "Doc5";
            dr["colUnAssignedDocStatus"] = "Qc complted";
            dr["colDocXmlStatus"] = "Not Generated";
            dt.Rows.Add(dr);
            return dt;
        }

        /// <summary>
        /// Gets all Modules.
        /// </summary>
        /// <returns>An instance of <c>DataTable</c>.</returns>
        public static DataTable GetAllModules()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MODULE_NAME", typeof(string));
            dt.Columns.Add("MODULE_VALUE", typeof(string));

            DataRow dr;
            dr = dt.NewRow();
            dr["MODULE_NAME"] = "Reaction Analysis";
            dr["MODULE_VALUE"] = "RA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["MODULE_NAME"] = "Spectral Analysis";
            dr["MODULE_VALUE"] = "SA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["MODULE_NAME"] = "Task Preparation";
            dr["MODULE_VALUE"] = "TP";
            dt.Rows.Add(dr);

            return dt;
        }

        public static bool SaveShipment(Shipment shipment, out string msg_out)
        {
            bool blStatus = false;
            string strMsg = "";
            try
            {
                using (OracleConnection conn = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "SHIPMENT_MANAGEMENT.SAVE_SHIPMENT";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("PIN_SHIPMENT_ID", OracleDbType.Int32, shipment.ShipmentID, ParameterDirection.Input);
                        command.Parameters.Add("PIN_SHIPMENT_NAME", OracleDbType.Varchar2, shipment.ShipmentName, ParameterDirection.Input);
                        command.Parameters.Add("PIC_DOC_TYPE", OracleDbType.Varchar2, shipment.Type, ParameterDirection.Input);
                        command.Parameters.Add("PIN_ABS_REF_COUNT", OracleDbType.Int32, shipment.AbstractRefsCount, ParameterDirection.Input);
                        command.Parameters.Add("PIN_SHIPMENT_YEAR", OracleDbType.Int32, shipment.ShipmentYear, ParameterDirection.Input);
                        command.Parameters.Add("PIN_ISSUE", OracleDbType.Int32, shipment.ShipmentIssue, ParameterDirection.Input);
                        command.Parameters.Add("PID_DOWNLOADED_DATE", OracleDbType.Date, shipment.DownloadDate.Date, ParameterDirection.Input);
                        command.Parameters.Add("PID_SCH_DELIVERY_DATE", OracleDbType.Date, shipment.ScheduleDeliveryDate.Date, ParameterDirection.Input);
                        command.Parameters.Add("PIC_DOWNLOADED_FILENAME", OracleDbType.Varchar2, shipment.DownloadFileName, ParameterDirection.Input);
                        command.Parameters.Add("PIC_TASK_PREPARATION_STATUS", OracleDbType.Varchar2, shipment.TaskPrepStatus, ParameterDirection.Input);
                        command.Parameters.Add("POC_STATUS", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.Output;

                        try
                        {
                            conn.OpenConnection();
                            command.ExecuteNonQuery();
                            if (command.Parameters["POC_STATUS"] != null)
                            {
                                msg_out = command.Parameters["POC_STATUS"].Value.ToString().ToUpper();
                                blStatus = true;
                            }
                            conn.Close();
                        }
                        catch (OracleException)
                        {
                            blStatus = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            msg_out = strMsg;
            return blStatus;
        }

        public static DataTable GetShipments()
        {
            DataTable dtResult = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "SHIPMENTS.GET_SHIPMENTS";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PORC_SHIPMENTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                    {
                        dtResult = new DataTable("Shipments");
                        try
                        {
                            dataAdapter.Fill(dtResult);
                        }
                        catch (OracleException)
                        {
                            throw;
                        }
                    }
                }
            }
            return dtResult;

        }

        public static bool SaveTaskPrepation(TaskPreparation objTaskPrep, string files)
        {
            string strTemp = null;
            bool blStatus = false;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oCmd = new OracleCommand())
                    {
                        oCmd.CommandText = "SHIPMENT_MANAGEMENT.SAVE_SHIPMENT_REFERENCE";
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Connection = oraCon;

                        oCmd.Parameters.Add("PIN_SHIPMENT_REF_ID", OracleDbType.Int32).Value = objTaskPrep.ShipmentRefID;
                        oCmd.Parameters.Add("PIC_ABSTRACT_REF_NO", OracleDbType.Varchar2).Value = objTaskPrep.AbstractRefNo;
                        oCmd.Parameters.Add("PIC_JOURNAL_NAME", OracleDbType.Varchar2).Value = objTaskPrep.JournalName;
                        oCmd.Parameters.Add("PIC_DOI", OracleDbType.Varchar2, 4000).Value = objTaskPrep.DOI;
                        oCmd.Parameters.Add("PIC_ZERO_RXN_STATUS", OracleDbType.Char, 1).Value = objTaskPrep.IsNoReaction ? 'Y' : 'N';

                        oCmd.Parameters.Add("PIC_FILE_NAME", OracleDbType.Varchar2).Value = objTaskPrep.AbstractRefNo;
                        oCmd.Parameters.Add("PIC_FILE_TYPE", OracleDbType.Varchar2).Value = objTaskPrep.FileType;
                        oCmd.Parameters.Add("PIC_REF_FILE_NAMES", OracleDbType.Varchar2).Value = files;
                        oCmd.Parameters.Add("PIC_SYS_NO", OracleDbType.Varchar2).Value = objTaskPrep.SysNo;
                        oCmd.Parameters.Add("PIC_SYS_TEXT", OracleDbType.Varchar2).Value = objTaskPrep.SysText;
                        oCmd.Parameters.Add("PIC_SYS_CLASS_TYPE", OracleDbType.Varchar2).Value = objTaskPrep.SysNoClassType;

                        OracleParameter paramStatus = new OracleParameter();
                        paramStatus.ParameterName = "POC_STATUS";
                        paramStatus.Direction = ParameterDirection.Output;
                        paramStatus.OracleDbType = OracleDbType.Varchar2;
                        paramStatus.Size = 200;
                        oCmd.Parameters.Add(paramStatus);

                        oCmd.Parameters.Add("PORC_SHIPMENT_REFS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;


                        oraCon.Open();
                        oCmd.ExecuteNonQuery();
                        oraCon.Close();

                        if (paramStatus.Value != null)
                        {
                            if (paramStatus.Value.ToString().Length > 0)
                            {
                                strTemp = Convert.ToString(oCmd.Parameters["POC_STATUS"].Value);
                                if (strTemp.ToUpper() == "UPDATE SUCCESS")
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
            catch (Exception)
            {
                throw;
            }
            return blStatus;
        }

        public static DataTable GetShipmentReportData_New(int shpId)
        {
            DataTable dtResults = null;

            try
            {
                using (OracleConnection con = ConnectionDB.GetOracleConnection())
                {
                    con.Open();

                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "REPORTS.SHIPMENT_SUMMARY_REPORT";
                        cmd.CommandType = CommandType.StoredProcedure;

                        OracleParameter p_Batch = new OracleParameter();
                        p_Batch.ParameterName = "PIN_SHIPMENT_ID";
                        p_Batch.OracleDbType = OracleDbType.Int32;
                        p_Batch.Value = shpId;
                        cmd.Parameters.Add(p_Batch);

                        OracleDataAdapter pgSqlDtAdpt = new OracleDataAdapter(cmd);
                        pgSqlDtAdpt.Fill(dtResults);
                    }
                }

            }
            catch (OracleException)
            {
                throw;
            }
            return null;
        }

        public static DataTable Get_MonthlyStatus_Report(DateTime _fromdate, DateTime _todate)
        {
            DataTable dtResults = null;
            OracleConnection con = null;
            try
            {
                con = ConnectionDB.GetOracleConnection();
                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "REPORTS.GET_MONTHLYSTATUS_REPORT";
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter p_FromDate = new OracleParameter();
                p_FromDate.ParameterName = "PID_FROM_DATE";
                p_FromDate.DbType = DbType.Date;
                p_FromDate.Value = _fromdate;
                cmd.Parameters.Add(p_FromDate);

                OracleParameter p_ToDate = new OracleParameter();
                p_ToDate.ParameterName = "PID_TO_DATE";
                p_ToDate.DbType = DbType.Date;
                p_ToDate.Value = _todate;
                cmd.Parameters.Add(p_ToDate);

                DataSet dsResult = new DataSet();

                OracleDataAdapter pgSqlDtAdpt = new OracleDataAdapter(cmd);
                pgSqlDtAdpt.Fill(dtResults);

                con.Close();
            }
            catch (OracleException)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return dtResults;
        }

        public static DataTable GetMonthlyStatusReport(DateTime fromDate, DateTime toDate,string module)
        {
            DataTable dtResults = null;           
            try
            {
                using (OracleConnection con = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = con;
                        oraCmd.CommandText = "REPORTS.MONTHLY_USER_REPORT";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //OracleParameter pStartDate = new OracleParameter();
                        //pStartDate.ParameterName = "PID_START_DATE";
                        //pStartDate.DbType = DbType.Date;
                        //pStartDate.Value = fromDate;
                        //oraCmd.Parameters.Add(pStartDate);

                        //OracleParameter pToDate = new OracleParameter();
                        //pToDate.ParameterName = "PID_END_DATE";
                        //pToDate.DbType = DbType.Date;
                        //pToDate.Value = toDate;
                        //oraCmd.Parameters.Add(pToDate);

                        oraCmd.Parameters.Add("PID_START_DATE", OracleDbType.Date).Value = fromDate;
                        oraCmd.Parameters.Add("PID_END_DATE", OracleDbType.Date).Value = toDate;
                        oraCmd.Parameters.Add("PIC_STATUS", OracleDbType.Varchar2).Value = module;
                        oraCmd.Parameters.Add("PORC_REPORT", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        dtResults = new DataTable();

                        OracleDataAdapter oraDp = new OracleDataAdapter(oraCmd);
                        oraDp.Fill(dtResults);
                    }
                }
            }
            catch (OracleException)
            {
                throw;
            }           
            return dtResults;
        }

        public static DataTable GetUserDateWiseSummaryReport(int shipmentId, DateTime fromDate, DateTime toDate)
        {
            DataTable dtResult = new DataTable();

            using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand oCmd = new OracleCommand())
                {
                    oCmd.CommandText = "REPORTS.USER_DATE_WISE_SUMMARY_REPORT";
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Connection = oraCon;

                    oCmd.Parameters.Add("PIN_SHIPMENT_ID", OracleDbType.Int32).Value = shipmentId;
                    oCmd.Parameters.Add("PID_FROM_DATE", OracleDbType.Date).Value = fromDate;
                    oCmd.Parameters.Add("PID_TO_DATE", OracleDbType.Date).Value = toDate;
                    oCmd.Parameters.Add("PORC_REPORT", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oCmd))
                    {
                        dtResult = new DataTable("shipmentdata");
                        try
                        {
                            dataAdapter.Fill(dtResult);
                        }
                        catch (OracleException)
                        {
                            throw;
                        }
                    }
                }
            }

            return dtResult;
        }

        public static DataTable GetUserHourlySummaryReport(int urId, DateTime reportDate)
        {
            DataTable hourlyReport = new DataTable();

            using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand oCmd = new OracleCommand())
                {
                    oCmd.CommandText = "REPORTS.USER_HOURLY_REPORT";
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Connection = oraCon;

                    oCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = urId;
                    oCmd.Parameters.Add("PID_REPORT_DATE", OracleDbType.Date).Value = reportDate;                   
                    oCmd.Parameters.Add("PORC_HOURLY_REPORT", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(oCmd))
                    {
                        hourlyReport = new DataTable();
                        try
                        {
                            dataAdapter.Fill(hourlyReport);
                        }
                        catch (OracleException)
                        {
                            throw;
                        }
                    }
                }
            }

            return hourlyReport;
        }

        public static DataTable GetAgentSolevtMasterDetails()
        {
            DataTable dtAgentSolventRef = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        dtAgentSolventRef = new DataTable();
                        
                        //string stTime = DateTime.Now.ToString();
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "REACTION_ANALYSIS.GET_SOLVENT_AGENT_DLTS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        oraCon.Open();

                        OracleDataReader oraRdr = oraCmd.ExecuteReader(CommandBehavior.CloseConnection);
                        dtAgentSolventRef.Load(oraRdr);
                      
                        //OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        //oraAdpt.Fill(dtAgentSolventRef);

                        //string endTime = DateTime.Now.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAgentSolventRef;
        }
    }
}
