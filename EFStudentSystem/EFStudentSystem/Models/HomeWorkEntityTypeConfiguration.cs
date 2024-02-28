using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Models
{
    internal class HomeWorkEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            
            builder.Property(e => e.Content).IsUnicode(false);
        }
    }
}
