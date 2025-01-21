using eticaret.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Context.Mapping.UsersMappings
{
    public class UserRoleMapping : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            //Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });
            builder.HasData(UserRole());
        }

        private List<UserRole> UserRole()
        {
            return new List<UserRole>
            {
                new UserRole { RoleId = 1, UserId = 1 },
                new UserRole { RoleId = 2, UserId = 1 }
            };
        }
    }
}
