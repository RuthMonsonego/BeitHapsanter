using AutoMapper;
using BeitHapsanter_Api.Models;
using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace BeitHapsanter_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomersService _data;
        private readonly IMapper _mapper;
        public CustomersController(CustomersService context,IMapper mapping)
        {
            _data = context;
            _mapper = mapping;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public List<Customer> Get()
        {
            return _data.getCustomers();
        }

        //GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _data.Get(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] CustomerPostModel c)
        {
            var newCustomer = new Customer { Name = c.Name, Address = c.Address, LastPurchaseDate = c.LastPurchaseDate, Phone = c.Phone };
            _data.Post(newCustomer); 
        }

        [HttpPut]
        public void Put(int id, [FromBody] CustomerPostModel c)
        {
            var customer = _data.Get(id);
            if(customer != null)
            {
                customer.Name = c.Name;
                customer.Address = c.Address;
                customer.LastPurchaseDate = c.LastPurchaseDate;
                customer.Phone = c.Phone;
                _data.Put(id, customer);
            }
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _data.Delete(id);
        }
    }
}
