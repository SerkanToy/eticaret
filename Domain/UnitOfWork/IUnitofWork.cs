using eticaret.Domain.Repository;

namespace eticaret.Domain.UnitOfWork
{
    public interface IUnitofWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, new();
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
