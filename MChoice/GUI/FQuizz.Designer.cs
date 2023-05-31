namespace MChoice.GUI
{
    partial class FQuizz
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshQuizz = new System.Windows.Forms.Button();
            this.btnUpdateQuizz = new System.Windows.Forms.Button();
            this.btnRemoveQuizz = new System.Windows.Forms.Button();
            this.btnAddQuizz = new System.Windows.Forms.Button();
            this.cbChapter = new System.Windows.Forms.ComboBox();
            this.lblChapter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.txtAnD = new System.Windows.Forms.TextBox();
            this.txtAnC = new System.Windows.Forms.TextBox();
            this.txtAnB = new System.Windows.Forms.TextBox();
            this.txtAnA = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.dtGVQuizz = new System.Windows.Forms.DataGridView();
            this.dtGVExam = new System.Windows.Forms.DataGridView();
            this.cbSubjectName = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVQuizz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVExam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtGVQuizz);
            this.panel1.Controls.Add(this.dtGVExam);
            this.panel1.Controls.Add(this.cbSubjectName);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 655);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshQuizz);
            this.groupBox1.Controls.Add(this.btnUpdateQuizz);
            this.groupBox1.Controls.Add(this.btnRemoveQuizz);
            this.groupBox1.Controls.Add(this.btnAddQuizz);
            this.groupBox1.Controls.Add(this.cbChapter);
            this.groupBox1.Controls.Add(this.lblChapter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdD);
            this.groupBox1.Controls.Add(this.rdC);
            this.groupBox1.Controls.Add(this.rdB);
            this.groupBox1.Controls.Add(this.rdA);
            this.groupBox1.Controls.Add(this.txtAnD);
            this.groupBox1.Controls.Add(this.txtAnC);
            this.groupBox1.Controls.Add(this.txtAnB);
            this.groupBox1.Controls.Add(this.txtAnA);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(24, 337);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1106, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quizz";
            // 
            // btnRefreshQuizz
            // 
            this.btnRefreshQuizz.BackColor = System.Drawing.Color.White;
            this.btnRefreshQuizz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshQuizz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshQuizz.FlatAppearance.BorderSize = 2;
            this.btnRefreshQuizz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshQuizz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshQuizz.Location = new System.Drawing.Point(849, 188);
            this.btnRefreshQuizz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshQuizz.Name = "btnRefreshQuizz";
            this.btnRefreshQuizz.Size = new System.Drawing.Size(112, 50);
            this.btnRefreshQuizz.TabIndex = 7;
            this.btnRefreshQuizz.Text = "Refresh";
            this.btnRefreshQuizz.UseVisualStyleBackColor = false;
            this.btnRefreshQuizz.Click += new System.EventHandler(this.btnRefreshQuizz_Click);
            this.btnRefreshQuizz.MouseEnter += new System.EventHandler(this.btnRefreshQuizz_MouseEnter);
            this.btnRefreshQuizz.MouseLeave += new System.EventHandler(this.btnRefreshQuizz_MouseLeave);
            // 
            // btnUpdateQuizz
            // 
            this.btnUpdateQuizz.BackColor = System.Drawing.Color.White;
            this.btnUpdateQuizz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateQuizz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateQuizz.FlatAppearance.BorderSize = 2;
            this.btnUpdateQuizz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuizz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateQuizz.Location = new System.Drawing.Point(849, 103);
            this.btnUpdateQuizz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateQuizz.Name = "btnUpdateQuizz";
            this.btnUpdateQuizz.Size = new System.Drawing.Size(112, 50);
            this.btnUpdateQuizz.TabIndex = 7;
            this.btnUpdateQuizz.Text = "Update";
            this.btnUpdateQuizz.UseVisualStyleBackColor = false;
            this.btnUpdateQuizz.Click += new System.EventHandler(this.btnUpdateQuizz_Click);
            this.btnUpdateQuizz.MouseEnter += new System.EventHandler(this.btnUpdateQuizz_MouseEnter);
            this.btnUpdateQuizz.MouseLeave += new System.EventHandler(this.btnUpdateQuizz_MouseLeave);
            // 
            // btnRemoveQuizz
            // 
            this.btnRemoveQuizz.BackColor = System.Drawing.Color.White;
            this.btnRemoveQuizz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveQuizz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveQuizz.FlatAppearance.BorderSize = 2;
            this.btnRemoveQuizz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveQuizz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveQuizz.Location = new System.Drawing.Point(664, 188);
            this.btnRemoveQuizz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveQuizz.Name = "btnRemoveQuizz";
            this.btnRemoveQuizz.Size = new System.Drawing.Size(112, 50);
            this.btnRemoveQuizz.TabIndex = 7;
            this.btnRemoveQuizz.Text = "Remove";
            this.btnRemoveQuizz.UseVisualStyleBackColor = false;
            this.btnRemoveQuizz.Click += new System.EventHandler(this.btnRemoveQuizz_Click);
            this.btnRemoveQuizz.DragLeave += new System.EventHandler(this.btnRemoveQuizz_DragLeave);
            this.btnRemoveQuizz.MouseEnter += new System.EventHandler(this.btnRemoveQuizz_MouseEnter);
            this.btnRemoveQuizz.MouseLeave += new System.EventHandler(this.btnRemoveQuizz_MouseLeave);
            // 
            // btnAddQuizz
            // 
            this.btnAddQuizz.BackColor = System.Drawing.Color.White;
            this.btnAddQuizz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuizz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddQuizz.FlatAppearance.BorderSize = 2;
            this.btnAddQuizz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuizz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddQuizz.Location = new System.Drawing.Point(664, 103);
            this.btnAddQuizz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddQuizz.Name = "btnAddQuizz";
            this.btnAddQuizz.Size = new System.Drawing.Size(112, 50);
            this.btnAddQuizz.TabIndex = 7;
            this.btnAddQuizz.Text = "Add";
            this.btnAddQuizz.UseVisualStyleBackColor = false;
            this.btnAddQuizz.Click += new System.EventHandler(this.btnAddQuizz_Click);
            this.btnAddQuizz.MouseEnter += new System.EventHandler(this.btnAddQuizz_MouseEnter);
            this.btnAddQuizz.MouseLeave += new System.EventHandler(this.btnAddQuizz_MouseLeave);
            // 
            // cbChapter
            // 
            this.cbChapter.FormattingEnabled = true;
            this.cbChapter.Location = new System.Drawing.Point(664, 31);
            this.cbChapter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbChapter.Name = "cbChapter";
            this.cbChapter.Size = new System.Drawing.Size(297, 30);
            this.cbChapter.TabIndex = 6;
            // 
            // lblChapter
            // 
            this.lblChapter.AutoSize = true;
            this.lblChapter.Location = new System.Drawing.Point(561, 28);
            this.lblChapter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(81, 22);
            this.lblChapter.TabIndex = 5;
            this.lblChapter.Text = "Chapter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Content";
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(487, 236);
            this.rdD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(21, 20);
            this.rdD.TabIndex = 2;
            this.rdD.TabStop = true;
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(487, 196);
            this.rdC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(21, 20);
            this.rdC.TabIndex = 2;
            this.rdC.TabStop = true;
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(487, 158);
            this.rdB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(21, 20);
            this.rdB.TabIndex = 2;
            this.rdB.TabStop = true;
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(487, 116);
            this.rdA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(21, 20);
            this.rdA.TabIndex = 2;
            this.rdA.TabStop = true;
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // txtAnD
            // 
            this.txtAnD.Location = new System.Drawing.Point(98, 228);
            this.txtAnD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnD.Name = "txtAnD";
            this.txtAnD.Size = new System.Drawing.Size(367, 28);
            this.txtAnD.TabIndex = 1;
            // 
            // txtAnC
            // 
            this.txtAnC.Location = new System.Drawing.Point(98, 188);
            this.txtAnC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnC.Name = "txtAnC";
            this.txtAnC.Size = new System.Drawing.Size(367, 28);
            this.txtAnC.TabIndex = 1;
            // 
            // txtAnB
            // 
            this.txtAnB.Location = new System.Drawing.Point(98, 150);
            this.txtAnB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnB.Name = "txtAnB";
            this.txtAnB.Size = new System.Drawing.Size(367, 28);
            this.txtAnB.TabIndex = 1;
            // 
            // txtAnA
            // 
            this.txtAnA.Location = new System.Drawing.Point(98, 112);
            this.txtAnA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnA.Name = "txtAnA";
            this.txtAnA.Size = new System.Drawing.Size(367, 28);
            this.txtAnA.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(98, 28);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(367, 61);
            this.txtContent.TabIndex = 0;
            // 
            // dtGVQuizz
            // 
            this.dtGVQuizz.AllowUserToAddRows = false;
            this.dtGVQuizz.AllowUserToDeleteRows = false;
            this.dtGVQuizz.AllowUserToResizeColumns = false;
            this.dtGVQuizz.AllowUserToResizeRows = false;
            this.dtGVQuizz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVQuizz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVQuizz.Location = new System.Drawing.Point(291, 31);
            this.dtGVQuizz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGVQuizz.Name = "dtGVQuizz";
            this.dtGVQuizz.ReadOnly = true;
            this.dtGVQuizz.RowHeadersVisible = false;
            this.dtGVQuizz.RowHeadersWidth = 62;
            this.dtGVQuizz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVQuizz.Size = new System.Drawing.Size(838, 297);
            this.dtGVQuizz.TabIndex = 1;
            this.dtGVQuizz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVQuizz_CellClick);
            // 
            // dtGVExam
            // 
            this.dtGVExam.AllowUserToAddRows = false;
            this.dtGVExam.AllowUserToDeleteRows = false;
            this.dtGVExam.AllowUserToResizeColumns = false;
            this.dtGVExam.AllowUserToResizeRows = false;
            this.dtGVExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVExam.Location = new System.Drawing.Point(24, 69);
            this.dtGVExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGVExam.Name = "dtGVExam";
            this.dtGVExam.ReadOnly = true;
            this.dtGVExam.RowHeadersVisible = false;
            this.dtGVExam.RowHeadersWidth = 62;
            this.dtGVExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVExam.Size = new System.Drawing.Size(258, 259);
            this.dtGVExam.TabIndex = 1;
            this.dtGVExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVExam_CellClick);
            // 
            // cbSubjectName
            // 
            this.cbSubjectName.FormattingEnabled = true;
            this.cbSubjectName.Location = new System.Drawing.Point(24, 31);
            this.cbSubjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSubjectName.Name = "cbSubjectName";
            this.cbSubjectName.Size = new System.Drawing.Size(256, 28);
            this.cbSubjectName.TabIndex = 0;
            this.cbSubjectName.SelectedIndexChanged += new System.EventHandler(this.cbSubjectName_SelectedIndexChanged);
            // 
            // FQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FQuizz";
            this.Text = "FQuizz";
            this.Load += new System.EventHandler(this.FQuizz_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVQuizz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGVExam;
        private System.Windows.Forms.ComboBox cbSubjectName;
        private System.Windows.Forms.DataGridView dtGVQuizz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshQuizz;
        private System.Windows.Forms.Button btnUpdateQuizz;
        private System.Windows.Forms.Button btnRemoveQuizz;
        private System.Windows.Forms.Button btnAddQuizz;
        private System.Windows.Forms.ComboBox cbChapter;
        private System.Windows.Forms.Label lblChapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.TextBox txtAnD;
        private System.Windows.Forms.TextBox txtAnC;
        private System.Windows.Forms.TextBox txtAnB;
        private System.Windows.Forms.TextBox txtAnA;
        private System.Windows.Forms.TextBox txtContent;
    }
}