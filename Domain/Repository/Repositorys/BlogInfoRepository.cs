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
            var blog = context.BlogInfo.FirstOrDefault(b => b.Id == userId);


            return new BlogInfo
            {
                Id = blog.Id,
                Title = blog.Title,
                Description = blog.Description,
                CreateBy = blog.CreateBy
            };
        }
    }
}
