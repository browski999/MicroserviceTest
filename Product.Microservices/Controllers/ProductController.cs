using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product.Microservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private readonly IMediator _mediator;

        //public ProductController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(CreateProductCommand command)
        //{
        //    return Ok(await _mediator.Send(command));
        //}

        [HttpGet]
        public async Task<List<Models.Product>> GetAll()
        {
            //return Ok(await _mediator.Send(new GetAllProductsQuery()));
            var productList = new List<Models.Product>
                {
                    new Models.Product
                    {
                        Id = 1,
                        Barcode = "Test string",
                        ConfidentialData = "Some confidential data",
                        BuyingPrice = 12.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Barcode = "Test string 1",
                        ConfidentialData = "Some confidential data with another",
                        BuyingPrice = 2.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                    new Models.Product
                    {
                        Id = 3,
                        Barcode = "Test string",
                        ConfidentialData = "Some confidential data",
                        BuyingPrice = 12.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                    new Models.Product
                    {
                        Id = 4,
                        Barcode = "Test string",
                        ConfidentialData = "Some confidential data",
                        BuyingPrice = 12.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                    new Models.Product
                    {
                        Id = 5,
                        Barcode = "Test string",
                        ConfidentialData = "Some confidential data",
                        BuyingPrice = 12.95m,
                        Description = "This is a test description",
                        IsActive = false,
                        Name = "One product",
                        Rate = 15.0m,
                        SKU = "test sku"
                    },
                };

            return productList;
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    return Ok(await _mediator.Send(new GetProductByIdQuery { Id = id }));
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    return Ok(await _mediator.Send(new DeleteProductByIdCommand { Id = id }));
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int id, UpdateProductCommand command)
        //{
        //    if (id != command.Id)
        //    {
        //        return BadRequest(typeof(UpdateProductCommand));
        //    }

        //    return Ok(await _mediator.Send(command));
        //}
    }
}
