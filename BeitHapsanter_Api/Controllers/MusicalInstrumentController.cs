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
        [HttpGet("{code}")]
        public MusicalInstrument Get(int code)
        {
            return _data.Get(code);
        }
        // POST api/<MusicalInstrumentController>
        [HttpPost]
        public void Post([FromBody] MusicalInstrument m)
        {
            _data.Post(m); 
        }

        // PUT api/<MusicalInstrumentController>
        [HttpPut]
        public void Put(int code, [FromBody] MusicalInstrument m)
        {
            _data.Put(code, m);
        }

        // DELETE api/<MusicaLInstrumentController>/5
        [HttpDelete("{code}")]
        public void Delete(int code)
        {
            _data.Delete(code);
        }
    }
}
