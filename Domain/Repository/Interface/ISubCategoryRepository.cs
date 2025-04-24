using Microsoft.AspNetCore.Mvc.Rendering;
using eticaret.Domain.Core.Entities;

namespace eticaret.Domain.Repository.Interface
{
    public interface ISubCategoryRepository : IRepository<SubCategory>
    {
        SelectList SubCategorySelect(int[] CategoryId = null);

    }
}
