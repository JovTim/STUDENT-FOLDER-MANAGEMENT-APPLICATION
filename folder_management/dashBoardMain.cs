using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_management
{
    public partial class dashBoardMain : UserControl
    {
        sqliteDataAccess dataAccess;
        private static bool isCheckFoldersCalled;
        public dashBoardMain()
        {
            InitializeComponent();
            dataAccess = new sqliteDataAccess();    
        }

        private void dashBoardMain_Load(object sender, EventArgs e)
        {
            if (!isCheckFoldersCalled) // Check if it has been called
            {
                checkFolders();
                isCheckFoldersCalled = true; // Set the flag to true
                //MessageBox.Show("I CHECKED THE FOLDER STATUS!", "Title");
            }
        }


        public void checkFolders()
        {
            dataAccess.checkEncodeDates();
        }
    }
}
