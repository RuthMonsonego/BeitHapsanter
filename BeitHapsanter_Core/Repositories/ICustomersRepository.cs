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
        List<Customers> AllCustomers();
        Customers GetById(int id);
        void Post(Customers c);
        void Put(int id, Customers c);
        void Delete(int id);
    }
}
