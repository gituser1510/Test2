using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace ChemInform.Dal
{
    public class ConnectionDB
    {
        /// <summary>
        /// Gets an instance of oracle connection.
        /// </summary>
        /// <returns></returns>
        public static OracleConnection GetOracleConnection()
        {
            string conString = string.Format("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))"
                + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={2})));User Id={3};Password={4}; "
                + " Connection Timeout=60;Validate Connection = true", AppConfiguration.Host, AppConfiguration.Port,
                AppConfiguration.Database, AppConfiguration.UserName, AppConfiguration.Password);
            return new OracleConnection(conString); ;
        }

        /// <summary>
        /// Gets an instance of oracle connection.
        /// </summary>
        public static OracleConnection OracleConnection
        {
            get
            {
                return GetOracleConnection();
            }
        }
    }
}
