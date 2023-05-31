using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DAL
{
    public class DAL_Exam
    {
        DataProvider dataProvider= new DataProvider();
        public DAL_Exam() { }   
        public DataTable GetExamBySubjectAvail(DTO_Subject sb)
        {
            string querry = string.Format("select ID as 'ID Exam' from EXAM  where ID_SB = {0} and CHECKED = 0",sb.idSubject);
            return dataProvider.ExecuteQuerry(querry);
        }
        public DataTable GetExamBySubject(DTO_Subject sb)
        {
            string querry = string.Format("select ID as 'ID Exam',CHECKED as 'Checked' from EXAM  where ID_SB = {0}", sb.idSubject);
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddExam(DTO_Subject sb)
        {
            try
            {
                string querry = string.Format("insert into EXAM(ID_SB) values ({0})",sb.idSubject);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {


            }
            return 0;
        }
        public DataTable GetExamAvailableByIdSubject(int idSubject)
        {
            string querry = string.Format("SELECT top 1 * FROM EXAM ex where ID_SB = {0} and CHECKED = 0",idSubject);
            return dataProvider.ExecuteQuerry(querry);
            
        }
        public int UpdateStatusExam(int idExam, bool check)
        {
            try
            {
                if (check)
                {
                    string querry = string.Format("update EXAM set CHECKED = 1 where ID = {0}", idExam);
                    if(dataProvider.ExecuteNonQuerry(querry) <= 0)
                    {
                        return 0;
                    }
                }
                else
                {
                    string querry = string.Format("update EXAM set CHECKED = 0 where ID = {0}", idExam);
                    if (dataProvider.ExecuteNonQuerry(querry) <= 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
            catch (Exception)
            {

            }
            return 0;
        }
        DAL_Result dalResult = new DAL_Result();
        DAL_Quizz dalQuizz  = new DAL_Quizz();  
        
        public int RemoveExam(List<DTO_Exam> exs)
        {
            try
            {
                foreach (DTO_Exam ex  in exs)
                {
                    string querry = string.Format("select count(*) from RESULT where ID_EXAM = {0}",ex.idExam);
                    if((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("select ID from RESULT where ID_EXAM = {0}", ex.idExam);
                        DataTable dtIDResult = dataProvider.ExecuteQuerry(querry);
                        List<DTO_Result> rss = new List<DTO_Result>();
                        foreach (DataRow dr in dtIDResult.Rows)
                        {
                            DTO_Result rs = new DTO_Result((int)dr[0]);
                            rss.Add(rs);
                        }
                        if (dalResult.RemoveResult(rss) <= 0)
                        {
                            return 0;
                        }
                    }
                    querry = string.Format("select count(*) from LIST_QUIZZES where ID_EXAM = {0}",ex.idExam);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("select ID_QUIZZ from LIST_QUIZZES where ID_EXAM = {0}", ex.idExam);
                        DataTable dtIDQuizz = dataProvider.ExecuteQuerry(querry);   
                        List<DTO_Quizz> quizzes = new List<DTO_Quizz>();
                        foreach (DataRow dr in dtIDQuizz.Rows)
                        {
                            DTO_Quizz quizz = new DTO_Quizz((int)dr[0]);
                            quizzes.Add(quizz);
                        }
                        if (dalQuizz.RemoveListQuizz(quizzes) <= 0)
                        {
                            return 0;

                        }
                        
                    }
                    querry = string.Format("delete from EXAM where ID = {0}", ex.idExam);
                    if (dataProvider.ExecuteNonQuerry(querry) <= 0)
                    {
                        return 0;
                    }

                }
                return 1;
            }
            catch (Exception)
            {

            }
            return 0;
        }
    }
}
