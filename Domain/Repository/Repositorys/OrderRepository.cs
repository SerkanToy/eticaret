using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Repositorys
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(CommerceContext context) : base(context)
        {
        }

        public async Task<List<Order>> OrderJoinProductAsync(Expression<Func<Order, bool>> predicate = null)
        {
            var pro = await context.Order.Where(predicate).
                Include(j => j.User).
                Include(f => f.Product).
                ThenInclude(g => g.Baskets).ToListAsync();            

            return pro ?? new List<Order>();
        }
    }
}
