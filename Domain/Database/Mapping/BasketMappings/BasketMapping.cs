using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.BasketMappings
{
    public class BasketMapping : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(y => y.Baskets).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.User).WithMany(y => y.Baskets).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
