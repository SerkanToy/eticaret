using eticaret.Domain.Core.Entities;
using eticaret.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Wishlist
{
    public class WishlistModel : PageModel
    {
        [BindProperty]
        public List<Product> wishlistViewModel { get; set; }
        private readonly IFavoritesRepository favoritesRepository;
        public WishlistModel(IFavoritesRepository favoritesRepository)
        {
            this.favoritesRepository = favoritesRepository;
        }
        public void OnGet()
        {
            if(User.Identity.IsAuthenticated == true)
                wishlistViewModel = favoritesRepository.FavoritesJoin(x => x.IsDeleted == false);
            else
                wishlistViewModel = new List<Product>();
        }
    }
}
