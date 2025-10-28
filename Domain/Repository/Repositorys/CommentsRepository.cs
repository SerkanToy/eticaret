using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace eticaret.Domain.Repository.Repositorys
{
    public class CommentsRepository : Repository<Comments>, ICommentsRepository
    {
        public CommentsRepository(CommerceContext context) : base(context)
        {
            
        }
    }
}
