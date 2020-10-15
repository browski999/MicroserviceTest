using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Microservices.Features.CustomerFeatures.Queries
{
    public class GetCustomerByIdQuery : IRequest<Models.Customer>
    {
        public int Id { get; set; }

        public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Models.Customer>
        {
            private readonly ICustomerDbContext _context;

            public GetCustomerByIdQueryHandler(ICustomerDbContext context)
            {
                _context = context;
            }

            public async Task<Models.Customer> Handle(GetCustomerByIdQuery query, CancellationToken cancellationToken)
            {
                var customer = _context.Customers.Where(x => x.Id == query.Id).FirstOrDefault();
                if (customer == null) return null;

                return customer;
            }
        }
    }
}
