using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_UserAdmin
    {
        public int idUserAdmin { get; set; }
        public string usName { get; set; }
        public string pass { get; set; }
        public DTO_UserAdmin() { }
        public DTO_UserAdmin(int idUserAdmin)
        {
            this.idUserAdmin = idUserAdmin;
        }
        public DTO_UserAdmin(string usName, string pass)
        {
            this.usName = usName;
            this.pass = pass;

        }
        public DTO_UserAdmin(int idUserAdmin, string usName, string pass)
        {
            this.idUserAdmin = idUserAdmin;
            this.usName = usName;
            this.pass = pass;
        }
    }
}
