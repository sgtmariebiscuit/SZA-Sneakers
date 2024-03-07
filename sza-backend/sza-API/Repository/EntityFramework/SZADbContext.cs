using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using sza_API.Models;

namespace Repository.EntityFramework
{

    public class SZADbContext : DbContext
    {
        public SZADbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=SZADB;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
               .Property(e => e.Id)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
               .Property(e => e.Id)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<OrderProducts>()
               .Property(e => e.Id)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Order>()
                .Property(e => e.Id)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Sneaker>()
               .Property(e => e.Id)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Supplier>()
               .Property(e => e.Id)
               .ValueGeneratedOnAdd();
            // Other configurations...
        }

        public DbSet<Admin> admin {  get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<OrderProducts> orderProduct { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Sneaker> sneakers { get; set;}
        public DbSet<Supplier> suppliers { get; set; }
    }
}
