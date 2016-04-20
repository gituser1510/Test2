using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChemInform.Bll;
using System.Data;

namespace ChemInform.Common
{
    public static class GlobalVariables
    {
        public static UserInfo LogInUserInfo { get; set; }

        public static int PrevTotalPageNumber { get; set; }

        public static string UserName { get; set; }

        public static string RoleName { get; set; }

        public static int RoleId { get; set; }

        public static string Module { get; set; }

        public static int UR_ID { get; set; }

        public static DataTable DtProject { get; set; }

        public static int TaskId { get; set; }

        public static DataTable ClasificationMaster { get; set; }

        public static DataTable SysNoClasifications { get; set; }

        public static DataTable ShipmentMaster { get; set; }

        public static string TaskPrepOutputPath { get; set; }

        public static string TaskPrepInputPath { get; set; }

        public static string ProjectName = "Wiley - ChemInform";

        public const string MessageCaption = "WCI";
        
        public static int UserID { get; set; }

        public static bool IsLoginSuccess { get; set; }

        public static DataTable SolvCatalystMaster { get; set; }

        public static DataTable DeliveredSolvCatalysts { get; set; }

        public static int ShipmentRefID { get; set; }
    }
}
