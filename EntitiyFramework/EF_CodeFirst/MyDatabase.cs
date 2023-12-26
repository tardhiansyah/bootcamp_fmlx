using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst;

public class MyDatabase : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlite(@"Data Source=D:\EntitiyFramework\EF_CodeFirst\MyDatabase.db");
        optionsBuilder.UseSqlite(@"Data Source=./MyDatabase.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(category =>
        {
            category.HasKey(c => c.CategoryId);
            category.HasMany(c => c.Products).WithOne(p => p.Category);
            category.Property(c => c.CategoryName).IsRequired();
            category.Property(c => c.Description);
        });
        modelBuilder.Entity<Product>(product =>
        {
            product.HasKey(p => p.ProductId);
            product.Property(p => p.ProductName).IsRequired();
        });

        //Seeding
        modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                CategoryId = 1,
                CategoryName = "Electronics",
                Description = "Electric Home Appliances"
            },
            new Category()
            {
                CategoryId = 2,
                CategoryName = "Fruit",
                Description = "Tropical Fruit"
            });
        
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                ProductId = 1,
                ProductName = "Television",
                CategoryId = 1
            },
            new Product()
            {
                ProductId = 2,
                ProductName = "Radio",
                CategoryId = 1
            });
    }
}