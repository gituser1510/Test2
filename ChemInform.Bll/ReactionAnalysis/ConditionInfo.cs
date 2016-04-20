using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class ConditionInfo
    {
        public int ReactionID { get; set; }
        public int RxnStepID { get; set; }
        public int ConditionID { get; set; }
        
        public string Time { get; set; }
        public string Temperature { get; set; }
        public string Pressure { get; set; }
        public string PH { get; set; }
        public string TimeUnits { get; set; }
        public string TempUnits { get; set; }
        public string PressureUnits { get; set; }
        public string Operation { get; set; }
        public bool WarmUp { get; set; }
        public bool CoolDown { get; set; }
        public bool Reflux { get; set; }
        public string Other { get; set; }        
        public int StepNo { get; set; }

        public string Option { get; set; }    
    }
}
