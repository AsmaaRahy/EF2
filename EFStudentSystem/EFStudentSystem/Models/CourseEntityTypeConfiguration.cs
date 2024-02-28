using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Models
{
    internal class CourseEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(e => e.CourseName).HasMaxLength(80);
            builder.Property(e => e.CourseName).IsUnicode();

            builder.Property(e => e.Description).IsUnicode();
            builder.Property(e => e.Description).IsRequired(false);

            builder
     .HasMany(e => e.Resources)
     .WithOne(e => e.Course)
     .HasForeignKey(e => e.CourseId)
     .IsRequired();

            builder
     .HasMany(e => e.Homeworks)
     .WithOne(e => e.Course)
     .HasForeignKey(e => e.CourseId)
     .IsRequired();

            builder
                .HasMany(e => e.Students)
                .WithMany(e => e.Courses);


        }
    }
}
