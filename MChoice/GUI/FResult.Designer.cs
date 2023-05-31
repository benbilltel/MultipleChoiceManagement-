namespace MChoice.GUI
{
    partial class FResult
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
            this.btnRemoveResult = new System.Windows.Forms.Button();
            this.dtGVResult = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnRemoveResult);
            this.panel1.Controls.Add(this.dtGVResult);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 655);
            this.panel1.TabIndex = 0;
            // 
            // btnRemoveResult
            // 
            this.btnRemoveResult.BackColor = System.Drawing.Color.White;
            this.btnRemoveResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveResult.FlatAppearance.BorderSize = 2;
            this.btnRemoveResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemoveResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnRemoveResult.Location = new System.Drawing.Point(1023, 417);
            this.btnRemoveResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveResult.Name = "btnRemoveResult";
            this.btnRemoveResult.Size = new System.Drawing.Size(137, 80);
            this.btnRemoveResult.TabIndex = 1;
            this.btnRemoveResult.Text = "Remove";
            this.btnRemoveResult.UseVisualStyleBackColor = false;
            this.btnRemoveResult.Click += new System.EventHandler(this.btnRemoveResult_Click);
            this.btnRemoveResult.MouseEnter += new System.EventHandler(this.btnRemoveResult_MouseEnter);
            this.btnRemoveResult.MouseLeave += new System.EventHandler(this.btnRemoveResult_MouseLeave);
            // 
            // dtGVResult
            // 
            this.dtGVResult.AllowUserToAddRows = false;
            this.dtGVResult.AllowUserToDeleteRows = false;
            this.dtGVResult.AllowUserToResizeColumns = false;
            this.dtGVResult.AllowUserToResizeRows = false;
            this.dtGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGVResult.Location = new System.Drawing.Point(5, 5);
            this.dtGVResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGVResult.Name = "dtGVResult";
            this.dtGVResult.ReadOnly = true;
            this.dtGVResult.RowHeadersVisible = false;
            this.dtGVResult.RowHeadersWidth = 62;
            this.dtGVResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVResult.Size = new System.Drawing.Size(1155, 402);
            this.dtGVResult.TabIndex = 0;
            // 
            // FResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FResult";
            this.Text = "FResult";
            this.Load += new System.EventHandler(this.FResult_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGVResult;
        private System.Windows.Forms.Button btnRemoveResult;
    }
}