using BeitHapsanter_Core.Entitits;
using BeitHapsanter_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Service.Services
{
    public class MusicalInstrumentService
    {
        private readonly IMusicalInstrumentRepository musicalInstrumentRepository;
        public MusicalInstrumentService(IMusicalInstrumentRepository musicalInstrumentRepository)
        {
            this.musicalInstrumentRepository = musicalInstrumentRepository;
        }

        public List<MusicalInstrument> getMusicalInstruments()
        {
            return musicalInstrumentRepository.GetAllMusicalInstruments();
        }
        public MusicalInstrument GetById(int id)
        {
            return musicalInstrumentRepository.GetById(id);
        }
        public void Post(MusicalInstrument m)
        {
            musicalInstrumentRepository.Post(m);
        }

        public void Put(int id, MusicalInstrument m)
        {
            musicalInstrumentRepository.Put(id, m);
        }

        public void Delete(int id)
        {
            musicalInstrumentRepository.Delete(id);
        }
    }
}
