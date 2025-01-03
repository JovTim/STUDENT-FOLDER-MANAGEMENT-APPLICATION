using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_management
{
    public partial class dashBoardMain : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        sqliteDataAccess dataAccess;
        private static bool isCheckFoldersCalled;
        public dashBoardMain()
        {
            InitializeComponent();
            dataAccess = new sqliteDataAccess();
        }

        private void dashBoardMain_Load(object sender, EventArgs e)
        {
            if (!isCheckFoldersCalled) // Check if it has been called
            {
                checkFolders();
                isCheckFoldersCalled = true;
            }
            panelRoundEdges();

            loadStats();
        }


        public void checkFolders()
        {
            dataAccess.checkEncodeDates();
        }

        public void panelRoundEdges()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));

            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 100, 100));

            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width,
            panel3.Height, 100, 100));

            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width,
            panel4.Height, 100, 100));

            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width,
            panel5.Height, 100, 100));

            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width,
            panel6.Height, 30, 30));

            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width,
            panel7.Height, 30, 30));

            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width,
            panel8.Height, 30, 30));

            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width,
            panel9.Height, 30, 30));

            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width,
            panel10.Height, 30, 30));

        }

        public void loadStats()
        {
            totalFolders.Text = dataAccess.totalFolders().ToString();
            officeFolders.Text = dataAccess.totalOfficeFolders().ToString();
            encodingFolders.Text = dataAccess.totalEncodingFolders().ToString();
            missingFolders.Text = dataAccess.totalMissingFolders().ToString();
            archivedFolders.Text = dataAccess.totalArchivedFolders().ToString();

            loadTotalFirst();
            loadTotalSecond();
            loadTotalThird();
            loadTotalFourth();
            loadTotalIrregular();
        }


        private void loadTotalFirst()
        {
            List<int> firstData = dataAccess.totalFirstYear();

            totalFirstYear.Text = firstData[0].ToString();
            firstYearOffice.Text = firstData[1].ToString();
            firstYearEncoding.Text = firstData[2].ToString();
            firstYearMissing.Text = firstData[3].ToString();
        }

        private void loadTotalSecond()
        {
            List<int> secondData = dataAccess.totalSecondYear();

            totalSecondYear.Text = secondData[0].ToString();
            secondYearOffice.Text = secondData[1].ToString();
            secondYearEncoding.Text = secondData[2].ToString();
            secondYearMissing.Text = secondData[3].ToString();
        }

        private void loadTotalThird()
        {
            List<int> thirdData = dataAccess.totalThirdYear();

            totalThirdYear.Text = thirdData[0].ToString();
            thirdYearOffice.Text = thirdData[1].ToString();
            thirdYearEncoding.Text = thirdData[2].ToString();
            thirdYearMissing.Text = thirdData[3].ToString();
        }

        private void loadTotalFourth()
        {
            List<int> fourthData = dataAccess.totalFourthYear();

            totalFourthYear.Text = fourthData[0].ToString();
            fourthYearOffice.Text = fourthData[1].ToString();
            fourthYearEncoding.Text = fourthData[2].ToString();
            fourthYearMissing.Text = fourthData[3].ToString();
        }

        private void loadTotalIrregular()
        {
            List<int> irregularData = dataAccess.totalIrregular();

            totalIrregular.Text = irregularData[0].ToString();
            irregOffice.Text = irregularData[1].ToString();
            irregEncoding.Text = irregularData[2].ToString();
            irregMissing.Text = irregularData[3].ToString();
        }
    }
}
