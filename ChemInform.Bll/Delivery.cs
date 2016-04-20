using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class Delivery
    {
        public int Id { get; set; }
        public string DeliveryName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DeliveryRefCount { get; set; }
        public int DeliveryRxnCount { get; set; }
        public int MDLStartNo { get; set; }
        public int MDLEndNo { get; set; } 
        public List<int> DeliveryRefsList { get; set; }
        public List<int> RefMdlStartNoList { get; set; }
        public List<int> RefMdlEndNoList { get; set; }        
        public DmlOperations DmlType { get; set; }
        public int Urid { get; set; }
    }
}
