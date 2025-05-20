using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Contact
{
    public class ContactModel : PageModel
    {
        [ActionName(name: "contact")]
        public void OnGet()
        {
        }
    }
}
