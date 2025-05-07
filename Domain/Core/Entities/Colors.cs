using eticaret.Domain.Interfaced;

namespace eticaret.Domain.Core.Entities
{
    public class Colors : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colorvalue { get; set; }
        public string CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ColorProduct> ColorProduct { get; set; }
    }
}
