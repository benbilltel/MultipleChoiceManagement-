namespace MChoice.GUI
{
    partial class FUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefreshUserAdmin = new System.Windows.Forms.Button();
            this.btnRemoveUserAdmin = new System.Windows.Forms.Button();
            this.btnUpdateUserAdmin = new System.Windows.Forms.Button();
            this.btnAddUserAdmin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.txtUserAdmin = new System.Windows.Forms.TextBox();
            this.dtGVUserAdmin = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddUserStudent = new System.Windows.Forms.Button();
            this.btnRefreshUserStudent = new System.Windows.Forms.Button();
            this.btnRemoveUserStudent = new System.Windows.Forms.Button();
            this.btnUpdateUserStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassStudent = new System.Windows.Forms.TextBox();
            this.txtUsernameStudent = new System.Windows.Forms.TextBox();
            this.dtGVStudent = new System.Windows.Forms.DataGridView();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.dtGVUserStudent = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVUserAdmin)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVUserStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1148, 655);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtGVUserAdmin);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1140, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnRefreshUserAdmin);
            this.groupBox3.Controls.Add(this.btnRemoveUserAdmin);
            this.groupBox3.Controls.Add(this.btnUpdateUserAdmin);
            this.groupBox3.Controls.Add(this.btnAddUserAdmin);
            this.groupBox3.Location = new System.Drawing.Point(906, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnRefreshUserAdmin
            // 
            this.btnRefreshUserAdmin.BackColor = System.Drawing.Color.White;
            this.btnRefreshUserAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUserAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshUserAdmin.FlatAppearance.BorderSize = 2;
            this.btnRefreshUserAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshUserAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefreshUserAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshUserAdmin.Location = new System.Drawing.Point(24, 204);
            this.btnRefreshUserAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshUserAdmin.Name = "btnRefreshUserAdmin";
            this.btnRefreshUserAdmin.Size = new System.Drawing.Size(146, 49);
            this.btnRefreshUserAdmin.TabIndex = 6;
            this.btnRefreshUserAdmin.Text = "Refresh";
            this.btnRefreshUserAdmin.UseVisualStyleBackColor = false;
            this.btnRefreshUserAdmin.Click += new System.EventHandler(this.btnRefreshUserAdmin_Click);
            this.btnRefreshUserAdmin.MouseEnter += new System.EventHandler(this.btnRefreshUserAdmin_MouseEnter);
            this.btnRefreshUserAdmin.MouseLeave += new System.EventHandler(this.btnRefreshUserAdmin_MouseLeave);
            // 
            // btnRemoveUserAdmin
            // 
            this.btnRemoveUserAdmin.BackColor = System.Drawing.Color.White;
            this.btnRemoveUserAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUserAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveUserAdmin.FlatAppearance.BorderSize = 3;
            this.btnRemoveUserAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveUserAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemoveUserAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveUserAdmin.Location = new System.Drawing.Point(24, 86);
            this.btnRemoveUserAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveUserAdmin.Name = "btnRemoveUserAdmin";
            this.btnRemoveUserAdmin.Size = new System.Drawing.Size(146, 49);
            this.btnRemoveUserAdmin.TabIndex = 4;
            this.btnRemoveUserAdmin.Text = "Remove";
            this.btnRemoveUserAdmin.UseVisualStyleBackColor = false;
            this.btnRemoveUserAdmin.Click += new System.EventHandler(this.btnRemoveUserAdmin_Click);
            this.btnRemoveUserAdmin.MouseEnter += new System.EventHandler(this.btnRemoveUserAdmin_MouseEnter);
            this.btnRemoveUserAdmin.MouseLeave += new System.EventHandler(this.btnRemoveUserAdmin_MouseLeave);
            // 
            // btnUpdateUserAdmin
            // 
            this.btnUpdateUserAdmin.BackColor = System.Drawing.Color.White;
            this.btnUpdateUserAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUserAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateUserAdmin.FlatAppearance.BorderSize = 2;
            this.btnUpdateUserAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateUserAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateUserAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateUserAdmin.Location = new System.Drawing.Point(24, 145);
            this.btnUpdateUserAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateUserAdmin.Name = "btnUpdateUserAdmin";
            this.btnUpdateUserAdmin.Size = new System.Drawing.Size(146, 49);
            this.btnUpdateUserAdmin.TabIndex = 5;
            this.btnUpdateUserAdmin.Text = "Update";
            this.btnUpdateUserAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateUserAdmin.Click += new System.EventHandler(this.btnUpdateUserAdmin_Click);
            this.btnUpdateUserAdmin.MouseEnter += new System.EventHandler(this.btnUpdateUserAdmin_MouseEnter);
            this.btnUpdateUserAdmin.MouseLeave += new System.EventHandler(this.btnUpdateUserAdmin_MouseLeave);
            // 
            // btnAddUserAdmin
            // 
            this.btnAddUserAdmin.BackColor = System.Drawing.Color.White;
            this.btnAddUserAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUserAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddUserAdmin.FlatAppearance.BorderSize = 2;
            this.btnAddUserAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddUserAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddUserAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddUserAdmin.Location = new System.Drawing.Point(24, 27);
            this.btnAddUserAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUserAdmin.Name = "btnAddUserAdmin";
            this.btnAddUserAdmin.Size = new System.Drawing.Size(146, 49);
            this.btnAddUserAdmin.TabIndex = 3;
            this.btnAddUserAdmin.Text = "Add";
            this.btnAddUserAdmin.UseVisualStyleBackColor = false;
            this.btnAddUserAdmin.Click += new System.EventHandler(this.btnAddUserAdmin_Click);
            this.btnAddUserAdmin.MouseEnter += new System.EventHandler(this.btnAddUserAdmin_MouseEnter);
            this.btnAddUserAdmin.MouseLeave += new System.EventHandler(this.btnAddUserAdmin_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassAdmin);
            this.groupBox1.Controls.Add(this.txtUserAdmin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(30, 314);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(841, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.Location = new System.Drawing.Point(152, 141);
            this.txtPassAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.Size = new System.Drawing.Size(272, 28);
            this.txtPassAdmin.TabIndex = 1;
            this.txtPassAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassAdmin_KeyPress);
            // 
            // txtUserAdmin
            // 
            this.txtUserAdmin.Location = new System.Drawing.Point(152, 66);
            this.txtUserAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserAdmin.Name = "txtUserAdmin";
            this.txtUserAdmin.Size = new System.Drawing.Size(272, 28);
            this.txtUserAdmin.TabIndex = 0;
            this.txtUserAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserAdmin_KeyPress);
            // 
            // dtGVUserAdmin
            // 
            this.dtGVUserAdmin.AllowUserToAddRows = false;
            this.dtGVUserAdmin.AllowUserToDeleteRows = false;
            this.dtGVUserAdmin.AllowUserToResizeColumns = false;
            this.dtGVUserAdmin.AllowUserToResizeRows = false;
            this.dtGVUserAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVUserAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVUserAdmin.Location = new System.Drawing.Point(30, 28);
            this.dtGVUserAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGVUserAdmin.Name = "dtGVUserAdmin";
            this.dtGVUserAdmin.ReadOnly = true;
            this.dtGVUserAdmin.RowHeadersVisible = false;
            this.dtGVUserAdmin.RowHeadersWidth = 62;
            this.dtGVUserAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVUserAdmin.Size = new System.Drawing.Size(1074, 211);
            this.dtGVUserAdmin.TabIndex = 0;
            this.dtGVUserAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVUserAdmin_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dtGVStudent);
            this.tabPage2.Controls.Add(this.cbClass);
            this.tabPage2.Controls.Add(this.dtGVUserStudent);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1140, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Student";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnAddUserStudent);
            this.groupBox4.Controls.Add(this.btnRefreshUserStudent);
            this.groupBox4.Controls.Add(this.btnRemoveUserStudent);
            this.groupBox4.Controls.Add(this.btnUpdateUserStudent);
            this.groupBox4.Location = new System.Drawing.Point(834, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 240);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // btnAddUserStudent
            // 
            this.btnAddUserStudent.BackColor = System.Drawing.Color.White;
            this.btnAddUserStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUserStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddUserStudent.FlatAppearance.BorderSize = 2;
            this.btnAddUserStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddUserStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddUserStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddUserStudent.Location = new System.Drawing.Point(71, 27);
            this.btnAddUserStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUserStudent.Name = "btnAddUserStudent";
            this.btnAddUserStudent.Size = new System.Drawing.Size(146, 42);
            this.btnAddUserStudent.TabIndex = 3;
            this.btnAddUserStudent.Text = "Add";
            this.btnAddUserStudent.UseVisualStyleBackColor = false;
            this.btnAddUserStudent.Click += new System.EventHandler(this.btnAddUserStudent_Click);
            this.btnAddUserStudent.MouseEnter += new System.EventHandler(this.btnAddUserStudent_MouseEnter);
            this.btnAddUserStudent.MouseLeave += new System.EventHandler(this.btnAddUserStudent_MouseLeave);
            // 
            // btnRefreshUserStudent
            // 
            this.btnRefreshUserStudent.BackColor = System.Drawing.Color.White;
            this.btnRefreshUserStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshUserStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshUserStudent.FlatAppearance.BorderSize = 2;
            this.btnRefreshUserStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshUserStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUserStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefreshUserStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshUserStudent.Location = new System.Drawing.Point(71, 183);
            this.btnRefreshUserStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshUserStudent.Name = "btnRefreshUserStudent";
            this.btnRefreshUserStudent.Size = new System.Drawing.Size(146, 42);
            this.btnRefreshUserStudent.TabIndex = 3;
            this.btnRefreshUserStudent.Text = "Refresh";
            this.btnRefreshUserStudent.UseVisualStyleBackColor = false;
            this.btnRefreshUserStudent.Click += new System.EventHandler(this.btnRefreshUserStudent_Click);
            this.btnRefreshUserStudent.MouseEnter += new System.EventHandler(this.btnRefreshUserStudent_MouseEnter);
            this.btnRefreshUserStudent.MouseLeave += new System.EventHandler(this.btnRefreshUserStudent_MouseLeave);
            // 
            // btnRemoveUserStudent
            // 
            this.btnRemoveUserStudent.BackColor = System.Drawing.Color.White;
            this.btnRemoveUserStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUserStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveUserStudent.FlatAppearance.BorderSize = 2;
            this.btnRemoveUserStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveUserStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUserStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemoveUserStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveUserStudent.Location = new System.Drawing.Point(71, 79);
            this.btnRemoveUserStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveUserStudent.Name = "btnRemoveUserStudent";
            this.btnRemoveUserStudent.Size = new System.Drawing.Size(146, 42);
            this.btnRemoveUserStudent.TabIndex = 3;
            this.btnRemoveUserStudent.Text = "Remove";
            this.btnRemoveUserStudent.UseVisualStyleBackColor = false;
            this.btnRemoveUserStudent.Click += new System.EventHandler(this.btnRemoveUserStudent_Click);
            this.btnRemoveUserStudent.MouseEnter += new System.EventHandler(this.btnRemoveUserStudent_MouseEnter);
            this.btnRemoveUserStudent.MouseLeave += new System.EventHandler(this.btnRemoveUserStudent_MouseLeave);
            // 
            // btnUpdateUserStudent
            // 
            this.btnUpdateUserStudent.BackColor = System.Drawing.Color.White;
            this.btnUpdateUserStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUserStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateUserStudent.FlatAppearance.BorderSize = 2;
            this.btnUpdateUserStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateUserStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUserStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateUserStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateUserStudent.Location = new System.Drawing.Point(71, 131);
            this.btnUpdateUserStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateUserStudent.Name = "btnUpdateUserStudent";
            this.btnUpdateUserStudent.Size = new System.Drawing.Size(146, 42);
            this.btnUpdateUserStudent.TabIndex = 3;
            this.btnUpdateUserStudent.Text = "Update";
            this.btnUpdateUserStudent.UseVisualStyleBackColor = false;
            this.btnUpdateUserStudent.Click += new System.EventHandler(this.btnUpdateUserStudent_Click);
            this.btnUpdateUserStudent.MouseEnter += new System.EventHandler(this.btnUpdateUserStudent_MouseEnter);
            this.btnUpdateUserStudent.MouseLeave += new System.EventHandler(this.btnUpdateUserStudent_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPassStudent);
            this.groupBox2.Controls.Add(this.txtUsernameStudent);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(40, 345);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(734, 240);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            // 
            // txtPassStudent
            // 
            this.txtPassStudent.Location = new System.Drawing.Point(186, 112);
            this.txtPassStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassStudent.Name = "txtPassStudent";
            this.txtPassStudent.Size = new System.Drawing.Size(272, 28);
            this.txtPassStudent.TabIndex = 1;
            this.txtPassStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassStudent_KeyPress);
            // 
            // txtUsernameStudent
            // 
            this.txtUsernameStudent.Location = new System.Drawing.Point(186, 60);
            this.txtUsernameStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsernameStudent.Name = "txtUsernameStudent";
            this.txtUsernameStudent.Size = new System.Drawing.Size(272, 28);
            this.txtUsernameStudent.TabIndex = 0;
            this.txtUsernameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsernameStudent_KeyPress);
            // 
            // dtGVStudent
            // 
            this.dtGVStudent.AllowUserToAddRows = false;
            this.dtGVStudent.AllowUserToDeleteRows = false;
            this.dtGVStudent.AllowUserToResizeColumns = false;
            this.dtGVStudent.AllowUserToResizeRows = false;
            this.dtGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVStudent.Location = new System.Drawing.Point(40, 52);
            this.dtGVStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGVStudent.Name = "dtGVStudent";
            this.dtGVStudent.ReadOnly = true;
            this.dtGVStudent.RowHeadersVisible = false;
            this.dtGVStudent.RowHeadersWidth = 62;
            this.dtGVStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVStudent.Size = new System.Drawing.Size(410, 242);
            this.dtGVStudent.TabIndex = 4;
            this.dtGVStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVStudent_CellClick);
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(40, 11);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(408, 28);
            this.cbClass.TabIndex = 3;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // dtGVUserStudent
            // 
            this.dtGVUserStudent.AllowUserToAddRows = false;
            this.dtGVUserStudent.AllowUserToDeleteRows = false;
            this.dtGVUserStudent.AllowUserToResizeColumns = false;
            this.dtGVUserStudent.AllowUserToResizeRows = false;
            this.dtGVUserStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVUserStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVUserStudent.Location = new System.Drawing.Point(459, 52);
            this.dtGVUserStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGVUserStudent.Name = "dtGVUserStudent";
            this.dtGVUserStudent.ReadOnly = true;
            this.dtGVUserStudent.RowHeadersVisible = false;
            this.dtGVUserStudent.RowHeadersWidth = 62;
            this.dtGVUserStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVUserStudent.Size = new System.Drawing.Size(656, 242);
            this.dtGVUserStudent.TabIndex = 1;
            this.dtGVUserStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVUserStudent_CellClick);
            // 
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FUser";
            this.Text = "FUser";
            this.Load += new System.EventHandler(this.FUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVUserAdmin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVUserStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGVUserAdmin;
        private System.Windows.Forms.DataGridView dtGVUserStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.TextBox txtUserAdmin;
        private System.Windows.Forms.Button btnRefreshUserAdmin;
        private System.Windows.Forms.Button btnUpdateUserAdmin;
        private System.Windows.Forms.Button btnRemoveUserAdmin;
        private System.Windows.Forms.Button btnAddUserAdmin;
        private System.Windows.Forms.DataGridView dtGVStudent;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefreshUserStudent;
        private System.Windows.Forms.Button btnUpdateUserStudent;
        private System.Windows.Forms.Button btnRemoveUserStudent;
        private System.Windows.Forms.Button btnAddUserStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassStudent;
        private System.Windows.Forms.TextBox txtUsernameStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}