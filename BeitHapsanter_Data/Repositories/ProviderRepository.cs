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
            return _context.ProviderList;
        }
        public Provider GetById(int id)
        {
            return _context.ProviderList.First((x) => x.id == id);
        }
        public void Post(Provider p)
        {
            _context.ProviderList.Add(new Provider { id = _context.ProviderCount++, name = p.name, phone = p.phone, address = p.address });
        }

        public void Put(int id, Provider p)
        {
            var f = _context.ProviderList.First(e => e.id == id);
            f.name = p.name;
            f.phone = p.phone;
            f.address = p.address;
        }

        public void Delete(int id)
        {
            var p = _context.ProviderList.First(e => e.id == id);
            _context.ProviderList.Remove(p);
        }
    }
}

