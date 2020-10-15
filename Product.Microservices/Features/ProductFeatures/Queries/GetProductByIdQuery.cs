using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Queries
{
    public class GetProductByIdQuery : IRequest<Models.Product>
    {
        public int Id { get; set; }

        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Models.Product>
        {
            private readonly IProductDbContext _context;

            public GetProductByIdQueryHandler(IProductDbContext context)
            {
                _context = context;
            }

            public async Task<Models.Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
            {
                var product = _context.Products.Where(x => x.Id == query.Id).FirstOrDefault();

                if (product == null) return null;

                return product;
            }
        }
    }
}
