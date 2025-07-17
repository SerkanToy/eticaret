using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using eticaret.Models.ViewModel.WishlistDTO;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Security.Claims;

namespace eticaret.Domain.Repository.Repositorys
{
    public class FavoritesRepository : Repository<Favorites>, IFavoritesRepository
    {
        private readonly IHttpContextAccessor _httpConAcsr;
        public FavoritesRepository(CommerceContext context) : base(context)
        {
            _httpConAcsr = new HttpContextAccessor();
        }

        public List<Product> FavoritesJoin(Expression<Func<Product, bool>> predicate = null)
        {
            var name = _httpConAcsr.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var identityuser = context.UserApp.FirstOrDefault(x => x.Id == Convert.ToInt32(name));
            var wishlistViewModel = context.Favorites.Where(x => x.UserId == Convert.ToInt32(name))
                .Include(x => x.Product).ThenInclude(x => x.SubCategory).ThenInclude(x => x.Category)
                .Include(i => i.Product.Images).Include(i => i.Product.RatinProducts)
                .Select(c => new Product
                {
                    Id = c.Product.Id,
                    Name = c.Product.Name,
                    Description = c.Product.Description,
                    IsDeleted = c.Product.IsDeleted,
                    Category = c.Product.SubCategory.Category,
                    Images = c.Product.Images.Where(x => x.IsDeleted == false && x.IsShowcase == true).ToList(),
                    NewPrice = c.Product.NewPrice,
                    OldPrice = c.Product.OldPrice,
                    RatinMax = c.Product.RatinProducts.Count() != 0 ? c.Product.RatinProducts.Select(v => new RatinProduct
                                {
                                    Id = v.Id,
                                    ProductId = v.ProductId,
                                    RatinId = v.RatinId,
                                    Ratin = new Ratin
                                    {
                                        Id = v.Ratin.Id,
                                        Rating = v.Ratin.Rating
                                    }
                                }).Max(f => f.Ratin.Rating) : 0,
                });
            return wishlistViewModel.ToList();
        }
    }
}
