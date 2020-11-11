using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Microservices.Features.CustomerFeatures.Commands
{
    public class DeleteCustomerByIdCommand : IRequest<int>
    {
        public int Id { get; set; }

        public class DeleteCustomerByIdCommandHandler : IRequestHandler<DeleteCustomerByIdCommand, int>
        {
            private readonly ICustomerDbContext _context;

            public DeleteCustomerByIdCommandHandler(ICustomerDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteCustomerByIdCommand command, CancellationToken cancellationToken)
            {
                //var customer = _context.Customers.Where(x => x.Id == command.Id).FirstOrDefault();
                //if (customer == null) return default;

                //_context.Customers.Remove(customer);
                //await _context.SaveChanges();

                //return customer.Id;

                return 103;
            }
        }
    }
}
