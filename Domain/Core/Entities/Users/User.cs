using eticaret.Domain.Core.Entities;
using eticaret.Domain.Interfaced;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Domain.Entities.Users
{
    public class User : IdentityUser<int>, IModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string? TC { get; set; }
        public ICollection<Address> Address { get; set; }
        public string CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsLocked { get; set; }
        public string Flag {  get; set; }
        [NotMapped]
        public ICollection<UserRole> UserRole { get; set; }
        public ICollection<BlogInfo> BlogInfos { get; set; }
        public ICollection<BlogInfoAndComment> BlogInfoAndComment { get; set; }
    }
}
