using Microsoft.EntityFrameworkCore;
using TestTaskWebApi.Models;

namespace TestTaskWebApi.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> opt) : base(opt)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
