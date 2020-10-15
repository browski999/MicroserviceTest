using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Product.Microservices
{
    public class ProductDbContext : DbContext, IProductDbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        { }

        public DbSet<Models.Product> Products { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}

