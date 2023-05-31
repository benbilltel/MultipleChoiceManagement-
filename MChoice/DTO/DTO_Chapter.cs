using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_Chapter
    {
        public int idChapter { get; set; }
        public string nameChapter { get; set; }
        public DTO_Subject subject { get; set; }    
        public DTO_Chapter(int idChapter, string nameChapter ,DTO_Subject subject)
        {
            this.idChapter = idChapter;
            this.nameChapter = nameChapter;
            this.subject = subject;
        }
        public DTO_Chapter() { }    
        public DTO_Chapter(string nameChapter,DTO_Subject subject)
        {
            this.nameChapter=nameChapter;
            this.subject = subject;
        }
        public DTO_Chapter(int idChapter) {
            this.idChapter = idChapter;
        }
        public DTO_Chapter(int idChapter,string nameChapter)
        {
            this.idChapter = idChapter;
            this.nameChapter = nameChapter;
        }
    }
}
