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
    public partial class editStudentFolder : UserControl
    {
        public event Action? SwitchToMainControl;
        public editStudentFolder()
        {
            InitializeComponent();
        }

        private void editStudentFolder_Load(object sender, EventArgs e)
        {

        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {
            SwitchToMainControl?.Invoke();
        }
    }
}
