using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_ListQuizzes
    {
        public int  id { get; set; }
        public DTO_Exam exam { get; set; }
        public DTO_Quizz quizz { get; set; }
        public DTO_ListQuizzes(int id, DTO_Exam exam, DTO_Quizz quizz)
        {
            this.id = id;
            this.exam = exam;
            this.quizz = quizz;
        }
        public DTO_ListQuizzes( DTO_Exam exam, DTO_Quizz quizz)
        {
           
            this.exam = exam;
            this.quizz = quizz;
        }
        public DTO_ListQuizzes() { }
        public DTO_ListQuizzes(int id) {
            this.id = id;
        }

    }
}
