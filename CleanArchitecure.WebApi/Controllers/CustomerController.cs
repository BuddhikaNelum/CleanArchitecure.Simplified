using CleanArchitecure.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecure.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer([FromRoute] int id)
        {
            var response = await _customerService.GetCustomer(id);
            return Ok(response);
        }
    }
}
