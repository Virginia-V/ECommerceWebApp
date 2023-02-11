namespace ECommerce.Domain
{
    public class Device : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<DeviceInfo> DeviceInfos { get; set; }
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual BasketDevice BasketDevice { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }

    }
}
