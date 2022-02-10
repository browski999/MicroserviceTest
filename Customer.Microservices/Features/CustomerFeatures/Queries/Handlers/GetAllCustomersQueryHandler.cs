using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Microservices.Features.CustomerFeatures.Queries
{
    public partial class GetAllCustomersQuery
    {
        public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<Models.Customer>>
        {
            private readonly ICustomerDbContext _context;

            public GetAllCustomersQueryHandler(ICustomerDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Models.Customer>> Handle(GetAllCustomersQuery query, CancellationToken cancellationToken)
            {
                Log.Information("Start of GetAllCustomers Handler");

                var customerList = await _context.Customers.ToListAsync();

                Log.Information("End of GetAllCustomers Handler");

                return customerList.AsReadOnly();
            }
        }
    }
}
