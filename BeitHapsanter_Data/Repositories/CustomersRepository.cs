using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Data.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly DataContext _context;
        public CustomersRepository(DataContext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return _context.Customers.First((x) => x.Id == id);
        }

        public void Post(Customer c)
        {
            _context.Customers.Add(c);
            _context.SaveChanges();
        }

        public void Put(int id, Customer c)
        {
            var f = Get(id);
            if (f != null)
            {
                f.Name = c.Name;
                f.Phone = c.Phone;
                f.Address = c.Address;
                f.LastPurchaseDate = c.LastPurchaseDate;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            _context.Customers.Remove(Get(id));
            _context.SaveChanges();
        }
    }
}
