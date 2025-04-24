using eticaret.Domain.Interfaced;

namespace eticaret.Domain.Core.Entities
{
    public class SubCategory : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public string CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public Category Categorys { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
