using eticaret.Domain.Core.Entities;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Interface
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<List<Order>> OrderJoinProductAsync(Expression<Func<Order, bool>> predicate = null);
    }
}
