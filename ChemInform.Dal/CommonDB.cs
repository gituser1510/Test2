using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using ChemInform.Bll;

namespace ChemInform.Dal
{
    public class CommonDB
    {
        public static bool SaveApplicationErrors(ApplicationError appError)
        {
            bool blStatus = false;
            try
            {
                using (OracleConnection dbCon = ConnectionDB.GetOracleConnection())
                {
                    using (OracleCommand oraCmd = new OracleCommand())
                    {
                        oraCmd.CommandText = "COMMON.INSERT_APP_ERRORS";
                        oraCmd.CommandType = CommandType.StoredProcedure;
                        oraCmd.Connection = dbCon;

                        oraCmd.Parameters.Add("PIC_USER_NAME", OracleDbType.Varchar2).Value = appError.UserName;
                        oraCmd.Parameters.Add("PIC_ROLE_NAME ", OracleDbType.Varchar2).Value = appError.RoleName;
                        oraCmd.Parameters.Add("PIC_APP_ERRORS ", OracleDbType.Varchar2).Value = appError.AppError;

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
