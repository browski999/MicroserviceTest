using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product.Microservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            return Content("BOB");
        }
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

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    return Ok(await _mediator.Send(new GetAllProductsQuery()));
        //}

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
