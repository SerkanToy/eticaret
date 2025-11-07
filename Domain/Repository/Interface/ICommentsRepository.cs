using eticaret.Domain.Core.Entities;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Interface
{
    public interface ICommentsRepository : IRepository<Comments>
    {
        List<Comments> CommerceJoinBlog(Expression<Func<Comments, bool>> predicate = null, string id = null);
    }
}
