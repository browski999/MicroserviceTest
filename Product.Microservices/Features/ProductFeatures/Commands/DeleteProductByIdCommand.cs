using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    public class DeleteProductByIdCommand : IRequest<int>
    {
        public int Id { get; set; }

        public class DeleteProductByIdCommandHandler : IRequestHandler<DeleteProductByIdCommand, int>
        {
            private readonly IProductDbContext _context;

            public DeleteProductByIdCommandHandler(IProductDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(DeleteProductByIdCommand command, CancellationToken cancellationToken)
            {
                //var product = await _context.Products.Where(x => x.Id == command.Id).FirstOrDefaultAsync();
                //if (product == null) return default;

                //_context.Products.Remove(product);
                //await _context.SaveChanges();

                //return product.Id;

                return 99;
            }
        }
    }
}
