using eticaret.Domain.Entities.Users;
using eticaret.Domain.Interfaced;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Domain.Entities
{
    public class Address: IModel
    {
        public Address() 
        {
            
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Bırakmayın")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş Bırakmayın")]
        public string Name { get; set; }
        public int UserId { get; set; }
        [NotMapped]
        public UserApp? User { get; set; }
        public string? CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string? CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? Flag { get; set; }
    }
}
