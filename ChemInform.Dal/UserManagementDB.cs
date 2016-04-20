using System;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

using ChemInform.Bll;
using ChemInform.Bll.UsersManagment;

namespace ChemInform.Dal
{
    public class UserManagementDB
    {
        /// <summary>
        /// Inserts the new user or updates an existing user.
        /// </summary>
        /// <param name="user">An instance of user.</param>
        /// <returns>Unique userid</returns>
        public static int SaveUser(User user)
        {
            int userId = -1;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT.SAVE_USER";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    command.Parameters.Add("PIN_USER_ID", OracleDbType.Int32, user.ID, ParameterDirection.Input);
                    command.Parameters.Add("PIC_USER_NAME", OracleDbType.Varchar2, user.Name, ParameterDirection.Input);
                    command.Parameters.Add("PIC_EMAIL_ID", OracleDbType.Varchar2, user.EmailId, ParameterDirection.Input);
                    command.Parameters.Add("PIC_IS_ACTIVE", OracleDbType.Char, user.IsActive, ParameterDirection.Input);
                    try
                    {
                        conn.OpenConnection();
                        command.ExecuteNonQuery();
                        userId = command.GetInt32Value("Return_Value");
                        conn.Close();
                    }
                    catch (OracleException)
                    {
                        throw;
                    }
                }
            }
            return userId;
        }

        /// <summary>
        /// Inserts the new role for user or updates an existing role.
        /// </summary>
        /// <param name="userInfo">An instance of UserRole class.</param>
        /// <returns>Returns user role id if saves. Otherwise default value (-1).</returns>
        public static int SaveUserRole(UserRole userInfo)
        {
            int result = -1;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT.SAVE_USER_ROLE";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    command.Parameters.Add("PIN_UR_ID", OracleDbType.Int32, userInfo.UserRoleId, ParameterDirection.Input);
                    command.Parameters.Add("PIN_USER_ID", OracleDbType.Int32, userInfo.UserID, ParameterDirection.Input);
                    command.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32, userInfo.RoleId, ParameterDirection.Input);
                    command.Parameters.Add("PIC_APP_MODULE", OracleDbType.Varchar2, userInfo.ModuleName, ParameterDirection.Input);
                    command.Parameters.Add("PIC_STATUS", OracleDbType.Char, userInfo.IsActive, ParameterDirection.Input);
                    try
                    {
                        conn.OpenConnection();
                        command.ExecuteNonQuery();
                        result = command.GetInt32Value("Return_Value");
                        conn.Close();
                    }
                    catch (OracleException)
                    {
                        throw;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Gets all users from database.
        /// </summary>
        /// <returns>An instance of <c>DataTable</c>.</returns>
        public static DataTable GetAllUsers()
        {
            DataTable dtUserDetails = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT.GET_ALL_USERS";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PORC_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                    {
                        dtUserDetails = new DataTable("Users");
                        try
                        {
                            dataAdapter.Fill(dtUserDetails);
                        }
                        catch (OracleException)
                        {
                            throw;
                        }
                    }
                }
            }
            return dtUserDetails;
        }

        /// <summary>
        /// Gets all master roles.
        /// </summary>
        /// <returns>An instance of <c>DataTable</c>.</returns>
        public static DataTable GetAllMasterRoles()
        {
            DataTable dtRoles = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT.GET_ROLES";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PORC_ROLES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                    {
                        dtRoles = new DataTable("Roles");
                        try
                        {
                            dataAdapter.Fill(dtRoles);
                        }
                        catch (OracleException)
                        {
                            throw;
                        }
                    }
                }
            }
            return dtRoles;
        }
         /// <summary>
        /// Get all TeamLeads of perticuler Module.
        /// </summary>
        /// <param name="roleId">Role id of TeamLeader</param>
        /// <param name="ModuleName">Module Name</param>
        /// <returns>An Instance of <c>Datatable</c></returns>
        public static DataTable GetAllTeamLeadsByRoleID(int roleId, string ModuleName)
        {
            DataTable dtRoles = null;
            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USERS_TEAM_MANAGEMENT.GET_MANAGERS_BY_ROLE";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = roleId;
                    command.Parameters.Add("PIC_MODULE_NAME", OracleDbType.Varchar2).Value = ModuleName;
                    command.Parameters.Add("PORC_MANAGERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter oraAdpt = new OracleDataAdapter(command))
                    {
                        dtRoles = new DataTable();
                        try
                        {
                            oraAdpt.Fill(dtRoles);
                        }
                        catch (OracleException)
                        {

                            throw;
                        }
                    }
                }
            }
            return dtRoles;
        }

        /// <summary>
        /// Get Incharge details.
        /// </summary>
        /// <param name="roleId">RoleId of user.</param>
        /// <param name="teamLeadUrId">Team Lead Ur Id</param>
        /// <param name="ModuleName">Module Name</param>
        /// <returns>An instance of <c>DataTable</c>.</returns>
        public static DataTable GetInchargeDetails(int roleId, int teamLeadUrId, string ModuleName)
        {
            DataTable dtInchargeDetails = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USERS_TEAM_MANAGEMENT.GET_INCHARGE_NAMES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = roleId;
                    command.Parameters.Add("PIN_TEAM_LEAD_UR_ID", OracleDbType.Int32).Value = teamLeadUrId == 0 ? Convert.DBNull : teamLeadUrId;
                    command.Parameters.Add("PIC_MODULE_NAME", OracleDbType.Varchar2).Value = ModuleName;
                    command.Parameters.Add("PORC_INCHARGE_NAMES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter oraAdpt = new OracleDataAdapter(command);
                    dtInchargeDetails = new DataTable();
                    try
                    {
                        oraAdpt.Fill(dtInchargeDetails);
                    }
                    catch (OracleException)
                    {
                        throw;
                    }
                }
            }

            return dtInchargeDetails;
        }

        /// <summary>
        /// Get User role Details.
        /// </summary>
        /// <returns>An instance of <c>DataTable</c>.</returns>
        public static DataTable GetUserRoleDetails()
        {
            DataTable dtUserDetails = null;
            try
            {
                using (OracleConnection conn = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "USER_MANAGEMENT.GET_ASSIGNED_USERS_WITH_ROLES";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("PORC_USER_ROLES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        using (OracleDataAdapter oraAdpt = new OracleDataAdapter(command))
                        {
                            dtUserDetails = new DataTable();
                            try
                            {
                                oraAdpt.Fill(dtUserDetails);
                            }
                            catch (OracleException)
                            {
                                throw;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return dtUserDetails;
        }

        /// <summary>
        ///  Get all users in Team(QC.Analyst/Rev.Analyst/Analyst) by Team Leader Id.
        /// </summary>
        /// <param name="shimentId">Selected shipment id by TL</param>
        /// <param name="teamLeaderId">Team Leader UR_Id</param>
        /// <returns></returns>
        public static DataTable GetAllUsersInTeamByTeamLeaderUserRoleId(int teamLeaderUserRoleId)
        {
            DataTable dtAllUsersInTeam = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        //Initialization & settings
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "USERS_TEAM_MANAGEMENT.GET_TEAM_LEADER_CURATION_TEAM";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //Parameters                        
                        oraCmd.Parameters.Add("PIN_TL_UR_ID", OracleDbType.Int32).Value = teamLeaderUserRoleId;
                        oraCmd.Parameters.Add("PORC_CURATION_TEAM", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        // Filling data to out parameter ref-cursor to data table.
                        dtAllUsersInTeam = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtAllUsersInTeam);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAllUsersInTeam;
        }

        /// <summary>
        /// Get user details by user name and role id.
        /// </summary>
        /// <param name="userName">string: user name</param>
        /// <param name="roleId">int: role id</param>
        /// <returns>Data Table - All details including</returns>
        public static DataTable GetUserDetailsByUserNameAndRoleId(string userName, int roleId)
        {
            DataTable dtUserDetails = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        //Initialization & settings
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "USERS_TEAM_MANAGEMENT.GET_USER_DETAILS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //Parameters                        
                        oraCmd.Parameters.Add("PIC_USER_NAME", OracleDbType.Varchar2).Value = userName;
                        oraCmd.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = roleId;
                        oraCmd.Parameters.Add("PORC_USER_DETAILS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        // Filling data to out parameter ref-cursor to data table.
                        dtUserDetails = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtUserDetails);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtUserDetails;
        }

        public static bool InActivateUserRole(int selUserRoleID, out string statusMsg)
        {
            bool blStatus = false;
            string strTemp = string.Empty;

            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "USERS_TEAM_MANAGEMENT.INACTIVATE_USER_ROLE";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //PIN_UR_ID
                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = selUserRoleID;

                        OracleParameter paStatus = new OracleParameter();
                        paStatus.Direction = ParameterDirection.Output;
                        paStatus.OracleDbType = OracleDbType.Varchar2;
                        paStatus.Size = 200;
                        oraCmd.Parameters.Add(paStatus);


                        oraCon.Open();
                        oraCmd.ExecuteNonQuery();
                        blStatus = true;
                        oraCon.Close();

                        if (paStatus.Value != null)
                        {
                            if (paStatus.Value.ToString().Length > 0)
                            {
                                strTemp = paStatus.Value.ToString();
                            }
                            else
                            {
                                strTemp = paStatus.Value.ToString();
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            statusMsg = strTemp;
            return blStatus;
        }

        /// <summary>
        /// Inserts the new Team mapping or updates an existing Team mapping.
        /// </summary>
        /// <param name="objTeamUser">Instance of TeamUsers</param>
        /// <returns>Unique mapping Id.</returns>
        public static int SaveUserMapping(TeamUsers objTeamUser)
        {
            int MappingId = -1;
            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT.SAVE_TEAM_USER";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    command.Parameters.Add("PIN_TEAM_USER_ID", OracleDbType.Int32, objTeamUser.TeamUserId, ParameterDirection.Input);
                    command.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2, objTeamUser.Module, ParameterDirection.Input);
                    command.Parameters.Add("PIN_PRJ_MGR_UR_ID", OracleDbType.Int32, objTeamUser.PrjMgrUrId, ParameterDirection.Input);
                    command.Parameters.Add("PIN_DELY_MGR_UR_ID", OracleDbType.Int32, objTeamUser.DelyMgrUrId, ParameterDirection.Input);
                    command.Parameters.Add("PIN_MOD_HEAD_UR_ID", OracleDbType.Int32, objTeamUser.QualAnlstUrId, ParameterDirection.Input);
                    command.Parameters.Add("PIN_TEAM_LDR_UR_ID", OracleDbType.Int32, objTeamUser.TeamLdrUrId, ParameterDirection.Input);
                    command.Parameters.Add("PIN_QUAL_ANLST_UR_ID", OracleDbType.Char, objTeamUser.QualAnlstUrId, ParameterDirection.Input);
                    command.Parameters.Add("PIN_REV_ANLST_UR_ID", OracleDbType.Char, objTeamUser.RevAnlstUrId, ParameterDirection.Input);
                    command.Parameters.Add("PIN_ANLST_UR_ID", OracleDbType.Char, objTeamUser.AnlstUrId, ParameterDirection.Input);
                    command.Parameters.Add("PIN_TSK_PREP_UR_ID", OracleDbType.Char, objTeamUser.TaskPrepUrId, ParameterDirection.Input);
                    command.Parameters.Add("PIC_IS_ACTIVE", OracleDbType.Char, objTeamUser.IsActive, ParameterDirection.Input);
                    command.Parameters.Add("PIN_CREATED_BY", OracleDbType.Char, objTeamUser.CreatedBy, ParameterDirection.Input);

                    try
                    {
                        conn.OpenConnection();
                        command.ExecuteNonQuery();
                        MappingId = command.Parameters["Return_Value"].Value != null ? Convert.ToInt32(command.Parameters["Return_Value"].Value.ToString()) : -1; //Convert.ToInt32(oCmd.Parameters["Return_Value"].Value.ToString());
                        conn.Close();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return MappingId;
        }

        /// <summary>
        /// Get All Teamuser mappings from Database.
        /// </summary>
        /// <returns>An Instance of <c>Datatable</c></returns>
        public static DataTable GetTeamUserDetails()
        {
            DataTable dtResult = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT.GET_ALL_TEAM_USERS";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PORC_TEAM_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                    {
                        dtResult = new DataTable("TeamMappings");
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
        /// Check for valid user.
        /// </summary>
        /// <param name="userName">userName.</param>
        /// <param name="roleId">role Id.</param>
        /// <param name="ModuleName">Module Name.</param>
        /// <param name="userID">Reflects UserId If perticular user is Active, else -1.</param>
        /// <param name="urID">Reflects UrId If perticular role is Active, else -1.</param>
        /// <returns>Returns true if role is active, otherwise false.</returns>
        public static bool CheckForValidUser(string userName, int roleId, string ModuleName, out int userID, out int urID)
        {
            bool blStatus = false;
            userID = -1;
            urID = -1;
            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "USER_MANAGEMENT.CHECK_FOR_VALID_USER";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("PIC_USER_NAME", OracleDbType.Varchar2).Value = userName;
                    command.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = roleId;
                    command.Parameters.Add("PIC_MODULE_NAME", OracleDbType.Varchar2).Value = ModuleName;
                    command.Parameters.Add("PON_USER_ID", OracleDbType.Int32, userID, ParameterDirection.Output);
                    command.Parameters.Add("PON_UR_ID", OracleDbType.Int32, userID, ParameterDirection.Output);


                    conn.Open();
                    command.ExecuteScalar();
                    userID = command.GetInt32Value("PON_USER_ID");
                    urID = command.GetInt32Value("PON_UR_ID");
                    if (userID != -1 && urID != -1)
                    {
                        blStatus = true;
                    }
                }
            }
            return blStatus;
        }

        /// <summary>
        /// Get user details on roleId.
        /// </summary>
        /// <param name="roleId">Role Id</param>
        /// <returns>An Instance of datatable.</returns>
        public static DataTable GetUserDetailsOnRoleId(int roleId)
        {
            DataTable dtResult = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT.GET_USER_BY_ROLE_ID";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32, roleId, ParameterDirection.Input);
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
            return dtResult;
        }

        /// <summary>
        /// Get user details based on RoleId,Module Name
        /// </summary>
        /// <param name="roleId">Role Id</param>
        /// <param name="module">Module Name</param>
        /// <returns>An Instance of datatable.</returns>
        public static DataTable GetUserDetailsOnRoleId(int roleId, string module)
        {
            DataTable dtResult = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT.GET_USERS_BY_ROLE_ID_MODULE";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32, roleId, ParameterDirection.Input);
                    command.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2, module, ParameterDirection.Input);
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
            return dtResult;
        }

        /// <summary>
        /// Get user names and userroles to Bind comboboxes value member as userRole Id.
        /// </summary>
        /// <param name="roleId">Role Id.</param>
        /// <param name="module">Module.</param>
        /// <returns></returns>
        public static DataTable GetUserNamesAndUserRoleIds(int roleId, string userName, string module = null)
        {
            DataTable dtResult = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT_NEW.GET_USER_DETAILS";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2, module, ParameterDirection.Input);
                    command.Parameters.Add("PIC_USER_NAME", OracleDbType.Varchar2, userName, ParameterDirection.Input);
                    command.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32, roleId, ParameterDirection.Input);

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
            return dtResult;
        }


    }
}
