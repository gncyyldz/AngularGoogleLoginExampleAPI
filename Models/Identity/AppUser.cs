using Microsoft.AspNetCore.Identity;

namespace AngularGoogleLoginExampleAPI.Models.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string Provider { get; set; }
    }
}
