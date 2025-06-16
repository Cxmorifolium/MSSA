using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sqlite.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private Product[] GetProducts()
        {
            return new Product[]
            {
                new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 999.99m, StockQuantity = 50 },
                new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 699.99m, StockQuantity = 100 },
                new Product { Id = 3, Name = "Tablet", Description = "Portable tablet with stylus support", Price = 499.99m, StockQuantity = 75 }
            };
        }
    }
}
