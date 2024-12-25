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

        public event Action SwitchToNextControl;
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
            /*
            
            string[] sample_row1 = { "folder_pic_default.jpg" , "202281641", "DOUGLAS, JOHN PINLAC", "1", "1", "OFFICE", "A11"};
            string[] sample_row2 = { "folder_pic_default.jpg" ,"202391431", "MCDO, PIATOS -", "2", "2", "ENCODING", "A12"};
            List<string[]> sample_rows = new List<string[]>
            { sample_row1, sample_row2 };

            string imageDirectory = AppDomain.CurrentDomain.BaseDirectory;
            */

            string cachePath = "cacheImage";
            Directory.CreateDirectory(cachePath);

            var studentInfos = new List<(string Url, string studentNo, string studentName, string Year, string Block, string Status, string Code)>
            {
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw" , "202281641", "DOUGLAS, JOHN PINLAC", "1", "1", "OFFICE", "A11"),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw", "202391431", "MCDO, PIATOS -", "2", "2", "ENCODING", "A12"),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","2022714141", "LUCER, JAMES COW", "3", "3", "MISSING", "B41" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202283152", "PEREZ, MARIA LYN SANTOS", "4", "4", "OFFICE", "A13" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202295738", "CAMPOS, RICARDO SANTIAGO", "5", "5", "OFFICE", "A14" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw", "202267241", "FLORES, DANIEL PATRICK", "6", "6", "OFFICE", "B42" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202301523", "VILLANUEVA, RHEA MAE RIVERA", "7", "7", "OFFICE", "A15" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202311642", "SANTOS, MIGUEL RAMON", "8", "8", "OFFICE", "A16" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202260432", "GONZALEZ, ANDREA MARIE", "9", "9", "OFFICE", "B43" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202322451", "REYES, JONATHAN JOSE", "10", "10", "OFFICE", "A17" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202333982", "TAN, LIZA GRACE", "11", "11", "ENCODING", "A18" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202250920", "CHAVEZ, ROBERTO LUIS", "12", "12", "OFFICE", "B44" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202344013", "VILLALON, CHRISTIAN MARCOS", "13", "13", "OFFICE", "A19" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202355342", "JUNIO, ALICE MARIE LOUISE", "14", "14", "ENCODING", "A20" ),
                ("https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw","202267083", "SERRANO, MARIA CLARA AGUILAR", "15", "15", "OFFICE", "B45" ),
            };

            foreach (var i in studentInfos)
            {

                var image = await CacheAndLoadImageAsync(i.Url, cachePath);
                listFolders.Rows.Add(image, i.studentNo, i.studentName, i.Year, i.Block, i.Status, i.Code);
                /*
                // Load Image from File
                string imagePath = System.IO.Path.Combine(imageDirectory, i[0]);
                Image? profileImage = null;
                if (System.IO.File.Exists(imagePath))
                {
                    profileImage = Image.FromFile(imagePath);
                }

                // Add Row to DataGridView
                listFolders.Rows.Add(profileImage, i[1], i[2], i[3], i[4], i[5], i[6]);
                */
            }

            // Populate Status Column
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
            SwitchToNextControl?.Invoke();
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

        // Whenever you try to change the value of the STATUS column, it will automatically change the color of the entire row
        // NOTE: I MIGHT USE THIS TO ALSO UPDATE THE DATABASE
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
    }
}
