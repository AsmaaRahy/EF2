using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudentSystem.Models
{
    internal class ResourceEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.Property(e => e.ResourceName).HasMaxLength(50);
            builder.Property(e => e.ResourceName).IsUnicode();

            builder.Property(e => e.Url).IsUnicode(false);
        }
    }
}
