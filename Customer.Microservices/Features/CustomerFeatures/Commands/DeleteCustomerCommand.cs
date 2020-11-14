using MediatR;

namespace Customer.Microservices.Features.CustomerFeatures.Commands
{
    public partial class DeleteCustomerByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
