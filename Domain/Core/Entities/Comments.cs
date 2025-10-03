using eticaret.Domain.Interfaced;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret.Domain.Core.Entities
{
    public class Comments : IModel
    {
        public Comments() 
        {
            BlogInfoAndComment = new List<BlogInfoAndComment>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<BlogInfoAndComment> BlogInfoAndComment { get; set; }
        [ForeignKey(nameof(Reply))]
        public int? CommentsId { get; set; }
        public Comments? Reply { get; set; }
        public ICollection<Comments>? Replys { get; set; }
        public string CreateBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeleteBy { get; set; }
        public string CreateDate { get; set; }
        public string? ModifiedDate { get; set; }
        public string? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public string FN { get; set; }
    }
}
