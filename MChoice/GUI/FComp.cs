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
    public partial class FComp : Form
    {
        public FComp()
        {
            InitializeComponent();
        }
        public FComp(int idSubject, int idStudent)
        {
            InitializeComponent();
            this.idSubject = idSubject;
            this.idStudent = idStudent;
        }
        int idSubject;
        int idStudent;
        bool isOut = true;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitAnswers();
            if(score != -1)
            {
                DTO_Exam exam = new DTO_Exam(idExamCrr);
                DTO_Student st = new DTO_Student(idStudent);
                DTO_Result rs = new DTO_Result(exam,st,score);
                if (dalResult.AddResult(rs) > 0)
                {
                    MessageBox.Show("Your score was saved!");
                    isOut = false;
                    this.Close();
                    FStudentClient fStudentClient = new FStudentClient(idStudent);
                    fStudentClient.Show();
                }
                else
                {
                    MessageBox.Show("Your score was not saved!Something is wrong!");
                }
                
            }
            else
            {
                MessageBox.Show("Your score was not saved!");
            }
            
        }

        private void FComp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isOut)
            {
                Application.Exit();
            }
        }
        DataTable dtExamInfo,dtListQuizz;
        DAL_Exam dalExam = new DAL_Exam();
        DAL_Quizz dalQuizz = new DAL_Quizz();
        int idExamCrr;
        private void FComp_Load(object sender, EventArgs e)
        {
            dtExamInfo = dalExam.GetExamAvailableByIdSubject(idSubject);
            if(dtExamInfo.Rows.Count>0)
            {
                DataRow row = dtExamInfo.Rows[0];
                idExamCrr = (int)row[0];
                DTO_Exam exam = new DTO_Exam(idExamCrr);
                dtListQuizz = dalQuizz.GetListQuizz(exam);
                if(dtListQuizz.Rows.Count>0) {
                    dtListQuizz.Columns.Add("UserChoice", typeof(string));
                    LoadQuestion(currentQuestionIndex);
                }
                else
                {
                    MessageBox.Show("Exam is unavailable!");
                    isOut = false;
                    this.Close();
                    FStudentClient fStudentClient = new FStudentClient(idStudent);
                    fStudentClient.Show();
                }
                
            }
            else
            {
                MessageBox.Show("No exam available!");
                isOut = false;
                this.Close();
                FStudentClient fStudentClient = new FStudentClient(idStudent);
                fStudentClient.Show();
            }
           
        }
        private int currentQuestionIndex = 0;

        private void btnPrevious_Click(object sender, EventArgs e)
        {
         
            DataRow questionRow = dtListQuizz.Rows[currentQuestionIndex];
            if (rdA.Checked)
            {
                questionRow["UserChoice"] = questionRow[3].ToString().Trim();
            }
            else if (rdB.Checked)
            {
                questionRow["UserChoice"] = questionRow[4].ToString().Trim();
            }
            else if (rdC.Checked)
            {
                questionRow["UserChoice"] = questionRow[5].ToString().Trim();
            }
            else if (rdD.Checked)
            {
                questionRow["UserChoice"] = questionRow[6].ToString().Trim();
            }

         
            currentQuestionIndex--;

            LoadQuestion(currentQuestionIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
         
            DataRow questionRow = dtListQuizz.Rows[currentQuestionIndex];
            if (rdA.Checked)
            {
                questionRow["UserChoice"] = questionRow[3].ToString().Trim();
            }
            else if (rdB.Checked)
            {
                questionRow["UserChoice"] = questionRow[4].ToString().Trim();
            }
            else if (rdC.Checked)
            {
                questionRow["UserChoice"] = questionRow[5].ToString().Trim();
            }
            else if (rdD.Checked)
            {
                questionRow["UserChoice"] = questionRow[6].ToString().Trim();
            }

     
            currentQuestionIndex++;

          
            if (currentQuestionIndex >= dtListQuizz.Rows.Count)
            {
                SubmitAnswers();
                
                this.Close();
                return;
            }

            LoadQuestion(currentQuestionIndex);
        }
        DAL_Result dalResult = new DAL_Result();
        float score = -1f;
        private void SubmitAnswers()
        {

            int correctAnswers = 0;
            foreach (DataRow questionRow in dtListQuizz.Rows)
            {
                if (questionRow["UserChoice"].ToString() == questionRow[7].ToString())
                {
                    correctAnswers++;
                }
            }

            score = ((float)correctAnswers / (float)dtListQuizz.Rows.Count) * 10f;
            score = (float)Math.Round(score, 2);
            MessageBox.Show($"You scored {score}/10 on the exam.");
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void LoadQuestion(int questionIndex)
        {
          
            DataRow questionRow = dtListQuizz.Rows[questionIndex];

           
            lblQuestion.Text = questionRow[2].ToString() + ":";

         
            rdA.Text = questionRow[3].ToString();
            rdB.Text = questionRow[4].ToString();
            rdC.Text = questionRow[5].ToString();
            rdD.Text = questionRow[6].ToString();

         
            if (!string.IsNullOrEmpty(questionRow["UserChoice"].ToString()))
            {
                if (questionRow["UserChoice"].ToString().Trim().Equals(questionRow[3].ToString().Trim()))
                {
                    rdA.Checked = true;
                }
                if (questionRow["UserChoice"].ToString().Trim().Equals(questionRow[4].ToString().Trim()))
                {
                    rdB.Checked = true;
                }
                if (questionRow["UserChoice"].ToString().Trim().Equals(questionRow[5].ToString().Trim()))
                {
                    rdC.Checked = true;
                }
                if (questionRow["UserChoice"].ToString().Trim().Equals(questionRow[6].ToString().Trim()))
                {
                    rdD.Checked = true;
                }
            }
            else
            {
               
                rdA.Checked = false;
                rdB.Checked = false;
                rdC.Checked = false;
                rdD.Checked = false;
            }

           
            btnPrevious.Enabled = (questionIndex > 0);
            btnNext.Enabled = (questionIndex < dtListQuizz.Rows.Count - 1);
        }
    }
}
