using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Queries
{
    public partial class GetAllProductsQuery
    {
        /// <summary>
        /// 
        /// </summary>
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Models.Product>>
        {
            private readonly IProductDbContext _context;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="context"></param>
            public GetAllProductsQueryHandler(IProductDbContext context)
            {
                _context = context;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="query"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<Models.Product>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
            {
                //var productList = await _context.Products.ToListAsync();

                var productList = new List<Models.Product>
                {
                    new Models.Product
                    {
                        Id = 1,
                        Barcode = "Test string",
                        ConfidentialData = "Some confidential data",
                        BuyingPrice = 12.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Barcode = "Test string 1",
                        ConfidentialData = "Some confidential data with another",
                        BuyingPrice = 2.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                    new Models.Product
                    {
                        Id = 3,
                        Barcode = "Test string",
                        ConfidentialData = "Some confidential data",
                        BuyingPrice = 12.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                    new Models.Product
                    {
                        Id = 4,
                        Barcode = "Test string",
                        ConfidentialData = "Some confidential data",
                        BuyingPrice = 12.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                    new Models.Product
                    {
                        Id = 5,
                        Barcode = "Test string",
                        ConfidentialData = "Some confidential data",
                        BuyingPrice = 12.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                };

                if (productList == null)
                {
                    return null;
                }

                return productList.AsReadOnly();
            }
        }
    }
}
