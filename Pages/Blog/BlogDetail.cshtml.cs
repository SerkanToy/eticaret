using eticaret.Domain.Core.Entities;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Blog
{
    public class BlogDetailModel : PageModel
    {
        private IUnitofWork unitofWork;
        [BindProperty]
        public BlogInfo blogDetailViewModel { get; set; }
        [BindProperty]
        public IEnumerable<BlogInfo> blogViewModel { get; set; }
        [BindProperty]
        public int count { get; set; }
        [BindProperty]
        public int back { get; set; }
        [BindProperty]
        public int next { get; set; }
        public BlogDetailModel(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public void OnGet(int id = 0)
        {
            blogDetailViewModel = unitofWork.GetRepository<BlogInfo>().GetAllIQueryable(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
            blogViewModel = unitofWork.GetRepository<BlogInfo>().GetAllIQueryable(x => x.IsDeleted == false)
                .OrderBy(o => o.CreateDate).Where(x => x.Id != id)
                .Take(4);
            if (blogDetailViewModel == null)
            {
                blogDetailViewModel = new BlogInfo();
            }
            count = unitofWork.GetRepository<BlogInfo>().GetAllIQueryable(x => x.IsDeleted == false).Count();
        }
    }
}
