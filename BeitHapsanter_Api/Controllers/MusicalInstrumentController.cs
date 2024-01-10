using BeitHapsanter_Api.Models;
using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace BeitHapsanter_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicalInstrumentController : ControllerBase
    {
        private readonly MusicalInstrumentService _data;
        public MusicalInstrumentController(MusicalInstrumentService context)
        {
            _data = context;
        }
        // GET: api/<MusicalInstrumentController>
        [HttpGet]
        public List<MusicalInstrument> Get()
        {
            return _data.getMusicalInstruments();
        }

        //GET api/<MusicalInstrumentController>/5
        [HttpGet("{id}")]
        public MusicalInstrument Get(int id)
        {
            return _data.Get(id);
        }
        // POST api/<MusicalInstrumentController>
        [HttpPost]
        public void Post([FromBody] MusicalInstrumentPostModel m)
        {
            var musicInstrument = new MusicalInstrument { Name = m.Name, Manufacturer = m.Manufacturer, CostPrice = m.CostPrice, PurchasePrice = m.PurchasePrice, Satockpile = m.Satockpile, ProviderCode = m.ProviderCode };
            _data.Post(musicInstrument); 
        }

        // PUT api/<MusicalInstrumentController>
        [HttpPut]
        public void Put(int code, [FromBody] MusicalInstrumentPostModel m)
        {
            MusicalInstrument musical = new MusicalInstrument { Name = m.Name, Manufacturer = m.Manufacturer, CostPrice = m.CostPrice, PurchasePrice = m.PurchasePrice, Satockpile = m.Satockpile, ProviderCode = m.ProviderCode };
            _data.Put(code, musical);
        }

        // DELETE api/<MusicaLInstrumentController>/5
        [HttpDelete("{code}")]
        public void Delete(int code)
        {
            _data.Delete(code);
        }
    }
}
