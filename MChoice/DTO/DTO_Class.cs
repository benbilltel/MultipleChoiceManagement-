using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_Class
    {
        public int idClass { get; set; }
        public string nameClass { get; set; }
        public DTO_Class() { }
        public DTO_Class(int idClass, string nameClass)
        {
            this.idClass = idClass;
            this.nameClass = nameClass;

        }
        public DTO_Class(string nameClass)
        {
            this.nameClass=nameClass;
        }
        public DTO_Class (int idClass)
        {
            this.idClass = idClass;
        }
    }
}
