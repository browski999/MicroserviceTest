using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    public class UpdateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal Rate { get; set; }

        public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
        {
            private readonly IProductDbContext _context;

            public UpdateProductCommandHandler(IProductDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
            {
                //var product = _context.Products.Where(x => x.Id == command.Id).FirstOrDefault();

                //if (product == null)
                //{
                //    return default;
                //}
                //else
                //{
                //    product.Barcode = command.Barcode;
                //    product.Name = command.Name;
                //    product.BuyingPrice = command.BuyingPrice;
                //    product.Rate = command.Rate;
                //    product.Description = command.Description;

                //    _context.Products.Update(product);
                //    await _context.SaveChanges();

                //    return product.Id;
                //}

                return 100;
            }
        }
    }
}
