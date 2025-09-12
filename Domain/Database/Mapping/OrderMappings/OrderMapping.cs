using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.OrderMappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(y => y.Orders).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.User).WithMany(y => y.Orders).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
        }
    }
}
