using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string PhoneNumber { get; set;}
        public string BirthDay { get; set;}

        public DateTime RegisteredOn { get; set;}

        public List<Course> Courses { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<Homework> Homeworks { get; set; }


    }
}
