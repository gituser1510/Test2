using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class StepInfo
    {
        public int ReactionID { get; set; }
        public int StepID { get; set; }
        public int SerialNo { get; set; }
        public string  StepYield { get; set; }
        public List<ParticipantInfo> StepParticipants { get; set; }
        public List<ConditionInfo> StepConditions { get; set; }
    }
}
