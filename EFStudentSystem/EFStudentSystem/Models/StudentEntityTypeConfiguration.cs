using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Models
{
    internal class StudentEntityTypeConfiguration
    {

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(e => e.StudentName).HasMaxLength(100);
            builder.Property(e => e.StudentName).IsUnicode();

            builder.Property(e => e.PhoneNumber).HasMaxLength(10);
            builder.Property(e => e.PhoneNumber).IsUnicode(false);
            builder.Property(e => e.PhoneNumber).IsRequired(false);

            builder.Property(e => e.BirthDay).IsRequired(false);

            builder
     .HasMany(e => e.Homeworks)
     .WithOne(e => e.Student)
     .HasForeignKey(e => e.StudentId)
     .IsRequired();


            builder
                .HasMany(e => e.Courses)
                .WithMany(e => e.Students);
        }
    }
}
