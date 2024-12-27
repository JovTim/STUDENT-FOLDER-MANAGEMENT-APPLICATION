namespace folder_management
{
    partial class editStudentFolder
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
            addContentButton = new Button();
            updateButton = new Button();
            label11 = new Label();
            studentNumberTextBox = new TextBox();
            panel1 = new Panel();
            photoPreviewBox = new PictureBox();
            label10 = new Label();
            contentLists = new ListView();
            listContents = new ColumnHeader();
            addNewContent = new TextBox();
            label9 = new Label();
            contentListsComboBox = new ComboBox();
            label8 = new Label();
            codeTextBox = new TextBox();
            label7 = new Label();
            blockTextBox = new TextBox();
            label6 = new Label();
            yearTextBox = new TextBox();
            label5 = new Label();
            middleNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            label2 = new Label();
            profileUrlTextBox = new TextBox();
            addCancelButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photoPreviewBox).BeginInit();
            SuspendLayout();
            // 
            // addContentButton
            // 
            addContentButton.BackColor = Color.FromArgb(92, 225, 230);
            addContentButton.FlatAppearance.BorderColor = Color.FromArgb(92, 225, 230);
            addContentButton.FlatAppearance.BorderSize = 0;
            addContentButton.FlatStyle = FlatStyle.Flat;
            addContentButton.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addContentButton.Location = new Point(357, 468);
            addContentButton.Name = "addContentButton";
            addContentButton.Size = new Size(104, 39);
            addContentButton.TabIndex = 62;
            addContentButton.Text = "ADD";
            addContentButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(92, 225, 230);
            updateButton.FlatAppearance.BorderColor = Color.FromArgb(92, 225, 230);
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(830, 634);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(129, 59);
            updateButton.TabIndex = 61;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(27, 159);
            label11.Name = "label11";
            label11.Size = new Size(195, 28);
            label11.TabIndex = 60;
            label11.Text = "STUDENT NUMBER";
            // 
            // studentNumberTextBox
            // 
            studentNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            studentNumberTextBox.Location = new Point(27, 190);
            studentNumberTextBox.Name = "studentNumberTextBox";
            studentNumberTextBox.Size = new Size(251, 27);
            studentNumberTextBox.TabIndex = 59;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(photoPreviewBox);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(651, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 364);
            panel1.TabIndex = 58;
            // 
            // photoPreviewBox
            // 
            photoPreviewBox.Location = new Point(3, 31);
            photoPreviewBox.Name = "photoPreviewBox";
            photoPreviewBox.Size = new Size(437, 330);
            photoPreviewBox.TabIndex = 35;
            photoPreviewBox.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(171, 28);
            label10.TabIndex = 34;
            label10.Text = "PHOTO PREVIEW";
            // 
            // contentLists
            // 
            contentLists.Columns.AddRange(new ColumnHeader[] { listContents });
            contentLists.Location = new Point(27, 525);
            contentLists.Name = "contentLists";
            contentLists.Size = new Size(526, 176);
            contentLists.TabIndex = 57;
            contentLists.UseCompatibleStateImageBehavior = false;
            contentLists.View = View.Details;
            // 
            // listContents
            // 
            listContents.Text = "FOLDER CONTENTS";
            listContents.Width = 520;
            // 
            // addNewContent
            // 
            addNewContent.BorderStyle = BorderStyle.FixedSingle;
            addNewContent.Location = new Point(27, 473);
            addNewContent.Name = "addNewContent";
            addNewContent.Size = new Size(292, 27);
            addNewContent.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 389);
            label9.Name = "label9";
            label9.Size = new Size(197, 28);
            label9.TabIndex = 55;
            label9.Text = "FOLDER CONTENTS";
            // 
            // contentListsComboBox
            // 
            contentListsComboBox.FormattingEnabled = true;
            contentListsComboBox.Location = new Point(27, 420);
            contentListsComboBox.Name = "contentListsComboBox";
            contentListsComboBox.Size = new Size(292, 28);
            contentListsComboBox.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(483, 315);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 53;
            label8.Text = "CODE";
            // 
            // codeTextBox
            // 
            codeTextBox.BorderStyle = BorderStyle.FixedSingle;
            codeTextBox.Location = new Point(483, 346);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(70, 27);
            codeTextBox.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(391, 315);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 51;
            label7.Text = "BLOCK";
            // 
            // blockTextBox
            // 
            blockTextBox.BorderStyle = BorderStyle.FixedSingle;
            blockTextBox.Location = new Point(391, 346);
            blockTextBox.Name = "blockTextBox";
            blockTextBox.Size = new Size(70, 27);
            blockTextBox.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(302, 315);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 49;
            label6.Text = "YEAR";
            // 
            // yearTextBox
            // 
            yearTextBox.BorderStyle = BorderStyle.FixedSingle;
            yearTextBox.Location = new Point(302, 346);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(70, 27);
            yearTextBox.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 315);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 47;
            label5.Text = "MIDDLE NAME";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            middleNameTextBox.Location = new Point(27, 346);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(251, 27);
            middleNameTextBox.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 235);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 45;
            label4.Text = "LAST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 235);
            label3.Name = "label3";
            label3.Size = new Size(130, 28);
            label3.TabIndex = 44;
            label3.Text = "FIRST NAME";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Location = new Point(302, 266);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(251, 27);
            lastNameTextBox.TabIndex = 43;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Location = new Point(27, 266);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(251, 27);
            firstNameTextBox.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 87);
            label2.Name = "label2";
            label2.Size = new Size(292, 28);
            label2.TabIndex = 41;
            label2.Text = "GOOGLE DRIVE PICTURE LINK";
            // 
            // profileUrlTextBox
            // 
            profileUrlTextBox.BorderStyle = BorderStyle.FixedSingle;
            profileUrlTextBox.Location = new Point(27, 118);
            profileUrlTextBox.Name = "profileUrlTextBox";
            profileUrlTextBox.Size = new Size(526, 27);
            profileUrlTextBox.TabIndex = 40;
            // 
            // addCancelButton
            // 
            addCancelButton.BackColor = SystemColors.AppWorkspace;
            addCancelButton.FlatAppearance.BorderColor = SystemColors.ControlLight;
            addCancelButton.FlatAppearance.BorderSize = 0;
            addCancelButton.FlatStyle = FlatStyle.Flat;
            addCancelButton.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCancelButton.Location = new Point(965, 634);
            addCancelButton.Name = "addCancelButton";
            addCancelButton.Size = new Size(129, 59);
            addCancelButton.TabIndex = 39;
            addCancelButton.Text = "CANCEL";
            addCancelButton.UseVisualStyleBackColor = false;
            addCancelButton.Click += addCancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(525, 54);
            label1.TabIndex = 38;
            label1.Text = "UPDATE STUDENT FOLDER";
            // 
            // editStudentFolder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(addContentButton);
            Controls.Add(updateButton);
            Controls.Add(label11);
            Controls.Add(studentNumberTextBox);
            Controls.Add(panel1);
            Controls.Add(contentLists);
            Controls.Add(addNewContent);
            Controls.Add(label9);
            Controls.Add(contentListsComboBox);
            Controls.Add(label8);
            Controls.Add(codeTextBox);
            Controls.Add(label7);
            Controls.Add(blockTextBox);
            Controls.Add(label6);
            Controls.Add(yearTextBox);
            Controls.Add(label5);
            Controls.Add(middleNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label2);
            Controls.Add(profileUrlTextBox);
            Controls.Add(addCancelButton);
            Controls.Add(label1);
            Name = "editStudentFolder";
            Size = new Size(1104, 708);
            Load += editStudentFolder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)photoPreviewBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addContentButton;
        private Button updateButton;
        private Label label11;
        private TextBox studentNumberTextBox;
        private Panel panel1;
        private PictureBox photoPreviewBox;
        private Label label10;
        private ListView contentLists;
        private ColumnHeader listContents;
        private TextBox addNewContent;
        private Label label9;
        private ComboBox contentListsComboBox;
        private Label label8;
        private TextBox codeTextBox;
        private Label label7;
        private TextBox blockTextBox;
        private Label label6;
        private TextBox yearTextBox;
        private Label label5;
        private TextBox middleNameTextBox;
        private Label label4;
        private Label label3;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label label2;
        private TextBox profileUrlTextBox;
        private Button addCancelButton;
        private Label label1;
    }
}
