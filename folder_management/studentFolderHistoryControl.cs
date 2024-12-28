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
    public partial class studentFolderHistoryControl : UserControl
    {
        private sqliteDataAccess dataAccess;
        public studentFolderHistoryControl()
        {
            InitializeComponent();

            dataAccess = new sqliteDataAccess();
        }

        private void studentFolderHistoryControl_Load(object sender, EventArgs e)
        {
            //sampleData();
            historyFolderLoad();
        }

        private void sampleData()
        {
            List<string[]> sampleData = new List<string[]>
                {
                    new string[] {"202287413", "FORD, HENRY CIVIL", "RETURNED", "2022-12-12", "A01", "" },
                    new string[] {"202280121", "GANA, SARA MAL", "BORROWED", "2022-12-12", "A21", "" },
                    new string[] { "202370131", "WATSON, GARY SMILE", "ARCHIVED", "2022-12-12", "B12", "" },
                    new string[] { "202150431", "MONROE, JAMES PENNY", "RETURNED", "2022-12-12", "C15", "" },
                    new string[] { "202290001", "ADAMS, LOUISE -", "UPDATED", "2022-12-12", "A19", "YEAR, BLOCK" },
                    new string[] { "202103123", "MANSON, HARRY STYLES", "ADDED", "2022-12-12", "B41", "" },
                    new string[] { "202160132", "WILLIAM, BOB MARLEY", "BORROWED", "2022-12-12", "A09", "" },
                    new string[] { "202301231", "PARKER, JANE -", "MISSING", "2022-12-12", "A05", "" },
                };

            foreach (var row in sampleData)
            {
                historyList.Rows.Add(row);
            }
        }

        private void historyFolderLoad()
        {
            if (dataAccess == null)
            {
                MessageBox.Show("Data access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var historyFolderData = dataAccess.loadFolderHistory();

            if (historyFolderData == null || historyFolderData.Count == 0)
            {
                MessageBox.Show("No data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var historyInfos = historyFolderData.Select(i => (
                studentNumber: i[0],
                fullName: i[1],
                historyType: i[2],
                historyDate: i[3],
                code: i[4],
                information: i[5]
            )).ToList();

            foreach (var i in historyInfos)
            {
                historyList.Rows.Add(i.studentNumber, i.fullName.ToUpper(),  i.historyType, i.historyDate, i.code, i.information);
            }
        }

        private void historyList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = historyList.Rows[e.RowIndex];

                if (row.Cells[2].Value.ToString() == "RETURNED")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7ed957");
                }
                else if (row.Cells[2].Value.ToString() == "BORROWED")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#a6a6a6");
                }
                else if (row.Cells[2].Value.ToString() == "ARCHIVED")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ffde59");
                }
                else if (row.Cells[2].Value.ToString() == "MISSING")
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ff5757");
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
