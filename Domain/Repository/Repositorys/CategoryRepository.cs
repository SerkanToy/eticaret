using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Repositorys
{
    public class CategoryRepository: Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(CommerceContext context) : base(context)
        {
        }

        public List<Category> CategoryJoin(Expression<Func<Category, bool>> predicate = null, bool isDelete = false)
        {
            if(predicate != null)
            {
                return context.Category.Where(predicate).Include(j => j.CategoryProducts.Where(g => g.Product.IsDeleted == isDelete)).ThenInclude(g => g.Product).ToList();
            }
            return context.Category.Include(j => j.CategoryProducts).ThenInclude(g => g.Product).ToList();
        }

        public List<Category> CategoryJoin(string flag, bool isDelete = false)
        {
            return context.Category.Where(x => x.IsDeleted == isDelete && x.Flag == flag).Include(j => j.SubCategorys).ThenInclude(g => g.Products).ToList();
        }

        public List<Category> CategorySubCategory(bool isDelete = false)
        {
            return context.Category.Where(x => x.IsDeleted == isDelete).Include("SubCategorys").ToList();
        }

        public SelectList CategorySelect(int[] CategoryId = null)
        {
            return new SelectList(context.Category.Where(x => x.IsDeleted == false).OrderBy(x => x.Name), "Id", "Name", CategoryId);
        }

    }
}
