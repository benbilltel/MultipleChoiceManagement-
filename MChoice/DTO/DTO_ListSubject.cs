using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_ListSubject
    {
        public int  idListSubjedt { get; set; }
        public DTO_Class cl { get; set; }
        public DTO_Subject sb { get; set; }
        public DTO_ListSubject() { }
        public DTO_ListSubject(int idListsubject) {
            this.idListSubjedt = idListsubject;
        }
        public DTO_ListSubject(int idListSubject,DTO_Class cl, DTO_Subject sb)
        {
            this.idListSubjedt = idListSubjedt;
            this.cl = cl;
            this.sb = sb;
        }
        public DTO_ListSubject(DTO_Class cl,DTO_Subject sb)
        {
            this.cl = cl;
            this.sb = sb;
        }
    }
}
