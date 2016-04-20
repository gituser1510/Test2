#region Name Spaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using ChemInform.Bll;
#endregion

namespace ChemInform.Dal
{
    /// <summary>
    /// Class UserMasterDAL - All dml and Retrival opeartions.
    /// </summary>
    public class UserMasterDAL
    {       
        /// <summary>
        /// Create Users
        /// </summary>
        /// <param name="userMaster">Object: class reference object of User</param>
        /// <returns>string : status message</returns>
        public static string CreateUser(User userMaster)
        {
            string strUserStatus = "";
            try
            {                
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oCmd = new OracleCommand())
                    {
                        OracleParameter[] oPrms = new OracleParameter[8];

                        oPrms[0] = new OracleParameter("PIN_USER_ID", OracleDbType.Int32, userMaster.ID, ParameterDirection.Input);
                        oPrms[1] = new OracleParameter("PIC_USER_NAME", OracleDbType.Varchar2, 100, userMaster.Name, ParameterDirection.Input);
                        oPrms[2] = new OracleParameter("PIC_EMAIL_ID", OracleDbType.Varchar2, 100, userMaster.EmailId, ParameterDirection.Input);
                        oPrms[3] = new OracleParameter("PIC_PASSWORD", OracleDbType.Varchar2, 100, userMaster.Password, ParameterDirection.Input);
                        oPrms[4] = new OracleParameter("PIC_IS_ACTIVE", OracleDbType.Varchar2, 1, userMaster.Status, ParameterDirection.Input);
                        oPrms[5] = new OracleParameter("PIC_OP_TYPE", OracleDbType.Varchar2, 10, userMaster.OptionType, ParameterDirection.Input);
                        oPrms[6] = new OracleParameter("PIC_IS_LDAP_USER", OracleDbType.Char, 1, userMaster.IsLDAPUser, ParameterDirection.Input);
                        oPrms[7] = new OracleParameter("POC_STATUS", OracleDbType.Varchar2, 100, null, ParameterDirection.Output);

                        oCmd.CommandText = "USER_MANAGEMENT_NEW.SAVE_USER";
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Connection = dbCon;
                        oCmd.Parameters.AddRange(oPrms);

                        dbCon.Open();
                        oCmd.ExecuteNonQuery();
                        strUserStatus = oPrms[7].Value != null ? oPrms[7].Value.ToString() : "";
                        dbCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strUserStatus;
        }

        /// <summary>
        /// Create Profile
        /// </summary>
        /// <param name="userRole">Object: class reference object of UserProfileBLL</param>
        /// <returns>string : status message</returns>
        public static string CreateProfile(UserProfileBLL userRole)
        {
            string strUserStatus = "";
            try
            {
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oCmd = new OracleCommand())
                    {
                        oCmd.CommandText = "USER_MANAGEMENT_NEW.SAVE_USER_ROLE";
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Connection = dbCon;

                        oCmd.Parameters.Add("PIN_USER_ID", OracleDbType.Int32, 10, userRole.UserId, ParameterDirection.Input);
                        oCmd.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32, 10, userRole.RoleId, ParameterDirection.Input);
                        oCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2, 3, userRole.ModuleName, ParameterDirection.Input);
                        OracleParameter paStatus = new OracleParameter();
                        paStatus.Direction = ParameterDirection.Output;
                        paStatus.OracleDbType = OracleDbType.Varchar2;
                        paStatus.Size = 200;
                        oCmd.Parameters.Add(paStatus);
                        dbCon.Open();
                        oCmd.ExecuteNonQuery();

                        if (paStatus.Value != null)
                        {
                            if (paStatus.Value.ToString().Length > 0)
                            {
                                strUserStatus = paStatus.Value.ToString();
                            }
                            else
                            {
                                strUserStatus = paStatus.Value.ToString();
                            }
                        }
                        dbCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strUserStatus;
        }

