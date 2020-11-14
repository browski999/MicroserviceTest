using MediatR;

namespace Customer.Microservices.Features.CustomerFeatures.Commands
{
    public class CreateCustomerCommand : IRequest<int>
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
    }
}
