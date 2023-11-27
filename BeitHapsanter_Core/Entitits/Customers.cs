namespace BeitHapsanter_Core.Entitits
{
    public class Customers
    {
        public int id { set; get; }
        public string? name { set; get; }
        public string? phone { set; get; }
        public string? address { set; get; }
        public DateTime lastPurchaseDate { set; get; }
    }
}
