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
            loadStudentFolderControl();
            /*
            studentFolderControl studentFolderControl = new studentFolderControl();
            studentFolderControl.Dock = DockStyle.Fill;
            folderMainPanel.Controls.Add(studentFolderControl);
            */
        }

        private void folderBoardMain_Load(object sender, EventArgs e)
        {

        }

        private void studentFolder_Click(object sender, EventArgs e)
        {

        }

        private void folderHistory_Click(object sender, EventArgs e)
        {


        }

        private void folderArchives_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadStudentFolderControl()
        {
            var studentFolder = new studentFolderControl();
            studentFolder.SwitchToNextControl += loadAddStudentFolderControl;
            studentFolder.SwitchToEditControl += loadEditStudentFolderControl;
            showUserControl(studentFolder);
        }


        public void loadAddStudentFolderControl()
        {
            var addStudentFolder = new addStudentFolder();
            addStudentFolder.SwitchToPreviousControl += loadStudentFolderControl;
            showUserControl(addStudentFolder);
        }

        private void showUserControl(UserControl userControl)
        {
            folderMainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            folderMainPanel.Controls.Add(userControl);
        }

        public void loadEditStudentFolderControl()
        {
            var editStudentFolder = new editStudentFolder();
            editStudentFolder.SwitchToMainControl += loadStudentFolderControl;
            showUserControl (editStudentFolder);
        }
        private void folderMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
