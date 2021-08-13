using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopDemo.Customer.Commands;
using ShopDemo.Customer.Models;
using ShopDemo.Customer.Queries;

namespace ShopDemo.Controllers.API.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<List<CustomerModel>> Get()
        {
            return await _mediator.Send(new GetCustomerListQuery());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<CustomerModel> Get(int id)
        {
            return await _mediator.Send(new GetCustomerByIdQuery(id));
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<CustomerModel> Post([FromBody] CustomerModel value)
        {
            var model = new InsertCustomerCommand(value.FirstName, value.LastName);

            return await _mediator.Send(model);
        }
    }
}
