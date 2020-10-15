using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Microservices.Features.CustomerFeatures.Queries
{
    public class GetAllCustomersQuery : IRequest<IEnumerable<Models.Customer>>
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
                var customerList = await _context.Customers.ToListAsync();

                if (customerList == null)
                {
                    return null;
                }

                return customerList.AsReadOnly();
            }
        }
    }
}
