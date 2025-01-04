using System;
using System.Drawing;
using System.Windows.Forms;

namespace folder_management
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            dashBoardMain dashBoardMain = new dashBoardMain();

            dashBoardMain.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dashBoardMain);
        }

        private void mainFormTitle_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void line1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashBoardButton_Click(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#5ce1e6");
            panel4.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel6.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel7.BackColor = ColorTranslator.FromHtml("#d9d9d9");

            // dispose the controls before removing them (to release resources)
            foreach (Control control in mainPanel.Controls)
            {
                control.Dispose();
            }
            mainPanel.Controls.Clear();
            dashBoardMain dashBoardMain1 = new dashBoardMain();
            dashBoardMain1.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dashBoardMain1);

        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel4.BackColor = ColorTranslator.FromHtml("#5ce1e6");
            panel6.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel7.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            // dispose the controls before removing them (to release resources)
            foreach (Control control in mainPanel.Controls)
            {
                control.Dispose();
            }

            mainPanel.Controls.Clear();

            folderBoardMain folderBoardMain = new folderBoardMain();
            folderBoardMain.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(folderBoardMain);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel4.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel6.BackColor = ColorTranslator.FromHtml("#5ce1e6");
            panel7.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            foreach (Control control in mainPanel.Controls)
            {
                control.Dispose();
            }
            mainPanel.Controls.Clear();

            studentFolderHistoryControl studentFolderHistoryControl = new studentFolderHistoryControl();
            studentFolderHistoryControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(studentFolderHistoryControl);
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel4.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel6.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            panel7.BackColor = ColorTranslator.FromHtml("#5ce1e6");
            foreach (Control control in mainPanel.Controls)
            {
                control.Dispose();
            }
            mainPanel.Controls.Clear();

            studentFolderArchiveControl studentFolderArchiveControl = new studentFolderArchiveControl();
            studentFolderArchiveControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(studentFolderArchiveControl);
        }
    }
}
