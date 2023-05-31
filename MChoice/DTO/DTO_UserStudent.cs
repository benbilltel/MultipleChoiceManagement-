using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_UserStudent
    {
        public int id { get; set; }
        public string usname { get; set; }
        public string pass { get; set; }
        public DTO_Student student { get; set; }
        public DTO_Class cl     { get; set; }
        public DTO_UserStudent(int id, string usname, string pass,DTO_Student student,DTO_Class cl)
        {
            this.id = id;
            this.usname = usname;
                
            this.pass = pass;
            this.student = student;
            this.cl = cl;
        }
        public DTO_UserStudent( string usname, string pass, DTO_Student student, DTO_Class cl)
        {

            this.usname = usname;

            this.pass = pass;
            this.student = student;
            this.cl = cl;
        }
        public DTO_UserStudent(int id, string usname, string pass)
        {
            this.id = id;
            this.usname = usname;

            this.pass = pass;
            
        }
        public DTO_UserStudent() { }
        public DTO_UserStudent(int id)
        {
            this.id=id;
        }

    }
}
