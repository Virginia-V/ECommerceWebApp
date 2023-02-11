namespace ECommerce.Domain
{
    public class BasketDevice : BaseEntity
    {
        public int BasketId { get; set; }
        public virtual Basket Basket { get; set; }
        public int DeviceId { get; set; }
        public virtual Device Device { get; set; }

    }
}
