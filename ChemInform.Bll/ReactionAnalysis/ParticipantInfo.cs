using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class ParticipantInfo
    {
        public int ReactionID { get; set; }
        public int RxnStepID { get; set; }
        public int ParticipantID { get; set; }
        public string ParticipantType { get; set; }

        public int StepNo { get; set; }
        public string ParticipantName { get; set; }
        public object Structure { get; set; }
        public object StructureImage { get; set; }
        public string StructureNo { get; set; }
        public string Grade { get; set; }
        public string InchiKey { get; set; }
        public string Option { get; set; }
    }
}
