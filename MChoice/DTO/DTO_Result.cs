using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_Result
    {
        public int idResult { get; set; }
        public DTO_Exam exam { get; set; }
        public DTO_Student student { get; set; }
        public float score { get; set; }
        public DTO_Result() { }
        public DTO_Result(int idResult, DTO_Exam exam, DTO_Student student, float score)
        {
            this.idResult = idResult;
            this.exam = exam;
            this.student = student;
            this.score = score;
        }
        public DTO_Result( DTO_Exam exam, DTO_Student student, float score)
        {
           
            this.exam = exam;
            this.student = student;
            this.score = score;
        }
        public DTO_Result(int idResult)
        {
            this.idResult = idResult;
        }


    }
}
