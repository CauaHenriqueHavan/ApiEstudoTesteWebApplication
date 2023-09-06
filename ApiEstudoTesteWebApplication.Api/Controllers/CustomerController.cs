using ApiEstudoTesteWebApplication.Domain.DTOs.OutputModel;
using ApiEstudoTesteWebApplication.Domain.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiEstudoTesteWebApplication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
            => _customerService = customerService;

        [HttpGet]
        [ProducesResponseType(typeof(List<CustumerOutputModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Customer()
            => Ok(await _customerService.GetCustomerAsync());
    }
}
