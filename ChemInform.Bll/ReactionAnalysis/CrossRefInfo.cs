using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class CrossRefInfo
    {
        public int ReactionID { get; set; }
        public int CrossRefID { get; set; }
        public int CrossRefNo { get; set; }
        public string PrevReactionNo { get; set; }
        public string SuccReactionNo { get; set; }
        public string CrossRefType { get; set; }
        public string Option { get; set; }

    }
}
