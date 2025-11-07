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
                new UserRole { RoleId = "3B1DAF66-67E0-4F2A-BB56-03DA7178C814", UserId = "9E400748-88B1-40DE-965C-CD6D005B1A62" },
                new UserRole { RoleId = "58975898-C79C-404B-AC1B-C586036C55E9", UserId = "9E400748-88B1-40DE-965C-CD6D005B1A62" }
            };
        }
    }
}
