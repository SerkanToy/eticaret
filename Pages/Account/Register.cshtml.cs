using eticaret.Domain;
using eticaret.Domain.Entities.Users;
using eticaret.Models;
using eticaret.Models.ViewModel.RegisterDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eticaret.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegisterViewModel registerViewModel { get; set; }
        private UserManager<UserApp> _userManager;
        public RegisterModel(UserManager<UserApp> _userManager)
        {
            this._userManager = _userManager;
        }

        public IActionResult OnGet()
        {
            registerViewModel = new RegisterViewModel();
            return Page();
        }

        public async Task OnPostRegister()
        {
            if (ModelState.IsValid)
            {
                var isUser = await _userManager.FindByEmailAsync(registerViewModel.Email.Trim());
                if(isUser is not null)
                {
                    registerViewModel.Messages = new Message
                    {
                        Succeeded = false,
                        TextMessage = new List<string> { $"({registerViewModel.Name.CustomToTitleCase()} {registerViewModel.SurName.CustomToUpper()}) Kullanıcı Kayıtlı." }
                    };
                    return;
                }

                IdentityResult result = await _userManager.CreateAsync(new UserApp
                {
                    Name = registerViewModel.Name.CustomToLower().Trim(),
                    SurName = registerViewModel.SurName.CustomToLower().Trim(),
                    Email = registerViewModel.Email.Trim(),
                    UserName = $"{registerViewModel.Name.CustomToLower()}{registerViewModel.SurName.CustomToLower()}",
                    Flag = Guid.NewGuid().ToString(),
                    CreateBy = $"{registerViewModel.Name.CustomToLower()}{registerViewModel.SurName.CustomToLower()}",
                    CreateDate = DateTime.Now.ToString()
                }, registerViewModel.Psswrd);

                if (result.Succeeded)
                {
                    registerViewModel.Messages = new Message
                    {
                        Succeeded = true,
                        TextMessage = new List<string> { $"({registerViewModel.Name.CustomToTitleCase()} {registerViewModel.SurName.CustomToUpper()}) Kayıt İşlemi Başarılı." }
                    };
                    return;
                }

                registerViewModel.Messages = new Message
                {
                    Succeeded = false,
                    TextMessage = ModelStateExtensions.AddModelErrorStringList(result.Errors.ToList())
                };
            }

        }
    }
}
