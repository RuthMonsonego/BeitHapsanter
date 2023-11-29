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
        public CustomersController(CustomersService context)
        {
            _data = context;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public List<Customers> Get()
        {
            return _data.getCustomers();
        }

        //GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customers Get(int id)
        {
            return _data.Get(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] Customers c)
        {
            _data.Post(c); 
        }

        [HttpPut]
        public void Put(int id, [FromBody] Customers c)
        {
            _data.Put(id, c);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _data.Delete(id);
        }
    }
}
