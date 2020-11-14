using MediatR;

namespace Customer.Microservices.Features.CustomerFeatures.Commands
{
    public partial class UpdateCustomerCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
    }
}
