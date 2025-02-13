using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace eticaret.Domain.Repository.Repositorys
{
    public class CategoryRepository: Repository<Category> , ICatetgoryRepository
    {
        public CategoryRepository(CommerceContext context) : base(context)
        {
        }

        public List<Category> CategoryJoin(string flag, bool isDelete = false)
        {
            return context.Category.Where(x => x.IsDeleted == isDelete && x.Flag == flag).Include(j => j.CategoryProducts).ThenInclude(g => g.Product).ToList();
        }

        public SelectList CategorySelect(int[] CategoryId = null)
        {
            return new SelectList(context.Category.Where(x => x.IsDeleted == false).OrderBy(x => x.Name), "Id", "Name", CategoryId);
        }

    }
}
