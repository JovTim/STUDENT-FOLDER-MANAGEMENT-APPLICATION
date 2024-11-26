namespace folder_management
{
    partial class folderBoardMain
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
            panel1 = new Panel();
            studentFolder = new Button();
            folderHistory = new Button();
            panel2 = new Panel();
            folderArchives = new Button();
            panel3 = new Panel();
            folderMainPanel = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 225, 230);
            panel1.Location = new Point(31, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 3);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // studentFolder
            // 
            studentFolder.BackColor = Color.Transparent;
            studentFolder.FlatAppearance.BorderSize = 0;
            studentFolder.FlatStyle = FlatStyle.Flat;
            studentFolder.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            studentFolder.Location = new Point(31, 6);
            studentFolder.Name = "studentFolder";
            studentFolder.Size = new Size(250, 56);
            studentFolder.TabIndex = 6;
            studentFolder.Text = "STUDENT FOLDER";
            studentFolder.UseVisualStyleBackColor = false;
            studentFolder.Click += studentFolder_Click;
            // 
            // folderHistory
            // 
            folderHistory.BackColor = Color.Transparent;
            folderHistory.FlatAppearance.BorderSize = 0;
            folderHistory.FlatStyle = FlatStyle.Flat;
            folderHistory.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            folderHistory.Location = new Point(31, 77);
            folderHistory.Name = "folderHistory";
            folderHistory.Size = new Size(250, 56);
            folderHistory.TabIndex = 7;
            folderHistory.Text = "HISTORY";
            folderHistory.UseVisualStyleBackColor = false;
            folderHistory.Click += folderHistory_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Location = new Point(31, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 3);
            panel2.TabIndex = 6;
            // 
            // folderArchives
            // 
            folderArchives.BackColor = Color.Transparent;
            folderArchives.FlatAppearance.BorderSize = 0;
            folderArchives.FlatStyle = FlatStyle.Flat;
            folderArchives.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            folderArchives.Location = new Point(31, 148);
            folderArchives.Name = "folderArchives";
            folderArchives.Size = new Size(250, 56);
            folderArchives.TabIndex = 8;
            folderArchives.Text = "ARCHIVES";
            folderArchives.UseVisualStyleBackColor = false;
            folderArchives.Click += folderArchives_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 217, 217);
            panel3.Location = new Point(31, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 3);
            panel3.TabIndex = 6;
            // 
            // folderMainPanel
            // 
            folderMainPanel.BackColor = SystemColors.Control;
            folderMainPanel.Location = new Point(347, 6);
            folderMainPanel.Name = "folderMainPanel";
            folderMainPanel.Size = new Size(1104, 708);
            folderMainPanel.TabIndex = 9;
            folderMainPanel.Paint += folderMainPanel_Paint;
            // 
            // folderBoardMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(folderMainPanel);
            Controls.Add(panel3);
            Controls.Add(folderArchives);
            Controls.Add(panel2);
            Controls.Add(folderHistory);
            Controls.Add(studentFolder);
            Controls.Add(panel1);
            Name = "folderBoardMain";
            Size = new Size(1473, 740);
            Load += folderBoardMain_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button studentFolder;
        private Button folderHistory;
        private Panel panel2;
        private Button folderArchives;
        private Panel panel3;
        private Panel folderMainPanel;
    }
}
