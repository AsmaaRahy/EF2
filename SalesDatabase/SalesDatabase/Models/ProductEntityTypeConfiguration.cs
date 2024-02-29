using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    internal class ProductEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.Name).IsUnicode();

            builder.Property(e => e.Description).HasMaxLength(250);
            builder.Property(e => e.Description).HasDefaultValue("No Description");
        }
    }
}
