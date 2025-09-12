using eticaret.Domain.Core.Entities;
using eticaret.Domain.Entities.Users;
using eticaret.Domain.Repository.Interface;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Myorders
{
    [Authorize]
    public class MyOrdersModel : PageModel
    {
        [BindProperty]
        public List<Order> orderViewModel { get; set; }
        [BindProperty]
        public UserApp userViewModel { get; set; }

        private IUnitofWork unitofWork;
        private IOrderRepository orderRepository;
        public MyOrdersModel(IUnitofWork unitofWork, IOrderRepository orderRepository)
        {
            this.unitofWork = unitofWork;
            this.orderRepository = orderRepository;
        }
        public async Task OnGet()
        {
            var user = unitofWork.GetUserBy(User.Identity?.Name);
            userViewModel = user;
            orderViewModel = await orderRepository.OrderJoinProductAsync(predicate: x => x.UserId == user.Id);
        }
    }
}
