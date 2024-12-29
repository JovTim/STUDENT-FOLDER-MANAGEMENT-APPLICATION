namespace folder_management
{
    partial class studentFolderArchiveControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            archiveList = new DataGridView();
            studentNoCol = new DataGridViewTextBoxColumn();
            lastNameCol = new DataGridViewTextBoxColumn();
            firstNameCol = new DataGridViewTextBoxColumn();
            middleName = new DataGridViewTextBoxColumn();
            dateCol = new DataGridViewTextBoxColumn();
            deleteButton = new Button();
            unarchiveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)archiveList).BeginInit();
            SuspendLayout();
            // 
            // archiveList
            // 
            archiveList.AllowUserToAddRows = false;
            archiveList.AllowUserToDeleteRows = false;
            archiveList.AllowUserToOrderColumns = true;
            archiveList.AllowUserToResizeColumns = false;
            archiveList.AllowUserToResizeRows = false;
            archiveList.BackgroundColor = SystemColors.Control;
            archiveList.BorderStyle = BorderStyle.None;
            archiveList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(92, 225, 230);
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            archiveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            archiveList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            archiveList.Columns.AddRange(new DataGridViewColumn[] { studentNoCol, lastNameCol, firstNameCol, middleName, dateCol });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            archiveList.DefaultCellStyle = dataGridViewCellStyle7;
            archiveList.EnableHeadersVisualStyles = false;
            archiveList.GridColor = SystemColors.Control;
            archiveList.Location = new Point(95, 89);
            archiveList.Name = "archiveList";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Transparent;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            archiveList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            archiveList.RowHeadersVisible = false;
            archiveList.RowHeadersWidth = 100;
            archiveList.RowTemplate.DividerHeight = 5;
            archiveList.RowTemplate.Height = 60;
            archiveList.ScrollBars = ScrollBars.Vertical;
            archiveList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            archiveList.Size = new Size(1311, 562);
            archiveList.TabIndex = 7;
            // 
            // studentNoCol
            // 
            studentNoCol.HeaderText = "STUDENT NO";
            studentNoCol.MinimumWidth = 6;
            studentNoCol.Name = "studentNoCol";
            studentNoCol.ReadOnly = true;
            studentNoCol.Width = 150;
            // 
            // lastNameCol
            // 
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            lastNameCol.DefaultCellStyle = dataGridViewCellStyle6;
            lastNameCol.HeaderText = "LAST NAME";
            lastNameCol.MinimumWidth = 6;
            lastNameCol.Name = "lastNameCol";
            lastNameCol.ReadOnly = true;
            lastNameCol.Width = 290;
            // 
            // firstNameCol
            // 
            firstNameCol.HeaderText = "FIRST NAME";
            firstNameCol.MinimumWidth = 6;
            firstNameCol.Name = "firstNameCol";
            firstNameCol.Width = 290;
            // 
            // middleName
            // 
            middleName.HeaderText = "MIDDLE NAME";
            middleName.MinimumWidth = 6;
            middleName.Name = "middleName";
            middleName.Width = 290;
            // 
            // dateCol
            // 
            dateCol.HeaderText = "ARCHIVE DATE";
            dateCol.MinimumWidth = 6;
            dateCol.Name = "dateCol";
            dateCol.Width = 290;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1246, 24);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(77, 59);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "🗑️";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // unarchiveButton
            // 
            unarchiveButton.Location = new Point(1329, 24);
            unarchiveButton.Name = "unarchiveButton";
            unarchiveButton.Size = new Size(77, 59);
            unarchiveButton.TabIndex = 9;
            unarchiveButton.Text = "/\\";
            unarchiveButton.UseVisualStyleBackColor = true;
            unarchiveButton.Click += unarchiveButton_Click;
            // 
            // studentFolderArchiveControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(unarchiveButton);
            Controls.Add(deleteButton);
            Controls.Add(archiveList);
            Name = "studentFolderArchiveControl";
            Size = new Size(1473, 740);
            Load += studentFolderArchiveControl_Load;
            ((System.ComponentModel.ISupportInitialize)archiveList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView archiveList;
        private DataGridViewTextBoxColumn studentNoCol;
        private DataGridViewTextBoxColumn lastNameCol;
        private DataGridViewTextBoxColumn firstNameCol;
        private DataGridViewTextBoxColumn middleName;
        private DataGridViewTextBoxColumn dateCol;
        private Button deleteButton;
        private Button unarchiveButton;
    }
}
