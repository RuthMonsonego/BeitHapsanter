using BeitHapsanter;
using BeitHapsanter.Core.Entitits;
using Microsoft.AspNetCore.Mvc;

namespace BeitHapsanter_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DataContext _data;
        public CustomersController(DataContext context)
        {
            _data = context;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public List<Customers> Get()
        {
            return _data.CustomersList;
        }

        //GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult<Customers> Get(int id)
        {
            var f = _data.CustomersList.Find(e => e.id == id);
            if (f != null)
                return f;
            return NotFound();
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] Customers c)
        {
            _data.CustomersList.Add(new Customers { id = _data.CustomersCount++, name = c.name, phone = c.phone, address = c.address, lastPurchaseDate = c.lastPurchaseDate });
        }

        [HttpPut]
        public ActionResult Put(int id, [FromBody] Customers c)
        {
            var f = _data.CustomersList.Find(e => e.id == id);
            if (f == null)
                return NotFound();
            f.name = c.name;
            f.phone = c.phone;
            f.address = c.address;
            f.lastPurchaseDate = c.lastPurchaseDate;
            return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var c = _data.CustomersList.Find(e => e.id == id);
            if (c == null)
                return NotFound();
            _data.CustomersList.Remove(c);
            return Ok();
        }
    }
}
