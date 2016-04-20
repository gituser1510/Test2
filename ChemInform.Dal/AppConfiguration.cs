// -----------------------------------------------------------------------
// <copyright file="AppConfiguration.cs" company="www.gvkbio.com">
//   Copyright 2014 - 2015 - www.gvkbio.com. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Configuration;

namespace ChemInform.Dal
{
    /// <summary>
    /// The AppConfiguaration class contains read-only properties that are essentially short cuts to settings in the app.config file.
    /// </summary>
    internal static class AppConfiguration
    {
        /// <summary>
        /// Gets the host name of the oracle server.
        /// </summary>
        public static string Host
        {
            get
            {
                return ConfigurationManager.AppSettings["HOSTNAME"];
            }
        }

              /// <summary>
        /// Gets the Port of the oracle server.
        /// </summary>
        public static string Port
        {
            get
            {
                return ConfigurationManager.AppSettings["PORTNUMBER"];
            }
        }

        /// <summary>
        /// Gets the database name of the oracle server.
        /// </summary>
        public static string Database
        {
            get
            {
                return ConfigurationManager.AppSettings["DATABASE"];
            }
        }

        /// <summary>
        /// Gets the schema name of the oracle server.
        /// </summary>
        public static string UserName
        {
            get
            {
                return ConfigurationManager.AppSettings["USERNAME"];
            }
        }

        /// <summary>
        /// Gets the schema password of the oracle server.
        /// </summary>
        public static string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["PASSWORD"];
            }
        }

    }
}
