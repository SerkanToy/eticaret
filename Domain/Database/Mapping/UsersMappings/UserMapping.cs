using eticaret.Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Context.Mapping.UsersMappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Address).WithOne(x => x.User).OnDelete(deleteBehavior:DeleteBehavior.NoAction);
            builder.HasMany(x => x.BlogInfos).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(deleteBehavior:DeleteBehavior.NoAction);
            builder.HasMany(x => x.BlogInfoAndComment).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(deleteBehavior:DeleteBehavior.NoAction);
            builder.HasData(User());
        }
        private User User()
        {
            var user = new User
            {
                Id = 1,
                Email = "stoy@windowslive.com",
                NormalizedEmail = "STOY@WINDOWSLIVE.COM",
                Name = "Serkan",
                SurName = "TOY",
                UserName = "stoy",
                NormalizedUserName = "STOY",
                PhoneNumber = "0(533) 656 30 95",
                SecurityStamp = "63742240-5787-4E6A-8AE2-FE8BA5381630",
                CreateBy = "Sistem",
                CreateDate = DateTime.Now.ToString(),
                IsLocked = false,
                Flag = "D90E65E6-9611-4B5F-9F24-BBD468398D51",
                TC = "28301227926"
            };
            user.PasswordHash = CreatePasswordHash(user, "Qwe123");
            return user;
        }

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHash = new PasswordHasher<User>();
            return passwordHash.HashPassword(user, password);
        }


    }
}
