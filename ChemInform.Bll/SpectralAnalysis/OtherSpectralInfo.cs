using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class OtherSpectralInfo
    {
        public int    CompoundID      { get; set; }
        public int    OtherSpectralID { get; set; }
        public string SpectroMeter    { get; set; }
        public string ValueType       { get; set; }
        public string Comments        { get; set; }
        public string ElectronVolts   { get; set; }
        public string Method          { get; set; }
        public string SamplePreparation { get; set; }
        public string PeakValues      { get; set; }
    }
}
