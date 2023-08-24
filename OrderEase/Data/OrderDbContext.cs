using Microsoft.EntityFrameworkCore;
using OrderEase.Models;
using System.Security.Principal;

namespace OrderEase.Data
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base (options)
        {
                
        }
        //Configure Relationships 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Supplier>().HasKey(os => new
            {
                os.OrderID,
                os.SupplierID
            });

            modelBuilder.Entity<Order_Supplier>().HasOne(o => o.Order).WithMany(os => os.Orders_Suppliers).HasForeignKey(o => o.OrderID);
            modelBuilder.Entity<Order_Supplier>().HasOne(o => o.Supplier).WithMany(os => os.Orders_Suppliers).HasForeignKey(o => o.SupplierID);


            base.OnModelCreating(modelBuilder); 
        }
        //Defining Tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order_Supplier> Orders_Supplier { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet <Customer> Customers { get; set; }

    }
}
