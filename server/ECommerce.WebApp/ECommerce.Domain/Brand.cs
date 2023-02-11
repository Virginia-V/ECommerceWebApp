namespace ECommerce.Domain
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Type> Types { get; set; }
    }
}
