﻿namespace folder_management
{
    partial class studentFolderHistoryControl
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
            historyList = new DataGridView();
            studentNoCol = new DataGridViewTextBoxColumn();
            studentNameCol = new DataGridViewTextBoxColumn();
            historyStatusCol = new DataGridViewTextBoxColumn();
            historyDateCol = new DataGridViewTextBoxColumn();
            codeCol = new DataGridViewTextBoxColumn();
            informationCol = new DataGridViewTextBoxColumn();
            btnFirst = new Button();
            btnPrev = new Button();
            btnLast = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)historyList).BeginInit();
            SuspendLayout();
            // 
            // historyList
            // 
            historyList.AllowUserToAddRows = false;
            historyList.AllowUserToDeleteRows = false;
            historyList.AllowUserToOrderColumns = true;
            historyList.AllowUserToResizeColumns = false;
            historyList.AllowUserToResizeRows = false;
            historyList.BackgroundColor = SystemColors.Control;
            historyList.BorderStyle = BorderStyle.None;
            historyList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(92, 225, 230);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            historyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            historyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyList.Columns.AddRange(new DataGridViewColumn[] { studentNoCol, studentNameCol, historyStatusCol, historyDateCol, codeCol, informationCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            historyList.DefaultCellStyle = dataGridViewCellStyle3;
            historyList.EnableHeadersVisualStyles = false;
            historyList.GridColor = SystemColors.Control;
            historyList.Location = new Point(113, 81);
            historyList.Name = "historyList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            historyList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            historyList.RowHeadersVisible = false;
            historyList.RowHeadersWidth = 100;
            historyList.RowTemplate.DividerHeight = 5;
            historyList.RowTemplate.Height = 60;
            historyList.ScrollBars = ScrollBars.Vertical;
            historyList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            historyList.Size = new Size(1282, 562);
            historyList.TabIndex = 6;
            historyList.CellFormatting += historyList_CellFormatting;
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
            // historyStatusCol
            // 
            historyStatusCol.HeaderText = "STATUS";
            historyStatusCol.MinimumWidth = 6;
            historyStatusCol.Name = "historyStatusCol";
            historyStatusCol.ReadOnly = true;
            historyStatusCol.Width = 125;
            // 
            // historyDateCol
            // 
            historyDateCol.HeaderText = "DATE";
            historyDateCol.MinimumWidth = 6;
            historyDateCol.Name = "historyDateCol";
            historyDateCol.Width = 250;
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
            // informationCol
            // 
            informationCol.HeaderText = "INFORMATION";
            informationCol.MinimumWidth = 6;
            informationCol.Name = "informationCol";
            informationCol.Width = 400;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(1089, 649);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(72, 58);
            btnFirst.TabIndex = 7;
            btnFirst.Text = "FIRST";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(1167, 649);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(72, 58);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "PREV";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnLast
            // 
            btnLast.Enabled = false;
            btnLast.Location = new Point(1323, 649);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(72, 58);
            btnLast.TabIndex = 10;
            btnLast.Text = "LAST";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1245, 649);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(72, 58);
            btnNext.TabIndex = 9;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // studentFolderHistoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnFirst);
            Controls.Add(historyList);
            Name = "studentFolderHistoryControl";
            Size = new Size(1473, 740);
            Load += studentFolderHistoryControl_Load;
            ((System.ComponentModel.ISupportInitialize)historyList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView historyList;
        private DataGridViewTextBoxColumn studentNoCol;
        private DataGridViewTextBoxColumn studentNameCol;
        private DataGridViewTextBoxColumn historyStatusCol;
        private DataGridViewTextBoxColumn historyDateCol;
        private DataGridViewTextBoxColumn codeCol;
        private DataGridViewTextBoxColumn informationCol;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnLast;
        private Button btnNext;
    }
}
