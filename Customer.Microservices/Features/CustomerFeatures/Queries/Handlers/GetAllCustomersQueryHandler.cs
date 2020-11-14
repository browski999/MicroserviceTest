using MediatR;
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
                //var customerList = await _context.Customers.ToListAsync();

                var customerList = new List<Models.Customer>
                {
                    new Models.Customer
                    {
                        Id = 1,
                        Forename = "Bob",
                        Surname = "Wright",
                        EmailAddress = "bob.wright@gmail.com",
                        Age = 32
                    },
                    new Models.Customer
                    {
                        Id = 2,
                        Forename = "Kevin",
                        Surname = "Jones",
                        EmailAddress = "kevin.jones@gmail.com",
                        Age = 23
                    },
                    new Models.Customer
                    {
                        Id = 3,
                        Forename = "Owen",
                        Surname = "Michael",
                        EmailAddress = "owen.michael@gmail.com",
                        Age = 16
                    },
                    new Models.Customer
                    {
                        Id = 4,
                        Forename = "Janice",
                        Surname = "Williams",
                        EmailAddress = "janice.williams@gmail.com",
                        Age = 62
                    },
                    new Models.Customer
                    {
                        Id = 5,
                        Forename = "Brian",
                        Surname = "Keen",
                        EmailAddress = "brian.keen@gmail.com",
                        Age = 70
                    },
                };

                if (customerList == null)
                {
                    return null;
                }

                return customerList.AsReadOnly();

                //return customerList.AsReadOnly();
            }
        }
    }
}
