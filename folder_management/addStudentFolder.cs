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
        private verificationTool? verificationTool;
        public addStudentFolder()
        {
            InitializeComponent();

            dataAccess = new sqliteDataAccess();
            programTools = new programTools();
            verificationTool = new verificationTool();
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
            if (ValidateInputs() && !(ValidateInputs2()))
            {
                string profileUrl = string.IsNullOrWhiteSpace(profileUrlTextBox.Text)
                    ? "https://drive.google.com/uc?export=download&id=1mVxkZkivUqkKST3CePQ72O93N135VHxw"
                    : programTools.convertToDownloadableLink(profileUrlTextBox.Text);

                string middleName = string.IsNullOrWhiteSpace(middleNameTextBox.Text) ? "-" : middleNameTextBox.Text;

                dataAccess.insertFolder(
                    profileUrl,
                    studentNumberTextBox.Text,
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    middleName,
                    Convert.ToInt32(yearTextBox.Text),
                    Convert.ToInt32(blockTextBox.Text),
                    1,
                    codeTextBox.Text);

                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Invalid input/s. Please try again!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool ValidateInputs()
        {
            return verificationTool.validateUrl(profileUrlTextBox.Text) &&
                   verificationTool.validateName(firstNameTextBox.Text) &&
                   verificationTool.validateName(lastNameTextBox.Text) &&
                   verificationTool.validateName(middleNameTextBox.Text) &&
                   verificationTool.validateNumber(yearTextBox.Text) &&
                   verificationTool.validateNumber(blockTextBox.Text) &&
                   verificationTool.validateCode(codeTextBox.Text);
        }

        private bool ValidateInputs2()
        {
            return string.IsNullOrWhiteSpace(firstNameTextBox.Text) &&
                    string.IsNullOrWhiteSpace(lastNameTextBox.Text) &&
                    string.IsNullOrWhiteSpace(yearTextBox.Text) &&
                    string.IsNullOrWhiteSpace(blockTextBox.Text) &&
                    string.IsNullOrWhiteSpace(codeTextBox.Text);
        }

        private void ClearTextBoxes()
        {
            profileUrlTextBox.Text = string.Empty;
            studentNumberTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            blockTextBox.Text = string.Empty;
            codeTextBox.Text = string.Empty;
        }
    }
}
