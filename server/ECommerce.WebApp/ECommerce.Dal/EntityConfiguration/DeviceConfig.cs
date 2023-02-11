using ECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Dal.EntityConfiguration
{
    public class DeviceConfig : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.Property(x => x.Name)
                 .IsRequired()
                 .HasMaxLength(100);
            builder.Property(x => x.Price)
                 .IsRequired();
            builder.Property(x => x.ImageUrl)
                 .IsRequired();

        }
    }
}
