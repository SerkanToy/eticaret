using eticaret.Domain.Interfaced;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Domain.Entities.Users
{
    public class Role : IdentityRole<int>, IModel
    {
        [NotMapped]
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public string Flag { get; set; }
        public string CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
