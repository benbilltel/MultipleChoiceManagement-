namespace MChoice.GUI
{
    partial class FClass
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSubjectName1 = new System.Windows.Forms.ComboBox();
            this.btnRemoveLsSb = new System.Windows.Forms.Button();
            this.btnAddLsSb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshExam = new System.Windows.Forms.Button();
            this.rdUnchecked = new System.Windows.Forms.RadioButton();
            this.rdChecked = new System.Windows.Forms.RadioButton();
            this.txtIDExam = new System.Windows.Forms.TextBox();
            this.cbSubjectName2 = new System.Windows.Forms.ComboBox();
            this.btnUpdateExam = new System.Windows.Forms.Button();
            this.btnRemoveExam = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnRemoveClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.dtGVExam = new System.Windows.Forms.DataGridView();
            this.dtGVLsSb = new System.Windows.Forms.DataGridView();
            this.dtGVClass = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLsSb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtGVExam);
            this.panel1.Controls.Add(this.dtGVLsSb);
            this.panel1.Controls.Add(this.dtGVClass);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 524);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cbSubjectName1);
            this.groupBox2.Controls.Add(this.btnRemoveLsSb);
            this.groupBox2.Controls.Add(this.btnAddLsSb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(341, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(316, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List subjects of class";
            // 
            // cbSubjectName1
            // 
            this.cbSubjectName1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSubjectName1.FormattingEnabled = true;
            this.cbSubjectName1.Location = new System.Drawing.Point(29, 58);
            this.cbSubjectName1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSubjectName1.Name = "cbSubjectName1";
            this.cbSubjectName1.Size = new System.Drawing.Size(233, 26);
            this.cbSubjectName1.TabIndex = 3;
            // 
            // btnRemoveLsSb
            // 
            this.btnRemoveLsSb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveLsSb.FlatAppearance.BorderSize = 2;
            this.btnRemoveLsSb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveLsSb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveLsSb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveLsSb.Location = new System.Drawing.Point(163, 114);
            this.btnRemoveLsSb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveLsSb.Name = "btnRemoveLsSb";
            this.btnRemoveLsSb.Size = new System.Drawing.Size(100, 34);
            this.btnRemoveLsSb.TabIndex = 2;
            this.btnRemoveLsSb.Text = "Remove";
            this.btnRemoveLsSb.UseVisualStyleBackColor = true;
            this.btnRemoveLsSb.Click += new System.EventHandler(this.btnRemoveLsSb_Click);
            this.btnRemoveLsSb.MouseEnter += new System.EventHandler(this.btnRemoveLsSb_MouseEnter);
            this.btnRemoveLsSb.MouseLeave += new System.EventHandler(this.btnRemoveLsSb_MouseLeave);
            // 
            // btnAddLsSb
            // 
            this.btnAddLsSb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddLsSb.FlatAppearance.BorderSize = 2;
            this.btnAddLsSb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddLsSb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLsSb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddLsSb.Location = new System.Drawing.Point(29, 114);
            this.btnAddLsSb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddLsSb.Name = "btnAddLsSb";
            this.btnAddLsSb.Size = new System.Drawing.Size(100, 34);
            this.btnAddLsSb.TabIndex = 2;
            this.btnAddLsSb.Text = "Add";
            this.btnAddLsSb.UseVisualStyleBackColor = true;
            this.btnAddLsSb.Click += new System.EventHandler(this.btnAddLsSb_Click);
            this.btnAddLsSb.MouseEnter += new System.EventHandler(this.btnAddLsSb_MouseEnter);
            this.btnAddLsSb.MouseLeave += new System.EventHandler(this.btnAddLsSb_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject name";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnRefreshExam);
            this.groupBox3.Controls.Add(this.rdUnchecked);
            this.groupBox3.Controls.Add(this.rdChecked);
            this.groupBox3.Controls.Add(this.txtIDExam);
            this.groupBox3.Controls.Add(this.cbSubjectName2);
            this.groupBox3.Controls.Add(this.btnUpdateExam);
            this.groupBox3.Controls.Add(this.btnRemoveExam);
            this.groupBox3.Controls.Add(this.btnAddExam);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(697, 260);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(333, 242);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam of Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exam ID";
            // 
            // btnRefreshExam
            // 
            this.btnRefreshExam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshExam.FlatAppearance.BorderSize = 2;
            this.btnRefreshExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshExam.Location = new System.Drawing.Point(227, 158);
            this.btnRefreshExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshExam.Name = "btnRefreshExam";
            this.btnRefreshExam.Size = new System.Drawing.Size(100, 34);
            this.btnRefreshExam.TabIndex = 7;
            this.btnRefreshExam.Text = "Refresh";
            this.btnRefreshExam.UseVisualStyleBackColor = true;
            this.btnRefreshExam.Click += new System.EventHandler(this.btnRefreshExam_Click);
            this.btnRefreshExam.MouseEnter += new System.EventHandler(this.btnRefreshExam_MouseEnter);
            this.btnRefreshExam.MouseLeave += new System.EventHandler(this.btnRefreshExam_MouseLeave);
            // 
            // rdUnchecked
            // 
            this.rdUnchecked.AutoSize = true;
            this.rdUnchecked.Location = new System.Drawing.Point(23, 185);
            this.rdUnchecked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdUnchecked.Name = "rdUnchecked";
            this.rdUnchecked.Size = new System.Drawing.Size(113, 22);
            this.rdUnchecked.TabIndex = 6;
            this.rdUnchecked.TabStop = true;
            this.rdUnchecked.Text = "Unchecked";
            this.rdUnchecked.UseVisualStyleBackColor = true;
            // 
            // rdChecked
            // 
            this.rdChecked.AutoSize = true;
            this.rdChecked.Location = new System.Drawing.Point(23, 157);
            this.rdChecked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdChecked.Name = "rdChecked";
            this.rdChecked.Size = new System.Drawing.Size(95, 22);
            this.rdChecked.TabIndex = 5;
            this.rdChecked.TabStop = true;
            this.rdChecked.Text = "Checked";
            this.rdChecked.UseVisualStyleBackColor = true;
            // 
            // txtIDExam
            // 
            this.txtIDExam.Location = new System.Drawing.Point(11, 114);
            this.txtIDExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDExam.Name = "txtIDExam";
            this.txtIDExam.ReadOnly = true;
            this.txtIDExam.Size = new System.Drawing.Size(180, 24);
            this.txtIDExam.TabIndex = 4;
            // 
            // cbSubjectName2
            // 
            this.cbSubjectName2.FormattingEnabled = true;
            this.cbSubjectName2.Location = new System.Drawing.Point(11, 57);
            this.cbSubjectName2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSubjectName2.Name = "cbSubjectName2";
            this.cbSubjectName2.Size = new System.Drawing.Size(180, 26);
            this.cbSubjectName2.TabIndex = 3;
            this.cbSubjectName2.SelectedIndexChanged += new System.EventHandler(this.cbSubjectName2_SelectedIndexChanged);
            // 
            // btnUpdateExam
            // 
            this.btnUpdateExam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateExam.FlatAppearance.BorderSize = 2;
            this.btnUpdateExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateExam.Location = new System.Drawing.Point(227, 116);
            this.btnUpdateExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateExam.Name = "btnUpdateExam";
            this.btnUpdateExam.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateExam.TabIndex = 2;
            this.btnUpdateExam.Text = "Update";
            this.btnUpdateExam.UseVisualStyleBackColor = true;
            this.btnUpdateExam.Click += new System.EventHandler(this.btnUpdateExam_Click);
            this.btnUpdateExam.MouseEnter += new System.EventHandler(this.btnUpdateExam_MouseEnter);
            this.btnUpdateExam.MouseLeave += new System.EventHandler(this.btnUpdateExam_MouseLeave);
            // 
            // btnRemoveExam
            // 
            this.btnRemoveExam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveExam.FlatAppearance.BorderSize = 2;
            this.btnRemoveExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveExam.Location = new System.Drawing.Point(227, 74);
            this.btnRemoveExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveExam.Name = "btnRemoveExam";
            this.btnRemoveExam.Size = new System.Drawing.Size(100, 34);
            this.btnRemoveExam.TabIndex = 2;
            this.btnRemoveExam.Text = "Remove";
            this.btnRemoveExam.UseVisualStyleBackColor = true;
            this.btnRemoveExam.Click += new System.EventHandler(this.btnRemoveExam_Click);
            this.btnRemoveExam.MouseEnter += new System.EventHandler(this.btnRemoveExam_MouseEnter);
            this.btnRemoveExam.MouseLeave += new System.EventHandler(this.btnRemoveExam_MouseLeave);
            // 
            // btnAddExam
            // 
            this.btnAddExam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddExam.FlatAppearance.BorderSize = 2;
            this.btnAddExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddExam.Location = new System.Drawing.Point(227, 31);
            this.btnAddExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(100, 34);
            this.btnAddExam.TabIndex = 2;
            this.btnAddExam.Text = "Add";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            this.btnAddExam.MouseEnter += new System.EventHandler(this.btnAddExam_MouseEnter);
            this.btnAddExam.MouseLeave += new System.EventHandler(this.btnAddExam_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnRefreshClass);
            this.groupBox1.Controls.Add(this.btnUpdateClass);
            this.groupBox1.Controls.Add(this.btnRemoveClass);
            this.groupBox1.Controls.Add(this.btnAddClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(16, 260);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(295, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class";
            // 
            // btnRefreshClass
            // 
            this.btnRefreshClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshClass.FlatAppearance.BorderSize = 2;
            this.btnRefreshClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.btnRefreshClass.Location = new System.Drawing.Point(153, 157);
            this.btnRefreshClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshClass.Name = "btnRefreshClass";
            this.btnRefreshClass.Size = new System.Drawing.Size(100, 34);
            this.btnRefreshClass.TabIndex = 2;
            this.btnRefreshClass.Text = "Refresh";
            this.btnRefreshClass.UseVisualStyleBackColor = true;
            this.btnRefreshClass.Click += new System.EventHandler(this.btnRefreshClass_Click);
            this.btnRefreshClass.MouseEnter += new System.EventHandler(this.btnRefreshClass_MouseEnter);
            this.btnRefreshClass.MouseLeave += new System.EventHandler(this.btnRefreshClass_MouseLeave);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateClass.FlatAppearance.BorderSize = 2;
            this.btnUpdateClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(146)))), ((int)(((byte)(199)))));
            this.btnUpdateClass.Location = new System.Drawing.Point(33, 157);
            this.btnUpdateClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateClass.TabIndex = 2;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            this.btnUpdateClass.MouseEnter += new System.EventHandler(this.btnUpdateClass_MouseEnter);
            this.btnUpdateClass.MouseLeave += new System.EventHandler(this.btnUpdateClass_MouseLeave);
            // 
            // btnRemoveClass
            // 
            this.btnRemoveClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveClass.FlatAppearance.BorderSize = 2;
            this.btnRemoveClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveClass.Location = new System.Drawing.Point(153, 114);
            this.btnRemoveClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveClass.Name = "btnRemoveClass";
            this.btnRemoveClass.Size = new System.Drawing.Size(100, 34);
            this.btnRemoveClass.TabIndex = 2;
            this.btnRemoveClass.Text = "Remove";
            this.btnRemoveClass.UseVisualStyleBackColor = true;
            this.btnRemoveClass.Click += new System.EventHandler(this.btnRemoveClass_Click);
            this.btnRemoveClass.MouseEnter += new System.EventHandler(this.btnRemoveClass_MouseEnter);
            this.btnRemoveClass.MouseLeave += new System.EventHandler(this.btnRemoveClass_MouseLeave);
            // 
            // btnAddClass
            // 
            this.btnAddClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddClass.FlatAppearance.BorderSize = 2;
            this.btnAddClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(86)))));
            this.btnAddClass.Location = new System.Drawing.Point(33, 114);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(100, 34);
            this.btnAddClass.TabIndex = 2;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            this.btnAddClass.MouseEnter += new System.EventHandler(this.btnAddClass_MouseEnter);
            this.btnAddClass.MouseLeave += new System.EventHandler(this.btnAddClass_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class name";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(33, 58);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(220, 24);
            this.txtClassName.TabIndex = 0;
            // 
            // dtGVExam
            // 
            this.dtGVExam.AllowUserToAddRows = false;
            this.dtGVExam.AllowUserToDeleteRows = false;
            this.dtGVExam.AllowUserToResizeColumns = false;
            this.dtGVExam.AllowUserToResizeRows = false;
            this.dtGVExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVExam.Location = new System.Drawing.Point(697, 4);
            this.dtGVExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGVExam.Name = "dtGVExam";
            this.dtGVExam.ReadOnly = true;
            this.dtGVExam.RowHeadersVisible = false;
            this.dtGVExam.RowHeadersWidth = 62;
            this.dtGVExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVExam.Size = new System.Drawing.Size(333, 185);
            this.dtGVExam.TabIndex = 0;
            this.dtGVExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVExam_CellClick);
            // 
            // dtGVLsSb
            // 
            this.dtGVLsSb.AllowUserToAddRows = false;
            this.dtGVLsSb.AllowUserToDeleteRows = false;
            this.dtGVLsSb.AllowUserToResizeColumns = false;
            this.dtGVLsSb.AllowUserToResizeRows = false;
            this.dtGVLsSb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVLsSb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVLsSb.Location = new System.Drawing.Point(341, 4);
            this.dtGVLsSb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGVLsSb.Name = "dtGVLsSb";
            this.dtGVLsSb.ReadOnly = true;
            this.dtGVLsSb.RowHeadersVisible = false;
            this.dtGVLsSb.RowHeadersWidth = 62;
            this.dtGVLsSb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVLsSb.Size = new System.Drawing.Size(316, 185);
            this.dtGVLsSb.TabIndex = 0;
            this.dtGVLsSb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVLsSb_CellClick);
            // 
            // dtGVClass
            // 
            this.dtGVClass.AllowUserToAddRows = false;
            this.dtGVClass.AllowUserToDeleteRows = false;
            this.dtGVClass.AllowUserToResizeColumns = false;
            this.dtGVClass.AllowUserToResizeRows = false;
            this.dtGVClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVClass.Location = new System.Drawing.Point(16, 4);
            this.dtGVClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGVClass.Name = "dtGVClass";
            this.dtGVClass.ReadOnly = true;
            this.dtGVClass.RowHeadersVisible = false;
            this.dtGVClass.RowHeadersWidth = 62;
            this.dtGVClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVClass.Size = new System.Drawing.Size(295, 185);
            this.dtGVClass.TabIndex = 0;
            this.dtGVClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVClass_CellClick);
            // 
            // FClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FClass";
            this.Text = "FClass";
            this.Load += new System.EventHandler(this.FClass_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLsSb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGVClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnRemoveClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridView dtGVExam;
        private System.Windows.Forms.DataGridView dtGVLsSb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSubjectName1;
        private System.Windows.Forms.Button btnRemoveLsSb;
        private System.Windows.Forms.Button btnAddLsSb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveExam;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.ComboBox cbSubjectName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdChecked;
        private System.Windows.Forms.TextBox txtIDExam;
        private System.Windows.Forms.RadioButton rdUnchecked;
        private System.Windows.Forms.Button btnUpdateExam;
        private System.Windows.Forms.Button btnRefreshExam;
        private System.Windows.Forms.Label label4;
    }
}