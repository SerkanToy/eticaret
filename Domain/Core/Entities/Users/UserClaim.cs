using Microsoft.AspNetCore.Identity;

namespace eticaret.Domain.Entities.Users
{
    public class UserClaim : IdentityUserClaim<int>
    {
        public string Flag { get; set; }
    }
}
