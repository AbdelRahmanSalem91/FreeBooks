
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.ViewModel
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string UserImage { get; set; }
        public bool IsActive { get; set; }
    }
}
