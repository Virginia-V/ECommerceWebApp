using Microsoft.AspNetCore.Identity;

namespace ECommerce.Domain.Auth
{
    public class Role : IdentityRole<int>
    {
        public Role(string name) : base(name)
        {

        }
    }
}
