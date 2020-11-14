using MediatR;
using System.Collections.Generic;

namespace Product.Microservices.Features.ProductFeatures.Queries
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetAllProductsQuery : IRequest<IEnumerable<Models.Product>>
    {
    }
}
