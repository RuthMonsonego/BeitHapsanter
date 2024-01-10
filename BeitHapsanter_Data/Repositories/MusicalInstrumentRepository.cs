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
            return _context.MusicalInstruments.ToList();
        }

        public MusicalInstrument Get(int code)
        {
            return _context.MusicalInstruments.ToList().First((x) => x.Id == code);
        }

        public void Post(MusicalInstrument m)
        {
            _context.MusicalInstruments.Add(m);
            _context.SaveChanges();
        }

        public void Put(int code, MusicalInstrument m)
        {
            var f = Get(code);
            if (f != null)
            {
                f.Name = m.Name;
                f.Manufacturer = m.Manufacturer;
                f.CostPrice = m.CostPrice;
                f.PurchasePrice = m.PurchasePrice;
                f.Satockpile = m.Satockpile;
                f.ProviderCode = m.ProviderCode;
                _context.SaveChanges();
            }
        }

        public void Delete(int code)
        {
            _context.MusicalInstruments.Remove(Get(code));
            _context.SaveChanges();
        }
    }
}

