namespace ECommerce.Domain
{
    public class Type : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
