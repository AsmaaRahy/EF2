using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    internal class CustomerEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Name).IsUnicode();

            builder.Property(e => e.Email).HasMaxLength(80);
            builder.Property(e => e.Email).IsUnicode(false);
         
        }
    }
}
