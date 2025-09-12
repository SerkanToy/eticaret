using eticaret.Domain.Database.Context;
using eticaret.Domain.Entities.Users;
using eticaret.Domain.Repository;
using eticaret.Domain.Repository.Interface;
using eticaret.Domain.Repository.Repositorys;

namespace eticaret.Domain.UnitOfWork
{
    public class UnitofWork : IUnitofWork
    {
        private bool disposed = false;
        protected CommerceContext context;
        private ICategoryRepository catetgoryRepository;
        private IProductRepository productRepository;
        private IFavoritesRepository favoritesRepository;
        public UnitofWork(CommerceContext context, 
            ICategoryRepository catetgoryRepository = null,
            IProductRepository productRepository = null,
            IFavoritesRepository favoritesRepository = null)
        {
            this.context = context;
            this.catetgoryRepository = catetgoryRepository;
            this.productRepository = productRepository;
            this.favoritesRepository = favoritesRepository;
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

        public int GetUserById(string username)
        {
            var user = context.UserApp.FirstOrDefault(x => x.UserName == username);
            return user.Id;
        }

        public UserApp GetUserBy(string username)
        {
            var user = context.UserApp.FirstOrDefault(x => x.UserName == username);
            return user;
        }

        public ICategoryRepository Catetgory()
        {
            return catetgoryRepository ??= new CategoryRepository(context);
        }

        public IProductRepository Product()
        {
            return productRepository ??= new ProductRepository(context);
        }

        public IFavoritesRepository Favorite()
        {
            return favoritesRepository ??= new FavoritesRepository(context);
        }
    }
}
