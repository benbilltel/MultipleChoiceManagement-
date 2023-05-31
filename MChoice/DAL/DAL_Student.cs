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
    public class DAL_Student
    {
        DataProvider dataProvider = new DataProvider();
        public DAL_Student() { }
        public DataTable GetStudentByClass(DTO_Class cl)
        {
            string querry = string.Format("select st.ID,FIRST_NAME as 'First Name',LAST_NAME as 'Last Name' ,GENDER as 'Gender',PHONE_CONTACT as 'Phone Contact',cl.NAME_CLASS from STUDENT st join CLASS cl on cl.ID = ID_CLASS where ID_CLASS = {0}",cl.idClass);
            return dataProvider.ExecuteQuerry(querry);
        }
        public DataTable GetStudentById(int id)
        {
            string querry = string.Format("select st.ID,st.FIRST_NAME,st.LAST_NAME,st.GENDER,st.PHONE_CONTACT,st.ID_CLASS,cl.NAME_CLASS from STUDENT st join CLASS cl on cl.ID = st.ID_CLASS where st.ID = {0}", id);
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddStudent(DTO_Student student)
        {
            try
            {
                string querry = string.Format("insert into STUDENT values (N'{0}',N'{1}','{2}','{3}',{4})",student.firstName.Trim(),
                    student.lastName.Trim(),student.gender.Trim(),student.phoneContact.Trim(),student.cl.idClass);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public int UpdateStudent(DTO_Student student)
        {
            try
            {
                string querry = string.Format("update STUDENT set FIRST_NAME=N'{0}',LAST_NAME = N'{1}',GENDER = '{2}', PHONE_CONTACT = '{3}',ID_CLASS = {4} where ID = {5}", student.firstName.Trim(),
                    student.lastName.Trim(), student.gender.Trim(), student.phoneContact.Trim(), student.cl.idClass,student.idStudent);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        DAL_Result dalResult = new DAL_Result();
        DAL_UserStudent dalUserStudent = new DAL_UserStudent();
        public int RemoveStudent(List<DTO_Student> stds)
        {
            try
            {
                foreach (DTO_Student std in stds)
                {
                    string querry = string.Format("select count(*) from RESULT where ID_STUDENT = {0}", std.idStudent);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("select ID from RESULT where ID_STUDENT = {0}", std.idStudent);
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
                    querry = string.Format("select count(*) from USER_STUDENT where ID_STUDENT = {0}", std.idStudent);
                    if ((int)dataProvider.ExecuteScalar(querry) > 0)
                    {
                        querry = string.Format("select ID from USER_STUDENT where ID_STUDENT = {0}", std.idStudent);
                        DataTable dtIDResult = dataProvider.ExecuteQuerry(querry);
                        List<DTO_UserStudent> rss = new List<DTO_UserStudent>();
                        foreach (DataRow dr in dtIDResult.Rows)
                        {
                            DTO_UserStudent rs = new DTO_UserStudent((int)dr[0]);
                            rss.Add(rs);
                        }
                        if (dalUserStudent.RemoveUserStudents(rss) <= 0)
                        {
                            return 0;
                        }
                    }
                    querry = string.Format("delete from STUDENT where ID = {0}", std.idStudent);
                    if (dataProvider.ExecuteNonQuerry(querry) <= 0)
                    {
                        return 0;
                    }
                }return 1;
                
            }
            catch (Exception)
            {

            }
            return 0;
        }
    }
}
