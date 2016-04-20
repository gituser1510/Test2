using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class UserInfo
    {
        public int    UserID     { get; set; }
        public string UserName   { get; set; }
        public int    UserRoleID { get; set; }
        public string RoleName   { get; set; }
        public string EmailID    { get; set; }
        public string ModuleName { get; set; }
        public string UserStatus { get; set; }

        public int TeamLeadURID { get; set; }
        public int InchargeURID { get; set; }
    }
}
