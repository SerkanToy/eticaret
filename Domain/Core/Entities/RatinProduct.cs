using eticaret.Domain.Entities.Users;

namespace eticaret.Domain.Core.Entities
{
    public class RatinProduct
    {
        public RatinProduct()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string RatinId { get; set; }
        public Ratin Ratin { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public UserApp User { get; set; }

    }
}
