using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Queries
{
    public partial class GetProductByIdQuery
    {
        /// <summary>
        /// /
        /// </summary>
        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Models.Product>
        {
            private readonly IProductDbContext _context;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="context"></param>
            public GetProductByIdQueryHandler(IProductDbContext context)
            {
                _context = context;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="query"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Models.Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
            {
                //var product = await _context.Products.Where(x => x.Id == query.Id).FirstOrDefaultAsync();

                //if (product == null) return null;
                var product = new Models.Product
                {
                    Id = 1,
                    Name = "A brand new product",
                    Description = "This is a test",
                    ConfidentialData = "Not at all confidential",
                    Barcode = "Some random",
                    BuyingPrice = 15.99m,
                    IsActive = false,
                    Rate = 23.95m,
                    SKU = "A description"
                };

                return product;
            }
        }
    }
}
