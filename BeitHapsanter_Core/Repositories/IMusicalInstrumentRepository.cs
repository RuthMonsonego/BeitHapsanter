using BeitHapsanter_Core.Entitits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Core.Repositories
{
    public interface IMusicalInstrumentRepository
    {
        List<MusicalInstrument> GetAllMusicalInstruments();
        MusicalInstrument Get(int code);
        void Post(MusicalInstrument m);
        void Put(int code, MusicalInstrument m);
        void Delete(int code);
    }
}
