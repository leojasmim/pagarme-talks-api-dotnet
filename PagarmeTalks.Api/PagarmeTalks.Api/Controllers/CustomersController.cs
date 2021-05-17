using Microsoft.AspNetCore.Mvc;
using PagarmeTalks.Api.Attributes;
using PagarmeTalks.Api.Models;
using PagarmeTalks.Api.Models.Contracts;
using PagarmeTalks.Api.Models.Entities;
using PagarmeTalks.Api.Repositories;
using PagarmeTalks.Api.Validators;
using System.Collections.Generic;
using System.Linq;

namespace PagarmeTalks.Api.Controllers
{
    [ApiKeyAttribute]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private CustomerRepository _customerRepository;
        public CustomersController()
        {
            _customerRepository = new CustomerRepository();
        }

        [Route("{id}")]
        public IActionResult Get(string id)
        {
            var customer = _customerRepository.GetById(id);

            if (customer == null)
                return NotFound();

            var response = CreateResponse(customer);
            return Ok(response);
        }

        public IActionResult GetAll()
        {
            var customers = _customerRepository.GetAll();

            if (customers == null || customers.Any() == false)
                return NotFound();

            var response = new List<CustomerResponse>();
            foreach (var customer in customers)
                response.Add(CreateResponse(customer));

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post(CustomerRequest request)
        {
            var customer = new Customer(request);

            var validator = new CustomerValidator();

            var results = validator.Validate(customer);

            if (results.IsValid == false)
            {
                return BadRequest(new { Error = results.Errors.First().ErrorMessage });
            }

            _customerRepository.Save(customer);

            var response = CreateResponse(customer);
            return StatusCode(201, response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(string id, CustomerRequest request)
        {
            if (ModelState.IsValid == false)
                return BadRequest();

            var customer = _customerRepository.GetById(id);
            customer.Update(request);
            _customerRepository.Update(customer);

            var response = CreateResponse(customer);
            return StatusCode(204);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id)
        {
            var customer = _customerRepository.Delete(id);
            return StatusCode(204);
        }

        private CustomerResponse CreateResponse(Customer customer)
        {
            return new CustomerResponse(customer);
        }

    }
}
