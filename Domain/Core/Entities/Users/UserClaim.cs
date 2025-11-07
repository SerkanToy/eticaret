using Microsoft.AspNetCore.Identity;

namespace eticaret.Domain.Entities.Users
{
    public class UserClaim : IdentityUserClaim<string>
    {
        public string Flag { get; set; }
    }
}
