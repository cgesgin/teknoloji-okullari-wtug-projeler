using Microsoft.AspNetCore.Identity;

namespace _01LoginRegistration.Entities
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string ?Tags { get; set; }
    }
}
