using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository;

namespace eticaret.Domain.UnitOfWork
{
    public class UnitofWork : IUnitofWork
    {
        private bool disposed = false;
        protected CommerceContext context;
        public UnitofWork(CommerceContext context)
        {
            this.context = context;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, new()
        {
            return new Repository<TEntity>(context);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
