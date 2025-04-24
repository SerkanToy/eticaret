using eticaret.Domain.Repository;
using eticaret.Domain.Repository.Interface;
using eticaret.Domain.Repository.Repositorys;
using eticaret.Domain.UnitOfWork;
using eticaret.Models.MailMessageSend;

namespace eticaret.Domain.Extensions
{
    public static class AddCustumTransient
    {
        public static void TransientAdd(this IServiceCollection services)
        {
            services.AddTransient(typeof(IUnitofWork), typeof(UnitofWork));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IProductRepository), typeof(ProductRepository));
            services.AddTransient(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddTransient(typeof(IEmailServis), typeof(EmailServis));
        }
    }
}
