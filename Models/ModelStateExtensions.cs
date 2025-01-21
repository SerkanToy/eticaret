using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace eticaret.Models
{
    public static class ModelStateExtensions
    {
        public static void AddModelErrorList(this ModelStateDictionary modelState, List<string> error)
        {
            error.ForEach(x =>
            {
                modelState.AddModelError(string.Empty, x);
            });
        }

        public static List<string> AddModelErrorStringList(List<IdentityError> error)
        {
            var errors = new List<string>();
            foreach (var item in error)
            {
                errors.Add(item.Description);
            }
            return errors;
        }

    }
}
