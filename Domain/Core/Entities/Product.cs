using eticaret.Domain.Interfaced;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Domain.Core.Entities
{
    public class Product: IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Flag { get; set; }
        public int RatinAVG { get; set; }
        [NotMapped]
        public int RatinMax { get; set; }
        [NotMapped]
        public Category CategoryName { get; set; }
        public ICollection<CategoryProduct> CategoryProducts { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<RatinProduct> RatinProducts { get; set; }
    }
}
