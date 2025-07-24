using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Basket
{
    [Authorize]
    public class BasketModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
