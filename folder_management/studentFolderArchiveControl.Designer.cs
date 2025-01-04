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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentFolderArchiveControl));
            archiveList = new DataGridView();
            studentNoCol = new DataGridViewTextBoxColumn();
            lastNameCol = new DataGridViewTextBoxColumn();
            firstNameCol = new DataGridViewTextBoxColumn();
            middleName = new DataGridViewTextBoxColumn();
            dateCol = new DataGridViewTextBoxColumn();
            deleteButton = new Button();
            unarchiveButton = new Button();
            btnNext = new Button();
            btnPrev = new Button();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(92, 225, 230);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            archiveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            archiveList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            archiveList.Columns.AddRange(new DataGridViewColumn[] { studentNoCol, lastNameCol, firstNameCol, middleName, dateCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            archiveList.DefaultCellStyle = dataGridViewCellStyle3;
            archiveList.EnableHeadersVisualStyles = false;
            archiveList.GridColor = SystemColors.Control;
            archiveList.Location = new Point(95, 89);
            archiveList.Name = "archiveList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            archiveList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            lastNameCol.DefaultCellStyle = dataGridViewCellStyle2;
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
            deleteButton.BackColor = Color.Transparent;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.BackgroundImageLayout = ImageLayout.Zoom;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(1292, 35);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(50, 48);
            deleteButton.TabIndex = 8;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // unarchiveButton
            // 
            unarchiveButton.BackColor = Color.Transparent;
            unarchiveButton.BackgroundImage = (Image)resources.GetObject("unarchiveButton.BackgroundImage");
            unarchiveButton.BackgroundImageLayout = ImageLayout.Zoom;
            unarchiveButton.FlatAppearance.BorderSize = 0;
            unarchiveButton.FlatStyle = FlatStyle.Flat;
            unarchiveButton.Location = new Point(1356, 35);
            unarchiveButton.Name = "unarchiveButton";
            unarchiveButton.Size = new Size(50, 48);
            unarchiveButton.TabIndex = 9;
            unarchiveButton.UseVisualStyleBackColor = false;
            unarchiveButton.Click += unarchiveButton_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Zoom;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(1356, 657);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(50, 48);
            btnNext.TabIndex = 13;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Transparent;
            btnPrev.BackgroundImage = (Image)resources.GetObject("btnPrev.BackgroundImage");
            btnPrev.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Location = new Point(1292, 657);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(50, 48);
            btnPrev.TabIndex = 12;
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // studentFolderArchiveControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
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
        private Button btnNext;
        private Button btnPrev;
    }
}
