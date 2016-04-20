using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ChemInform.Dal
{
    internal static class OracleExtensions
    {
        /// <summary>
        /// Opens the database connection if already opened.
        /// </summary>
        /// <param name="conn"></param>
        public static void OpenConnection(this OracleConnection conn)
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
        }

        /// <summary>
        /// Gets parameter value if available. Otherwise it returns default value as -1.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameter">Name of the parameter to return the value</param>
        /// <returns>An integer value if available. Otherwise -1.</returns>
        public static int GetInt32Value(this OracleCommand command, string parameter)
        {
            int result = -1;
            OracleDecimal oracleDecimal;

        if (!((OracleDecimal)(command.Parameters[parameter].Value)).IsNull) 
            {
                oracleDecimal = (OracleDecimal)command.Parameters[parameter].Value;                                     
                if (oracleDecimal.IsInt)
                {
                    result = oracleDecimal.ToInt32();
                }
            }
            return result;
        }
    }
}
