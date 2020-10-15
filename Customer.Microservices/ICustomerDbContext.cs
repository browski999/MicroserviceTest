using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Customer.Microservices
{
    public interface ICustomerDbContext
    {
        DbSet<Models.Customer> Customers { get; set; }

        Task<int> SaveChanges();
    }
}