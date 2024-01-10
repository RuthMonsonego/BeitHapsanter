using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Data.Repositories
{
    public class ProviderRepository: IProviderRepository
    {
        private readonly DataContext _context;
        public ProviderRepository(DataContext context)
        {
            _context = context;
        }

        public List<Provider> GetAllProviders()
        {
            return _context.Providers.ToList();
        }

        public Provider Get(int id)
        {
            return _context.Providers.ToList().First((x) => x.Id == id);
        }

        public void Post(Provider p)
        {
            _context.Providers.Add(p);
            _context.SaveChanges();
        }

        public void Put(int id, Provider p)
        {
            var f = Get(id);
            if (f != null)
            {
                f.Name = p.Name;
                f.Phone = p.Phone;
                f.Address = p.Address;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var p = Get(id);
            _context.Providers.Remove(p);
            _context.SaveChanges();
        }
    }
}

