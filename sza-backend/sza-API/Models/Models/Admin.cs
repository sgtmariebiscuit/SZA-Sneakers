using Models.EntityFramework;

namespace sza_API.Models
{
    public class Admin : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
