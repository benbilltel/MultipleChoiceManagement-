using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public  class DTO_Exam
    {
        public int idExam { get; set; }
        public int checkedExam  { get; set; }
        public DTO_Subject subject { get; set; }
        public DTO_Exam() { }
        public DTO_Exam(int idExam, int checkedExam, DTO_Subject subject)
        {
            this.idExam = idExam;
            this.checkedExam = checkedExam;
            this.subject = subject;
        }
        public DTO_Exam(int idExam)
        {
            this.idExam = idExam;   
        }
    }
}
