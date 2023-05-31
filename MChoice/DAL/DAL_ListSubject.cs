using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DAL
{
    public class DAL_ListSubject
    {
        DataProvider dataProvider = new DataProvider();
        public DAL_ListSubject() { }
        public DataTable GetListSubjectByClassID (DTO_Class cl)
        {
            string querry = string.Format("select ls.ID,SB.NAME_SB as 'Subject Name' from LIST_SUBJECT ls join SB on ls.ID_SUBJECT = SB.ID where ls.ID_CLASS = {0}",cl.idClass);
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddListSubject(DTO_ListSubject lsSb)
        {
            try
            {
                string querry = string.Format("insert into LIST_SUBJECT values({0},{1})",lsSb.cl.idClass,lsSb.sb.idSubject);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {
            }
            return 0;   
        }
        public DataTable GetListSubjectAvailable(DTO_Student student)
        {
            string querry = string.Format("select ex.ID_SB from RESULT rs join EXAM ex on ex.ID = rs.ID_EXAM where ID_STUDENT = {0}", student.idStudent);
            DataTable dtIDSubjectUnavailable = dataProvider.ExecuteQuerry(querry);
            if(dtIDSubjectUnavailable.Rows.Count<=0) {
                querry = string.Format("select ID_SUBJECT,sb.NAME_SB as 'Subject' from LIST_SUBJECT join SB on SB.ID = LIST_SUBJECT.ID_SUBJECT where ID_CLASS = {0}", student.cl.idClass);
                return dataProvider.ExecuteQuerry(querry);
            }
            List<int> listIDSBUnavailable = new List<int>();    
            foreach (DataRow dr in dtIDSubjectUnavailable.Rows) {
                listIDSBUnavailable.Add((int)dr[0]);
            }
            string st = "";
            int index = 0;
            foreach(int id in listIDSBUnavailable)
            {
                if(index == 0)
                {
                    st += id.ToString();
                    index++;
                }
                else
                {
                    st += "," + id.ToString();
                }
                
            }
            querry = string.Format("select ID_SUBJECT,sb.NAME_SB as 'Subject' from LIST_SUBJECT join SB on SB.ID = LIST_SUBJECT.ID_SUBJECT where ID_CLASS = {0} and ID_SUBJECT not in ({1}) ",student.cl.idClass,st);
            return dataProvider.ExecuteQuerry(querry);
        }
        public int RemoveLsSb(List<DTO_ListSubject> lsSB)
        {
            try
            {
                foreach (DTO_ListSubject ls in lsSB) {
                    string querry = string.Format("delete from LIST_SUBJECT where ID = {0}",ls.idListSubjedt);
                    if(dataProvider.ExecuteNonQuerry(querry)<=0) {
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
