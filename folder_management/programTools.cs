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
    }
}
