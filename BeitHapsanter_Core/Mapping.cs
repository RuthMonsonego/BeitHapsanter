using AutoMapper;
using BeitHapsanter_Core.DTO;
using BeitHapsanter_Core.Entitits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Core
{
    public class Mapping : Profile
    {
       public Mapping()
        {
            CreateMap<CustomerDto,Customer>().ReverseMap();
            CreateMap<MusicalInstrumentDto,MusicalInstrument>().ReverseMap();
            CreateMap<ProviderDto,Provider>().ReverseMap();
        }
    }
}
