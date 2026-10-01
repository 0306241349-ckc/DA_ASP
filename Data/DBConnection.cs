using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MyProject.Models;
namespace MyProject.Data
{
    public class DBConnection : DbContext
    {
        public DBConnection(DbContextOptions<DBConnection> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);         
        }
    }
}
