namespace eticaret.Models
{
    public class Message
    {
        public bool Succeeded { get; set; } = false;
        public ICollection<string>? TextMessage { get; set; }
    }
}
