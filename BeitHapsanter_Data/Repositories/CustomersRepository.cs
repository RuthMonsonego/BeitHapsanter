using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Data.Repositories
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly DataContext _context;
        public CustomersRepository(DataContext context)
        {
            _context = context;
        }

        public List<Customers> AllCustomers() { return _context.CustomersList; }
        public Customers GetById(int id)
        {
            return _context.CustomersList.First((x) => x.id == id);
        }
        public void Post(Customers c)
        {
            _context.CustomersList.Add(new Customers { id = _context.CustomersCount++, name = c.name, phone = c.phone, address = c.address, lastPurchaseDate = c.lastPurchaseDate });
        }

        public void Put(int id, Customers c)
        {
            var f = _context.CustomersList.Find(e => e.id == id);
            if (f != null)
            { 
                f.name = c.name;
                f.phone = c.phone;
                f.address = c.address;
                f.lastPurchaseDate = c.lastPurchaseDate;
            }
        }

        public void Delete(int id)
        {
            _context.CustomersList.Remove(_context.CustomersList.First(e => e.id == id));
        }
    }
}
