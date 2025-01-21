using Microsoft.AspNetCore.Identity;
using eticaret.Domain.Entities.Users;

namespace eticaret.Domain.ErrorTr
{
    public class CustomPasswordValidator : IPasswordValidator<User>
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            List<IdentityError> errors = new List<IdentityError>();

            /*if (password.Contains("123") || password.Contains("1234") || password.Contains("12345") || password.Contains("123456") || password.Contains("1234567"))
            {
                errors.Add(new IdentityError { Code = "PasswordHash", Description = $"Şifre Ardışık Sayı ve Tekrar Eden Sayılar İçeremez." });
            }

            if (password.CustomToLower().Contains($"{user.Name.CustomToLower()}") || password.CustomToLower().Contains($"{user.SurName.CustomToLower()}"))
            {
                errors.Add(new IdentityError { Code = "PasswordHash", Description = "Kişisel Bilgileriniz Şifre Olarak Kullanılamaz. (Araç Plakası, İsim, Soyisim, Email, Doğum Tarihi)" });
            }*/

            if (errors.Count == 0)
            {
                return await Task.FromResult(IdentityResult.Success);
            }
            else
            {
                return await Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
        }

    }
}
