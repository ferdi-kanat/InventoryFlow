using InventoryFlow.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace InventoryFlow.DataAccess.Concrete.EntityFramework
{
    public class InventoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Ensure this matches the name you found in Part 1 (sqllocaldb info)
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryFlowDB;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }

        // NEW ADDITION: Configure table specifics here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                // Fix for the Decimal Warning
                modelBuilder.Entity<Product>()
                    .Property(p => p.UnitPrice)
                    .HasColumnType("decimal(18,2)"); // 18 digits total, 2 after the dot

                // --- NEW FIX FOR SALE TOTAlPRICE ---
                modelBuilder.Entity<Sale>()
                    .Property(s => s.TotalPrice)
                    .HasColumnType("decimal(18,2)"); // 18 digits total, 2 after the dot
            }
            else
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }
        }
    }
}