using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    internal class SalesEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.Property(e => e.Date).HasDefaultValueSql("getdate()");

        }
    }
}
