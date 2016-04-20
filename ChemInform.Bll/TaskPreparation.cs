using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class TaskPreparation
    {
        public int ShipmentRefID { get; set; }
        public int ShipmentId { get; set; }
        public string AbstractRefNo { get; set; }
        public string JournalName { get; set; }       
        public string DOI { get; set; }
        public bool IsNoReaction { get; set; }

        public string SysNo { get; set; }
        public string SysText { get; set; }  
        public string SysNoClassType { get; set; }   

        public int UrId { get; set; }
        public object FileType { get; set; }        
        public int ValidateUrId { get; set; }
    }
}
