using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Microservices.Features.CustomerFeatures.Commands
{
    public class UpdateCustomerCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }

        public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, int>
        {
            private readonly ICustomerDbContext _context;

            public UpdateCustomerCommandHandler(ICustomerDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(UpdateCustomerCommand command, CancellationToken cancellationToken)
            {
                var customer = _context.Customers.Where(x => x.Id == command.Id).FirstOrDefault();

                if (customer == null)
                {
                    return default;
                }
                else
                {
                    customer.Forename = command.Forename;
                    customer.Surname = command.Surname;
                    customer.Age = command.Age;
                    customer.EmailAddress = command.EmailAddress;

                    _context.Customers.Update(customer);
                    await _context.SaveChanges();
                    return customer.Id;
                }
            }
        }
    }
}
