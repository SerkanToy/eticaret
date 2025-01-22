using eticaret.Domain;
using eticaret.Domain.Entities.Users;
using eticaret.Models.Login;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace eticaret.Pages.Account
{
    public class LoginModel : PageModel
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public LoginModel(UserManager<User> _userManager, SignInManager<User> _signInManager)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
        }


        [BindProperty]
        public LoginViewModel loginViewModel { get; set; }
        public void OnGet()
        {
        }

        public async Task OnPostLoginData(string? ReturnUrl = null)
        {
            ReturnUrl = ReturnUrl ?? Url.Action("Index", "Home", new { area = "" });
            if (ModelState.IsValid)
            {
                User hasUser = await _userManager.FindByEmailAsync(loginViewModel.Email);

                if (hasUser == null)
                {
                    ModelState.AddModelError("", "Kullan�c�  Bulunmamaktad�r!");
                    ModelState.AddModelError($"{loginViewModel.Email}", "Giri� ��lemi Ba�ar�s�z.");
                }

                if (!hasUser.IsLocked && hasUser.IsDeleted)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user: hasUser, password: loginViewModel.Password, isPersistent: loginViewModel.RememberMe, lockoutOnFailure: true);

                    if (result.IsLockedOut)
                    {
                        ModelState.AddModelError("", "3 Hatal� Giri�'ten Sonra 5 Dakika S�re ile Hesabiniz Kilitlenmi�tir. L�tfen 5 Dakika Bekleyin.");                        
                    }

                    if (result.Succeeded)
                    {
                        await _userManager.ResetAccessFailedCountAsync(hasUser);
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Email, hasUser!.Email!),
                            new Claim("Id", hasUser.Id.ToString()),
                            new Claim("FullName", $"{hasUser.Name.CustomToTitleCase()} {hasUser.SurName.CustomToUpper()}"),
                            new Claim("PhoneNumber", $"{hasUser.PhoneNumber}"),
                            new Claim("Flag", $"{hasUser.Flag}"),
                            new Claim("EPosta", $"{hasUser.Email}")
                        };
                        await _signInManager.SignInWithClaimsAsync(hasUser, false, claims);
                        //return RedirectToAction("Index", "Home", new { area = "" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "Giri� ��lemi Ba�ar�s�z.");
                    }
                }
                else
                {
                    ModelState.AddModelError($"{loginViewModel.Email}", "Giri� ��lemi Ba�ar�s�z.");                 
                    ModelState.AddModelError($"{loginViewModel.Password}", "Giri� ��lemi Ba�ar�s�z.");                 
                }

            }
        }
    }
}
