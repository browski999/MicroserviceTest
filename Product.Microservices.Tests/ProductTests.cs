using MediatR;
using Moq;
using Product.Microservices.Features.ProductFeatures.Queries;
using Xunit;

namespace Product.Microservices.Tests
{
    public class ProductTests
    {
        [Fact]
        public void ShouldReturnAListOfProduct()
        {
            //Arrange
            var mediator = new Mock<IMediator>();

            GetAllProductsQuery query = new GetAllProductsQuery();

        }

    }
}
