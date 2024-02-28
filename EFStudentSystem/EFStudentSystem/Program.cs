using EFStudentSystem.Data;
using EFStudentSystem.Models;

namespace EFStudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            context.Students.Add(new Student() { StudentName = "Ali", PhoneNumber = "0123355", BirthDay = "2/12/2000", RegisteredOn = DateTime.Now);
            context.Students.Add(new Student() { StudentName = "Mai", PhoneNumber = "0123355", RegisteredOn = DateTime.Now });
            context.Students.Add(new Student() { StudentName = "Nour", BirthDay = "2/12/2000", RegisteredOn = DateTime.Now.AddHours(-3) });

            context.Courses.Add(new Course() { CourseName = "Math1", Description = "math1 course", StartDate = DateTime.Now.AddMonths(-1), EndDate = DateTime.Now.AddMonths(1), Price = 1000 });
            context.Courses.Add(new Course() { CourseName = "English2", Description = "math2 course", StartDate = DateTime.Now.AddMonths(-1), EndDate = DateTime.Now.AddMonths(1), Price = 1000 });
            context.Courses.Add(new Course() { CourseName = "Programming1", StartDate = DateTime.Now.AddMonths(-1), EndDate = DateTime.Now.AddMonths(1), Price = 2500 });

            context.Resources.Add(new Resource() { ResourceName = "resourse 1", Url = "http://www.Resourse1.com", ResourceType = ResourceType.Video, CourseId = 40 });
            context.Resources.Add(new Resource() { ResourceName = "resourse 2", Url = "https://www.Resourse2.com", ResourceType = ResourceType.Document, CourseId = 42 });
            context.Resources.Add(new Resource() { ResourceName = "resourse 3", Url = "http://www.Resourse3.com", ResourceType = ResourceType.Other, CourseId = 42 });
            context.Resources.Add(new Resource() { ResourceName = "resourse 4", Url = "http://www.Resourse4.com", ResourceType = ResourceType.Presentation, CourseId = 41 });

            context.Homeworks.Add(new Homework() { Content = "content1", ContentType = ContentType.Application, SubmissionTime = DateTime.Now, StudentId = 28, CourseId = 42 });
            context.Homeworks.Add(new Homework() { Content = "content2", ContentType = ContentType.Pdf, SubmissionTime = DateTime.Now.AddDays(-5), StudentId = 30, CourseId = 40 });
            context.Homeworks.Add(new Homework() { Content = "content3", ContentType = ContentType.Zip, SubmissionTime = DateTime.Now, StudentId = 29, CourseId = 41 });


            context.SaveChanges();
        }
    }
}
