using eticaret.Domain.Entities.Users;
using eticaret.Domain.Interfaced;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Domain.Entities
{
    public class Address: IModel
    {
        public Address() 
        {
            
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        [NotMapped]
        public User User { get; set; }
        public string CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Flag { get; set; }
    }
}
