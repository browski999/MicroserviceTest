using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateProductCommand : IRequest<int>
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal BuyingPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Rate { get; set; }

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
