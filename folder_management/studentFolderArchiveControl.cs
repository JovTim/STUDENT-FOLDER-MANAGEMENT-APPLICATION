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

    public partial class studentFolderArchiveControl : UserControl
    {
        sqliteDataAccess dataAccess;
        private const int pageSize = 10;
        private int currentPageIndex = 1;
        public studentFolderArchiveControl()
        {
            InitializeComponent();

            dataAccess = new sqliteDataAccess();
        }

        private void studentFolderArchiveControl_Load(object sender, EventArgs e)
        {
            loadArchive();
        }

        private void loadArchive()
        {
            if (dataAccess == null)
            {
                MessageBox.Show("Data access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var archive = dataAccess.loadArchiveFolder(pageSize, currentPageIndex);

            if (archive == null || archive.Count == 0)
            {
                MessageBox.Show("No data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var archiveInfo = archive.Select(i => (
            studentNumber: i[0],
            lastName: i[1],
            firstName: i[2],
            middleName: i[3],
            date: i[4]
            )).ToList();

            foreach (var i in archiveInfo)
            {
                archiveList.Rows.Add(i.studentNumber, i.lastName.ToUpper(), i.firstName.ToUpper(), i.middleName.ToUpper(), i.date);
            }
        }

        private void unarchiveButton_Click(object sender, EventArgs e)
        {
            if (archiveList.SelectedRows.Count == 1)
            {
                unarchiveButton.Enabled = true;
                deleteButton.Enabled = true;
                DataGridViewRow selectedRow = archiveList.SelectedRows[0];
                string cellValue = selectedRow.Cells[0].Value?.ToString();
                dataAccess.unarchiveFolder(cellValue);
                MessageBox.Show($"Student {cellValue} has been unarchived!", "Archive Message", MessageBoxButtons.OK);

                int selected = archiveList.SelectedRows[0].Index;
                archiveList.Rows.RemoveAt(selected);



            }
            else
            {
                unarchiveButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            unarchiveButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this folder?", "DELETE INFO", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (archiveList.SelectedRows.Count == 1)
                {
                    unarchiveButton.Enabled = true;
                    deleteButton.Enabled = true;

                    DataGridViewRow selectedRow = archiveList.SelectedRows[0];
                    string cellValue = selectedRow.Cells[0].Value?.ToString();
                    dataAccess.unarchiveFolder(cellValue);
                    dataAccess.deleteFolder(cellValue);

                    int selected = archiveList.SelectedRows[0].Index;
                    archiveList.Rows.RemoveAt(selected);
                }
                else
                {
                    unarchiveButton.Enabled = false;
                    deleteButton.Enabled = false;
                }
                unarchiveButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < pageSize && archiveList.RowCount >= 10)
            {
                currentPageIndex++;
                archiveList.Rows.Clear();
                loadArchive();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                archiveList.Rows.Clear();
                loadArchive();
            }
        }
    }
}
