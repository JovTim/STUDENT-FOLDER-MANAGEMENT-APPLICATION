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
            searchBar = new TextBox();
            searchButton = new Button();
            panel1 = new Panel();
            searchBarText = new Label();
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
            searchBar.Size = new Size(852, 40);
            searchBar.TabIndex = 1;
            searchBar.Click += searchBar_Click;
            searchBar.TextChanged += searchBar_TextChanged;
            searchBar.Enter += searchBar_Enter;
            searchBar.Leave += searchBar_Leave;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(909, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(61, 48);
            searchButton.TabIndex = 2;
            searchButton.Text = "@-";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(51, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 550);
            panel1.TabIndex = 3;
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
            // studentFolderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchBarText);
            Controls.Add(panel1);
            Controls.Add(searchButton);
            Controls.Add(searchBar);
            Name = "studentFolderControl";
            Size = new Size(1104, 708);
            Load += studentFolderControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchBar;
        private Button searchButton;
        private Panel panel1;
        private Label searchBarText;
    }
}
