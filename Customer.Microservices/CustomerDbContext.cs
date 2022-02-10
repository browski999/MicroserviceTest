using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Customer.Microservices
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerDbContext : DbContext, ICustomerDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        { }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Models.Customer> Customers { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
