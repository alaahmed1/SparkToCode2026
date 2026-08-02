using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;
namespace WebAPIProject
{
    public class WebAPIProjectContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        public WebAPIProjectContex (DbContextOptions<WebAPIProjectContext> options) : base(options)
        {
        }
    }
}
