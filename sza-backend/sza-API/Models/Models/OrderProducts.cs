using Models.EntityFramework;

namespace sza_API.Models
{
    public class OrderProducts : BaseEntity
    {
        public int OrderId { get; set; }
        public int SneakerId { get; set; }
    }
}
