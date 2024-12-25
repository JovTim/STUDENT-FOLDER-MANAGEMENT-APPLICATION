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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentFolderControl));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            searchBar = new TextBox();
            searchBarText = new Label();
            listFolders = new DataGridView();
            profilePicCol = new DataGridViewImageColumn();
            studentNoCol = new DataGridViewTextBoxColumn();
            studentNameCol = new DataGridViewTextBoxColumn();
            yearCol = new DataGridViewTextBoxColumn();
            blockCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewComboBoxColumn();
            codeCol = new DataGridViewTextBoxColumn();
            addStudent = new Button();
            archiveStudent = new Button();
            toolTipArchive = new ToolTip(components);
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
            searchBar.Size = new Size(936, 40);
            searchBar.TabIndex = 1;
            searchBar.Click += searchBar_Click;
            searchBar.TextChanged += searchBar_TextChanged;
            searchBar.Enter += searchBar_Enter;
            searchBar.Leave += searchBar_Leave;
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
            listFolders.Columns.AddRange(new DataGridViewColumn[] { profilePicCol, studentNoCol, studentNameCol, yearCol, blockCol, statusCol, codeCol });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            listFolders.DefaultCellStyle = dataGridViewCellStyle5;
            listFolders.EnableHeadersVisualStyles = false;
            listFolders.GridColor = SystemColors.Control;
            listFolders.Location = new Point(51, 146);
            listFolders.Name = "listFolders";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Transparent;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            listFolders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            listFolders.RowHeadersVisible = false;
            listFolders.RowHeadersWidth = 100;
            listFolders.RowTemplate.DividerHeight = 5;
            listFolders.RowTemplate.Height = 60;
            listFolders.ScrollBars = ScrollBars.Vertical;
            listFolders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listFolders.Size = new Size(958, 562);
            listFolders.TabIndex = 5;
            listFolders.CellContentClick += listFolders_CellContentClick;
            listFolders.CellFormatting += listFolders_CellFormatting;
            listFolders.CellPainting += listFolders_CellPainting;
            listFolders.CellValueChanged += listFolders_CellValueChanged;
            listFolders.CurrentCellDirtyStateChanged += listFolders_CurrentCellDirtyStateChanged;
            // 
            // profilePicCol
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            profilePicCol.DefaultCellStyle = dataGridViewCellStyle2;
            profilePicCol.HeaderText = "👤";
            profilePicCol.MinimumWidth = 6;
            profilePicCol.Name = "profilePicCol";
            profilePicCol.Resizable = DataGridViewTriState.False;
            profilePicCol.Width = 60;
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
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            studentNameCol.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 5, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            statusCol.DefaultCellStyle = dataGridViewCellStyle4;
            statusCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            statusCol.DividerWidth = 1;
            statusCol.FlatStyle = FlatStyle.Flat;
            statusCol.HeaderText = "STATUS";
            statusCol.MinimumWidth = 6;
            statusCol.Name = "statusCol";
            statusCol.Width = 140;
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
            // addStudent
            // 
            addStudent.Location = new Point(926, 89);
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
            archiveStudent.Location = new Point(859, 89);
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
            // studentFolderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(archiveStudent);
            Controls.Add(addStudent);
            Controls.Add(listFolders);
            Controls.Add(searchBarText);
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
        private Label searchBarText;
        private DataGridView listFolders;
        private Button addStudent;
        private Button archiveStudent;
        private ToolTip toolTipArchive;
        private DataGridViewImageColumn profilePicCol;
        private DataGridViewTextBoxColumn studentNoCol;
        private DataGridViewTextBoxColumn studentNameCol;
        private DataGridViewTextBoxColumn yearCol;
        private DataGridViewTextBoxColumn blockCol;
        private DataGridViewComboBoxColumn statusCol;
        private DataGridViewTextBoxColumn codeCol;
    }
}
