using Microsoft.AspNetCore.Identity;

namespace Domain.Models.User
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
