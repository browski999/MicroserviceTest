using MediatR;

namespace Product.Microservices.Features.ProductFeatures.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateProductCommand : IRequest<int>
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

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
    }
}
