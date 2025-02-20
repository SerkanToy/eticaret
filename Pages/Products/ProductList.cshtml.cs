using eticaret.Domain.Core.Entities;
using eticaret.Domain.UnitOfWork;
using eticaret.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace eticaret.Pages.Products
{
    public class ProductListModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Product> productViewModel { get; set; }
        [BindProperty]
        public IEnumerable<dynamic> productExpandoObject { get; set; } = new List<Dynamic>();
        [BindProperty]
        public IEnumerable<Category> categoryViewModel { get; set; }
        [BindProperty]
        public IEnumerable<Ratin> ratinViewModel { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? flag { get; set; }

        private IUnitofWork unitofWork;

        public ProductListModel(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
            categoryViewModel = unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
            ratinViewModel = unitofWork.GetRepository<Ratin>().GetAllIQueryable();
            productViewModel = unitofWork.GetRepository<Product>().GetAllIQueryable(x => x.IsDeleted == false).ToList();
        }

        public void OnGet()
        {            
            if(flag is not null)
            {
                productViewModel = unitofWork.GetRepository<Product>().GetAllIQueryable(x => x.IsDeleted == false && x.CategoryProducts.Any(f => f.Category.Flag == flag)).ToList();
                productExpandoObject = productViewModel.Select(c => new Dynamic
                {
                    ["Name"] = c.Name,
                    ["CategoryProducts"] = c.CategoryProducts,
                    ["Categorys"] = c.CategoryProducts,
                    ["Rating"] = c.RatinProducts
                });
                //.GetAllIQueryable(x => x.IsDeleted == false && x.CategoryProducts.Where(x => x.Category.Flag == flag));
                return;
            }
            productViewModel = unitofWork.GetRepository<Product>().GetAllIQueryable(x => x.IsDeleted == false).ToList();
            productExpandoObject = productViewModel.Select(c => new Dynamic
            {
                ["Name"] = c.Name,
                ["CategoryProducts"] = c.CategoryProducts,
                ["Categorys"] = c.CategoryProducts, // == null ? new Dictionary<string, object>() : c.CategoryProducts,
                ["Rating"] = c.RatinProducts // == null? new Dictionary<string, object>() : c.RatinProducts
            });
        }
    }
}
