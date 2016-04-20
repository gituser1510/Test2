using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class User
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string Name 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user status.
        /// </summary>
        public char IsActive
        {
            get;
            set;
        }

        public User()
        {
            ID = -1;
            IsActive = 'Y';
        }

        public string Password { get; set; }

        public char IsLDAPUser { get; set; }

        public string Status { get; set; }

        public DmlOperations OptionType { get; set; }
    }

    public class UserProfileBLL
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int ProjectManagerURID { get; set; }
        public int QualityAnalystURID { get; set; }
        public int ReviewerAnalystURID { get; set; }
        public int AnalystURID { get; set; }
        public int ToolManagerURID { get; set; }
        public string Status { get; set; }
        public DmlOperations OptionType { get; set; }
        public string ModuleName { get; set; }
    }
}
