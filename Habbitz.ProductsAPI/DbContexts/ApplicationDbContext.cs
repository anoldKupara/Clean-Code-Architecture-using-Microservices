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
    }
}