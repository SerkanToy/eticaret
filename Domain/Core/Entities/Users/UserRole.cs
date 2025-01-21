using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Domain.Entities.Users
{
    public class UserRole : IdentityUserRole<int>
    {
        //public override int UserId { get; set; } = default!;
        [NotMapped]
        public virtual User User { get; set; }
        //public override int RoleId { get; set; } = default!;
        [NotMapped]
        public virtual Role Role { get; set; }
    }
}
