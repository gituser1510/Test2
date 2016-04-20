using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class ArticleInfo
    {
        public int ArticleID { get; set; }
        public string JournalName { get; set; }
        public string Issue { get; set; }
        public string Volume { get; set; }
        public string DOI { get; set; }
        public string Authors { get; set; }
    }
}
