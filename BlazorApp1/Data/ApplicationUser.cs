using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Role { get; set; }
        //role
    }

}
