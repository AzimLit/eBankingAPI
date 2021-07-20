using eBankingAPI.Data.Services;
using eBankingAPI.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBankingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public CustomersService _customersService;

        public CustomersController(CustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet("Get-all-customers")]
        public IActionResult GetAllCustomers()
        {
            var allCustomers = _customersService.GetAllCustomers();
            return Ok(allCustomers);
        }

        [HttpGet("get-customer-Id/{Id}")]
        public IActionResult GetCustomerById(int Id)
        {
            var customer = _customersService.GetCustomerById(Id);
            return Ok(customer);
        }

        [HttpPost("Add-customer")]
        public IActionResult AddCustomer([FromBody] CustomerVM customer) 
        {
            _customersService.AddCustomer(customer);
            return Ok();
        }

        [HttpPut("Update-customer-by-Id/{Id}")]
        public IActionResult UpdateCustomerId( int Id,[FromBody] CustomerVM customer)
        {
            var updateCustomer = _customersService.UpdateCustomerId(Id, customer);
            return Ok(updateCustomer);
        }

        [HttpDelete("Delete-customer-by-Id/{Id}")]
        public IActionResult DeleteCustomerById(int Id)
        {
            _customersService.DeleteCustomerById(Id);
            return Ok();
        }
    }
}
