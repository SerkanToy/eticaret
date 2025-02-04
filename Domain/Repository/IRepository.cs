using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int Id);
        Task<TEntity> GetFindAsync(Expression<Func<TEntity, bool>> predicate = null);
        void Insert(TEntity entity);
        Task<IQueryable<TEntity>> GetAllIQueryableAsync(Expression<Func<TEntity, bool>> predicate = null);
        IQueryable<TEntity> GetAllIQueryable(Expression<Func<TEntity, bool>> predicate = null);
        IQueryable<TEntity> GetTakeIQueryable(Expression<Func<TEntity, bool>> predicate = null, int take = 0);
        Task<IQueryable<TEntity>> GetTakeIQueryableAsync(Expression<Func<TEntity, bool>> predicate = null, int take = 0);
        Task<IEnumerable<TEntity>> Includes(
            Expression<Func<TEntity, bool>> predicate = null,
            int take = 0,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        Task<TEntity> Includes(
            Expression<Func<TEntity, bool>> predicate = null,
            Expression<Func<TEntity, bool>> predicateTrueFalse = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);
        Task<int> SaveAsync();
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteIEnumerable(IEnumerable<TEntity> entity);

    }
}
