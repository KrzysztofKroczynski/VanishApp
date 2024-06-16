using Microsoft.AspNetCore.Identity;
using VanishApp.Data.Entities;

namespace VanishApp.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public Client? Client { get; set; }
}