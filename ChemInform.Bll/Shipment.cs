using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Bll
{
    public class Shipment
    {       
        public int ShipmentID
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }
               
        public string ShipmentName
        {
            get;
            set;
        }

        public int AbstractRefsCount
        {
            get;
            set;
        }

        public int ShipmentYear
        {
            get;
            set;
        }

        public int ShipmentIssue
        {
            get;
            set;
        }

        public DateTime DownloadDate
        {
            get;
            set;
        }
               
        public DateTime ScheduleDeliveryDate
        {
            get;
            set;
        }
                
        public string DownloadFileName
        {
            get;
            set;
        }
               
        public string ConvertedPdfFileName
        {
            get;
            set;
        }
                
        public Char TaskPrepStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Assign default Id to -1,Task Preparation status to 'N'
        /// </summary>
        public Shipment()
        {
            ShipmentID = -1;
            TaskPrepStatus = 'N';
        }
    }
}
