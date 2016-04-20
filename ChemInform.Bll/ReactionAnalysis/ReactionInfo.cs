using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ChemInform.Bll
{
    public class ReactionInfo
    {
        public int ShipmentRefID { get; set; }

        public string ShipmentRefType { get; set; }

        public int ReactionID { get; set; }
        public int ReactionSNo { get; set; }
        public string RxnMDLNo { get; set; }
        public string SysNo { get; set; }
        public string SysText { get; set; }
        public object ReactionScheme { get; set; }
        public string RxnComments { get; set; }
        public string AtomMappingType { get; set; }
        public List<ReactionRefInfo> RxnRef { get; set; }
        public List<CrossRefInfo> RxnCrossRef { get; set; }
        public List<ProductInfo> RxnProducts { get; set; }
        public List<StepInfo> RxnSteps { get; set; }
        public DataTable ParticipantsForPdf { get; set; }
               
        public string RxnCompleteStatus { get; set; }
        public string RoleName { get; set; }
        public int UR_ID { get; set; }

        public string IsImportantRxn { get; set; }      
    }
}
