using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll.UsersManagment
{
    public class TeamUsers
    {
        public int TeamUserId { get; set; }
        public string Module { get; set; }
        public int PrjMgrUrId { get; set; }
        public int DelyMgrUrId { get; set; }
        public int ModHeadUrId { get; set; }
        public int TeamLdrUrId { get; set; }
        public int QualAnlstUrId { get; set; }
        public int RevAnlstUrId { get; set; }
        public int AnlstUrId { get; set; }
        public int TaskPrepUrId { set; get; }
        public char IsActive { get; set; }
        public int CreatedBy { get; set; }
    }
}
