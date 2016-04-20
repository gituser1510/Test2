using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class SpectralInfo
    {
        public ArticleInfo ArticleInformation { get; set; }
        public CompoundInfo CompoundInformation { get; set; }
        public List<NMRSpectralInfo> NMRSpectralList { get; set; }
        public List<OtherSpectralInfo> OtherSpectralList { get; set; }
    }
}
