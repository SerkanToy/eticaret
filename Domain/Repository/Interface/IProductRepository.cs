using eticaret.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> ProductJoin(Expression<Func<Product, bool>> predicate = null);
        List<Product> ProductJoinTake(Expression<Func<Product, bool>> predicate = null);
        List<Product> ProductJoinCategory(Expression<Func<Product, bool>> predicate = null);
        List<Product> ProductJoinSubCategory(Expression<Func<Product, bool>> predicate = null);
        SelectList ProductSelect(int[] ProductId = null);

    }
}
