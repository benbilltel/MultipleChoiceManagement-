using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_Subject
    {
        public int idSubject { get; set; }
        public string nameSubject { get; set; }
        public string note { get; set; }
        public DTO_Subject() { }
        public DTO_Subject(int idSubject, string nameSubject, string note)
        {
            this.idSubject = idSubject;
            this.nameSubject = nameSubject;
            this.note = note;
        }
        public DTO_Subject(int idSubject)
        {
            this.idSubject = idSubject;
        }
        public DTO_Subject(string nameSubject,string note)
        {
            this.nameSubject = nameSubject;
                this.note = note;
        }
    }
}
