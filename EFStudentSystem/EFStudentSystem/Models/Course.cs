using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }

        public List<Student> Students { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Homework> Homeworks { get; set; }

    }
}
