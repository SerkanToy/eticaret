using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using eticaret.Domain.Entities.Users;

namespace eticaret.Domain.ErrorTr
{
    public class CustomUserValidator : IUserValidator<User>
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user)
        {
            List<IdentityError> errors = new List<IdentityError>();
            var con = await manager.Users.FirstOrDefaultAsync(x =>
                                (x.Name == user.Name && x.SurName == user.SurName)
                                || (x.Email == user.Email));

            /*if (con != null)
            {
                if (user.Email.Split("@")[1] != "sakarya.edu.tr")
                {
                    errors.Add(new IdentityError() { Code = "Email", Description = $"{user.Email} sakarya.edu.tr Kurumsal Posta Adresinizi Kullanın." });
                }
            }*/

            if (con != null)
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
