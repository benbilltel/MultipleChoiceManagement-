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
    public class DAL_UserStudent
    {
        DataProvider dataProvider = new DataProvider();
        public DAL_UserStudent() { }
        public DataTable GetUserStudent()
        {
            string querry = string.Format("select * from USER_STUDENT");
            return dataProvider.ExecuteQuerry(querry);
        }
        public DataTable GetUserStudentByIdStudent(DTO_Student student)
        {
            string querry = string.Format("select ID,USERNAME as 'Username',PASS_WORD as 'Password' from USER_STUDENT where ID_STUDENT = {0}", student.idStudent);
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddUserStudent(DTO_UserStudent usSt) {
            try
            {
                
                string querry = string.Format("insert into USER_STUDENT values (N'{0}',N'{1}',{2},{3})",usSt.usname.Trim(),usSt.pass.Trim(),usSt.student.idStudent,usSt.cl.idClass);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {


            }
            return 0;
        }
        public int UpdateUserStudent(DTO_UserStudent usSt)
        {
            try
            {

                string querry = string.Format("update USER_STUDENT set USERNAME = N'{0}',PASS_WORD = N'{1}' where ID = {2}", usSt.usname.Trim(), usSt.pass.Trim(), usSt.id);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {


            }
            return 0;
        }
        public int RemoveUserStudents(List<DTO_UserStudent> usSt)
        {
            try
            {
                foreach (DTO_UserStudent userStudent in usSt)
                {
                    string querry = string.Format("delete from USER_STUDENT where ID = {0}", userStudent.id);
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
        public int RemoveUserStudent(DTO_UserStudent usSt)
        {
            try
            {
                
                    string querry = string.Format("delete from USER_STUDENT where ID = {0}", usSt.id);
                return dataProvider.ExecuteNonQuerry(querry);
                    
                

            }
            catch (Exception)
            {


            }
            return 0;
        }
    }
}
