namespace eticaret.Domain.Core.Entities
{
    public class ColorProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ColorsId { get; set; }
        public Colors Colors { get; set; }
    }
}
