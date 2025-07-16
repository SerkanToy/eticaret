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
		private UserManager<UserApp> _userManager;
		private SignInManager<UserApp> _signInManager;
		public LoginModel(UserManager<UserApp> _userManager, SignInManager<UserApp> _signInManager)
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
			//ReturnUrl = ReturnUrl ?? Url.Action("Index", "Home", new { area = "" });
			if (ModelState.IsValid)
			{
                UserApp hasUser = await _userManager.FindByEmailAsync(loginViewModel.Email);

				if (hasUser == null)
				{
					ModelState.AddModelError($"{loginViewModel.Email}", "Kullanıcı  Bulunmamaktadır!");
				}
				
				if (!hasUser!.IsLocked && !hasUser.IsDeleted)
				{
					Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user: hasUser, password: loginViewModel.Password, isPersistent: loginViewModel.RememberMe, lockoutOnFailure: true);

					if (result.IsLockedOut)
					{
						ModelState.AddModelError("", "3 Hatalı Giriş'ten Sonra 5 Dakika Süre ile Hesabiniz Kilitlenmiştir. Lütfen 5 Dakika Bekleyin.");
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
							new Claim("EPosta", $"{hasUser.Email.CustomToLower()}")
						};
						await _signInManager.SignInWithClaimsAsync(hasUser, false, claims);
                        var context = new Microsoft.AspNetCore.Http.HttpContextAccessor();
						context.HttpContext.Response.Redirect("/", true);
                        //return RedirectToPage("");
                    }
					else
					{
						ModelState.AddModelError("", "Giriş İşlemi Başarısız.");
                    }
				}
				else
				{
					ModelState.AddModelError($"{loginViewModel.Email}", "Giriş İşlemi Başarısız.");
					ModelState.AddModelError($"{loginViewModel.Password}", "Giriş İşlemi Başarısız.");
                }
			}
		}
	
		public async Task OnGetOutput()
		{
            await _signInManager.SignOutAsync();
            var context = new Microsoft.AspNetCore.Http.HttpContextAccessor();
            context.HttpContext.Response.Redirect("/login", true);
        }
	
	}
}
