using eticaret.Domain.Core.Entities;
using eticaret.Domain.Repository.Interface;
using eticaret.Domain.UnitOfWork;
using eticaret.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace eticaret.Pages.Products
{
    public class ProductListModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Product> productViewModel { get; set; }
        [BindProperty]
        public IEnumerable<dynamic> productExpandoObject { get; set; } = new List<Dynamic>();
        [BindProperty]
        public IEnumerable<SubCategory> categoryViewModel { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? flag { get; set; }

        private IUnitofWork unitofWork;
        private IProductRepository productRepository;

        public ProductListModel(IUnitofWork unitofWork, IProductRepository productRepository)
        {
            this.unitofWork = unitofWork;
            this.productRepository = productRepository;
        }

        public async Task OnGet()
        {
            categoryViewModel = unitofWork.GetRepository<SubCategory>().GetAllIQueryable(x => x.IsDeleted == false); // unitofWork.Catetgory().CategorySubCategory(); //unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
            productViewModel = productRepository.ProductJoin(predicate: x => x.IsDeleted == false);
            productExpandoObject = productViewModel.Select(c => new Dynamic
            {
                ["Name"] = c.Name,
                ["SubCategory"] = c.SubCategory,
                ["Images"] = c.Images.Where(b => b.IsShowcase == true).Count() > 0 ? c.Images.Where(b => b.IsShowcase == true) : null,
                ["Description"] = c.Description,
                ["Rating"] = c.RatinProducts.Select(v => new Dynamic { ["ratin"] = Convert.ToInt32(v.Ratin.Rating) }),
                ["RatinMax"] = c.RatinMax,
                ["Category"] = c.Category,
                ["NewPrice"] = Convert.ToDecimal(c.NewPrice),
                ["OldPrice"] = Convert.ToDecimal(c.OldPrice)
            }).ToList();
        }

        public async Task OnGetCategory(string flag = null)
        {
            categoryViewModel = unitofWork.GetRepository<SubCategory>().GetAllIQueryable(x => x.IsDeleted == false); // unitofWork.Catetgory().CategorySubCategory(); //unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
            productViewModel = productRepository.ProductJoin(predicate: x => x.IsDeleted == false).Where(x => x.SubCategory.Category?.Flag == flag);
            productExpandoObject = productViewModel.Select(c => new Dynamic
            {
                ["Name"] = c.Name,
                ["SubCategory"] = c.SubCategory,
                ["Images"] = c.Images.Where(b => b.IsShowcase == true).Count() > 0 ? c.Images.Where(b => b.IsShowcase == true) : null,
                ["Description"] = c.Description,
                ["Rating"] = c.RatinProducts.Select(v => new Dynamic { ["ratin"] = Convert.ToInt32(v.Ratin.Rating) }),
                ["RatinMax"] = c.RatinMax,
                ["Category"] = c.Category,
                ["NewPrice"] = Convert.ToDecimal(c.NewPrice),
                ["OldPrice"] = Convert.ToDecimal(c.OldPrice)

            }).ToList();
        }

        public async Task OnGetSubCategory(string flag = null)
        {
            categoryViewModel = unitofWork.GetRepository<SubCategory>().GetAllIQueryable(x => x.IsDeleted == false); // unitofWork.Catetgory().CategorySubCategory(); //unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
            productViewModel = productRepository.ProductJoin(predicate: x => x.IsDeleted == false);
            productExpandoObject = productViewModel.Where(f => f.SubCategory.Flag == flag).Select(c => new Dynamic
            {
                ["Name"] = c.Name,
                ["SubCategory"] = c.SubCategory,
                ["Images"] = c.Images.Where(b => b.IsShowcase == true).Count() > 0 ? c.Images.Where(b => b.IsShowcase == true) : null,
                ["Description"] = c.Description,
                ["Rating"] = c.RatinProducts.Select(v => new Dynamic { ["ratin"] = Convert.ToInt32(v.Ratin.Rating) }),
                ["RatinMax"] = c.RatinMax,
                ["Category"] = c.Category,
                ["NewPrice"] = Convert.ToDecimal(c.NewPrice),
                ["OldPrice"] = Convert.ToDecimal(c.OldPrice)

            }).ToList();
        }

        public async Task OnGetPoint(string flag = null)
        {
            categoryViewModel = unitofWork.GetRepository<SubCategory>().GetAllIQueryable(x => x.IsDeleted == false); // unitofWork.Catetgory().CategorySubCategory(); //unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
            productViewModel = productRepository.ProductJoin(predicate: x => x.IsDeleted == false);
            productExpandoObject = productViewModel.Where(f => f.SubCategory.Flag == flag).Select(c => new Dynamic
            {
                ["Name"] = c.Name,
                ["SubCategory"] = c.SubCategory,
                ["Images"] = c.Images.Where(b => b.IsShowcase == true).Count() > 0 ? c.Images.Where(b => b.IsShowcase == true) : null,
                ["Description"] = c.Description,
                ["Rating"] = c.RatinProducts.Select(v => new Dynamic { ["ratin"] = Convert.ToInt32(v.Ratin.Rating) }),
                ["RatinMax"] = c.RatinMax,
                ["Category"] = c.Category,
                ["NewPrice"] = Convert.ToDecimal(c.NewPrice),
                ["OldPrice"] = Convert.ToDecimal(c.OldPrice)

            }).ToList();
        }

        public async Task OnGetColor(string flag = null)
        {
            categoryViewModel = unitofWork.GetRepository<SubCategory>().GetAllIQueryable(x => x.IsDeleted == false); // unitofWork.Catetgory().CategorySubCategory(); //unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
            productViewModel = productRepository.ProductJoin(predicate: x => x.IsDeleted == false);
            productExpandoObject = productViewModel.Where(f => f.SubCategory.Flag == flag).Select(c => new Dynamic
            {
                ["Name"] = c.Name,
                ["SubCategory"] = c.SubCategory,
                ["Images"] = c.Images.Where(b => b.IsShowcase == true).Count() > 0 ? c.Images.Where(b => b.IsShowcase == true) : null,
                ["Description"] = c.Description,
                ["Rating"] = c.RatinProducts.Select(v => new Dynamic { ["ratin"] = Convert.ToInt32(v.Ratin.Rating) }),
                ["RatinMax"] = c.RatinMax,
                ["Category"] = c.Category,
                ["NewPrice"] = Convert.ToDecimal(c.NewPrice),
                ["OldPrice"] = Convert.ToDecimal(c.OldPrice)

            }).ToList();
        }
    }
}
