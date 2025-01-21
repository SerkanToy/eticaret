using eticaret.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Context.Mapping.UsersMappings
{
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.UserRoles).WithOne().HasForeignKey(f => f.RoleId).IsRequired();
            builder.HasData(Role());
        }

        private List<Role> Role()
        {
            return new List<Role>
            {
                new Role { Id = 1, Name = "superuser", NormalizedName = "SUPERUSER", Flag = "46D16588-9420-4F85-A768-D21419075284", ConcurrencyStamp = "924B836D-B087-4D37-A52D-210ABD72CD96", CreateBy = "Sistem", CreateDate = DateTime.Now.ToString() },
                new Role { Id = 2, Name = "admin", NormalizedName = "ADMIN", Flag = "70449BCD-A6DC-4601-867E-35AD80657B28", ConcurrencyStamp = "232D9C58-01CE-466A-90D0-EB7039C75465", CreateBy = "Sistem", CreateDate = DateTime.Now.ToString() }
            };
        }

    }
}
