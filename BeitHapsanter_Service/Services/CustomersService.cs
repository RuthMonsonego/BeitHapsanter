using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Core.Repositories;
using BeitHapsanter_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Service.Services
{
    public class CustomersService
    {
        private readonly ICustomersRepository customersRepository;
        public CustomersService(ICustomersRepository customersRepository)
        {
            this.customersRepository = customersRepository;
        }

        public List<Customers> getCustomers()
        {
            return customersRepository.AllCustomers();
        }
        public Customers GetById(int id)
        {
            return customersRepository.GetById(id);
        }
        public void Post(Customers c)
        {
            customersRepository.Post(c);
        }

        public void Put(int id, Customers c)
        {
            customersRepository.Put(id, c);
        }

        public void Delete(int id)
        {
            customersRepository.Delete(id);
        }
    }
}
