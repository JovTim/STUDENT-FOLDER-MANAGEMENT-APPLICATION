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

        // sample data, might delete later in the future
        private void sampleDateLoad()
        {
            string[] sample_row1 = { "A11", "202281641", "DOUGLAS, JOHN PINLAC", "1", "1", "OFFICE", "DRAWER" };
            string[] sample_row2 = { "A12", "202391431", "MCDO, PIATOS -", "2", "2", "ENCODING", "LOCKER" };
            string[] sample_row3 = { "B41", "2022714141", "LUCER, JAMES COW", "3", "3", "MISSING", "TABLE" };
            string[] sample_row4 = { "A13", "202283152", "PEREZ, MARIA LYN SANTOS", "4", "4", "OFFICE", "DRAWER" };
            string[] sample_row5 = { "A14", "202295738", "CAMPOS, RICARDO SANTIAGO", "5", "5", "ENCODING", "LOCKER" };
            string[] sample_row6 = { "B42", "202267241", "FLORES, DANIEL PATRICK", "6", "6", "MISSING", "TABLE" };
            string[] sample_row7 = { "A15", "202301523", "VILLANUEVA, RHEA MAE RIVERA", "7", "7", "OFFICE", "DRAWER" };
            string[] sample_row8 = { "A16", "202311642", "SANTOS, MIGUEL RAMON", "8", "8", "ENCODING", "LOCKER" };
            string[] sample_row9 = { "B43", "202260432", "GONZALEZ, ANDREA MARIE", "9", "9", "MISSING", "TABLE" };
            string[] sample_row10 = { "A17", "202322451", "REYES, JONATHAN JOSE", "10", "10", "OFFICE", "DRAWER" };
            string[] sample_row11 = { "A18", "202333982", "TAN, LIZA GRACE", "11", "11", "ENCODING", "LOCKER" };
            string[] sample_row12 = { "B44", "202250920", "CHAVEZ, ROBERTO LUIS", "12", "12", "MISSING", "TABLE" };
            string[] sample_row13 = { "A19", "202344013", "VILLALON, CHRISTIAN MARCOS", "13", "13", "OFFICE", "DRAWER" };
            string[] sample_row14 = { "A20", "202355342", "JUNIO, ALICE MARIE LOUISE", "14", "14", "ENCODING", "LOCKER" };
            string[] sample_row15 = { "B45", "202267083", "SERRANO, MARIA CLARA AGUILAR", "15", "15", "MISSING", "TABLE" };

            List<string[]> sample_rows = new List<string[]>
            { sample_row1, sample_row2, sample_row3, sample_row4, sample_row5, sample_row6,
            sample_row7, sample_row8, sample_row9, sample_row10, sample_row11, sample_row12, sample_row13, sample_row14, sample_row15};

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

        // change the color of the row depending of the value of the status column
        // if status is ENCODING, the row color will turn light gray
        // if staus is MISSING, the row color will turn light red
        private void listFolders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = listFolders.Rows[e.RowIndex];

                if (row.Cells[5].Value.ToString() == "ENCODING")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#b9b9b9");
                }

                else if (row.Cells[5].Value.ToString() == "MISSING")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f58a8a");
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void listFolders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                DataGridViewRow row = listFolders.Rows[e.RowIndex];

                string? comboBoxValue = row.Cells[e.ColumnIndex].Value?.ToString();

                if (comboBoxValue == "ENCODING")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#b9b9b9");
                }

                else if (comboBoxValue == "MISSING")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f58a8a");
                }

                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

        private void listFolders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (listFolders.IsCurrentCellDirty)
            {
                listFolders.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
