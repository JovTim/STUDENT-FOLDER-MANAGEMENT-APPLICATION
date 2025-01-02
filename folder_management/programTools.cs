using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folder_management
{
    internal class programTools
    {
        public string convertToDownloadableLink(string link)
        {
            string[] splitted = link.Split('/');

            return $"https://drive.google.com/uc?export=download&id={splitted[5]}";
        }

        public bool getMonthDifference(DateTime start, DateTime end)
        {
            int yearDiff = end.Year - start.Year;
            int monthDiff = end.Month - start.Month;

            int difference = yearDiff * 12 + monthDiff;

            if (difference >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
