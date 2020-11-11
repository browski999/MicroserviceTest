using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.Microservices.Features.ProductFeatures.Commands;
using Product.Microservices.Features.ProductFeatures.Queries;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product.Microservices.Controllers
{
    /// <summary>
    /// Example of a .NET Core controller based on the controller name
    /// api/[controller] on ProductController becomes api/values
    /// endpoint: "/Product" from [controller] and name of controller , which is "ProductController"
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// 
        /// </summary>
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Action to create a new Product
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Action to return all Products
        /// </summary>
        /// <returns>List of Products</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllProductsQuery()));
        }

        /// <summary>
        /// Action to return a Product based on it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _mediator.Send(new GetProductByIdQuery { Id = id }));
        }

        /// <summary>
        /// Action to delete a Product based on it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteProductByIdCommand { Id = id }));
        }

        /// <summary>
        /// Action to update a Product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest(typeof(UpdateProductCommand));
            }

            return Ok(await _mediator.Send(command));
        }
    }
}
