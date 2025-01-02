using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_management
{
    public partial class studentFolderControl : UserControl
    {
        private const int pageSize = 10;
        private int currentPageIndex = 1;
        public event Action SwitchToNextControl;
        public event Action SwitchToEditControl;
        private sqliteDataAccess dataAccess;
        public studentFolderControl()
        {
            InitializeComponent();

            dataAccess = new sqliteDataAccess();

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
            if (searchBar.Text.Length >= 2)
            {
                listFolders.Rows.Clear();
                loadFolderIDData();
            }
        }

        // loading the ID number based on the search bar
        private async void loadFolderIDData()
        {
            string cachePath = "cacheImage";
            Directory.CreateDirectory(cachePath);

            if (dataAccess == null)
            {
                MessageBox.Show("Data access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load data from the database
            var folderData = dataAccess.loadFolderDataStudentNumber($"%{searchBar.Text}%");

            if (folderData == null || folderData.Count == 0)
            {
                MessageBox.Show("No data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Map the folder data to a list of tuples
            var studentInfos = folderData.Select(i => (
                Url: i[0],
                studentNo: i[1],
                studentName: i[2].ToUpper(),
                Year: i[3],
                Block: i[4],
                Status: i[5],
                Code: i[6]
            )).ToList();

            // Loop through the student information and add it to the DataGridView
            foreach (var i in studentInfos)
            {
                var image = await CacheAndLoadImageAsync(i.Url, cachePath);
                listFolders.Rows.Add(image, i.studentNo, i.studentName, i.Year, i.Block, i.Status, i.Code);
            }

            // Populate Status Column
            string[] status = { "OFFICE", "ENCODING", "MISSING" };
            statusCol.DataSource = status;
        }

        private void searchBarText_Click(object sender, EventArgs e)
        {

        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchBar.Text))
            {
                searchBarText.Visible = false;
            }
            else
            {
                searchBarText.Visible = true;
            }

        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            searchBarText.Visible = false;
        }

        private void listFolders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // sample data, might delete later in the future
        private async void sampleDateLoad()
        {
            string cachePath = "cacheImage";
            Directory.CreateDirectory(cachePath);

            if (dataAccess == null)
            {
                MessageBox.Show("Data access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load data from the database
            var folderData = dataAccess.loadFolderData(pageSize, currentPageIndex);

            if (folderData == null || folderData.Count == 0)
            {
                MessageBox.Show("No data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Map the folder data to a list of tuples
            var studentInfos = folderData.Select(i => (
                Url: i[0],
                studentNo: i[1],
                studentName: i[2].ToUpper(),
                Year: i[3],
                Block: i[4],
                Status: i[5],
                Code: i[6]
            )).ToList();

            // Loop through the student information and add it to the DataGridView
            foreach (var i in studentInfos)
            {
                var image = await CacheAndLoadImageAsync(i.Url, cachePath);
                listFolders.Rows.Add(image, i.studentNo, i.studentName, i.Year, i.Block, i.Status, i.Code);
            }

            // Populate Status Column
            string[] status = { "OFFICE", "ENCODING", "MISSING" };
            statusCol.DataSource = status;
        }

        private void toolTipArchive_Popup(object sender, PopupEventArgs e)
        {
        }

        // TODO: After Archive, refresh the form
        private void archiveStudent_Click(object sender, EventArgs e)
        {
            if (listFolders.SelectedRows.Count == 1)
            {
                archiveStudent.Enabled = true;
                DataGridViewRow selectedRow = listFolders.SelectedRows[0];

                string cellValue = selectedRow.Cells[1].Value?.ToString();


                dataAccess.insertArchive(cellValue);

                MessageBox.Show($"Student {cellValue} has been archived!", "Archive Message", MessageBoxButtons.OK);

                int selected = listFolders.SelectedRows[0].Index;
                listFolders.Rows.RemoveAt(selected);

            }
            else
            {
                archiveStudent.Enabled = false;
            }
            archiveStudent.Enabled = true;
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            SwitchToNextControl?.Invoke();
        }

        // change the color of the row depending of the value of the status column
        // if status is ENCODING, the row color will turn light gray
        // if staus is MISSING, the row color will turn light red
        private void listFolders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
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

        // Whenever you try to change the value of the STATUS column, it will automatically change the color of the entire row
        // NOTE: I MIGHT USE THIS TO ALSO UPDATE THE DATABASE
        private void listFolders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                DataGridViewRow row = listFolders.Rows[e.RowIndex];

                string? comboBoxValue = row.Cells[e.ColumnIndex].Value?.ToString();
                var cellValue = row.Cells[1].Value?.ToString();

                if (comboBoxValue == "ENCODING")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#b9b9b9");
                    dataAccess.updateFolderStatus(cellValue, 2);
                }

                else if (comboBoxValue == "MISSING")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f58a8a");
                    dataAccess.updateFolderStatus(cellValue, 3);
                }

                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    dataAccess.updateFolderStatus(cellValue, 1);
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

        // turn the image shape into circular
        private void listFolders_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == listFolders.Columns["profilePicCol"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                var image = (Image)listFolders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (image != null)
                {
                    int diameter = Math.Min(e.CellBounds.Width, e.CellBounds.Height);
                    Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, diameter, diameter);

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddEllipse(rect);
                        e.Graphics?.SetClip(path);
                        e.Graphics?.DrawImage(image, rect);
                        e.Graphics?.ResetClip();
                    }
                }

                e.Handled = true;
            }
        }

        // sanitize the url name
        private string SanitizeFileName(string url)
        {
            // Remove or replace characters that are invalid in file names
            var invalidChars = Path.GetInvalidFileNameChars();
            var sanitizedName = url.Replace("https://", "").Replace("http://", "")
                                   .Split(new char[] { '/', '?', '=', '&', '#' })
                                   .Last(); // This ensures the file name is unique by taking the last part of the URL
            foreach (var ch in invalidChars)
            {
                sanitizedName = sanitizedName.Replace(ch, '_');
            }
            return sanitizedName;
        }

        private async Task<Image> CacheAndLoadImageAsync(string url, string cachePath)
        {
            // Generate a sanitized file name based on the URL
            string fileName = Path.Combine(cachePath, SanitizeFileName(url) + ".jpg"); // Add appropriate file extension
            if (!File.Exists(fileName))
            {
                using (var httpClient = new HttpClient())
                {
                    var imageBytes = await httpClient.GetByteArrayAsync(url);
                    await File.WriteAllBytesAsync(fileName, imageBytes);
                }
            }
            return Image.FromFile(fileName);
        }

        private void listFolders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = listFolders.Rows[e.RowIndex];

                var cellValue = clickedRow.Cells[1].Value;

                dataAccess.insertTempData(Convert.ToString(cellValue));

                //MessageBox.Show($"You double-clicked on row {e.RowIndex}, value: {cellValue}");
            }
            SwitchToEditControl?.Invoke();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < pageSize && listFolders.RowCount >= 10)
            {
                currentPageIndex++;
                listFolders.Rows.Clear();
                sampleDateLoad();

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                listFolders.Rows.Clear();
                sampleDateLoad();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            listFolders.Rows.Clear();
            sampleDateLoad();
        }
    }
}
