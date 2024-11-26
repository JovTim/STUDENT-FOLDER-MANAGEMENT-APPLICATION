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
    public partial class folderBoardMain : UserControl
    {
        public folderBoardMain()
        {
            InitializeComponent();

            studentFolderControl studentFolderControl = new studentFolderControl();
            studentFolderControl.Dock = DockStyle.Fill;
            folderMainPanel.Controls.Add(studentFolderControl);
        }

        private void folderBoardMain_Load(object sender, EventArgs e)
        {

        }

        private void studentFolder_Click(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#5ce1e6");
            panel2.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel3.BackColor = ColorTranslator.FromHtml("#d9d9d9");

            foreach (Control control in folderMainPanel.Controls)
            {
                control.Dispose();
            }
            folderMainPanel.Controls.Clear();

            studentFolderControl studentFolderControl = new studentFolderControl();
            studentFolderControl.Dock = DockStyle.Fill;
            folderMainPanel.Controls.Add(studentFolderControl);
        }

        private void folderHistory_Click(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel2.BackColor = ColorTranslator.FromHtml("#5ce1e6");
            panel3.BackColor = ColorTranslator.FromHtml("#d9d9d9");

            foreach (Control control in folderMainPanel.Controls)
            {
                control.Dispose();
            }
            folderMainPanel.Controls.Clear();

            studentFolderHistoryControl folderHistory = new studentFolderHistoryControl();
            folderHistory.Dock = DockStyle.Fill;
            folderMainPanel.Controls.Add(folderHistory);

        }

        private void folderArchives_Click(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel2.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel3.BackColor = ColorTranslator.FromHtml("#5ce1e6");
            
            foreach (Control control in folderMainPanel.Controls)
            {
                control.Dispose();
            }
            folderMainPanel.Controls.Clear();

            studentFolderArchiveControl folderArchive = new studentFolderArchiveControl();
            folderArchive.Dock = DockStyle.Fill;
            folderMainPanel.Controls.Add(folderArchive);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void folderMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
