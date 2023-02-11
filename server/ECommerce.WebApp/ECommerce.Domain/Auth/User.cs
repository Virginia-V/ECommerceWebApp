using Microsoft.AspNetCore.Identity;

namespace ECommerce.Domain.Auth
{
    public class User : IdentityUser<int>
    {
        public virtual Basket Basket { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
