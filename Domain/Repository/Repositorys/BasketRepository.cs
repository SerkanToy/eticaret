using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace eticaret.Domain.Repository.Repositorys
{
    public class BasketRepository : Repository<Basket>, IBasketRepository
    {
        public BasketRepository(CommerceContext context) : base(context)
        {
            
        }

        public List<Basket> GetBasketJoinProduct(int userId)
        {
            return context.Baskets.Where(b => b.UserId == userId).Include(j => j.Product).ThenInclude(i => i.Images.Where(h => h.IsShowcase == true)).ToList();
        }
    }
}
