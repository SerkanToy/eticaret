using eticaret.Domain.Core.Entities;
using eticaret.Models.ViewModel.WishlistDTO;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Interface
{
    public interface IFavoritesRepository : IRepository<Favorites>
    {
        List<Product> FavoritesJoin(Expression<Func<Product, bool>> predicate = null);
    }
}
