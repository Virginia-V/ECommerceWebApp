using ECommerce.Domain.Auth;

namespace ECommerce.Domain
{
    public class Rating : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int DeviceId { get; set; }
        public virtual Device Device { get; set; }
        public string Rate { get; set; }
    }
}
