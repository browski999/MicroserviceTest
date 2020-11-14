using MediatR;

namespace Product.Microservices.Features.ProductFeatures.Queries
{
    /// <summary>
    /// 
    /// </summary>
    public class GetProductByIdQuery : IRequest<Models.Product>
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
    }
}
