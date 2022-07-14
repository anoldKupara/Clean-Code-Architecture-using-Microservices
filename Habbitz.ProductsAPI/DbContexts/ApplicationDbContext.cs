using Habbitz.ProductsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Habbitz.ProductsAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 5,
                Description = "A product made of flour and meat or potatoes",
                ImageUrl = "https://drive.google.com/file/d/1lBr9BJIXaoc-aICwwhFjI4hu3gO4R_W4/view?usp=sharing",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Panner Tikka",
                Price = 13.45,
                Description = "To be added later",
                ImageUrl = "https://drive.google.com/file/d/1PjE7OJWfOBQkAj-iwnF9hMD2sukfe8YV/view?usp=sharing",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "To be added later",
                ImageUrl = "https://drive.google.com/file/d/1H_jRrTvSAV-OXNe4NCMbYSlU87lMzAjd/view?usp=sharing",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Ice Cream",
                Price = 2.67,
                Description = "To be added laterr",
                ImageUrl = "https://drive.google.com/file/d/12UVuU89klgzU62yTyaE4NdKrflGM7uOn/view?usp=sharing",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Gelato",
                Price = 8.16,
                Description = "A fancy dessert",
                ImageUrl = "https://drive.google.com/file/d/12Z9dQ70racP7RMuVfZ51VP1mrCZlLsj9/view?usp=sharing",
                CategoryName = "Dessert"
            });
        }
    }
}