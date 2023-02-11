using ECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Dal.EntityConfiguration
{
    public class DeviceInfoConfig : IEntityTypeConfiguration<DeviceInfo>
    {
        public void Configure(EntityTypeBuilder<DeviceInfo> builder)
        {
            builder.Property(x => x.Title)
                 .IsRequired()
                 .HasMaxLength(80);
            builder.Property(x => x.Description)
                 .IsRequired()
                 .HasMaxLength(300);

        }
    }
}
