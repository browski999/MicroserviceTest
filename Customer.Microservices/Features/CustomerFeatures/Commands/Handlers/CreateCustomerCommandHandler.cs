using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Microservices.Features.CustomerFeatures.Commands
{
    public partial class CreateCustomerCommand
    {
        public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
        {
            private readonly ICustomerDbContext _context;

            public CreateCustomerCommandHandler(ICustomerDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
            {
                //var customer = new Models.Customer();
                //customer.Forename = command.Forename;
                //customer.Surname = command.Surname;
                //customer.Age = command.Age;
                //customer.EmailAddress = command.EmailAddress;

                //_context.Customers.Add(customer);
                //await _context.SaveChanges();

                var customer = new Models.Customer
                {
                    Id = 32,
                    Forename = "James",
                    Surname = "Brown",
                    EmailAddress = "james.brown@bbc.co.uk",
                    Age = 43
                };

                return customer.Id;
            }
        }
    }
}
