using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DAL
{
    public class DAL_Class
    {
        DataProvider dataProvider= new DataProvider();
        public DAL_Class() { }
        public DataTable GetClass()
        {
            string querry = string.Format("select ID, NAME_CLASS as 'Class Name' from CLASS");
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddClass(DTO_Class cl)
        {
            try
            {
                string querry = string.Format("insert into CLASS values(N'{0}')",cl.nameClass.Trim());
                return dataProvider.ExecuteNonQuerry(querry);   
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public int UpdateClass(DTO_Class cl)
        {
            try
            {
                string querry = string.Format("update CLASS set NAME_CLASS = N'{0}' where ID = {1}", cl.nameClass.Trim(),cl.idClass);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        DAL_Student dalStudent = new DAL_Student();
        DAL_ListSubject dalLssb = new DAL_ListSubject();
        public int RemoveClass(List<DTO_Class> cls)
        {
            try
            {
                foreach(DTO_Class cl in cls)
                {
                    string querry = string.Format("select count(*) from STUDENT where ID_CLASS = {0}",cl.idClass);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("select ID from STUDENT where ID_CLASS = {0}", cl.idClass);
                        DataTable dtIDStudent = dataProvider.ExecuteQuerry(querry);
                        List<DTO_Student> rss = new List<DTO_Student>();
                        foreach (DataRow dr in dtIDStudent.Rows)
                        {
                            DTO_Student rs = new DTO_Student((int)dr[0]);
                            rss.Add(rs);
                        }
                        if (dalStudent.RemoveStudent(rss) <= 0)
                        {
                            return 0;
                        }
                    }
                    querry = string.Format("select count(*) from LIST_SUBJECT where ID_CLASS = {0}", cl.idClass);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("select ID from LIST_SUBJECT where ID_CLASS = {0}", cl.idClass);
                        DataTable dtIDStudent = dataProvider.ExecuteQuerry(querry);
                        List<DTO_ListSubject> rss = new List<DTO_ListSubject>();
                        foreach (DataRow dr in dtIDStudent.Rows)
                        {
                            DTO_ListSubject rs = new DTO_ListSubject((int)dr[0]);
                            rss.Add(rs);
                        }
                        if (dalLssb.RemoveLsSb(rss) <= 0)
                        {
                            return 0;
                        }
                    }
                    querry = string.Format("delete from CLASS where ID = {0}", cl.idClass);
                    if(dataProvider.ExecuteNonQuerry(querry) <= 0)
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
