namespace folder_management
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainFormTitle = new Label();
            logoPlaceHolder = new Label();
            line1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            dashBoardButton = new Button();
            panel1 = new Panel();
            folderButton = new Button();
            panel2 = new Panel();
            mainPanel = new Panel();
            historyButton = new Button();
            panel5 = new Panel();
            archiveButton = new Button();
            line1.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormTitle
            // 
            mainFormTitle.AutoSize = true;
            mainFormTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormTitle.Location = new Point(120, -19);
            mainFormTitle.Name = "mainFormTitle";
            mainFormTitle.Size = new Size(183, 81);
            mainFormTitle.TabIndex = 0;
            mainFormTitle.Text = "Folds";
            mainFormTitle.Click += mainFormTitle_Click;
            // 
            // logoPlaceHolder
            // 
            logoPlaceHolder.AutoSize = true;
            logoPlaceHolder.BackColor = Color.Transparent;
            logoPlaceHolder.FlatStyle = FlatStyle.Flat;
            logoPlaceHolder.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoPlaceHolder.ForeColor = Color.FromArgb(92, 225, 230);
            logoPlaceHolder.Location = new Point(44, -22);
            logoPlaceHolder.Name = "logoPlaceHolder";
            logoPlaceHolder.Size = new Size(92, 81);
            logoPlaceHolder.TabIndex = 2;
            logoPlaceHolder.Text = "@";
            // 
            // line1
            // 
            line1.BackColor = Color.FromArgb(217, 217, 217);
            line1.Controls.Add(panel4);
            line1.Controls.Add(panel3);
            line1.Location = new Point(44, 65);
            line1.Name = "line1";
            line1.Size = new Size(1404, 3);
            line1.TabIndex = 0;
            line1.Paint += line1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(217, 217, 217);
            panel4.Location = new Point(607, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 3);
            panel4.TabIndex = 7;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(92, 225, 230);
            panel3.Location = new Point(361, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 3);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // dashBoardButton
            // 
            dashBoardButton.BackColor = Color.Transparent;
            dashBoardButton.FlatAppearance.BorderSize = 0;
            dashBoardButton.FlatStyle = FlatStyle.Flat;
            dashBoardButton.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashBoardButton.Location = new Point(405, -2);
            dashBoardButton.Name = "dashBoardButton";
            dashBoardButton.Size = new Size(231, 61);
            dashBoardButton.TabIndex = 3;
            dashBoardButton.Text = "DASHBOARD";
            dashBoardButton.UseVisualStyleBackColor = false;
            dashBoardButton.Click += dashBoardButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Location = new Point(642, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 53);
            panel1.TabIndex = 1;
            // 
            // folderButton
            // 
            folderButton.BackColor = Color.Transparent;
            folderButton.FlatAppearance.BorderSize = 0;
            folderButton.FlatStyle = FlatStyle.Flat;
            folderButton.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            folderButton.Location = new Point(651, -2);
            folderButton.Name = "folderButton";
            folderButton.Size = new Size(231, 61);
            folderButton.TabIndex = 4;
            folderButton.Text = "FOLDER";
            folderButton.UseVisualStyleBackColor = false;
            folderButton.Click += folderButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Location = new Point(888, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 53);
            panel2.TabIndex = 2;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Location = new Point(12, 84);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1473, 740);
            mainPanel.TabIndex = 5;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // historyButton
            // 
            historyButton.BackColor = Color.Transparent;
            historyButton.FlatAppearance.BorderSize = 0;
            historyButton.FlatStyle = FlatStyle.Flat;
            historyButton.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyButton.Location = new Point(897, -2);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(231, 61);
            historyButton.TabIndex = 6;
            historyButton.Text = "HISTORY";
            historyButton.UseVisualStyleBackColor = false;
            historyButton.Click += historyButton_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(217, 217, 217);
            panel5.Location = new Point(1134, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(3, 53);
            panel5.TabIndex = 2;
            // 
            // archiveButton
            // 
            archiveButton.BackColor = Color.Transparent;
            archiveButton.FlatAppearance.BorderSize = 0;
            archiveButton.FlatStyle = FlatStyle.Flat;
            archiveButton.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            archiveButton.Location = new Point(1143, -2);
            archiveButton.Name = "archiveButton";
            archiveButton.Size = new Size(231, 61);
            archiveButton.TabIndex = 7;
            archiveButton.Text = "ARCHIVE";
            archiveButton.UseVisualStyleBackColor = false;
            archiveButton.Click += archiveButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1497, 836);
            Controls.Add(archiveButton);
            Controls.Add(panel5);
            Controls.Add(historyButton);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(folderButton);
            Controls.Add(panel1);
            Controls.Add(dashBoardButton);
            Controls.Add(line1);
            Controls.Add(logoPlaceHolder);
            Controls.Add(mainFormTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mainForm_Load;
            line1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainFormTitle;
        private Label logoPlaceHolder;
        private Panel line1;
        private Button dashBoardButton;
        private Panel panel1;
        private Button folderButton;
        private Panel panel2;
        private Panel mainPanel;
        private Panel panel3;
        private Panel panel4;
        private Button historyButton;
        private Panel panel5;
        private Button archiveButton;
    }
}
