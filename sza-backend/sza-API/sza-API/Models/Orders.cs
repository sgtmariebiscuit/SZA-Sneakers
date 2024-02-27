namespace sza_API.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int CollectionMethod { get; set; }
    }
}
