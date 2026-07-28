using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFcoreProject.Models; //importing the models namespace to use the Employee and Department classes in the ProjectContext class.

namespace EFcoreProject
{
    public class ProjectContext : DbContext //OOP inheritance, takes a copy of the DbContext class and extends it with additional functionality specific to the ProjectContext class.
    {
        // 1. Register models with the context, which will be used to create tables in the database.
        public DbSet<Employee> employees { get; set; } 
        public DbSet<Department> departments { get; set; }
        //2. Configure the database connection string and other options for the context.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFcoreProjectDB;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
