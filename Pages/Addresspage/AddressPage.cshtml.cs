using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Addresspage
{
    [Authorize]
    public class AddressPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