        /// <summary>
        /// Get all Users
        /// </summary>
        /// <returns>Data Table: - Get all users details</returns>
        public static DataTable GetUserDetails()
        {
            DataTable dtUserDetails = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "USER_MANAGEMENT_NEW.GET_USERS";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PORC_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    DataSet dsResults = new DataSet();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dsResults);
                    if (dsResults != null)
                    {
                        if (dsResults.Tables.Count > 0)
                        {
                            if (dsResults.Tables[0] != null)
                            {
                                dtUserDetails = dsResults.Tables[0];
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
        /// Get all Active Users
        /// </summary>
        /// <returns>Data Table: - Get all users details</returns>
        public static DataTable GetActiveUserDetails()
        {
            DataTable dtUserDetails = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "USER_MANAGEMENT_NEW.GET_ACTIVE_USERS";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PORC_USERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    DataSet dsResults = new DataSet();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dsResults);
                    if (dsResults != null)
                    {
                        if (dsResults.Tables.Count > 0)
                        {
                            if (dsResults.Tables[0] != null)
                            {
                                dtUserDetails = dsResults.Tables[0];
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
        /// Get all roles
        /// </summary>
        /// <returns>Data Table: - Get all roles</returns>
        public static DataTable GetRoles()
        {
            DataTable dtRoles = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "USER_MANAGEMENT_NEW.GET_ROLES";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PORC_ROLES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    DataSet dsResults = new DataSet();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dsResults);

                    if (dsResults != null)
                    {
                        if (dsResults.Tables.Count > 0)
                        {
                            if (dsResults.Tables[0] != null)
                            {
                                dtRoles = dsResults.Tables[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtRoles;
        }

        /// <summary>
        /// Get Team Lead Details by Role
        /// </summary>
        /// <param name="roleId">int: role Id</param>
        /// <returns>Data Table: - Get Team Lead Details</returns>
        public static DataTable GetTeamLeadDetails(int roleId)
        {
            DataTable dtRoles = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "USERS_TEAM_MANAGEMENT.GET_MANAGERS_BY_ROLE";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = roleId;
                    oraCmd.Parameters.Add("PORC_MANAGERS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    DataSet dsResults = new DataSet();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dsResults);

                    if (dsResults != null)
                    {
                        if (dsResults.Tables.Count > 0)
                        {
                            if (dsResults.Tables[0] != null)
                            {
                                dtRoles = dsResults.Tables[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtRoles;
        }
        /// <summary>
        /// Get Incharge Details by Role and TL
        /// </summary>
        /// <param name="roleId">int: current user role Id</param>
        /// <param name="teamLeadUrId">int: TL user id</param>
        /// <returns>Data Table: - Get Incharge Details by Role and TL</returns>
        public static DataTable GetInchargeDetails(int roleId, int teamLeadUrId)
        {
            DataTable dtInchargeDetails = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "USERS_TEAM_MANAGEMENT.GET_INCHARGE_NAMES";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = roleId;
                        oraCmd.Parameters.Add("PIN_TEAM_LEAD_UR_ID", OracleDbType.Int32).Value = teamLeadUrId == 0 ? Convert.DBNull : teamLeadUrId;
                        oraCmd.Parameters.Add("PORC_INCHARGE_NAMES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        DataSet dsResults = new DataSet();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dsResults);

                        if (dsResults != null)
                        {
                            if (dsResults.Tables.Count > 0)
                            {
                                if (dsResults.Tables[0] != null)
                                {
                                    dtInchargeDetails = dsResults.Tables[0];
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtInchargeDetails;
        }

        /// <summary>
        /// Get all user profile details
        /// </summary>
        /// <returns>Data Table: - Get all user profile details</returns>
        public static DataTable GetUserProfileDetails()
        {
            DataTable dtUserDetails = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "USER_MANAGEMENT_NEW.GET_ACTIVE_USER_ROLES";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PORC_USER_ROLE_DETAILS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    DataSet dsResults = new DataSet();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dsResults);
                    if (dsResults != null)
                    {
                        if (dsResults.Tables.Count > 0)
                        {
                            if (dsResults.Tables[0] != null)
                            {
                                dtUserDetails = dsResults.Tables[0];
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

        //GET_TEAM_LEADER_CURATION_TEAM

        /// <summary>
        ///  Get all users in Team(QC.Analyst/Rev.Analyst/Analyst) by Team Leader Id.
        /// </summary>
        /// <param name="teamLeaderUserRoleId">int: Team Leader UR_Id</param>
        /// <returns>Data Table - Get All Users In Team By TeamLeader UserRole Id</returns>
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
        public static DataTable GetUserDetailsByUserNameAndRoleId(string userName, int roleId, string module)
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
                        oraCmd.CommandText = "USER_MANAGEMENT_NEW.GET_USER_DETAILS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //Parameters                        
                        oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = module;
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
               
        public static bool InActivateUserRole(int userRoleID, out string statusMsg)
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
                        oraCmd.CommandText = "USER_MANAGEMENT_NEW.INACTIVATE_USER_ROLE";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //PIN_UR_ID
                        oraCmd.Parameters.Add("PIN_UR_ID", OracleDbType.Int32).Value = userRoleID;

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

        public static bool InActivateTeamUser(int userRoleID, out string statusMsg)
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
                        oraCmd.CommandText = "USER_MANAGEMENT_NEW.INACTIVATE_TEAM_USERS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //PIN_UR_ID
                        oraCmd.Parameters.Add("PIN_TEAM_USER_ID", OracleDbType.Int32).Value = userRoleID;

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

        public static DataTable GetUserDetailsByApplicationAndRoleID(string strModuleName, int role_ID)
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
                        oraCmd.CommandText = "USER_MANAGEMENT_NEW.GET_USERNAMES_BY_APP_MOD";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = strModuleName;
                        oraCmd.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = role_ID;
                        oraCmd.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

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

        public static string CreateTeamStructure(UserProfileBLL userProfile)
        {
            string strUserStatus = "";
            try
            {
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oCmd = new OracleCommand())
                    {
                        oCmd.CommandText = "USER_MANAGEMENT_NEW.DML_TEAM_USERS";
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Connection = dbCon;

                        oCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2, 3, userProfile.ModuleName, ParameterDirection.Input);
                        oCmd.Parameters.Add("PIN_ANLST_UR_ID", OracleDbType.Int32, 10, userProfile.AnalystURID == 0 ? Convert.DBNull : userProfile.AnalystURID, ParameterDirection.Input);
                        oCmd.Parameters.Add("PIN_QUAL_ANLST_UR_ID", OracleDbType.Int32, 10, userProfile.QualityAnalystURID == 0 ? Convert.DBNull : userProfile.QualityAnalystURID, ParameterDirection.Input);
                        oCmd.Parameters.Add("PIN_REV_ANLST_UR_ID", OracleDbType.Int32, 10, userProfile.ReviewerAnalystURID == 0 ? Convert.DBNull : userProfile.ReviewerAnalystURID, ParameterDirection.Input);

                        OracleParameter paStatus = new OracleParameter();
                        paStatus.ParameterName = "POC_STATUS";
                        paStatus.Direction = ParameterDirection.Output;
                        paStatus.OracleDbType = OracleDbType.Varchar2;
                        paStatus.Size = 200;
                        oCmd.Parameters.Add(paStatus);

                        dbCon.Open();
                        oCmd.ExecuteNonQuery();
                        if (paStatus.Value != null)
                        {
                            if (paStatus.Value.ToString().Length > 0)
                            {
                                strUserStatus = paStatus.Value.ToString();
                            }
                            else
                            {
                                strUserStatus = Convert.ToString(paStatus.Value);
                            }
                        }
                        dbCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strUserStatus;
        }

        public static DataTable GetUserTeamUsersDetails()
        {
            DataTable dtTeamUsers = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = ConnectionDB.GetOracleConnection();
                    oraCmd.CommandText = "USER_MANAGEMENT_NEW.GET_TEAM_USERS";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    dtTeamUsers = new DataTable();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dtTeamUsers);                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtTeamUsers;
        }
           
        public static DataTable GetUsersByApplication(string strApplicationName, string strModuleName, int role_ID)
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
                        oraCmd.CommandText = "USER_MANAGEMENT.GET_USERNAMES_BY_APP_MOD";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //Parameters                        
                        oraCmd.Parameters.Add("PIC_APPLICATION", OracleDbType.Varchar2).Value = strApplicationName;
                        oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = strModuleName;
                        oraCmd.Parameters.Add("PIN_ROLE_ID", OracleDbType.Int32).Value = role_ID;
                        oraCmd.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

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

        public static DataTable CheckUserProfileDetails(string moduleName)
        {
            DataTable dtUserProfiles = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        //Initialization & settings
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "USER_MANAGEMENT.CHECK_TOOLMANAGER_ISEXIST";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        oraCmd.Parameters.Add("PIC_MODULE", OracleDbType.Varchar2).Value = moduleName;
                        oraCmd.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        // Filling data to out parameter ref-cursor to data table.
                        dtUserProfiles = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtUserProfiles);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtUserProfiles;
        }

        public static DataTable GetUserCredentialsByUserNameAndPassword(string userName, string userPassword)
        {
            DataTable dtUserCredentials = null;
            try
            {
                using (OracleConnection oraCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        //Initialization & settings
                        oraCmd.Connection = oraCon;
                        oraCmd.CommandText = "USER_MANAGEMENT.GET_USER_CREDENTIALS";
                        oraCmd.CommandType = CommandType.StoredProcedure;

                        //Parameters                        
                        oraCmd.Parameters.Add("PIC_USER_NAME", OracleDbType.Varchar2).Value = userName;
                        oraCmd.Parameters.Add("PIC_PASSWORD", OracleDbType.Varchar2).Value = userPassword;
                        oraCmd.Parameters.Add("PORC_RECORDS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        // Filling data to out parameter ref-cursor to data table.
                        dtUserCredentials = new DataTable();
                        OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                        oraAdpt.Fill(dtUserCredentials);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtUserCredentials;
        }

        public static DataTable GetAllUsersInformation()
        {
            DataTable dtResult = null;

            using (OracleConnection conn = ConnectionDB.GetOracleConnection())
            {
                using (OracleCommand command = conn.CreateCommand())
                {
                    command.CommandText = "USER_MANAGEMENT_NEW.GET_ALL_USERS";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("PORC_USER_NAMES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

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