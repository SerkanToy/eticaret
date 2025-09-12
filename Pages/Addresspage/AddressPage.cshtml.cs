using eticaret.Domain.Entities;
using eticaret.Domain.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Addresspage
{
    [Authorize]
    public class AddressPageModel : PageModel
    {
        private IUnitofWork unitofWork;
        [BindProperty]
        public List<Address> addressViewModel { get; set; }
        [BindProperty]
        public Address addressAddViewModel { get; set; }
        public AddressPageModel(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public void OnGet()
        {
            var user = unitofWork.GetUserBy(User.Identity?.Name);
            addressViewModel = unitofWork.GetRepository<Address>().GetAllIQueryableAsync(predicate: (x => x.UserId == user.Id && !x.IsDeleted == true)).Result.ToList() ?? new List<Address>();
        }

        public IActionResult OnPostAddAddress()
        {
            var user = unitofWork.GetUserBy(User.Identity?.Name);
            if (!ModelState.IsValid)
            {
                addressViewModel = unitofWork.GetRepository<Address>().GetAllIQueryableAsync(predicate: (x => x.UserId == user.Id && !x.IsDeleted == true)).Result.ToList() ?? new List<Address>();
                return Page();
            }
            unitofWork.GetRepository<Address>().Insert(new Address
            {
                Title = addressAddViewModel.Title,
                Name = addressAddViewModel.Name,
                UserId = user.Id,
                CreateBy = user.UserName,
                CreateDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"),
                IsDeleted = false,
                Flag = Guid.NewGuid().ToString()
            });
            unitofWork.SaveChanges();
            addressViewModel = unitofWork.GetRepository<Address>().GetAllIQueryableAsync(predicate: (x => x.UserId == user.Id && !x.IsDeleted == true)).Result.ToList() ?? new List<Address>();
            return Page();
        }
    }
}
