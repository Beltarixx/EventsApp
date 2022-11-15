using Microsoft.AspNetCore.Identity;

namespace EventsApp.DataAccessLayer.Entities
{
    public class User : IdentityUser
    {
        // Id, Email and Pasword come from IdentityUser
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
