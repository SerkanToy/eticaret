namespace eticaret.Domain.Core.Entities
{
    public class ColorProduct
    {
        public ColorProduct()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public string ColorsId { get; set; }
        public Colors Colors { get; set; }
    }
}
