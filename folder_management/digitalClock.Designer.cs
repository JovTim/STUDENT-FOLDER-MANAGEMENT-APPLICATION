namespace folder_management
{
    partial class digitalClock
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
            clock = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clock.Location = new Point(-15, 0);
            clock.Name = "clock";
            clock.Size = new Size(365, 106);
            clock.TabIndex = 0;
            clock.Text = "11:11:11";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date.Location = new Point(3, 106);
            date.Name = "date";
            date.Size = new Size(126, 28);
            date.TabIndex = 1;
            date.Text = "11/11/1111";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // digitalClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(date);
            Controls.Add(clock);
            Name = "digitalClock";
            Size = new Size(364, 148);
            Load += digitalClock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clock;
        private Label date;
        private System.Windows.Forms.Timer timer1;
    }
}
