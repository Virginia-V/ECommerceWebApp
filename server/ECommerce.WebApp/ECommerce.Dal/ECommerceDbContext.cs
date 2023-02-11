using ECommerce.Dal.Constants;
using ECommerce.Domain;
using ECommerce.Domain.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Type = ECommerce.Domain.Type;

namespace ECommerce.Dal
{
    public class ECommerceDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECommerceDbContext).Assembly);
            ApplyIdentityMapConfiguration(modelBuilder);
        }
        private void ApplyIdentityMapConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users", SchemaConstants.Auth);
            modelBuilder.Entity<UserClaim>().ToTable("UserClaims", SchemaConstants.Auth);
            modelBuilder.Entity<UserLogin>().ToTable("UserLogins", SchemaConstants.Auth);
            modelBuilder.Entity<UserToken>().ToTable("UserTokens", SchemaConstants.Auth);
            modelBuilder.Entity<Role>().ToTable("Roles", SchemaConstants.Auth);
            modelBuilder.Entity<RoleClaim>().ToTable("RoleClaims", SchemaConstants.Auth);
            modelBuilder.Entity<UserRole>().ToTable("UserRole", SchemaConstants.Auth);
        }

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<BasketDevice> BasketDevices { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceInfo> DeviceInfos { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Type> Types { get; set; }

    }
}
