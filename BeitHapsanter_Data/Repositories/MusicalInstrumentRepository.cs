using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Data.Repositories
{
    public class MusicalInstrumentRepository: IMusicalInstrumentRepository
    {
        private readonly DataContext _context;
        public MusicalInstrumentRepository(DataContext context)
        {
            _context = context;
        }

        public List<MusicalInstrument> GetAllMusicalInstruments()
        {
            return _context.MusicalInstrumentList;
        }
        public MusicalInstrument GetById(int code)
        {
            return _context.MusicalInstrumentList.First((x) => x.code == code);
        }
        public void Post(MusicalInstrument m)
        {
            _context.MusicalInstrumentList.Add(new MusicalInstrument { code = _context.MusicalInstrumentCount++, name = m.name, manufacturer = m.manufacturer, costPrice = m.costPrice, purchasePrice = m.purchasePrice, stockpile=m.stockpile, providerCode=m.providerCode });
        }

        public void Put(int code, MusicalInstrument m)
        {
            var f = _context.MusicalInstrumentList.Find(e => e.code == code);
            if (f != null)
            {
                f.name = m.name;
                f.manufacturer = m.manufacturer;
                f.costPrice = m.costPrice;
                f.purchasePrice = m.purchasePrice;
                f.stockpile = m.stockpile;
                f.providerCode = m.providerCode;
            }
        }

        public void Delete(int code)
        {
            _context.MusicalInstrumentList.Remove(_context.MusicalInstrumentList.First(e => e.code == code));
        }
    }
}

