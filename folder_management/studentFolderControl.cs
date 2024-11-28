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

            sampleDateLoad();
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
            /*
            if (string.IsNullOrEmpty(searchBar.Text))
            {
                searchBarText.Visible = true;
            }
            */
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

        private void listFolders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sampleDateLoad()
        {
            string[] sample_row1 = { "A11", "202281641", "DOUGLAS, JOHN PINLAC", "1", "1", "OFFICE", "DRAWER" };
            string[] sample_row2 = { "A12", "202391431", "MCDO, PIATOS -", "2", "2", "ENCODING", "LOCKER" };
            string[] sample_row3 = { "B41", "2022714141", "LUCER, JAMES COW", "3", "3", "MISSING", "TABLE" };

            List<string[]> sample_rows = new List<string[]> { sample_row1, sample_row2, sample_row3 };

            foreach (var i in sample_rows)
            {
                listFolders.Rows.Add(i);
            }

            string[] status = { "OFFICE", "ENCODING", "MISSING" };
            statusCol.DataSource = status;
        }

        private void toolTipArchive_Popup(object sender, PopupEventArgs e)
        {
        }

        private void archiveStudent_Click(object sender, EventArgs e)
        {

        }

        private void addStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
