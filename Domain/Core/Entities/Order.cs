using eticaret.Domain.Entities.Users;

namespace eticaret.Domain.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public UserApp User { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public string Quantity { get; set; }
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
