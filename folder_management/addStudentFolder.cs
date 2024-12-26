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
    public partial class addStudentFolder : UserControl
    {
        public event Action? SwitchToPreviousControl;
        private sqliteDataAccess dataAccess;
        private programTools? programTools;
        public addStudentFolder()
        {
            InitializeComponent();

            dataAccess = new sqliteDataAccess();
            programTools = new programTools();
        }

        private void addStudentFolder_Load(object sender, EventArgs e)
        {

        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {
            SwitchToPreviousControl?.Invoke();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string profileUrl = programTools.convertToDownloadableLink(profileUrlTextBox.Text);

            dataAccess.insertFolder(profileUrl, studentNumberTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, middleNameTextBox.Text, Convert.ToInt32(yearTextBox.Text), Convert.ToInt32(blockTextBox.Text), 1, codeTextBox.Text);
        }
    }
}
