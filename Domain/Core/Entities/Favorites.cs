using eticaret.Domain.Entities.Users;

namespace eticaret.Domain.Core.Entities
{
    public class Favorites
    {
        public Favorites()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public Product Product { get; set; }
        public string ProductId { get; set; }
        public UserApp User { get; set; }
        public string UserId { get; set; }
    }
}
