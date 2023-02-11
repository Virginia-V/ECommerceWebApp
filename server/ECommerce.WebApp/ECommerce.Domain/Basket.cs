using ECommerce.Domain.Auth;

namespace ECommerce.Domain
{
    public class Basket : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BasketDevice> BasketDevices { get; set; }
    }
}
