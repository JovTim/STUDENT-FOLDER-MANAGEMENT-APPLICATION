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
    public partial class studentFolderControl : UserControl
    {
        public studentFolderControl()
        {
            InitializeComponent();
        }

        private void studentFolderControl_Load(object sender, EventArgs e)
        {

        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            searchBarText.Visible = false;
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBarText_Click(object sender, EventArgs e)
        {

        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            searchBarText.Visible = true;
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            searchBarText.Visible = false;
        }
    }
}
