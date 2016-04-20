using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemInform.Common
{
    class DataConversions
    {
        public static string ConvertFahrenheitToDegress(string fahrenTemp)
        {
            string strFarehTemp = "";
            try
            {
                if (!string.IsNullOrEmpty(fahrenTemp))
                {
                    strFarehTemp = Math.Round((5.0 / 9.0) * (Convert.ToDouble(fahrenTemp.Trim()) - 32), 3).ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return strFarehTemp;
        }

        public static string ConvertKelvinsToDegress(string kelvinTemp)
        {
            string strKelvinTemp = "";
            try
            {
                if (!string.IsNullOrEmpty(kelvinTemp))
                {
                    strKelvinTemp = Math.Round((Convert.ToDouble(kelvinTemp.Trim()) - 273.15), 3).ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return strKelvinTemp;
        }

        public static string ConvertMinutesToHours(string minsTime)
        {
            string timeInHrs = "";
            try
            {
                if (!string.IsNullOrEmpty(minsTime))
                {
                    timeInHrs = Math.Round(TimeSpan.FromMinutes(Convert.ToDouble(minsTime.Trim())).TotalHours, 3).ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return timeInHrs;
        }

        public static string ConvertSecondsToHours(string secsTime)
        {
            string timeInHrs = "";
            try
            {
                if (!string.IsNullOrEmpty(secsTime))
                {
                    timeInHrs = Math.Round(TimeSpan.FromSeconds(Convert.ToDouble(secsTime.Trim())).TotalHours, 3).ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.WriteErrorLog(ex.Message);
            }
            return timeInHrs;
        }        
    }
}
