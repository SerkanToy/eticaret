using eticaret.Domain.Entities;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Payment
{
    [Authorize]
    public class PaymentModel : PageModel
    {
        private IUnitofWork unitofWork;
        [BindProperty]
        public List<Address> addressViewModel { get; set; }

        public PaymentModel(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public void OnGet()
        {
            var user = unitofWork.GetUserBy(User.Identity?.Name);
            addressViewModel = unitofWork.GetRepository<Address>().GetAllIQueryableAsync(predicate: (x => x.UserId == user.Id && !x.IsDeleted == true)).Result.ToList() ?? new List<Address>();
        }
    }
}
