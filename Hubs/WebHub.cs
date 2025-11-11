using eticaret.Domain.Core.Entities;
using eticaret.Domain.Repository.Interface;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace eticaret.Hubs
{
    public class WebHub: Hub
    {
        private readonly IUnitofWork unitofWork;
        private IBlogRepository blogRepository;
        private ICommentsRepository commentsRepository;
        public WebHub(IUnitofWork unitofWork, IBlogRepository blogRepository = null, ICommentsRepository commentsRepository = null)
        {
             this.unitofWork = unitofWork;
             this.blogRepository = blogRepository;
             this.commentsRepository = commentsRepository;
        }
           
        public async Task SendBasketCount()
        {
            int basketcount = 0;
            string userId = "0A670E37-AC6A-402B-9FDB-2633823E45DF";
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
            int favoritecount = 0;
            string userId = "E6CD8719-4A90-44C1-B966-E030962F9DD5";
            if (Context.User!.Identity!.IsAuthenticated == true)
            {
                userId = unitofWork.GetUserById(Context.User.FindFirst(ClaimTypes.Name)!.Value); 
                favoritecount = unitofWork.GetRepository<Favorites>().GetAllIQueryable(x => x.UserId == userId).Count();
                await Clients.User(userId.ToString()).SendAsync("FavoriteCount", favoritecount);
            }
            else
            {
                await Clients.User(userId).SendAsync("FavoriteCount", favoritecount);
            }
        }

        public async Task SendBlogComment(string id)
        {
            var blogAll = commentsRepository.CommerceJoinBlog(v => v.IsDeleted == false, id).Select(x => new Comments
            {
                Title = x.Title,
                Description = x.Description,
                CreateBy = x.CreateBy,
                CreateDate = x.CreateDate,
            }).ToList();
            /*var blogAll = unitofWork.GetRepository<Comments>().GetAllIQueryable(predicate: v => v.IsDeleted == false)
                .Select(x => new Comments
                {
                    Title = x.Title,
                    Description = x.Description,
                    CreateBy = x.CreateBy,
                    CreateDate = x.CreateDate,
                }).ToList();*/
            /*var blogAll = new List<Comments> { 
                new Comments { Id = 1, Title = "Sample Comment", Description = "This is a sample comment.", CreateBy = "User1", CreateDate = DateTime.Now.ToString(), IsDeleted = false, FN = "SampleFN" }
            };*/
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
