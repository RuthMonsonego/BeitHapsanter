namespace BeitHapsanter_Core.Entitits
{
    public class MusicalInstrument
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public double CostPrice { get; set; }
        public double PurchasePrice { get; set; }
        public int Satockpile { get; set; }
        public int ProviderID { get; set; }
        public Provider Provider { get; set; }
    }
}
