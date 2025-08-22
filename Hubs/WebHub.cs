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
            
            if (Context.User!.Identity!.IsAuthenticated == true)
            {
                var userId = unitofWork.GetUserById(Context.User.FindFirst(ClaimTypes.Name)!.Value); ;
                basketcount = unitofWork.GetRepository<Basket>().GetAllIQueryable(x => x.UserId == userId).Select(x => x.Total).Sum();
                await Clients.All.SendAsync("BasketCount", basketcount);
            }
            else
            {
                await Clients.All.SendAsync("BasketCount", basketcount);
            }
        }
    }
}
