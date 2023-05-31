using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_AnswerInfo
    {
        public int id { get; set; }
        public DTO_Result result { get; set; }
        public DTO_Quizz quizz { get; set; }
        public string answerStudent { get; set; }
        public DTO_AnswerInfo()
        {

        }
        public DTO_AnswerInfo(int id,DTO_Result result,DTO_Quizz quizz,string answerStudent)
        {
            this.id = id;
            this.result = result;
            this.quizz = quizz;
            this.answerStudent = answerStudent;
        }
        public DTO_AnswerInfo(int id)
        {
            this.id = id;
          
        }
        public DTO_AnswerInfo( DTO_Result result, DTO_Quizz quizz, string answerStudent)
        {
           
            this.result = result;
            this.quizz = quizz;
            this.answerStudent = answerStudent;
        }

    }
}
