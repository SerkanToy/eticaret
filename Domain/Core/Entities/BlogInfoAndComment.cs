using eticaret.Domain.Entities.Users;
using eticaret.Domain.Interfaced;

namespace eticaret.Domain.Core.Entities
{
    public class BlogInfoAndComment : IModel
    {
        public int BlogInfoId { get; set; }
        public BlogInfo BlogInfo { get; set; }
        public int CommentId { get; set; }
        public Comments Comment { get; set; }
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
