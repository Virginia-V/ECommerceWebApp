namespace ECommerce.Domain
{
    public class DeviceInfo : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int DeviceId { get; set; }
        public virtual Device Device { get; set; }
    }
}
