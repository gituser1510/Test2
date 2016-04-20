using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class ReactionRefInfo
    {
        public int ReactionID { get; set; }
        public int ExtRegID { get; set; }
        public int ExtRegNo { get; set; }
        public string RefPath { get; set; }
        public string Step { get; set; }
        public int ReactionRefId { get; set; }
        public string Option { get; set; }
    }
}
