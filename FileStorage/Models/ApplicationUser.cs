using Microsoft.AspNetCore.Identity;

namespace FileStorage.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateOnly RegistrationDate { get; set; }
    }
}
