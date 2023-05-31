using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DAL
{
    public class DAL_Subject
    {
        DataProvider dataProvider = new DataProvider();
        public DAL_Subject() { }
        public DataTable GetSubject()
        {
            string querry = string.Format("select ID,NAME_SB as 'Subject name',NOTE as 'Note' from SB");
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddSubject(DTO_Subject sb)
        {
            try
            {
                string querry = string.Format("insert into SB values (N'{0}',N'{1}')", sb.nameSubject.Trim(), sb.note.Trim());
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

                
            }
            return 0;
        }
        public int UpdateSubject(DTO_Subject sb) {
            try
            {
                string querry = string.Format("update SB set NAME_SB = N'{0}',NOTE = N'{1}' where ID = {2}", sb.nameSubject.Trim(), sb.note.Trim(),sb.idSubject);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {


            }
            return 0;
        }
        DAL_Exam dalExam = new DAL_Exam();
        public int RemoveSubject(List<DTO_Subject> sbs)
        {
            try
            {
                foreach (DTO_Subject sb in sbs)
                {
                    string querry = string.Format("select count(*) from EXAM where ID_SB = {0}", sb.idSubject);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("select ID from EXAM where ID_SB = {0}", sb.idSubject);
                        DataTable dtIDExam = dataProvider.ExecuteQuerry(querry);
                        List<DTO_Exam> exs = new List<DTO_Exam>();
                        foreach (DataRow dr in dtIDExam.Rows)
                        {
                            DTO_Exam ex = new DTO_Exam((int)dr[0]);
                            exs.Add(ex);
                        }
                        if (dalExam.RemoveExam(exs) <= 0)
                        {
                            return 0;
                        }
                    }
                    querry = string.Format("select count(*) from CHAPTER where ID_SB = {0}", sb.idSubject);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("delete from CHAPTER where ID_SB = {0}", sb.idSubject);
                        if(dataProvider.ExecuteNonQuerry(querry) <= 0)
                        {
                            return 0;
                        }
                    }
                    querry = string.Format("select count(*) from LIST_SUBJECT where ID_SUBJECT = {0}", sb.idSubject);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("delete from LIST_SUBJECT where ID_SUBJECT = {0}", sb.idSubject);
                        if (dataProvider.ExecuteNonQuerry(querry) <= 0)
                        {
                            return 0;
                        }
                    }
                    querry = string.Format("delete from SB where ID = {0}", sb.idSubject);
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
