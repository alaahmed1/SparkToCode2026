using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ECommerceDatabase.Models;

namespace ECommerceDatabase
{
    public class AppDBContext : DbContext
    {
        //register the models with the database context
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }


        //2 . Configure the database connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A_Laptop\\SQLEXPRESS;Database=ECommerceDatabase;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
