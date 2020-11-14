using MediatR;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DeleteProductByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
