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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            mainFormTitle = new Label();
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
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            panel7 = new Panel();
            line1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainFormTitle
            // 
            mainFormTitle.AutoSize = true;
            mainFormTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormTitle.Location = new Point(123, -15);
            mainFormTitle.Name = "mainFormTitle";
            mainFormTitle.Size = new Size(183, 81);
            mainFormTitle.TabIndex = 0;
            mainFormTitle.Text = "Folds";
            mainFormTitle.Click += mainFormTitle_Click;
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
            dashBoardButton.FlatAppearance.BorderColor = SystemColors.Control;
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
            folderButton.FlatAppearance.BorderColor = SystemColors.Control;
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
            historyButton.FlatAppearance.BorderColor = SystemColors.Control;
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
            archiveButton.FlatAppearance.BorderColor = SystemColors.Control;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(217, 217, 217);
            panel6.Location = new Point(897, 65);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 3);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(217, 217, 217);
            panel7.Location = new Point(1143, 65);
            panel7.Name = "panel7";
            panel7.Size = new Size(231, 3);
            panel7.TabIndex = 10;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1497, 836);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(pictureBox1);
            Controls.Add(archiveButton);
            Controls.Add(panel5);
            Controls.Add(historyButton);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(folderButton);
            Controls.Add(panel1);
            Controls.Add(dashBoardButton);
            Controls.Add(line1);
            Controls.Add(mainFormTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mainForm_Load;
            line1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainFormTitle;
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
        private PictureBox pictureBox1;
        private Panel panel6;
        private Panel panel7;
    }
}
