using eticaret.Domain.Entities.Users;

namespace eticaret.Domain.Core.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public UserApp User { get; set; }
        public int UserId { get; set; }
        public int Total { get; set; }
    }
}
