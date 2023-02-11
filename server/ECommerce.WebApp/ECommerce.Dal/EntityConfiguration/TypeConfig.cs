using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Type = ECommerce.Domain.Type;

namespace ECommerce.Dal.EntityConfiguration
{
    public class TypeConfig : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.Property(x => x.Name)
                 .IsRequired()
                 .HasMaxLength(80);

        }
    }
}
