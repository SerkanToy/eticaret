using eticaret.Domain.Core.Entities;

namespace eticaret.Domain.Repository.Interface
{
    public interface IBlogRepository : IRepository<BlogInfo>
    {
        BlogInfo GetBlogInfoJoin(int userId);
    }
}
