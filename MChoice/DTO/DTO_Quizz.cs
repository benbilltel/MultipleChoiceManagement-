using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_Quizz
    {
        public int idQuizz { get; set; }
        public string content { get; set; }
        public string anA { get; set; }
        public string  anB { get; set; }
        public string anC { get; set; }
        public string anD { get; set; }
        public string correctAn { get; set; }
        public DTO_Chapter chapter { get; set; }
        public DTO_Quizz(int idQuizz, string content, string anA, string anB, string anC, string anD, string correctAn, DTO_Chapter chapter)
        {
            this.idQuizz = idQuizz;
            this.content = content;
            this.anA = anA;
            this.anB = anB;
            this.anC = anC;
            this.anD = anD;
            this.correctAn = correctAn;
            this.chapter = chapter;
        }
        public DTO_Quizz(int idQuizz) {
            this.idQuizz=idQuizz;
        }
        public DTO_Quizz(string content, string anA, string anB, string anC, string anD, string correctAn, DTO_Chapter chapter) {
            this.content = content;
            this.anA = anA;
            this.anB = anB;
            this.anC = anC;
            this.anD = anD;
            this.correctAn = correctAn;
            this.chapter = chapter;
        }
    }
}
