using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChemInform.Bll;
using Oracle.DataAccess.Client;
using System.Data;

namespace ChemInform.Dal
{
    public class TaskManagementDB
    {
        /// <summary>
        /// Task Assignment to Task Preparation Team By Delivery Manager.
        /// </summary>
        /// <param name="shipMentId">Shipment Id.</param>
        /// <param name="taskPrepUrId">Task Preparation Ur Id.</param>
        /// <param name="deliveryMgrUrId">Delivery Manager Ur Id.</param>
        public static void TAtoTaskPrep(int shipMentId, int taskPrepUrId, int deliveryMgrUrId)
        {
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCon.Open();
                        oraCmd.CommandText = "TASK_MANAGEMENT.TSK_PREP_TASK_ALLOCATION";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPIMENT_ID", OracleDbType.Int32).Value = shipMentId;
                        oraCmd.Parameters.Add("PIN_DELIVERY_MGR_ID", OracleDbType.Int32).Value = deliveryMgrUrId;
                        oraCmd.Parameters.Add("PIN_TEAM_USER_ID", OracleDbType.Int32).Value = null; //TODO: crear doubt.
                        oraCmd.Parameters.Add("PIN_TP_UR_ID", OracleDbType.Int32).Value = taskPrepUrId;


                        oraCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get DM Task status about assigned Task Preparation Status.
        /// </summary>
        /// <param name="deliveryMgrId">Delivery Manager ur Id.</param>
        /// <returns>An Instance Of Datatable.</returns>
        public static DataTable GetDMAssignedTaskPreP(int deliveryMgrId)
        {
            DataTable dtResult = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "TASK_MANAGEMENT.GET_ALLOCATION_DETAILS";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PIN_DELIVERY_MGR_ID", OracleDbType.Int32).Value = deliveryMgrId;
                    command.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                    {
                        dtResult = new DataTable("AllowcationDetails");
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

        /// <summary>
        /// Get Assigned Shipments for Task Preparation User.
        /// </summary>
        /// <param name="taskPrepUrId">Task Preparation user's Ur Id.</param>
        /// <returns>Data Table</returns>
        public static DataTable GetTPassignedShipments(int taskPrepUrId)
        {
            DataTable dtResult = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "TASK_MANAGEMENT.GET_USER_TASK";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = taskPrepUrId;
                    command.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                    {
                        dtResult = new DataTable("AllowcationDetails");
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

        /// <summary>
        /// Update Task status for all roles.
        /// </summary>
        /// <param name="taskStatus">An Instance of TaskStatus.</param>
        /// <returns>True if update succesful, else false.</returns>
        public static bool UpdateTaskStatus(TaskStatus taskStatus)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection conn = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = conn.CreateCommand())
                    {
                        oraCmd.CommandText = "TASK_MANAGEMENT.UPDATE_TASK_STATUS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIN_TASK_ID", OracleDbType.Int32).Value = taskStatus.Task_ID;
                        oraCmd.Parameters.Add("PIN_TASK_ALLOC_ID", OracleDbType.Int32).Value = taskStatus.TaskAllocation_ID;
                        oraCmd.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = taskStatus.Role_ID;
                        oraCmd.Parameters.Add("PIC_STATUS", OracleDbType.Varchar2).Value = taskStatus.TaskStatusName;
                        oraCmd.Parameters.Add("PIC_REMARKS", OracleDbType.Varchar2).Value = taskStatus.TaskComments;

                        conn.OpenConnection();
                        oraCmd.ExecuteNonQuery();
                    }
                    blStatus = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blStatus;
        }

        public static DataTable GetUnAssignedRefrencesOnShipment(string module, int shipmentID)
        {
            DataTable dtAbsRefs = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "TASK_MANAGEMENT.GET_UNASSIGNED_REFS";
                    oraCmd.CommandType = CommandType.StoredProcedure;                   
                    oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = module;
                    oraCmd.Parameters.Add("PIN_SHIPMENT_ID", OracleDbType.Int32).Value = shipmentID;
                    oraCmd.Parameters.Add("PORC_REFS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    dtAbsRefs = new DataTable();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dtAbsRefs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAbsRefs;
        }

        public static DataTable GetUserTaskCountsOnModule(string module, out DataTable moduleUsers)
        {
            DataTable dtUsrTaskCounts = null;
            DataTable dtModuleUsers = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "TASK_MANAGEMENT.GET_USER_TASK_CNTS";
                    oraCmd.CommandType = CommandType.StoredProcedure;                  
                    oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = module;
                    oraCmd.Parameters.Add("PORC_MODULE_USER", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    oraCmd.Parameters.Add("PORC_USER_TASK_CNTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    dtUsrTaskCounts = new DataTable();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    DataSet dsResults = new DataSet();
                    oraAdpt.Fill(dsResults);
                    if (dsResults != null)
                    {
                        if (dsResults.Tables.Count == 2)
                        {
                            dtModuleUsers = dsResults.Tables[0];
                            dtUsrTaskCounts = dsResults.Tables[1];                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            moduleUsers = dtModuleUsers;
            return dtUsrTaskCounts;
        }

        public static DataTable GetAssignedRefrencesOnShipment(string module, int shipmentID)
        {
            DataTable dtAssignedRefs = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "TASK_MANAGEMENT.GET_SHIPMENT_REF_DETAILS";
                    oraCmd.CommandType = CommandType.StoredProcedure;                 
                    oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = module;
                    oraCmd.Parameters.Add("PIN_SHIPMENT_ID", OracleDbType.Int32).Value = shipmentID;
                    oraCmd.Parameters.Add("PORC_REFS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    dtAssignedRefs = new DataTable();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dtAssignedRefs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAssignedRefs;
        }

        public static bool UpdateTaskAssignmentDetails(string module, int shipmentID, long teamUserID, List<Int32> absRefIDs)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.CommandText = "TASK_MANAGEMENT.TASK_ALLOC_TO_CURATION";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Connection = dbCon;
                                               
                        oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = module;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_ID", OracleDbType.Int32).Value = shipmentID;
                        oraCmd.Parameters.Add("PIN_TEAM_USER_ID", OracleDbType.Int32).Value = teamUserID;

                        OracleParameter paRefIDs = new OracleParameter();
                        paRefIDs.ParameterName = "PINA_SHPMT_REF_IDS";
                        paRefIDs.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        paRefIDs.OracleDbType = OracleDbType.Int64;
                        if (absRefIDs.Count > 0)
                        {
                            paRefIDs.Value = absRefIDs.ToArray();
                        }
                        else
                        {
                            paRefIDs.Value = new Int32[1] { 0 };
                            paRefIDs.Size = 0;
                        }
                        oraCmd.Parameters.Add(paRefIDs);

                        dbCon.Open();
                        oraCmd.ExecuteNonQuery();
                        dbCon.Close();
                        blStatus = true;
                    }
                }
            }

            catch (Exception ex)
            {
                blStatus = false;
            }
            return blStatus;
        }

        public static DataTable GetUsersByModule(string module)
        {
            DataTable dtUsers = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "USER_MANAGEMENT.GET_APP_MODULE_USERS";
                    oraCmd.CommandType = CommandType.StoredProcedure;                   
                    oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = module;
                    oraCmd.Parameters.Add("PORC_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    dtUsers = new DataTable();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dtUsers);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtUsers;
        }

        public static DataTable GetUserTasksOnModule(int userRoleId, string module)
        {
            DataTable dtUserTasks = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "TASK_MANAGEMENT.GET_USER_TASKS";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                                       
                    oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = module;
                    oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = userRoleId;
                    oraCmd.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    dtUserTasks = new DataTable();
                    using (OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd))
                    {
                        oraAdpt.Fill(dtUserTasks);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtUserTasks;
        }

        public static bool UpdateUserTaskStatus(TaskStatus taskStatus)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.CommandText = "TASK_MANAGEMENT.UPDATE_TASK_STATUS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Connection = dbCon;

                        oraCmd.Parameters.Add("PIN_TASK_ID", OracleDbType.Int32).Value = taskStatus.Task_ID;
                        oraCmd.Parameters.Add("PIN_TASK_ALLOC_ID", OracleDbType.Int32).Value = taskStatus.TaskAllocation_ID;
                        //oraCmd.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = taskStatus.Role_ID;
                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = taskStatus.UR_ID;
                        oraCmd.Parameters.Add("PIC_STATUS", OracleDbType.Varchar2).Value = taskStatus.TaskStatusName;
                        oraCmd.Parameters.Add("PIC_REMARKS", OracleDbType.Varchar2).Value = taskStatus.TaskComments;

                        dbCon.Open();
                        oraCmd.ExecuteNonQuery();
                        dbCon.Close();
                        blStatus = true;
                    }
                }
            }
            catch (Exception ex)
            {
                blStatus = false;
            }
            return blStatus;
        }

        public static DataTable GetTaskPreparationRefsOnShipment(int shipmentID)
        {
            DataTable dtShipmentRefs = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "TASK_MANAGEMENT.GET_SHIPMENT_REFERENCES";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_SHIPMENT_ID", OracleDbType.Int32, 30).Value = shipmentID;
                        oraCmd.Parameters.Add("PORC_SHIPMENT_REFS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        dtShipmentRefs = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtShipmentRefs);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtShipmentRefs;
        }

        #region Task Modification and Task Cancellation Methods

        public static DataTable GetUserAssignedTasks(int userRoleId)
        {
            DataTable dtUserTasks = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "TASK_MANAGEMENT.MT_GET_USER_TASKS";
                    oraCmd.CommandType = CommandType.StoredProcedure;

                    oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = userRoleId;
                    oraCmd.Parameters.Add("PORC_USER_TASKS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    dtUserTasks = new DataTable();
                    using (OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd))
                    {
                        oraAdpt.Fill(dtUserTasks);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtUserTasks;
        }

        public static DataTable GetUsersTaskCountsOnRole(string module, int RoleId)
        {
            DataTable dtResult = null;
            try
            {
                using (OracleConnection conn = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "TASK_MANAGEMENT.MT_GET_USER_DETAILS";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2, module, ParameterDirection.Input);
                        command.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32, RoleId, ParameterDirection.Input);
                        command.Parameters.Add("PORC_USER_DETAILS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                        {
                            dtResult = new DataTable("UserDetails");
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
            }
            catch (Exception)
            {                
                throw;
            }
            return dtResult;
        }

        public static bool ModifyTaskAssignment(List<Int32> taskAllocIDs, int userRoleID, int toolMgrURID)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.CommandText = "TASK_MANAGEMENT.MT_REASSIGN_REFS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Connection = dbCon;

                        OracleParameter paAllocID = new OracleParameter();
                        paAllocID.ParameterName = "PIAN_TASK_ALLOC_IDS";
                        paAllocID.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        paAllocID.OracleDbType = OracleDbType.Int64;
                        if (taskAllocIDs.Count > 0)
                        {
                            paAllocID.Value = taskAllocIDs.ToArray();
                        }
                        else
                        {
                            paAllocID.Value = new Int32[1] { 0 };
                            paAllocID.Size = 0;
                        }
                        oraCmd.Parameters.Add(paAllocID);

                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = userRoleID;
                        oraCmd.Parameters.Add("PIN_PM_UR_ID", OracleDbType.Int32).Value = toolMgrURID;
                        oraCmd.Parameters.Add("POC_STATUS", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.Output;   

                        dbCon.Open();
                        oraCmd.ExecuteNonQuery();
                        dbCon.Close();

                        //if (oraCmd.Parameters["POC_STATUS"].Value != null)
                        //{
                        //    if (oraCmd.Parameters["POC_STATUS"].Value.ToString() == "SUCCESS")
                         //   {
                                blStatus = true;
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                blStatus = false;
            }
            return blStatus;
        }

        public static bool CancelTaskAssignment(List<Int32> taskIDs)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.CommandText = "TASK_MANAGEMENT.MT_CANCEL_TASKS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Connection = dbCon;

                        OracleParameter paTaskID = new OracleParameter();
                        paTaskID.ParameterName = "PIAN_TASK_IDS";
                        paTaskID.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        paTaskID.OracleDbType = OracleDbType.Int64;
                        if (taskIDs.Count > 0)
                        {
                            paTaskID.Value = taskIDs.ToArray();
                        }
                        else
                        {
                            paTaskID.Value = new Int32[1] { 0 };
                            paTaskID.Size = 0;
                        }
                        oraCmd.Parameters.Add(paTaskID);

                        oraCmd.Parameters.Add("POC_STATUS", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.Output;

                        dbCon.Open();
                        oraCmd.ExecuteNonQuery();
                        dbCon.Close();

                        if (oraCmd.Parameters["POC_STATUS"].Value != null)
                        {
                            if (oraCmd.Parameters["POC_STATUS"].Value.ToString() == "SUCCESS")
                            {
                                blStatus = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                blStatus = false;
            }
            return blStatus;
        }

        #endregion
    }
}
