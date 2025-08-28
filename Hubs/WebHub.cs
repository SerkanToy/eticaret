using eticaret.Domain.Core.Entities;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Linq;
using System.Security.Claims;

namespace eticaret.Hubs
{
    public class WebHub: Hub
    {
        private readonly IUnitofWork unitofWork;
        public WebHub(IUnitofWork unitofWork)
        {
             this.unitofWork = unitofWork;
        }
           
        public async Task SendBasketCount()
        {
            var basketcount = 0;
            int userId = 0;
            if (Context.User!.Identity!.IsAuthenticated == true)
            {
                userId = unitofWork.GetUserById(Context.User.FindFirst(ClaimTypes.Name)!.Value); ;
                basketcount = unitofWork.GetRepository<Basket>().GetAllIQueryable(x => x.UserId == userId).Select(x => x.Total).Sum();
                await Clients.User(userId.ToString()).SendAsync("BasketCount", basketcount);
            }
            else
            {
                await Clients.User(userId.ToString()).SendAsync("BasketCount", basketcount);
            }
        }

        public async Task SendFavoriteCount()
        {
            var favoritecount = 0;
            int userId = 0;
            if (Context.User!.Identity!.IsAuthenticated == true)
            {
                userId = unitofWork.GetUserById(Context.User.FindFirst(ClaimTypes.Name)!.Value); ;
                favoritecount = unitofWork.GetRepository<Favorites>().GetAllIQueryable(x => x.UserId == userId).Count();
                await Clients.User(userId.ToString()).SendAsync("FavoriteCount", favoritecount);
            }
            else
            {
                await Clients.User(userId.ToString()).SendAsync("FavoriteCount", favoritecount);
            }
        }

        /*public async Task SendCategories()
        {
            var categories = unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
            //var userId = unitofWork.GetUserById(Context.User.FindFirst(ClaimTypes.Name)!.Value); 
            await Clients.All.SendAsync("CategoriesList", categories);
        }*/
    }
}
