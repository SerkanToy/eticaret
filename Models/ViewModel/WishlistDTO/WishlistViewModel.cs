using eticaret.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Models.ViewModel.WishlistDTO
{
    public class WishlistViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WishlistCount { get; set; }
        [DisplayFormat(DataFormatString = "{18:2}")]
        public decimal OldPrice { get; set; } = 0;
        [DisplayFormat(DataFormatString = "{18:2}")]
        public decimal NewPrice { get; set; } = 0;
        public string Description { get; set; }
        public string Flag { get; set; }
        public int RatinAVG { get; set; }
        [NotMapped]
        public int RatinMax { get; set; }
        [NotMapped]
        public Category? Category { get; set; }
        [NotMapped]
        public ICollection<Colors>? Colors { get; set; }
        public ICollection<Favorites>? Favorites { get; set; }
        public ICollection<ColorProduct> ColorProduct { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<RatinProduct> RatinProducts { get; set; }
        public ICollection<Image>? Images { get; set; }
    }
}
