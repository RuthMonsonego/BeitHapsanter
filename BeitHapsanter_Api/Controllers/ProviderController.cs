using BeitHapsanter;
using BeitHapsanter.Core.Entitits;
using Microsoft.AspNetCore.Mvc;

namespace BeitHapsanter_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly DataContext _data;
        public ProviderController(DataContext context)
        {
            _data = context;
        }

        // GET: api/<ProviderController>
        [HttpGet]
        public List<Provider> Get()
        {
            return _data.ProviderList;
        }

        //GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public ActionResult<Provider> Get(int id)
        {
            var f = _data.ProviderList.Find(e => e.id == id);
            if (f != null)
                return f;
            return NotFound();
        }

        // POST api/<ProviderController>
        [HttpPost]
        public void Post([FromBody] Provider p)
        {
            _data.ProviderList.Add(new Provider { id = _data.ProviderCount++, name = p.name, phone=p.phone,address=p.address});
        }

        // POST api/<ProviderController>
        [HttpPut]
        public ActionResult Put(int id, [FromBody] Provider p)
        {
            var f = _data.ProviderList.Find(e => e.id == id);
            if (f == null)
                return NotFound();
            f.name = p.name;
            f.phone = p.phone;
            f.address = p.address;
            return Ok();
        }

        // DELETE api/<ProviderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var p = _data.ProviderList.Find(e => e.id == id);
            if (p == null)
                return NotFound();
            _data.ProviderList.Remove(p);
            return Ok();
        }
    }
}
