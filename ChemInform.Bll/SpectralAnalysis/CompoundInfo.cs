using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class CompoundInfo
    {
        public int CompoundID { get; set; }
        public object Compound { get; set; }
        public string CompoundNo { get; set; }
        public string CompoundLabel { get; set; }
        public string IUPACName { get; set; }
        public string InchiKey { get; set; }
        public string MolFormula { get; set; }
        public string MolWeight { get; set; }
        public string PageNo { get; set; }
        public string Comments { get; set; }
        public string Synonyms { get; set; }        
    }
}
