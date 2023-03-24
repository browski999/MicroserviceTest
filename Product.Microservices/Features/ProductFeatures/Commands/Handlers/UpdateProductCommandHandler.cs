using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    /// <summary>
    /// /
    /// </summary>
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public UpdateProductCommandHandler(IProductDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<int> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var product = _context.Products.Where(x => x.Id == command.Id).FirstOrDefault();

            if (product == null)
            {
                return default;
            }
            else
            {
                product.Barcode = command.Barcode;
                product.Name = command.Name;
                product.BuyingPrice = command.BuyingPrice;
                product.Rate = command.Rate;
                product.Description = command.Description;

                _context.Products.Update(product);
                await _context.SaveChanges();

                return product.Id;
            }
        }
    }
}

