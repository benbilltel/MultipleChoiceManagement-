using MChoice.DTO;
using MChoice.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DAL
{
    public class DAL_UserAdmin
    {
        DataProvider dataProvider = new DataProvider();
        public DAL_UserAdmin() { }
        public DataTable GetUserAdmin()
        {
            string querry = string.Format("select ID,USERNAME as 'Username' , PASS_WORD as 'Password' from USER_ADMIN");
            return dataProvider.ExecuteQuerry(querry);
        }
        public int AddUserAdmin(DTO_UserAdmin admin)
        {
            try
            {
                string querry = string.Format("insert into USER_ADMIN values (N'{0}',N'{1}')", admin.usName.Trim(), admin.pass.Trim());
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public int UpdateUserAdmin(DTO_UserAdmin admin)
        {
            try
            {
                string querry = string.Format("update USER_ADMIN set USERNAME = N'{0}',PASS_WORD = N'{1}' where ID = {2}", admin.usName.Trim(), admin.pass.Trim(),admin.idUserAdmin);
                return dataProvider.ExecuteNonQuerry(querry);
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public int RemoveUserAdmin(List<DTO_UserAdmin> ads)
        {
            try
            {
                foreach (DTO_UserAdmin ad in ads)
                {
                    string querry = string.Format("delete from USER_ADMIN where ID = {0}", ad.idUserAdmin);
                    if(dataProvider.ExecuteNonQuerry(querry)<=0)
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
