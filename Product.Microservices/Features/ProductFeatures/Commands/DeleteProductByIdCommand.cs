using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteProductByIdCommand : IRequest<int>
    {
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public class DeleteProductByIdCommandHandler : IRequestHandler<DeleteProductByIdCommand, int>
        {
            private readonly IProductDbContext _context;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="context"></param>
            public DeleteProductByIdCommandHandler(IProductDbContext context)
            {
                _context = context;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="command"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
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
