using eticaret.Domain.Core.Entities;
using eticaret.Domain.Repository.Interface;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace eticaret.Hubs
{
    public class WebHub: Hub
    {
        private readonly IUnitofWork unitofWork;
        private IBlogRepository blogRepository;
        public WebHub(IUnitofWork unitofWork, IBlogRepository blogRepository = null)
        {
             this.unitofWork = unitofWork;
             this.blogRepository = blogRepository;
        }
           
        public async Task SendBasketCount()
        {
            var basketcount = 0;
            int userId = 0;
            if (Context.User!.Identity!.IsAuthenticated == true)
            {
                userId = unitofWork.GetUserById(Context.User.FindFirst(ClaimTypes.Name)!.Value); 
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
                userId = unitofWork.GetUserById(Context.User.FindFirst(ClaimTypes.Name)!.Value); 
                favoritecount = unitofWork.GetRepository<Favorites>().GetAllIQueryable(x => x.UserId == userId).Count();
                await Clients.User(userId.ToString()).SendAsync("FavoriteCount", favoritecount);
            }
            else
            {
                await Clients.User(userId.ToString()).SendAsync("FavoriteCount", favoritecount);
            }
        }

        public async Task SendBlogComment()
        {
            var blogAll = unitofWork.GetRepository<Comments>().GetAllIQueryable(x => x.IsDeleted == false).Select(x => new Comments()
            {
                Title = x.Title,
                CreateDate = x.CreateDate,
                CreateBy = x.CreateBy,
                Description = x.Description
            });
            //var blogAll = "Serkan TOY";
            await Clients.All.SendAsync("BlogComment", blogAll);
        }

        /*public async Task SendCategories()
        {
            var categories = unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
            //var userId = unitofWork.GetUserById(Context.User.FindFirst(ClaimTypes.Name)!.Value); 
            await Clients.All.SendAsync("CategoriesList", categories);
        }*/
    }
}
