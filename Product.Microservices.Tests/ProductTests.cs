using Moq;
using Product.Microservices.Features.ProductFeatures.Queries;
using System.Linq;
using System.Threading;
using Xunit;

namespace Product.Microservices.Tests
{
    public class ProductTests
    {
        [Fact]
        public async void ShouldReturnAListOfProduct()
        {
            //Arrange
            var context = new Mock<IProductDbContext>();

            GetAllProductsQuery query = new GetAllProductsQuery();
            GetAllProductsQueryHandler handler = new GetAllProductsQueryHandler(context.Object);

            //Act
            var result = await handler.Handle(query, new CancellationToken());

            //Assert
            Assert.True(result.Count() > 1);
            Assert.False(result.Count() < 1);

        }

        [Fact]
        public async void ShouldReturnProductById()
        {
            //Arrange
            var context = new Mock<IProductDbContext>();

            GetProductByIdQuery query = new GetProductByIdQuery();
            GetProductByIdQueryHandler handler = new GetProductByIdQueryHandler(context.Object);

            //Act
            var result = await handler.Handle(query, new CancellationToken());

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Id > 0);
        }

    }
}
