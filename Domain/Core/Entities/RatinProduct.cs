using eticaret.Domain.Entities.Users;

namespace eticaret.Domain.Core.Entities
{
    public class RatinProduct
    {
        public int Id { get; set; }
        public int RatinId { get; set; }
        public Ratin Ratin { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
