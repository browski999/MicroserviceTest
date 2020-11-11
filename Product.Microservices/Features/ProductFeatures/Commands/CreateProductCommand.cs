using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateProductCommand : IRequest<int>
    {
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
        /// 
        /// </summary>
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            private readonly IProductDbContext _context;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="context"></param>
            public CreateProductCommandHandler(IProductDbContext context)
            {
                _context = context;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="command"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
            {
                //var product = new Models.Product();
                //product.Barcode = command.Barcode;
                //product.Name = command.Name;
                //product.BuyingPrice = command.BuyingPrice;
                //product.Rate = command.Rate;
                //product.Description = command.Description;

                //_context.Products.Add(product);
                //await _context.SaveChanges();

                var product = new Models.Product
                {
                    Id = 9,
                    Name = "A brand new created product",
                    Description = "This is the second test",
                    ConfidentialData = "Very confidential",
                    Barcode = "Some random barcode",
                    BuyingPrice = 5.99m,
                    IsActive = true,
                    Rate = 13.95m,
                    SKU = "A description of a SKU"
                };

                return product.Id;
            }
        }
    }
}
