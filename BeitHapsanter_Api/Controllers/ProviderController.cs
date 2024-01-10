using BeitHapsanter_Api.Models;
using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace BeitHapsanter_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly ProviderService _data;
        public ProviderController(ProviderService context)
        {
            _data = context;
        }

        // GET: api/<ProviderController>
        [HttpGet]
        public List<Provider> Get()
        {
            return _data.getProviders();
        }

        //GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public Provider Get(int id)
        {
            return _data.Get(id);
        }

        // POST api/<ProviderController>
        [HttpPost]
        public void Post([FromBody] ProviderPostModel p)
        {
            Provider provider = new Provider { Name = p.Name, Address = p.Address, Phone = p.Phone };
            _data.Post(provider);
        }

        // POST api/<ProviderController>
        [HttpPut]
        public void Put(int id, [FromBody] ProviderPostModel p)
        {
            Provider provider = new Provider { Name = p.Name,Address=p.Address, Phone = p.Phone };
            _data.Put(id, provider);
        }

        // DELETE api/<ProviderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _data.Delete(id);
        }
    }
}
