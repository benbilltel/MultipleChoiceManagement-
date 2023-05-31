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
    public class DAL_Chapter
    {
        DataProvider dataProvider = new DataProvider();
        public DAL_Chapter() { }
        public DataTable GetChapterBySubject(DTO_Subject sb)
        {
            string querry = string.Format("select ID,NAME_CHAPTER as 'Chapter Name',ID_SB from CHAPTER where ID_SB = {0}",sb.idSubject);
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddChapter(DTO_Chapter chapter)
        {
            try
            {
                string querry = string.Format("insert into CHAPTER values (N'{0}',{1})",chapter.nameChapter.Trim(),chapter.subject.idSubject);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public int UpdateChapter(DTO_Chapter chapter)
        {
            try
            {
                string querry = string.Format("update CHAPTER set NAME_CHAPTER = N'{0}' where ID = {1} ", chapter.nameChapter.Trim(), chapter.idChapter);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        DAL_Quizz dalQuizz  = new DAL_Quizz();
        public int RemoveChapter(List<DTO_Chapter> cps)
        {
            try
            {
                foreach (DTO_Chapter cp in cps)
                {
                    string querry = string.Format("select count(*) from QUIZZ where ID_CHAPTER = {0}", cp.idChapter);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("select ID from QUIZZ where ID_CHAPTER = {0}",cp.idChapter);
                        DataTable dtIDQuizz = dataProvider.ExecuteQuerry(querry);
                        List<DTO_Quizz>quizzes = new List<DTO_Quizz>(); 
                        foreach (DataRow dr in dtIDQuizz.Rows)
                        {
                            DTO_Quizz quizz = new DTO_Quizz((int)dr[0]);
                            quizzes.Add(quizz);
                        }
                        if(dalQuizz.RemoveListQuizz(quizzes) <= 0)
                        {
                            return 0;
                        }

                    }
                    querry = string.Format("delete from CHAPTER where ID = {0}", cp.idChapter);
                    if(dataProvider.ExecuteNonQuerry(querry) <= 0) {
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
