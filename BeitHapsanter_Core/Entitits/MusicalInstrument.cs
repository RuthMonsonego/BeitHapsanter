namespace BeitHapsanter_Core.Entitits
{
    public class MusicalInstrument
    {
        public int code { get; set; }
        public string? name { get; set; }
        public string? manufacturer { get; set; }
        public double costPrice { get; set; }
        public double purchasePrice { get; set; }
        public int stockpile { get; set; }
        public int providerCode { get; set; }
    }
}
