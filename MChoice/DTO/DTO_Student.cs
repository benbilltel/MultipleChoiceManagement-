using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChoice.DTO
{
    public class DTO_Student
    {
        public int  idStudent { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string phoneContact { get; set; }
        public DTO_Class cl { get; set; }
        public DTO_Student() { }
        public DTO_Student(int idStudent, string firstName, string lastName, string gender, string phoneContact, DTO_Class cl)
        {
            this.idStudent = idStudent;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.phoneContact = phoneContact;
            this.cl = cl;
        }

        public DTO_Student( string firstName, string lastName, string gender, string phoneContact, DTO_Class cl)
        {
           
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.phoneContact = phoneContact;
            this.cl = cl;
        }
        public DTO_Student (int idStudent)
        {
            this.idStudent= idStudent;
        }
        public DTO_Student(int idStudent,DTO_Class cl)
        {
            this.idStudent = idStudent;
            this.cl = cl;
        }

    }
}
