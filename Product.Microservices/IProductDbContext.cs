using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Product.Microservices
{
    public interface IProductDbContext
    {
        DbSet<Models.Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}
