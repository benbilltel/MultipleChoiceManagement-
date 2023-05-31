using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChoice.DAL
{
    public class DAL_Quizz
    {
        DataProvider dataProvider = new DataProvider();
        public DAL_Quizz() { }
        public DataTable GetListQuizz(DTO_Exam exam)
        {
            string querry = string.Format("select q.ID,c.NAME_CHAPTER as 'Chapter Name',q.CONTENT as'Content',q.AN_A as 'A',q.AN_B as 'B',q.AN_C as 'C',q.AN_D as 'D',q.CORRECT_AN from LIST_QUIZZES ls join EXAM ex on ex.ID = ls.ID_EXAM join QUIZZ q on q.ID = ls.ID_QUIZZ join CHAPTER c on c.ID = q.ID_CHAPTER where ex.ID = {0}",exam.idExam);
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddQuizz(DTO_Exam exam,DTO_Quizz quizz) {
            try
            {
                string querry = string.Format("EXEC ADDQUIZZ @idExam = {0},@content = N'{1}',@anA =N'{2}',@anB = N'{3}',@anC = N'{4}',@anD = N'{5}',@correcrAn =N'{6}',@idChapter = '{7}'", exam.idExam, quizz.content.Trim()
                    ,quizz.anA.Trim(),quizz.anB.Trim(),quizz.anC.Trim(),quizz.anD.Trim(),quizz.correctAn.Trim(),quizz.chapter.idChapter);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public int UpdateQuizz(DTO_Quizz quizz)
        {
            try
            {
                string querry = string.Format("update QUIZZ set CONTENT = N'{0}',AN_A = N'{1}',AN_B = N'{2}',AN_C = N'{3}',AN_D = N'{4}',CORRECT_AN = N'{5}', ID_CHAPTER = {6} where ID = {7}", quizz.content.Trim()
                    , quizz.anA.Trim(), quizz.anB.Trim(), quizz.anC.Trim(), quizz.anD.Trim(), quizz.correctAn.Trim(), quizz.chapter.idChapter, quizz.idQuizz);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public int RemoveListQuizz(List<DTO_Quizz> quizzes)
        {
            try
            {
                foreach (DTO_Quizz quizz in quizzes)
                {
                    string querry = string.Format("select count(*) from LIST_QUIZZES where ID_QUIZZ = {0}",quizz.idQuizz);
                    if((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("delete from LIST_QUIZZES where ID_QUIZZ = {0}", quizz.idQuizz);
                        if(dataProvider.ExecuteNonQuerry(querry)<=0)
                        {
                            return 0;
                        }
                    }
                    querry = string.Format("select count(*) from ANSWER_INFO where ID_QUIZZ = {0}", quizz.idQuizz);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("delete from ANSWER_INFO where ID_QUIZZ = {0}", quizz.idQuizz);
                        if (dataProvider.ExecuteNonQuerry(querry) <= 0)
                        {
                            return 0;
                        }
                    }

                    querry = string.Format("delete from QUIZZ where ID = {0}", quizz.idQuizz);
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
