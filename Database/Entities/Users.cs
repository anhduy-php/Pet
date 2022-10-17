using Microsoft.AspNetCore.Identity;

namespace Database.Entities
{
    public class Users : IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DoB { set; get; }
        public bool isDelete { set; get; }
    }
}
