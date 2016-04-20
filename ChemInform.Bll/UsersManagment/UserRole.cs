
namespace ChemInform.Bll.UsersManagment
{
    public class UserRole
    {
        /// <summary>
        /// Gets or sets the user role id (PK).
        /// </summary>
        public int UserRoleId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the userid.
        /// </summary>
        public int UserID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the roleid.
        /// </summary>
        public int RoleId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the application module name.
        /// </summary>
        public string ModuleName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the userrole status.
        /// </summary>
        public char IsActive
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the team lead id.
        /// </summary>
        public int TeamLeadID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the incharge id.
        /// </summary>
        public int InchargeID
        {
            get;
            set;
        }
    }
}
