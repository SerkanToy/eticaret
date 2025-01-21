using Microsoft.AspNetCore.Identity;
using eticaret.Domain.Entities.Users;

namespace eticaret.Domain.ErrorTr
{
    public class CustomRoleValidator : IRoleValidator<Role>
    {
        public async Task<IdentityResult> ValidateAsync(RoleManager<Role> manager, Role role)
        {
            List<IdentityError> errors = new List<IdentityError>();

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
