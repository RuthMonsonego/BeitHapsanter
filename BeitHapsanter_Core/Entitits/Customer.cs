namespace BeitHapsanter_Core.Entitits
{
    public class Customer
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public string? Phone { set; get; }
        public string? Address { set; get; }
        public DateTime LastPurchaseDate { set; get; }
    }
}
