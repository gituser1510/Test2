using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace ChemInformUpdates
{
    public static class UpdatesDAL
    {
        private static string newconStr = string.Empty;     

        public static OracleConnection GetOracleConnection()
        {
            OracleConnection con = null;

            string conHostName = ConfigurationSettings.AppSettings["HOSTNAME"].ToString();
            string conPort = ConfigurationSettings.AppSettings["PORTNUMBER"].ToString(); ;
            string conDatabase = ConfigurationSettings.AppSettings["DATABASE"].ToString();
            string _dbUserName = ConfigurationSettings.AppSettings["USERNAME"].ToString();
            string _dbPwd = ConfigurationSettings.AppSettings["PASSWORD"].ToString();

            newconStr = string.Format("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={2})));User Id={3};Password={4}; "
                + " Connection Timeout=60;Validate Connection = true", conHostName, conPort, conDatabase, _dbUserName, _dbPwd);

            try
            {
              
                con = new OracleConnection(newconStr);
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return con;
        }

        public static DataTable GetIndexingDllNames(int app_version)
        {
            DataTable dtDllNames = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = GetOracleConnection();
                    oraCmd.CommandText = "GET_APPLICATION_DLL_NAMES";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PIN_APP_VER", OracleDbType.Int32).Value = app_version;
                    oraCmd.Parameters.Add("PORC_DLLS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    DataSet dsResults = new DataSet();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dsResults);
                    if (dsResults != null)
                    {
                        if (dsResults.Tables.Count > 0)
                        {
                            if (dsResults.Tables[0] != null)
                            {
                                dtDllNames = dsResults.Tables[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtDllNames;
        }

        public static DataTable GetIndexingBuildDllVersions(int app_version)
        {
            DataTable dtDllVers = null;
            try
            {
                using (OracleCommand oraCmd = new OracleCommand())
                {
                    oraCmd.Connection = GetOracleConnection();
                    oraCmd.CommandText = "GET_APP_DLLS_BUILD_VERSIONS";
                    oraCmd.CommandType = CommandType.StoredProcedure;
                    oraCmd.Parameters.Add("PIN_APP_VER", OracleDbType.Int32).Value = app_version;
                    oraCmd.Parameters.Add("PORC_DLLS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    DataSet dsResults = new DataSet();
                    OracleDataAdapter oraAdpt = new OracleDataAdapter(oraCmd);
                    oraAdpt.Fill(dsResults);
                    if (dsResults != null)
                    {
                        if (dsResults.Tables.Count > 0)
                        {
                            if (dsResults.Tables[0] != null)
                            {
                                dtDllVers = dsResults.Tables[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtDllVers;
        }

        public static bool SaveApplicationErrors(string appErrMsg)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection dbCon = GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.CommandText = "COMMON.INSERT_APP_ERRORS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Connection = dbCon;

                        oraCmd.Parameters.Add("PIC_USER_NAME", OracleDbType.Varchar2).Value = string.Empty;
                        oraCmd.Parameters.Add("PIC_ROLE_NAME ", OracleDbType.Varchar2).Value = string.Empty;
                        oraCmd.Parameters.Add("PIC_APP_ERRORS ", OracleDbType.Varchar2).Value = appErrMsg;

                        dbCon.Open();
                        oraCmd.ExecuteNonQuery();
                        dbCon.Close();
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
 

    }
}
