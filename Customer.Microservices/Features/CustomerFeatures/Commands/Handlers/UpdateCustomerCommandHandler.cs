using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Microservices.Features.CustomerFeatures.Commands
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, int>
    {
        /// <summary>
        /// 
        /// </summary>
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

