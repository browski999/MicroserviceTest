using Customer.Microservices;
using Customer.Microservices.Features.CustomerFeatures.Queries;
using Moq;
using System.Linq;
using System.Threading;
using Xunit;
using static Customer.Microservices.Features.CustomerFeatures.Queries.GetAllCustomersQuery;
using static Customer.Microservices.Features.CustomerFeatures.Queries.GetCustomerByIdQuery;

namespace Product.Microservices.Tests
{
    public class CustomerTests
    {
        [Fact]
        public async void ShouldReturnAListOfCustomers()
        {
            //Arrange
            var context = new Mock<ICustomerDbContext>();

            GetAllCustomersQuery query = new GetAllCustomersQuery();
            GetAllCustomersQueryHandler handler = new GetAllCustomersQueryHandler(context.Object);

            //Act
            var result = await handler.Handle(query, new CancellationToken());

            //Assert
            Assert.True(result.Count() > 1);
            Assert.False(result.Any());

        }

        [Fact]
        public async void ShouldReturnCustomerById()
        {
            //Arrange
            var context = new Mock<ICustomerDbContext>();

            GetCustomerByIdQuery query = new GetCustomerByIdQuery();
            GetCustomerByIdQueryHandler handler = new GetCustomerByIdQueryHandler(context.Object);

            //Act
            var result = await handler.Handle(query, new CancellationToken());

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Id > 0);
        }

    }
}
