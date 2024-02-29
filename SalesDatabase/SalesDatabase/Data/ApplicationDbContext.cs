using Microsoft.EntityFrameworkCore;
using SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SaleDatabase;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());
            new CustomerEntityTypeConfiguration().Configure(modelBuilder.Entity<Customer>());
            new StoreEntityTypeConfiguration().Configure(modelBuilder.Entity<Store>());
            new SalesEntityTypeConfiguration().Configure(modelBuilder.Entity<Sale>());




        }

    }


}
