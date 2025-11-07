using eticaret.Domain.Entities.Users;
using eticaret.Domain.Interfaced;

namespace eticaret.Domain.Core.Entities
{
    public class BlogInfoAndComment : IModel
    {
        public string BlogInfoId { get; set; }
        public BlogInfo BlogInfo { get; set; }
        public string CommentId { get; set; }
        public Comments Comment { get; set; }
        public string UserId { get; set; }
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
