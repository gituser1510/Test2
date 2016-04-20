using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class NMRSpectralInfo
    {
        public int    CompoundID    { get; set; }
        public int    NMRSpectralID { get; set; }
        public string SpectroMeter  { get; set; }
        public string Solvent       { get; set; }
        public string Frequency     { get; set; }
        public string Nucleus       { get; set; }
        public string StdSolvent    { get; set; }
        public string ShiftValues   { get; set; }
    }
}
