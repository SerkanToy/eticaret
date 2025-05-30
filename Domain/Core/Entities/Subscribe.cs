using System.ComponentModel.DataAnnotations;

namespace eticaret.Domain.Core.Entities
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
