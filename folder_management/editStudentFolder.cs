﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_management
{
    public partial class editStudentFolder : UserControl
    {
        public event Action? SwitchToMainControl;
        private sqliteDataAccess dataAccess;
        public editStudentFolder()
        {
            InitializeComponent();

            dataAccess = new sqliteDataAccess();
        }

        private void editStudentFolder_Load(object sender, EventArgs e)
        {
            loadStudentData();
        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {
            SwitchToMainControl?.Invoke();
        }

        private void loadStudentData()
        {
            if (dataAccess == null)
            {
                MessageBox.Show("Data access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load data from the database
            var folderData = dataAccess.LoadEditFolderData();

            if (folderData == null || folderData.Count == 0)
            {
                MessageBox.Show("No data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var studentInfos = folderData.Select(i => (
            Url: i[0],
            studentNo: i[1],
            firstName: i[2],
            lastName: i[3],
            middleName: i[4],
            year: i[5],
            block: i[6],
            code: i[7]
            )).ToList();

            foreach (var i in studentInfos)
            {
                profileUrlTextBox.Text = i.Url;
                studentNumberTextBox.Text = i.studentNo;
                firstNameTextBox.Text = i.firstName;
                lastNameTextBox.Text = i.lastName;
                middleNameTextBox.Text = i.middleName;
                yearTextBox.Text = i.year;
                blockTextBox.Text = i.block;
                codeTextBox.Text = i.code;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
