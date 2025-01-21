using eticaret.Domain.Repository;
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
            services.AddTransient(typeof(IEmailServis), typeof(EmailServis));
        }
    }
}
