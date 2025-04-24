using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eticaret.Domain.Repository.Repositorys
{
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(CommerceContext context) : base(context)
        {
        }

        public SelectList SubCategorySelect(int[] SubCategoryId = null)
        {
            return new SelectList(context.SubCategory.Where(x => x.IsDeleted == false).OrderBy(x => x.Name), "Id", "Name", SubCategoryId);
        }
    }
}
