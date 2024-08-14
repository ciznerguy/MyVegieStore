using Microsoft.EntityFrameworkCore;
using MyVegieStore.Model;

namespace MyVegieStore.ViewModel
{
    public class MyVegieStoreContext : DbContext
    {
        public MyVegieStoreContext(DbContextOptions<MyVegieStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CustomerOrder> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map the Person base class to the Persons table
            modelBuilder.Entity<Person>()
                .ToTable("Person");

            // Map the Customer class to the Customers table
            modelBuilder.Entity<Customer>()
                .ToTable("Customer");

            // Map the Admin class to the Admins table
            modelBuilder.Entity<Admin>()
                .ToTable("Admin");

            // Map the Order class to the Orders table
            modelBuilder.Entity<CustomerOrder>()
                .ToTable("Orders")
                .HasKey(o => o.OrderID);

            // Map the Product class to the Product table
            modelBuilder.Entity<Product>()
                .ToTable("Product")
                .HasKey(p => p.ProductID);

            // Map the OrderDetails class to the OrderDetails table
            modelBuilder.Entity<OrderDetails>()
                .ToTable("OrderDetails")
                .HasKey(od => od.OrderDetailsID);

        }
    }
}
