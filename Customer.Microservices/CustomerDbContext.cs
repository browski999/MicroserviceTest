using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Customer.Microservices
{
    public class CustomerDbContext : DbContext, ICustomerDbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        { }
        public DbSet<Models.Customer> Customers { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }

}
