using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace eticaret.Domain.Repository.Repositorys
{
    public class BlogInfoRepository : Repository<BlogInfo>, IBlogRepository
    {
        public BlogInfoRepository(CommerceContext context) : base(context)
        {
            
        }

        public BlogInfo GetBlogInfoJoin(int userId)
        {
            var blog = context.BlogInfo.Include(j => j.BlogInfoAndComment).ThenInclude(y => y.Comment).ThenInclude(g => g.Replys).FirstOrDefault(b => b.Id == userId);


            return new BlogInfo
            {
                Id = blog.Id,
                Title = blog.Title,
                Description = blog.Description,
                CreateBy = blog.CreateBy,
                BlogInfoAndComment = blog.BlogInfoAndComment.Select(v => new BlogInfoAndComment
                {
                    UserId = v.UserId,
                    BlogInfoId = v.BlogInfoId,
                    CommentId = v.CommentId,
                    Comment = new Comments
                    {
                        Id = v.Comment.Id,
                        Title = v.Comment.Title, 
                        Description = v.Comment.Description,
                        CreateBy = v.Comment.CreateBy,
                        CreateDate = v.Comment.CreateDate,
                        FN = v.Comment.CreateBy.Substring(0, 1).ToUpper()
                    }
                }).Where(b => b.IsDeleted == false).ToList()
            };
        }
    }
}
