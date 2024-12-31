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
            archiveList = new DataGridView();
            studentNoCol = new DataGridViewTextBoxColumn();
            lastNameCol = new DataGridViewTextBoxColumn();
            firstNameCol = new DataGridViewTextBoxColumn();
            middleName = new DataGridViewTextBoxColumn();
            dateCol = new DataGridViewTextBoxColumn();
            deleteButton = new Button();
            unarchiveButton = new Button();
            btnLast = new Button();
            btnNext = new Button();
            btnPrev = new Button();
            btnFirst = new Button();
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
            // btnLast
            // 
            btnLast.Enabled = false;
            btnLast.Location = new Point(1334, 657);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(72, 58);
            btnLast.TabIndex = 14;
            btnLast.Text = "LAST";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1256, 657);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(72, 58);
            btnNext.TabIndex = 13;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(1178, 657);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(72, 58);
            btnPrev.TabIndex = 12;
            btnPrev.Text = "PREV";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(1100, 657);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(72, 58);
            btnFirst.TabIndex = 11;
            btnFirst.Text = "FIRST";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // studentFolderArchiveControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnFirst);
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
        private Button btnLast;
        private Button btnNext;
        private Button btnPrev;
        private Button btnFirst;
    }
}
