using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class FullArticleInfo
    {
        //Journal related fields
        public int ShipmentRefID { get; set; }
        public string ArticleType { get; set; }

        public string JournalRefNo { get; set; }
        public string JournalVolume { get; set; }
        public int JournalYear { get; set; }
        public string JournalName { get; set; }
        public string JournalDOI { get; set; }
        public string JournalStartPage { get; set; }
        public string JournalEndPage { get; set; }
        public int UR_ID { get; set; }
    }
}
