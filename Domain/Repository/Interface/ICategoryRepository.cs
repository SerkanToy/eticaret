using eticaret.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Interface
{
    public interface ICategoryRepository: IRepository<Category>
    {
        List<Category> CategoryJoin(Expression<Func<Category, bool>> predicate = null, bool isDelete = false);
        List<Category> CategoryJoin(string flag, bool isDelete = false);
        List<Category> CategorySubCategory(bool isDelete = false);
        SelectList CategorySelect(int[] CategoryId = null);

    }
}
