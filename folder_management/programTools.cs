using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

    public class verificationTool
    {
        public bool validateUrl(string url)
        {
            var urlRegex = new Regex(
                @"^(https?|ftps?):\/\/(?:[a-zA-Z0-9]" +
                @"(?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,}" +
                @"(?::(?:0|[1-9]\d{0,3}|[1-5]\d{4}|6[0-4]\d{3}" +
                @"|65[0-4]\d{2}|655[0-2]\d|6553[0-5]))?" +
                @"(?:\/(?:[-a-zA-Z0-9@%_\+.~#?&=]+\/?)*)?$",
                RegexOptions.IgnoreCase);

            if (!urlRegex.IsMatch(url))
                return false;

            var googleDriveRegex = new Regex(
                @"^(https?:\/\/)?(www\.)?(drive\.google\.com\/(file\/d\/|uc\?|open\?))",
                RegexOptions.IgnoreCase);

            return googleDriveRegex.IsMatch(url);
        }

        public bool validateName(string name)
        {
            if (name.Length > 30) return false;

            var nameRegex = new Regex(@"^[a-zA-Z\s\-]+$");

            return nameRegex.IsMatch(name);
        }

        public bool validateNumber(string input)
        {
            int number = 0;
            if (!int.TryParse(input, out number)) return false;

            int output = Convert.ToInt32(input);

            if (output < 0) return false;

            return true;
            /*
            var numberRegex = new Regex(@"^\d+$");

            return numberRegex.IsMatch(input);
            */
        }

        public bool validateCode(string input)
        {
            var combinedRegex = new Regex(@"^[a-zA-Z0-9\s\-]+$");

            return combinedRegex.IsMatch(input);
        }

    }
}
