using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Models.Product>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Models.Product>>
        {
            private readonly IProductDbContext _context;

            public GetAllProductsQueryHandler(IProductDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Models.Product>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
            {
                var productList = await _context.Products.ToListAsync();

                if (productList == null)
                {
                    return null;
                }

                return productList.AsReadOnly();
            }
        }
    }
}
