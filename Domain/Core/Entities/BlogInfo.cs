using eticaret.Domain.Entities.Users;
using eticaret.Domain.Interfaced;

namespace eticaret.Domain.Core.Entities
{
    public class BlogInfo : IModel
    {
        public BlogInfo()
        {
            CreateDate = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            BlogInfoAndComment = new List<BlogInfoAndComment>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<BlogInfoAndComment> BlogInfoAndComment { get; set; }
        public int UserId { get; set; }
        public UserApp User { get; set; }
        public string CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
