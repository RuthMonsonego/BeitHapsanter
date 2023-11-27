using BeitHapsanter.Core.Entitits;

namespace BeitHapsanter_Data
{
    public class DataContext
    {
        public List<Customers> CustomersList { get; set; }
        public List<MusicalInstrument> MusicalInstrumentList { get; set; }
        public List<Provider> ProviderList { get; set; }
        public int CustomersCount { get; set; }
        public int MusicalInstrumentCount { get; set; }
        public int ProviderCount { get; set; }
        public DataContext()
        {
            CustomersList = new List<Customers>();
            MusicalInstrumentList = new List<MusicalInstrument>();
            ProviderList = new List<Provider>();
            CustomersCount = 0;
            MusicalInstrumentCount = 0;
            ProviderCount = 0;
        }

    }
}
