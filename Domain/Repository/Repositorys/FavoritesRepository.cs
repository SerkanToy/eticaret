using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;

namespace eticaret.Domain.Repository.Repositorys
{
    public class FavoritesRepository : Repository<Favorites>, IFavoritesRepository
    {
        public FavoritesRepository(CommerceContext context) : base(context)
        {
        }
    }
}
