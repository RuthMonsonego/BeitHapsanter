using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Service.Services
{
    public class ProviderService
    {
        private readonly IProviderRepository providerRepository;

        public ProviderService(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
        }

        public List<Provider> getProviders()
        {
            return providerRepository.GetAllProviders();
        }

        public Provider Get(int id)
        {
            return providerRepository.Get(id);
        }

        public void Post(Provider p)
        {
            providerRepository.Post(p);
        }

        public void Put(int id, Provider p)
        {
            providerRepository.Put(id, p);
        }

        public void Delete(int id)
        {
            providerRepository.Delete(id);
        }
    }
}
