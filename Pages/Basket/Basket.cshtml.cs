using eticaret.Domain.Repository.Interface;
using eticaret.Domain.UnitOfWork;
using eticaret.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using basket = eticaret.Domain.Core.Entities;

namespace eticaret.Pages.Basket
{
    [Authorize]
    public class BasketModel : PageModel
    {
        [BindProperty]
        public IEnumerable<basket.Basket> basketViewModel { get; set; }
        [BindProperty]
        public decimal TotalPrice { get; set; }
        [BindProperty]
        public decimal KDV { get; set; }
        [BindProperty]
        public decimal KDVTotal { get; set; }
        [BindProperty]
        public decimal Transfer { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? flag { get; set; }

        private IUnitofWork unitofWork;
        private IBasketRepository basketRepository;

        public BasketModel(IUnitofWork unitofWork, IBasketRepository basketRepository)
        {
            this.unitofWork = unitofWork;
            this.basketRepository = basketRepository;
            //productViewModel = productRepository.ProductJoin(predicate: x => x.IsDeleted == false);
        }
        public async Task OnGet()
        {
            var userId = unitofWork.GetUserById(User.Identity?.Name);
            //productViewModel = await productRepository.ProductJoinBasketAsync(predicate: x => x.IsDeleted == false && x.Baskets.Any(b => b.UserId == userId));
            basketViewModel = basketRepository.GetBasketJoinProduct(userId:userId);
            TotalPrice += basketViewModel.Sum(x => (x.Product.NewPrice != 0 ? x.Product.NewPrice : x.Product.OldPrice) * x.Total);
            KDV = TotalPrice * 0.2m;
            Transfer = TotalPrice > 2000 ? 0 : 100;
            KDVTotal = TotalPrice + KDV + Transfer;
        }
    }
}
