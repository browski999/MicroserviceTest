using Customer.Microservices.Features.CustomerFeatures.Commands;
using Customer.Microservices.Features.CustomerFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Threading.Tasks;

namespace Customer.Microservices.Controllers
{
    /// <summary>
    /// Example of a .NET Core controller based on the controller name
    /// api/[controller] on CustomerController becomes api/customer
    /// endpoint: "/Customer" from [controller] and name of controller , which is "CustomerController"
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediator"></param>
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Action to create a new Customer
        /// </summary>
        /// <param name="commanfd"></param>
        /// <returns>Newly created Customer Id</returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Action to return all Customers
        /// </summary>
        /// <returns>List of Customers</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log.Information("Start of the GetAll method call");
            return Ok(await _mediator.Send(new GetAllCustomersQuery()));
        }

        /// <summary>
        /// Action to return a Customer by it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Customer</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _mediator.Send(new GetCustomerByIdQuery { Id = id }));
        }

        /// <summary>
        /// Action to delete a Customer by it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Deleted Customer Id</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteCustomerByIdCommand { Id = id }));
        }

        /// <summary>
        /// Action to update a Customer
        /// </summary>
        /// <param name="id"></param>
        /// <param name="command"></param>
        /// <returns>The updated Customer Id</returns>
        [HttpPut]
        public async Task<IActionResult> Update(int id, UpdateCustomerCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }
    }
}
