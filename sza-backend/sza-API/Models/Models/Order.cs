using Models.EntityFramework;

namespace sza_API.Models
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public int CollectionMethod { get; set; }
    }
}
