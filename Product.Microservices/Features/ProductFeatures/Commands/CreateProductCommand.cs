using MediatR;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    public partial class CreateProductCommand : IRequest<int>
    {

        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal Rate { get; set; }
    }
}
