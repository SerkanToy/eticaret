namespace eticaret.Domain.Core.Entities
{
    public class Ratin
    {
        public Ratin()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public int Rating { get; set; }
        public ICollection<RatinProduct> RatinProducts { get; set; }
    }
}
