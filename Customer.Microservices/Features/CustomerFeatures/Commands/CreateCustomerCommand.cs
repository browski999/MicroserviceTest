using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Microservices.Features.CustomerFeatures.Commands
{
    public class CreateCustomerCommand : IRequest<int>
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }

        public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
        {
            private readonly ICustomerDbContext _context;

            public CreateCustomerCommandHandler(ICustomerDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
            {
                var customer = new Models.Customer();
                customer.Forename = command.Forename;
                customer.Surname = command.Surname;
                customer.Age = command.Age;
                customer.EmailAddress = command.EmailAddress;

                _context.Customers.Add(customer);
                await _context.SaveChanges();
                return customer.Id;
            }
        }
    }
}
