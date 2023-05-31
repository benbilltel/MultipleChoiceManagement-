namespace MChoice.GUI
{
    partial class FStudentClient
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPhoneContact = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGVSubjectAvailable = new System.Windows.Forms.DataGridView();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.lblIDStudent = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVSubjectAvailable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnLogOut.FlatAppearance.BorderSize = 2;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnLogOut.Location = new System.Drawing.Point(10, 105);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(128, 37);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Class: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gender: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone Contact: ";
            // 
            // lblPhoneContact
            // 
            this.lblPhoneContact.AutoSize = true;
            this.lblPhoneContact.Location = new System.Drawing.Point(188, 184);
            this.lblPhoneContact.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhoneContact.Name = "lblPhoneContact";
            this.lblPhoneContact.Size = new System.Drawing.Size(38, 18);
            this.lblPhoneContact.TabIndex = 2;
            this.lblPhoneContact.Text = "......";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtGVSubjectAvailable);
            this.groupBox1.Location = new System.Drawing.Point(59, 330);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(563, 302);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Take subject to enroll";
            // 
            // dtGVSubjectAvailable
            // 
            this.dtGVSubjectAvailable.AllowUserToAddRows = false;
            this.dtGVSubjectAvailable.AllowUserToDeleteRows = false;
            this.dtGVSubjectAvailable.AllowUserToResizeColumns = false;
            this.dtGVSubjectAvailable.AllowUserToResizeRows = false;
            this.dtGVSubjectAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVSubjectAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVSubjectAvailable.Location = new System.Drawing.Point(23, 56);
            this.dtGVSubjectAvailable.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtGVSubjectAvailable.Name = "dtGVSubjectAvailable";
            this.dtGVSubjectAvailable.ReadOnly = true;
            this.dtGVSubjectAvailable.RowHeadersVisible = false;
            this.dtGVSubjectAvailable.RowHeadersWidth = 62;
            this.dtGVSubjectAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVSubjectAvailable.Size = new System.Drawing.Size(357, 166);
            this.dtGVSubjectAvailable.TabIndex = 2;
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.White;
            this.btnEnroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnEnroll.FlatAppearance.BorderSize = 2;
            this.btnEnroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnEnroll.Location = new System.Drawing.Point(10, 38);
            this.btnEnroll.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(128, 37);
            this.btnEnroll.TabIndex = 1;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            this.btnEnroll.MouseEnter += new System.EventHandler(this.btnEnroll_MouseEnter);
            this.btnEnroll.MouseLeave += new System.EventHandler(this.btnEnroll_MouseLeave);
            // 
            // lblIDStudent
            // 
            this.lblIDStudent.AutoSize = true;
            this.lblIDStudent.Location = new System.Drawing.Point(188, 33);
            this.lblIDStudent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIDStudent.Name = "lblIDStudent";
            this.lblIDStudent.Size = new System.Drawing.Size(38, 18);
            this.lblIDStudent.TabIndex = 2;
            this.lblIDStudent.Text = "......";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(188, 74);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(38, 18);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "......";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(188, 109);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(38, 18);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "......";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(188, 144);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(38, 18);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "......";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPhoneContact);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.lblClassName);
            this.groupBox2.Controls.Add(this.lblStudentName);
            this.groupBox2.Controls.Add(this.lblIDStudent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(60, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 236);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLogOut);
            this.groupBox3.Controls.Add(this.btnEnroll);
            this.groupBox3.Location = new System.Drawing.Point(399, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // FStudentClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FStudentClient";
            this.Text = "FStudentClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FStudentClient_FormClosed);
            this.Load += new System.EventHandler(this.FStudentClient_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVSubjectAvailable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPhoneContact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.DataGridView dtGVSubjectAvailable;
        private System.Windows.Forms.Label lblIDStudent;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}