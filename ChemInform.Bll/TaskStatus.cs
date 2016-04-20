using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class TaskStatus
    {
        public int Task_ID { get; set; }
               
        public string RoleName { get; set; }

        public int TaskAllocation_ID { get; set; }
               
        public string Status { get; set; }

        public int Role_ID { get; set; }

        public int UR_ID { get; set; }

        public string TaskStatusName { get; set; }

        public string TaskComments { get; set; }

        public char IsReassigned { get; set; }
    }
}
