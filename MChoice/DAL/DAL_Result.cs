using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DAL
{
    public class DAL_Result
    {
        DataProvider dataProvider = new DataProvider();
        public DAL_Result() { }
        public DataTable GetResult () {
            string querry = string.Format("select rs.ID, st.ID as 'ID Student',st.FIRST_NAME as 'First Name',st.LAST_NAME as 'Last Name',cl.NAME_CLASS as 'Class',SB.NAME_SB as 'Subject' , rs.SCORE as 'Score' from RESULT rs join EXAM ex on ex.ID  = rs.ID_EXAM join STUDENT st on st.ID = rs.ID_STUDENT join SB on SB.ID = ex.ID_SB join CLASS cl on cl.ID = st.ID_CLASS");
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddResult(DTO_Result rs)
        {
            try
            {
                string querry = string.Format("insert into RESULT values ({0},{1},{2})",rs.exam.idExam,rs.student.idStudent,rs.score);
                if(dataProvider.ExecuteNonQuerry(querry)<=0) {
                    return 0;
                }
                querry = string.Format("update EXAM set CHECKED = 1 where ID = {0}",rs.exam.idExam);
                if (dataProvider.ExecuteNonQuerry(querry) <= 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public int RemoveResult(List<DTO_Result> rss)
        {
            try
            {
                foreach (DTO_Result rs in rss)
                {
                    string querry = string.Format("select count(*) from ANSWER_INFO where ID_RESULT = {0}", rs.idResult);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("delete from ANSWER_INFO where ID_RESULT = {0}", rs.idResult);
                        if (dataProvider.ExecuteNonQuerry(querry) <= 0)
                        {
                            return 0;
                        }
                    }

                    querry = string.Format("delete from RESULT where ID = {0}", rs.idResult);
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
