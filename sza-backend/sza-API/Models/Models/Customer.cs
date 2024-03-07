using Models.EntityFramework;

namespace sza_API.Models
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
