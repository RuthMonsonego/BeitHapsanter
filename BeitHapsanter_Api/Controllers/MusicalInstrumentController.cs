using BeitHapsanter;
using BeitHapsanter.Core.Entitits;
using Microsoft.AspNetCore.Mvc;

namespace BeitHapsanter_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicalInstrumentController : ControllerBase
    {
        private readonly DataContext _data;
        public MusicalInstrumentController(DataContext context)
        {
            _data = context;
        }
        // GET: api/<MusicalInstrumentController>
        [HttpGet]
        public List<MusicalInstrument> Get()
        {
            return _data.MusicalInstrumentList;
        }

        //GET api/<MusicalInstrumentController>/5
        [HttpGet("{code}")]
        public ActionResult<MusicalInstrument> Get(int code)
        {
            var f = _data.MusicalInstrumentList.Find(e => e.code == code);
            if (f != null)
                return f;
            return NotFound();
        }
        // POST api/<MusicalInstrumentController>
        [HttpPost]
        public ActionResult Post([FromBody] MusicalInstrument m)
        {
            var f = _data.ProviderList.Find(e => e.id == m.providerCode);
            if (f == null)
                return NotFound();
            _data.MusicalInstrumentList.Add(new MusicalInstrument { code = _data.MusicalInstrumentCount++, name = m.name , manufacturer =m.manufacturer , costPrice =m.costPrice , purchasePrice =m.purchasePrice , stockpile =m.stockpile , providerCode =m.providerCode }) ;
            return Ok();
        }

        // PUT api/<MusicalInstrumentController>
        [HttpPut]
        public ActionResult Put(int code, [FromBody] MusicalInstrument m)
        {
            var f1 = _data.MusicalInstrumentList.Find(e => e.code == code);
            var f2 = _data.ProviderList.Find(e => e.id == m.providerCode);
            if (f1 == null||f2==null)
                return NotFound();
            f1.name = m.name;
            f1.manufacturer = m.manufacturer;
            f1.costPrice = m.costPrice;
            f1.purchasePrice = m.purchasePrice;
            f1.stockpile = m.stockpile;
            f1.providerCode = m.providerCode;
            return Ok();
        }

        // DELETE api/<MusicaLInstrumentController>/5
        [HttpDelete("{code}")]
        public ActionResult Delete(int code)
        {
            var m = _data.MusicalInstrumentList.Find(e => e.code == code);
            if (m == null)
                return NotFound();
            _data.MusicalInstrumentList.Remove(m);
            return Ok();
        }
    }
}
