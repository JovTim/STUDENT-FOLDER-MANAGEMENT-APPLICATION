namespace folder_management
{
    partial class studentFolderControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            searchBar = new TextBox();
            searchButton = new Button();
            searchBarText = new Label();
            listFolders = new DataGridView();
            addStudent = new Button();
            archiveStudent = new Button();
            toolTipArchive = new ToolTip(components);
            codeCol = new DataGridViewTextBoxColumn();
            studentNoCol = new DataGridViewTextBoxColumn();
            studentNameCol = new DataGridViewTextBoxColumn();
            yearCol = new DataGridViewTextBoxColumn();
            blockCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewComboBoxColumn();
            containerCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listFolders).BeginInit();
            SuspendLayout();
            // 
            // searchBar
            // 
            searchBar.BackColor = SystemColors.Control;
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Font = new Font("Bahnschrift SemiBold", 16F, FontStyle.Bold);
            searchBar.ForeColor = Color.Black;
            searchBar.Location = new Point(51, 3);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(866, 40);
            searchBar.TabIndex = 1;
            searchBar.Click += searchBar_Click;
            searchBar.TextChanged += searchBar_TextChanged;
            searchBar.Enter += searchBar_Enter;
            searchBar.Leave += searchBar_Leave;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(923, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(61, 48);
            searchButton.TabIndex = 2;
            searchButton.Text = "@-";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // searchBarText
            // 
            searchBarText.AutoSize = true;
            searchBarText.BackColor = Color.Transparent;
            searchBarText.Enabled = false;
            searchBarText.FlatStyle = FlatStyle.Flat;
            searchBarText.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            searchBarText.ForeColor = Color.FromArgb(217, 217, 217);
            searchBarText.Location = new Point(60, 10);
            searchBarText.Name = "searchBarText";
            searchBarText.Size = new Size(285, 24);
            searchBarText.TabIndex = 4;
            searchBarText.Text = "ENTER NAME OR STUDENT NO";
            searchBarText.Click += searchBarText_Click;
            // 
            // listFolders
            // 
            listFolders.AllowUserToAddRows = false;
            listFolders.AllowUserToDeleteRows = false;
            listFolders.AllowUserToOrderColumns = true;
            listFolders.AllowUserToResizeColumns = false;
            listFolders.AllowUserToResizeRows = false;
            listFolders.BackgroundColor = SystemColors.Control;
            listFolders.BorderStyle = BorderStyle.None;
            listFolders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(92, 225, 230);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listFolders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listFolders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listFolders.Columns.AddRange(new DataGridViewColumn[] { codeCol, studentNoCol, studentNameCol, yearCol, blockCol, statusCol, containerCol });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            listFolders.DefaultCellStyle = dataGridViewCellStyle4;
            listFolders.EnableHeadersVisualStyles = false;
            listFolders.GridColor = SystemColors.Control;
            listFolders.Location = new Point(51, 146);
            listFolders.Name = "listFolders";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Transparent;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            listFolders.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            listFolders.RowHeadersVisible = false;
            listFolders.RowHeadersWidth = 100;
            listFolders.RowTemplate.DividerHeight = 5;
            listFolders.RowTemplate.Height = 60;
            listFolders.ScrollBars = ScrollBars.Vertical;
            listFolders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listFolders.Size = new Size(1019, 562);
            listFolders.TabIndex = 5;
            listFolders.CellContentClick += listFolders_CellContentClick;
            listFolders.CellFormatting += listFolders_CellFormatting;
            listFolders.CellValueChanged += listFolders_CellValueChanged;
            listFolders.CurrentCellDirtyStateChanged += listFolders_CurrentCellDirtyStateChanged;
            // 
            // addStudent
            // 
            addStudent.Location = new Point(990, 89);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(61, 48);
            addStudent.TabIndex = 6;
            addStudent.Text = "+";
            toolTipArchive.SetToolTip(addStudent, "Add a new student folder");
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // archiveStudent
            // 
            archiveStudent.Location = new Point(923, 89);
            archiveStudent.Name = "archiveStudent";
            archiveStudent.Size = new Size(61, 48);
            archiveStudent.TabIndex = 7;
            archiveStudent.Text = "\\/";
            toolTipArchive.SetToolTip(archiveStudent, "Archive student folder\r\n- will not delete the folder\r\n- you need to go to the archive tab to manually\r\ndelete the folder");
            archiveStudent.UseVisualStyleBackColor = true;
            archiveStudent.Click += archiveStudent_Click;
            // 
            // toolTipArchive
            // 
            toolTipArchive.Popup += toolTipArchive_Popup;
            // 
            // codeCol
            // 
            codeCol.HeaderText = "CODE";
            codeCol.MinimumWidth = 6;
            codeCol.Name = "codeCol";
            codeCol.ReadOnly = true;
            codeCol.Resizable = DataGridViewTriState.False;
            codeCol.Width = 55;
            // 
            // studentNoCol
            // 
            studentNoCol.HeaderText = "STUDENT NO";
            studentNoCol.MinimumWidth = 6;
            studentNoCol.Name = "studentNoCol";
            studentNoCol.ReadOnly = true;
            studentNoCol.Width = 150;
            // 
            // studentNameCol
            // 
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            studentNameCol.DefaultCellStyle = dataGridViewCellStyle2;
            studentNameCol.HeaderText = "FULL NAME";
            studentNameCol.MinimumWidth = 6;
            studentNameCol.Name = "studentNameCol";
            studentNameCol.ReadOnly = true;
            studentNameCol.Width = 292;
            // 
            // yearCol
            // 
            yearCol.HeaderText = "YEAR";
            yearCol.MinimumWidth = 6;
            yearCol.Name = "yearCol";
            yearCol.ReadOnly = true;
            yearCol.Width = 120;
            // 
            // blockCol
            // 
            blockCol.HeaderText = "BLOCK";
            blockCol.MinimumWidth = 6;
            blockCol.Name = "blockCol";
            blockCol.ReadOnly = true;
            blockCol.Width = 120;
            // 
            // statusCol
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            statusCol.DefaultCellStyle = dataGridViewCellStyle3;
            statusCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            statusCol.DividerWidth = 1;
            statusCol.FlatStyle = FlatStyle.Flat;
            statusCol.HeaderText = "STATUS";
            statusCol.MinimumWidth = 6;
            statusCol.Name = "statusCol";
            statusCol.Width = 140;
            // 
            // containerCol
            // 
            containerCol.HeaderText = "CONTAINER";
            containerCol.MinimumWidth = 6;
            containerCol.Name = "containerCol";
            containerCol.ReadOnly = true;
            containerCol.Width = 120;
            // 
            // studentFolderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(archiveStudent);
            Controls.Add(addStudent);
            Controls.Add(listFolders);
            Controls.Add(searchBarText);
            Controls.Add(searchButton);
            Controls.Add(searchBar);
            Name = "studentFolderControl";
            Size = new Size(1104, 708);
            Load += studentFolderControl_Load;
            ((System.ComponentModel.ISupportInitialize)listFolders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchBar;
        private Button searchButton;
        private Label searchBarText;
        private DataGridView listFolders;
        private Button addStudent;
        private Button archiveStudent;
        private ToolTip toolTipArchive;
        private DataGridViewTextBoxColumn codeCol;
        private DataGridViewTextBoxColumn studentNoCol;
        private DataGridViewTextBoxColumn studentNameCol;
        private DataGridViewTextBoxColumn yearCol;
        private DataGridViewTextBoxColumn blockCol;
        private DataGridViewComboBoxColumn statusCol;
        private DataGridViewTextBoxColumn containerCol;
    }
}
