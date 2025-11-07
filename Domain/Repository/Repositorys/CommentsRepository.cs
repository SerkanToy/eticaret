using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Repositorys
{
    public class CommentsRepository : Repository<Comments>, ICommentsRepository
    {
        public CommentsRepository(CommerceContext context) : base(context)
        {
            
        }

        public List<Comments> CommerceJoinBlog(Expression<Func<Comments, bool>> predicate = null, string id = null)
        {
            return context.BlogInfoAndComment.Include(v => v.Comment)
                .Include(v => v.BlogInfo)
                .Where(v => v.BlogInfo.Id == id)
                .Select(c => new Comments
                {
                    Title = c.Comment.Title,
                    CreateBy = c.Comment.CreateBy,
                    Description = c.Comment.Description,
                    CreateDate = c.Comment.CreateDate
                }).ToList();    
            /*return context.Comment.Include(v => v.BlogInfoAndComment)
                .ThenInclude(v => v.BlogInfo)
                .Select(c => new Comments { 
                    Title = c.Title, CreateBy = c.CreateBy, Description = c.Description, CreateDate = c.CreateDate  
                }).ToList();*/
        }
    }
}