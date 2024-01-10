using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Service.Services
{
    public class CustomersService
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersService(ICustomersRepository customersRepository)
        {
            this._customersRepository = customersRepository;
        }

        public List<Customer> getCustomers()
        {
            return _customersRepository.GetAllCustomers().ToList();
        }

        public Customer Get(int id)
        {
            return _customersRepository.Get(id);
        }

        public void Post(Customer c)
        {
            _customersRepository.Post(c);
        }

        public void Put(int id, Customer c)
        {
            _customersRepository.Put(id, c);
        }

        public void Delete(int id)
        {
            _customersRepository.Delete(id);
        }
    }
}
