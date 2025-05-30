using eticaret.Domain.Core.Entities;
using eticaret.Domain.Repository.Interface;
using eticaret.Domain.UnitOfWork;
using eticaret.Models.ViewModel.ProductDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Blog
{
    public class BlogModel : PageModel
    {
        private IUnitofWork unitofWork;
        [BindProperty]
        public IEnumerable<BlogInfo> blogInfoViewModel { get; set; }
        public BlogModel(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public void OnGet()
        {
            blogInfoViewModel = unitofWork.GetRepository<BlogInfo>().GetAllIQueryable(x => x.IsDeleted == false).OrderByDescending(o => o.CreateDate).ToList();
        }
    }
}
