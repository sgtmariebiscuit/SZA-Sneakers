using Models.EntityFramework;

namespace sza_API.Models
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Cellnumber { get; set; }
        public string Email { get; set; }
    }
}
