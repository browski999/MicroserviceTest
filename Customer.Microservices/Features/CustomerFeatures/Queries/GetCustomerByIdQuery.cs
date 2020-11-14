using MediatR;

namespace Customer.Microservices.Features.CustomerFeatures.Queries
{
    public partial class GetCustomerByIdQuery : IRequest<Models.Customer>
    {
        public int Id { get; set; }
    }
}
