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

        public DbSet<Admin> admin {  get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<OrderProducts> orderProduct { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Sneaker> sneakers { get; set;}
        public DbSet<Supplier> suppliers { get; set; }
    }
}
