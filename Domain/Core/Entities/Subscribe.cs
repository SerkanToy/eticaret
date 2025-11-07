using System.ComponentModel.DataAnnotations;

namespace eticaret.Domain.Core.Entities
{
    public class Subscribe
    {
        public Subscribe()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
