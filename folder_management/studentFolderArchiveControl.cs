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

            var archive = dataAccess.loadArchiveFolder();

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

            foreach( var i in archiveInfo )
            {
                archiveList.Rows.Add(i.studentNumber, i.lastName.ToUpper(), i.firstName.ToUpper(), i.middleName.ToUpper(), i.date);
            }
        }
    }
}
