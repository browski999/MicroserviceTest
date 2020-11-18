using Moq;
using Product.Microservices.Features.ProductFeatures.Queries;
using System.Linq;
using Xunit;

namespace Product.Microservices.Tests
{
    public class ProductTests
    {
        [Fact]
        public async void ShouldReturnAListOfProduct()
        {
            //Arrang
            var context = new Mock<IProductDbContext>();

            GetAllProductsQuery query = new GetAllProductsQuery();
            GetAllProductsQueryHandler handler = new GetAllProductsQueryHandler(context.Object);

            //Act
            var result = await handler.Handle(query, new System.Threading.CancellationToken());

            //Assert
            Assert.True(result.Count() > 1);

        }

    }
}
