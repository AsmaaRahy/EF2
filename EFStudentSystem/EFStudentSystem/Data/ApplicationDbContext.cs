using EFStudentSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new StudentEntityTypeConfiguration().Configure(modelBuilder.Entity<Student>());
            new CourseEntityTypeConfiguration().Configure(modelBuilder.Entity<Course>());
            new ResourceEntityTypeConfiguration().Configure(modelBuilder.Entity<Resource>());
            new HomeWorkEntityTypeConfiguration().Configure(modelBuilder.Entity<Homework>());

            modelBuilder.Entity<StudentCourse>().
                HasKey(e=> new {e.StudentId, e.CourseId});
                


        }
    
}
}
