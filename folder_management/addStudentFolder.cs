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
        public event Action SwitchToPreviousControl;
        public addStudentFolder()
        {
            InitializeComponent();
        }

        private void addStudentFolder_Load(object sender, EventArgs e)
        {

        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {
            SwitchToPreviousControl?.Invoke();
        }


        /*
        private void addCloseButton_Click(object sender, EventArgs e)
        {
            SwitchToPreviousControl?.Invoke();
        }

        */
    }
}
