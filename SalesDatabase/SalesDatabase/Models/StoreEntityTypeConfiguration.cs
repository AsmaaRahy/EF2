using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    internal class StoreEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.Name).IsUnicode();
        }
    }
}
