using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class ProductInfo
    {
        public int ReactionID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public object Structure { get; set; }
        public object StructureImage { get; set; }
        public string StructureNo { get; set; }
        public string Yield { get; set; }
        public string CS { get; set; }//Chemo Selectivity
        public string DS { get; set; }//DiaStereo Selectivity
        public string DE { get; set; }//DiaStereo Excess 
        public string EE { get; set; }//Enatiomeric Excess
        public string InchiKey { get; set; }
        public string ProductGrade { get; set; }
        public string Option { get; set; }
    }
}
