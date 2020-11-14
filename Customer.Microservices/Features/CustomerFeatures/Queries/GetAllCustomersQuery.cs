using MediatR;
using System.Collections.Generic;

namespace Customer.Microservices.Features.CustomerFeatures.Queries
{
    public partial class GetAllCustomersQuery : IRequest<IEnumerable<Models.Customer>>
    {
    }
}
