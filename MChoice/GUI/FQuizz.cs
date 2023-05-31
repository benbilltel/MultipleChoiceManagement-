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

namespace MChoice.GUI
{
    public partial class FQuizz : Form
    {
        public FQuizz()
        {
            InitializeComponent();
        }
        DAL_Subject dalSubject = new DAL_Subject();
        DAL_Exam dalExam = new DAL_Exam();
        DAL_Chapter dalChapter = new DAL_Chapter();
        DAL_Quizz dalQuizz = new DAL_Quizz();
        DataTable dtSubject = null,dtChapter = null;
        void LoadCBSubject()
        {

            dtSubject = dalSubject.GetSubject();
            cbSubjectName.Items.Clear();
            if (dtSubject.Rows.Count > 0)
            {
               
                    foreach (DataRow row in dtSubject.Rows)
                    {
                        cbSubjectName.Items.Add(row[1].ToString().Trim());
                    }
                cbSubjectName.Text = cbSubjectName.Items[0].ToString().Trim();

            }
            else
            {
                cbSubjectName.Text = string.Empty;
            }

        }
        void LoadCBChapter ()
        {
            int idSB = -1;
            foreach (DataRow row in dtSubject.Rows)
            {
                if (cbSubjectName.Text.Trim().Equals(row[1].ToString().Trim()))
                {
                    idSB = (int)row[0];
                    break;
                }

            }if(idSB > 0)
            {
                DTO_Subject sb = new DTO_Subject(idSB);
                dtChapter = dalChapter.GetChapterBySubject(sb);
                cbChapter.Items.Clear();
                if (dtChapter.Rows.Count > 0)
                {
                    foreach (DataRow row in dtChapter.Rows)
                    {
                        cbChapter.Items.Add(row[1].ToString().Trim());
                    }
                    cbChapter.Text = cbChapter.Items[0].ToString().Trim();
                }
                else
                {
                    cbChapter.Text = string.Empty;
                }
            }
            
        }
        private void FQuizz_Load(object sender, EventArgs e)
        {
            LoadCBSubject();
            LoadCBChapter();
            if(dtGVExam.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGVExam.SelectedRows[0];
                DTO_Exam exam = new DTO_Exam((int)row.Cells[0].Value);
                LoadListQuizzesByExam(exam);
            }
            


        }
        void LoadDataExamBySubject(DTO_Subject sb)
        {
            dtGVExam.DataSource = dalExam.GetExamBySubjectAvail(sb);
            dtGVExam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void LoadListQuizzesByExam(DTO_Exam exam)
        {
            dtGVQuizz.DataSource = dalQuizz.GetListQuizz(exam);
            dtGVQuizz.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dtGVQuizz.Columns["ID"].Visible = false;
            dtGVQuizz.Columns["CORRECT_AN"].Visible = false;
        }
        private void dtGVExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVExam.Rows[e.RowIndex];
                DTO_Exam exam = new DTO_Exam((int)row.Cells[0].Value);
                LoadListQuizzesByExam(exam);
            }
        }
        void DisplayCorrectAnswer(List<string> ans,string crAn)
        {
            int index = 0;
            foreach (string an in ans)
            {
                if (an == crAn)
                {
                    break;
                }
                index++;
            }
            switch (index)
            {
                case 0:
                    rdA.Checked = true;
                    break;
                case 1: rdB.Checked = true; break;
                case 2: rdC.Checked = true; break;
                case 3: rdD.Checked = true; break;
                default: break;
            }
        }
        private void dtGVQuizz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVQuizz.Rows[e.RowIndex];
                txtContent.Text = row.Cells[2].Value.ToString().Trim();
                txtAnA.Text = row.Cells[3].Value.ToString().Trim();
                txtAnB.Text = row.Cells[4].Value.ToString().Trim();
                txtAnC.Text = row.Cells[5].Value.ToString().Trim();
                txtAnD.Text = row.Cells[6].Value.ToString().Trim();
                cbChapter.Text = row.Cells[1].Value.ToString().Trim();
                List<string> listAns = new List<string>();
                listAns.AddRange(new[] { txtAnA.Text.Trim(), txtAnB.Text.Trim(), txtAnC.Text.Trim(), txtAnD.Text.Trim() });
                DisplayCorrectAnswer(listAns, row.Cells[7].Value.ToString().Trim());
            }
        }
        bool CheckEmptyQuizz()
        {
            if(txtContent.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Content is required!");
                return false;
            }
            if (txtAnA.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Answer A is required!");
                return false;
            }
            if (txtAnB.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Answer B is required!");
                return false;
            }
            if (txtAnC.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Answer C is required!");
                return false;
            }
            if (txtAnD.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Answer D is required!");
                return false;
            }
            if(cbChapter.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Chapter D is required!");
                return false;
            }
            List<RadioButton> rds = new List<RadioButton>();
            rds.AddRange(new[] { rdA, rdB, rdC, rdD });
            if (!CheckRadioButtons(rds))
            {
                MessageBox.Show("Chose one correct answer!");
                return false;
            }
            return true;
        }
        bool CheckRadioButtons(List<RadioButton> radios)
        {
            foreach (var radio in radios)
            {
                if (radio.Checked)
                {
                    return true;
                }
            }
            return false;
        }
        string GetCorrectAnswer(List<RadioButton> rds)
        {
            int index = 0;
            foreach(RadioButton radio in rds) { 
                if(radio.Checked)
                {
                    break;
                }
                index++;
            }
            switch (index)
            {
                case 0: return txtAnA.Text.Trim();break;
                case 1: return txtAnB.Text.Trim(); break;
                case 2: return txtAnC.Text.Trim(); break;
                case 3: return txtAnD.Text.Trim(); break;
                    default: return null;
            }
        }
        private void btnAddQuizz_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyQuizz())
            {
                return;
            }
            if (dtGVExam.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGVExam.SelectedRows[0];
                int idExam = (int)row.Cells[0].Value;
                DTO_Exam exam = new DTO_Exam(idExam);
                List<RadioButton> rds = new List<RadioButton>();
                rds.AddRange(new[] { rdA, rdB, rdC, rdD });
                string crrAn = GetCorrectAnswer(rds);
                int idChapter = -1;
                foreach (DataRow dr in dtChapter.Rows)
                {
                    if (cbChapter.Text.Trim().Equals(dr[1].ToString().Trim()))
                    {
                        idChapter = (int)dr[0];
                        break;
                    }
                }
                if (idChapter != -1)
                {
                    DTO_Chapter chapter = new DTO_Chapter(idChapter);
                    DTO_Quizz quizz = new DTO_Quizz(txtContent.Text.Trim(), txtAnA.Text.Trim(), txtAnB.Text.Trim(), txtAnC.Text.Trim(), txtAnD.Text.Trim(),crrAn.Trim(),chapter);
                    if (dalQuizz.AddQuizz(exam, quizz) > 0)
                    {
                        RefreshQuizz();
                        MessageBox.Show("Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful!");
                    }
                }
                else
                {
                    MessageBox.Show("Chapter name does not exist!");
                    return;
                }
                 
            }
            else
            {
                MessageBox.Show("Select one ID exam to handle!");

            }
        }
        void RefreshQuizz()
        {
            txtContent.Text = string.Empty;
            txtAnA.Text = string.Empty;
            txtAnB.Text = string.Empty;
            txtAnC.Text = string.Empty;
            txtAnD.Text = string.Empty;
            cbChapter.Text = cbChapter.Items[0].ToString().Trim();
            rdA.Checked = false; rdB.Checked = false; rdC.Checked = false; rdD.Checked = false;
            if(dtGVExam.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGVExam.SelectedRows[0];
                int idExam = (int)row.Cells[0].Value;
                DTO_Exam exam = new DTO_Exam(idExam);
                LoadListQuizzesByExam(exam);
            }
           
        }

        private void btnRefreshQuizz_Click(object sender, EventArgs e)
        {
            RefreshQuizz();
        }

        private void btnUpdateQuizz_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyQuizz())
            {
                return;
            }
            if(dtGVQuizz.SelectedRows.Count == 1)
            {
                List<RadioButton> rds = new List<RadioButton>();
                rds.AddRange(new[] { rdA, rdB, rdC, rdD });
                string crrAn = GetCorrectAnswer(rds);
                int idChapter = -1;
                foreach (DataRow dr in dtChapter.Rows)
                {
                    if (cbChapter.Text.Trim().Equals(dr[1].ToString().Trim()))
                    {
                        idChapter = (int)dr[0];
                        break;
                    }
                }
                if (idChapter != -1)
                {
                    DataGridViewRow row = dtGVQuizz.SelectedRows[0];
                    DTO_Chapter chapter = new DTO_Chapter(idChapter);
                    DTO_Quizz quizz = new DTO_Quizz((int)row.Cells[0].Value,txtContent.Text.Trim(), txtAnA.Text.Trim(), txtAnB.Text.Trim(), txtAnC.Text.Trim(), txtAnD.Text.Trim(), crrAn.Trim(), chapter);
                    if (dalQuizz.UpdateQuizz(quizz) > 0)
                    {
                        RefreshQuizz();
                        MessageBox.Show("Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful!");
                    }
                }
                else
                {
                    MessageBox.Show("Chapter name does not exist!");

                }
            }
            else
            {
                MessageBox.Show("Select one quizz to handle!");
            }
            
        }

        private void btnRemoveQuizz_Click(object sender, EventArgs e)
        {
            if (dtGVQuizz.SelectedRows.Count > 0)
            {
                List<DTO_Quizz> quizzes = new List<DTO_Quizz>();
                foreach (DataGridViewRow row  in dtGVQuizz.SelectedRows)
                {
                    DTO_Quizz quizz = new DTO_Quizz((int)row.Cells[0].Value);
                    quizzes.Add(quizz);
                }
                if(dalQuizz.RemoveListQuizz(quizzes) > 0)
                {
                    RefreshQuizz();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Select quizzes to handle!");
            }
        }

        private void btnAddQuizz_MouseEnter(object sender, EventArgs e)
        {
            btnAddQuizz.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddQuizz_MouseLeave(object sender, EventArgs e)
        {
            btnAddQuizz.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void btnRemoveQuizz_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveQuizz.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnRemoveQuizz_DragLeave(object sender, EventArgs e)
        {
        }

        private void btnRemoveQuizz_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveQuizz.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void btnUpdateQuizz_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateQuizz.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnUpdateQuizz_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateQuizz.ForeColor = ColorTranslator.FromHtml("82, 146, 199");
        }

        private void btnRefreshQuizz_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshQuizz.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRefreshQuizz_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshQuizz.ForeColor = ColorTranslator.FromHtml("81, 63, 102");
        }

        private void cbSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubjectName.Items.Count > 0)
            {
                int idSB = -1;
                foreach (DataRow dr in dtSubject.Rows)
                {
                    if (cbSubjectName.Text.Trim().Equals(dr[1].ToString()))
                    {
                        idSB = (int)dr[0];
                        break;
                    }
                }
                if (idSB == -1)
                {
                    MessageBox.Show("Subject does not existed to handle!");
                    return;
                }
                DTO_Subject sb = new DTO_Subject(idSB);
                LoadDataExamBySubject(sb);
                LoadCBChapter();
            }
            if (dtGVExam.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGVExam.SelectedRows[0];
                DTO_Exam exam = new DTO_Exam((int)row.Cells[0].Value);
                LoadListQuizzesByExam(exam);
            }
        }
    }
}
