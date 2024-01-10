namespace BeitHapsanter_Api.Models
{
    public class MusicalInstrumentPostModel
    {
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public double CostPrice { get; set; }
        public double PurchasePrice { get; set; }
        public int Satockpile { get; set; }
        public int ProviderCode { get; set; }
    }
}
