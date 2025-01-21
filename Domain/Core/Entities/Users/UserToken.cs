using Microsoft.AspNetCore.Identity;

namespace eticaret.Domain.Entities.Users
{
    public class UserToken: IdentityUserToken<int>
    {
        //public virtual AppUser User { get; set; }
        public string Flag { get; set; }
    }
}
