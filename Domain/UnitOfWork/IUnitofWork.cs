using eticaret.Domain.Repository;
using eticaret.Domain.Repository.Interface;

namespace eticaret.Domain.UnitOfWork
{
    public interface IUnitofWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, new();
        ICategoryRepository Catetgory();
        IProductRepository Product();
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
