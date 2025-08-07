using eticaret.Domain.Core.Entities;
using eticaret.Domain.Repository.Interface;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using basket = eticaret.Domain.Core.Entities;

namespace eticaret.Pages.Basket
{
    [Authorize]
    public class BasketModel : PageModel
    {
        [BindProperty]
        public IEnumerable<basket.Basket> basketViewModel { get; set; }
        
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
        }
    }
}
