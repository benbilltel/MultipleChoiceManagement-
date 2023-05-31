namespace MChoice.GUI
{
    partial class FStudent
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
            this.cbClass2 = new System.Windows.Forms.ComboBox();
            this.btnRefreshStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneContact = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.dtGVStudent = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbClass);
            this.panel1.Controls.Add(this.dtGVStudent);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 655);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbClass2);
            this.groupBox1.Controls.Add(this.btnRefreshStudent);
            this.groupBox1.Controls.Add(this.btnUpdateStudent);
            this.groupBox1.Controls.Add(this.btnRemoveStudent);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPhoneContact);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(20, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1136, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // cbClass2
            // 
            this.cbClass2.FormattingEnabled = true;
            this.cbClass2.Location = new System.Drawing.Point(125, 162);
            this.cbClass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClass2.Name = "cbClass2";
            this.cbClass2.Size = new System.Drawing.Size(180, 30);
            this.cbClass2.TabIndex = 5;
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshStudent.FlatAppearance.BorderSize = 2;
            this.btnRefreshStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshStudent.Location = new System.Drawing.Point(962, 146);
            this.btnRefreshStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.Size = new System.Drawing.Size(112, 60);
            this.btnRefreshStudent.TabIndex = 4;
            this.btnRefreshStudent.Text = "Refresh";
            this.btnRefreshStudent.UseVisualStyleBackColor = true;
            this.btnRefreshStudent.Click += new System.EventHandler(this.btnRefreshStudent_Click);
            this.btnRefreshStudent.MouseEnter += new System.EventHandler(this.btnRefreshStudent_MouseEnter);
            this.btnRefreshStudent.MouseLeave += new System.EventHandler(this.btnRefreshStudent_MouseLeave);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateStudent.FlatAppearance.BorderSize = 2;
            this.btnUpdateStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateStudent.Location = new System.Drawing.Point(780, 146);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(112, 60);
            this.btnUpdateStudent.TabIndex = 4;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            this.btnUpdateStudent.MouseEnter += new System.EventHandler(this.btnUpdateStudent_MouseEnter);
            this.btnUpdateStudent.MouseLeave += new System.EventHandler(this.btnUpdateStudent_MouseLeave);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveStudent.FlatAppearance.BorderSize = 2;
            this.btnRemoveStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveStudent.Location = new System.Drawing.Point(962, 54);
            this.btnRemoveStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(112, 60);
            this.btnRemoveStudent.TabIndex = 4;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            this.btnRemoveStudent.MouseEnter += new System.EventHandler(this.btnRemoveStudent_MouseEnter);
            this.btnRemoveStudent.MouseLeave += new System.EventHandler(this.btnRemoveStudent_MouseLeave);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddStudent.FlatAppearance.BorderSize = 2;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddStudent.Location = new System.Drawing.Point(780, 54);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(112, 60);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.btnAddStudent.MouseEnter += new System.EventHandler(this.btnAddStudent_MouseEnter);
            this.btnAddStudent.MouseLeave += new System.EventHandler(this.btnAddStudent_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // txtPhoneContact
            // 
            this.txtPhoneContact.Location = new System.Drawing.Point(489, 110);
            this.txtPhoneContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneContact.Name = "txtPhoneContact";
            this.txtPhoneContact.Size = new System.Drawing.Size(188, 28);
            this.txtPhoneContact.TabIndex = 2;
            this.txtPhoneContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneContact_KeyPress);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(125, 108);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(180, 30);
            this.cbGender.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(489, 61);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 28);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 61);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(188, 28);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(20, 31);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(180, 28);
            this.cbClass.TabIndex = 1;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // dtGVStudent
            // 
            this.dtGVStudent.AllowUserToAddRows = false;
            this.dtGVStudent.AllowUserToDeleteRows = false;
            this.dtGVStudent.AllowUserToResizeColumns = false;
            this.dtGVStudent.AllowUserToResizeRows = false;
            this.dtGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVStudent.Location = new System.Drawing.Point(4, 69);
            this.dtGVStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGVStudent.Name = "dtGVStudent";
            this.dtGVStudent.ReadOnly = true;
            this.dtGVStudent.RowHeadersVisible = false;
            this.dtGVStudent.RowHeadersWidth = 62;
            this.dtGVStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVStudent.Size = new System.Drawing.Size(1155, 260);
            this.dtGVStudent.TabIndex = 0;
            this.dtGVStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVStudent_CellClick);
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FStudent";
            this.Text = "FStudent";
            this.Load += new System.EventHandler(this.FStudent_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.DataGridView dtGVStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneContact;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnRefreshStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ComboBox cbClass2;
        private System.Windows.Forms.Label label5;
    }
}