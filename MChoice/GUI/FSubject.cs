using MChoice.DAL;
using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MChoice.GUI
{
    public partial class FSubject : Form
    {
        public FSubject()
        {
            InitializeComponent();
        }
        DAL_Subject dalSubject = new DAL_Subject();
        DAL_Chapter dalChapter = new DAL_Chapter();
        void LoadDataSubject()
        {
            dtGVSubject.DataSource = dalSubject.GetSubject();
            dtGVSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVSubject.Columns["ID"].Visible = false;
        }
        void LoadDataChapter(DTO_Subject sb)
        {
            dtGVChapter.DataSource = dalChapter.GetChapterBySubject(sb);
            dtGVChapter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVChapter.Columns["ID"].Visible = false;
            dtGVChapter.Columns["ID_SB"].Visible = false;
        }
        void RefreshChapter()
        {
            txtChapterName.Text = string.Empty;
            DataGridViewRow row = dtGVSubject.SelectedRows[0];
            int idSb = (int)row.Cells[0].Value;
            DTO_Subject sb = new DTO_Subject(idSb);
            LoadDataChapter(sb);
        }
        bool CheckemptySubject()
        {
            if(txtSubjectName.Text.Trim()== string.Empty)
            {
                MessageBox.Show("Subject name is required!");
                return false;
            }
                return true;
        }
        private void FSubject_Load(object sender, EventArgs e)
        {
            LoadDataSubject();
            if(dtGVSubject.SelectedRows.Count> 0)
            {
                DataGridViewRow row = dtGVSubject.SelectedRows[0];
                int idSb = (int)row.Cells[0].Value;
                DTO_Subject sb = new DTO_Subject(idSb);
                LoadDataChapter(sb);
            }
            
        }

        private void dtGVSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVSubject.Rows[e.RowIndex];
                int idSb = (int)row.Cells[0].Value;
                DTO_Subject sb = new DTO_Subject(idSb);
                LoadDataChapter(sb);
                txtSubjectName.Text = row.Cells[1].Value.ToString().Trim();
                txtSubjectNote.Text = row.Cells[2].Value.ToString().Trim();   
            }
        }

        private void btnRefreshSubject_Click(object sender, EventArgs e)
        {
            txtSubjectName.Text = string.Empty;
            txtSubjectNote.Text = string.Empty;
            LoadDataSubject();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if(!CheckemptySubject()) { return; }
            DTO_Subject sb = new DTO_Subject(txtSubjectName.Text.Trim(),txtSubjectNote.Text.Trim());
            if (dalSubject.AddSubject(sb) > 0)
            {
                btnRefreshSubject_Click(sender, e);
                MessageBox.Show("Successful!");
            }
            else
            {
                MessageBox.Show("Unsuccessful!");
            }
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            if(dtGVSubject.SelectedRows.Count == 1)
            {
                if(!CheckemptySubject() ) { return; }
                DataGridViewRow row = dtGVSubject.SelectedRows[0];
                int idSb = (int)row.Cells[0].Value;
                DTO_Subject sb = new DTO_Subject(idSb,txtSubjectName.Text.Trim(),txtSubjectNote.Text.Trim());
                if (dalSubject.UpdateSubject(sb) > 0)
                {
                    btnRefreshSubject_Click(sender, e);
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Select one subject to handle!");
            }
        }

        private void btnRefreshChapter_Click(object sender, EventArgs e)
        {
            RefreshChapter();
        }

        private void dtGVChapter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVChapter.Rows[e.RowIndex];
                txtChapterName.Text = row.Cells[1].Value.ToString().Trim();    
            }
        }
        bool CheckEmptyChapter()
        {
            if (txtChapterName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Chapter name is required!");
                return false;
                }
            return true;
        }
        private void btnAddChapter_Click(object sender, EventArgs e)
        {
            if(dtGVSubject.SelectedRows.Count > 0)
            {
               if(!CheckEmptyChapter()) { return; }
                DataGridViewRow row = dtGVSubject.SelectedRows[0];
                int idSb = (int)row.Cells[0].Value;
                DTO_Subject sb = new DTO_Subject(idSb);
                DTO_Chapter cp = new DTO_Chapter(txtChapterName.Text.Trim(),sb);
                if (dalChapter.AddChapter(cp) > 0)
                {
                    btnRefreshChapter_Click(sender, e);
                    MessageBox.Show("Successful!");

                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Select one subject to add chapter!");
            }
        }

        private void btnUpdateChapter_Click(object sender, EventArgs e)
        {
            if(dtGVChapter.SelectedRows.Count == 1 ) { 
                if(!CheckEmptyChapter() ) { return; }
                DataGridViewRow row = dtGVChapter.SelectedRows[0];
                DTO_Chapter cp = new DTO_Chapter((int)row.Cells[0].Value,txtChapterName.Text.Trim());
                if (dalChapter.UpdateChapter(cp) > 0)
                {
                    btnRefreshChapter_Click(sender, e);
                    MessageBox.Show("Successful!");

                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }

            } 
            else
            {
                MessageBox.Show("Select one chapter to handle!");
            }
        }

        private void btnRemoveChapter_Click(object sender, EventArgs e)
        {
            if(dtGVChapter.SelectedRows.Count>0 )
            {
                List<DTO_Chapter> cps = new List<DTO_Chapter>();    
                foreach(DataGridViewRow row in dtGVChapter.SelectedRows)
                {
                    DTO_Chapter cp = new DTO_Chapter((int)row.Cells[0].Value);
                    cps.Add(cp);
                }
                if(dalChapter.RemoveChapter(cps)>0) {

                    RefreshChapter();
                    MessageBox.Show("Successful!");
                } else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Select chapters to handle!");
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if(dtGVSubject.SelectedRows.Count>0 ) {

                List<DTO_Subject> sbs = new List<DTO_Subject>();
                foreach(DataGridViewRow row in dtGVSubject.SelectedRows)
                {
                    DTO_Subject sb = new DTO_Subject((int)row.Cells[0].Value);
                    sbs.Add(sb);
                }
                if (dalSubject.RemoveSubject(sbs) > 0)
                {
                    btnRefreshSubject_Click(sender, e);
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            } else
            {
                MessageBox.Show("Select subjects to handle!");
            }
        }

        private void btnAddSubject_MouseEnter(object sender, EventArgs e)
        {
            btnAddSubject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddSubject_MouseLeave(object sender, EventArgs e)
        {
            btnAddSubject.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void btnRemoveSubject_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveSubject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRemoveSubject_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveSubject.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void btnRemoveChapter_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveChapter.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRemoveChapter_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveChapter.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void btnAddChapter_MouseEnter(object sender, EventArgs e)
        {
            btnAddChapter.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddChapter_MouseLeave(object sender, EventArgs e)
        {
            btnAddChapter.ForeColor = ColorTranslator.FromHtml("99, 180, 86");

        }

        private void btnUpdateSubject_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateSubject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnUpdateSubject_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateSubject.ForeColor = ColorTranslator.FromHtml("82, 146, 199");

        }

        private void btnUpdateChapter_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateChapter.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnUpdateChapter_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateChapter.ForeColor = ColorTranslator.FromHtml("#82, 146, 199");

        }

        private void btnRefreshSubject_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshSubject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRefreshSubject_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshSubject.ForeColor = ColorTranslator.FromHtml("81, 63, 102");

        }

        private void btnRefreshChapter_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshChapter.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRefreshChapter_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshChapter.ForeColor = ColorTranslator.FromHtml("81, 63, 102");
        }
    }
}
