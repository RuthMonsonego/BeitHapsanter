namespace BeitHapsanter_Core.Entitits
{
    public class Provider
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public string? Phone { set; get; }
        public string? Address { set; get; }
        public List<MusicalInstrument> MusicalInstruments { get; set; }

    }
}
