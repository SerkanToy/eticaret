using eticaret.Domain.Core.Entities;
using eticaret.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Products
{
    public class ProductDetailModel : PageModel
    {
        private IProductRepository productRepository;
        public ProductDetailModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [BindProperty]
        public Product productViewModel { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? flag { get; set; }
        [ActionName(name: "productdetail")]
        public void OnGet(string? flag = null)
        {
            productViewModel = productRepository.ProductByFlag(predicate: x => x.IsDeleted == false && x.Flag == flag);            
        }
    }
}
