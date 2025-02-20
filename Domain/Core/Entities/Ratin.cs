namespace eticaret.Domain.Core.Entities
{
    public class Ratin
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public ICollection<RatinProduct> RatinProducts { get; set; }
    }
}
