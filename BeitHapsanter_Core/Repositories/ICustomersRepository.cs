using BeitHapsanter_Core.Entitits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Core.Repositories
{
    public interface ICustomersRepository
    {
        List<Customer> GetAllCustomers();
        Customer Get(int id);
        void Post(Customer c);
        void Put(int id, Customer c);
        void Delete(int id);
    }
}
