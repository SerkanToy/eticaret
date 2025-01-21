using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace eticaret.Domain.Extensions
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
    }
}
