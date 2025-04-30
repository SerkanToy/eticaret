using eticaret.Domain.Interfaced;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Domain.Core.Entities
{
    public class Image: IModel
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
        public bool IsShowcase { get; set; }
        public string Flag { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
