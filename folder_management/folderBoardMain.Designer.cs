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
            folderMainPanel = new Panel();
            SuspendLayout();
            // 
            // folderMainPanel
            // 
            folderMainPanel.BackColor = SystemColors.Control;
            folderMainPanel.Location = new Point(199, 6);
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
            Name = "folderBoardMain";
            Size = new Size(1473, 740);
            Load += folderBoardMain_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel folderMainPanel;
    }
}
