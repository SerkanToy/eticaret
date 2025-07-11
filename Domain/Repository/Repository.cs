using eticaret.Domain.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected CommerceContext context;
        private DbSet<TEntity> _dbSet;
        
        public Repository(CommerceContext context)
        {
            this.context = context;
            _dbSet = context.Set<TEntity>();

        }

        public async Task<TEntity> Includes(Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, bool>> predicateTrueFalse = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null)
        {
            return includes(await this.GetAllIQueryableAsync(predicateTrueFalse)).FirstOrDefault(predicate);

        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Entry(entity).State = EntityState.Modified;
        }

        public async Task<IEnumerable<TEntity>> Includes(Expression<Func<TEntity, bool>> predicate = null, int take = 0, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            if (orderBy != null)
            {
                return includes(orderBy(await this.GetAllIQueryableAsync(predicate))).Take(take);
            }
            else
            {
                return includes(await this.GetAllIQueryableAsync(predicate)).Take(take);
            }
        }

        public async Task<TEntity> GetFindAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public TEntity GetFindEmail(Expression<Func<TEntity, bool>> predicate = null)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public async Task<TEntity> GetByIdAsync(int Id)
        {
            return await _dbSet.FindAsync(Id);
        }


        public async Task<IQueryable<TEntity>> GetAllIQueryableAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate == null)
            {
                var veri = await _dbSet.ToListAsync();
                return veri.AsQueryable();
            }
            else
            {
                var veri = await _dbSet.Where(predicate).ToListAsync();
                return veri.AsQueryable();
            }
        }

        public async Task<IQueryable<TEntity>> GetTakeIQueryableAsync(Expression<Func<TEntity, bool>> predicate = null, int take = 0)
        {
            if (predicate == null)
            {
                var veri = await _dbSet.ToListAsync();
                return veri.AsQueryable();
            }
            else
            {
                var veri = await _dbSet.Where(predicate).ToListAsync();
                return veri.Take(take).AsQueryable();
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using (var con = context)
            {
                return await con.Set<TEntity>().ToListAsync();
            }
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public void DeleteIEnumerable(IEnumerable<TEntity> entity)
        {
            context.Set<TEntity>().RemoveRange(entity);
        }

        public IQueryable<TEntity> GetAllIQueryable(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate == null)
            {
                var veri = _dbSet.ToList();
                return veri.AsQueryable();
            }
            else
            {
                var veri = _dbSet.Where(predicate).ToList();
                return veri.AsQueryable();
            }
        }

        public IQueryable<TEntity> GetTakeIQueryable(Expression<Func<TEntity, bool>> predicate = null, int take = 0)
        {
            if (predicate == null)
            {
                var veri = _dbSet.ToList();
                return veri.AsQueryable();
            }
            else
            {
                var veri = _dbSet.Where(predicate).ToList();
                return veri.Take(take).AsQueryable();
            }
        }

        public int TEntityMax(Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, int>> predicateMax = null)
        {
            if (predicate == null)
            {
                var veri = _dbSet.Where(predicate).Max(predicateMax);
                return veri;
            }
            else
            {
                var veri = _dbSet.Where(predicate).Max(predicateMax);
                return veri;
            }
        }
    }
}
