using BeitHapsanter_Core.Entitits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitHapsanter_Core.DTO
{
    public class MusicalInstrumentDto
    {
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public double CostPrice { get; set; }
        public int Satockpile { get; set; }
        public Provider Provider { get; set; }
    }
}
