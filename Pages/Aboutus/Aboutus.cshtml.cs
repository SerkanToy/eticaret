using eticaret.Domain.Core.Entities;
using eticaret.Domain.Entities;
using eticaret.Domain.Entities.Users;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Aboutus
{
    public class AboutusModel : PageModel
    {
        [BindProperty]
        public About aboutusViewModel { get; set; }
        [BindProperty]
        public int userCount { get; set; } = 0;
        [BindProperty]
        public int productCount { get; set; } = 0;


        private IUnitofWork unitofWork;
        public AboutusModel(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
            aboutusViewModel = unitofWork.GetRepository<About>().GetAllIQueryable(x => x.IsDeleted == false).FirstOrDefault();
            productCount = unitofWork.GetRepository<Product>().GetAllIQueryable(x => x.IsDeleted == false).Count();
            userCount = unitofWork.GetRepository<UserApp>().GetAllIQueryable(x => x.IsDeleted == false).Count();
        }

        public async Task OnGet()
        {            
            if (aboutusViewModel == null)
            {
                aboutusViewModel = new About();
            }
        }
    }
}
