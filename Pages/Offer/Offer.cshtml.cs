using eticaret.Domain.Core.Entities;
using eticaret.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Offer
{
    public class OfferModel : PageModel
    {
        private IProductRepository productRepository;

        public OfferModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [BindProperty]
        public IEnumerable<Product> productViewModel { get; set; }

        public void OnGet()
        { 
             productViewModel = productRepository.ProductJoin(predicate: x => x.IsDeleted == false && x.NewPrice != 0).OrderByDescending(x => x.CreateDate).ToList();
        }
    }
}
