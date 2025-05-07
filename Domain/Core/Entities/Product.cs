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
        public string? OldPrice { get; set; }
        public string? NewPrice { get; set; }
        public string Description { get; set; }
        public string Flag { get; set; }
        public int RatinAVG { get; set; }
        [NotMapped]
        public int RatinMax { get; set; }
        [NotMapped]
        public Category? Category { get; set; }
        [NotMapped]
        public ICollection<Colors>? Colors { get; set; }
        public ICollection<ColorProduct> ColorProduct { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<RatinProduct> RatinProducts { get; set; }
        public ICollection<Image>? Images { get; set; }
    }
}
