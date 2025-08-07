using eticaret.Domain.Core.Entities;

namespace eticaret.Domain.Repository.Interface
{
    public interface IBasketRepository : IRepository<Basket>
    {
        List<Basket> GetBasketJoinProduct(int userId);
    }
}
