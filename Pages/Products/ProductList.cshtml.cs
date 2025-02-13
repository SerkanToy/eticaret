using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using eticaret.Domain.Core.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using System.Collections.Immutable;
using System.Collections.Generic;
using eticaret.Models;
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
        [BindProperty(SupportsGet = true)]
        public string? flag { get; set; }

        private IUnitofWork unitofWork;

        public ProductListModel(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        public void OnGet()
        {
            var veri = unitofWork.GetRepository<Product>().GetAllIQueryable(x => x.IsDeleted == false).ToList();

            productExpandoObject = veri.Select(c => new Dynamic
                                    {
                                        ["Name"] = c.Name
                                    });

            /*productViewModel = (List<Domain.Core.Entities.Product>)unitofWork.GetRepository<eticaret.Domain.Core.Entities.Product>()
            .GetAllIQueryable(f => f.IsDeleted == false).Select(z => new eticaret.Domain.Core.Entities.Product { 
                Name = z.Name,
                Flag = z.Flag
            });
            if(flag is not null)
            {
                var id = unitofWork.GetRepository<Category>().GetFindAsync(x => x.Flag == flag).Result.Id;
                productViewModel = unitofWork.GetRepository<Product>().Includes(predicate:y => y.IsDeleted == false,includes: x => x.Include(c => c.CategoryProducts.Where(f => f.CategoryId == id)),orderBy: );//.GetAllIQueryable(x => x.IsDeleted == false && x.CategoryProducts.Where(x => x.Category.Flag == flag));
                return;
            }
            productViewModel = unitofWork.GetRepository<Product>().GetAllIQueryable(x => x.IsDeleted == false);*/
            categoryViewModel = unitofWork.GetRepository<Category>().GetAllIQueryable(x => x.IsDeleted == false);
        }
    }
}
