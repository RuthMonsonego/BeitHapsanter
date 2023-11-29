using BeitHapsanter_Core.Entitits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Core.Repositories
{
    public interface IProviderRepository
    {
        List<Provider> GetAllProviders();
        Provider Get(int id);
        void Post(Provider p);
        void Put(int id, Provider p);
        void Delete(int id);
    }
}
