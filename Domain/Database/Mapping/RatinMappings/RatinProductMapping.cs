using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.RatinMappings
{
    public class RatinProductMapping : IEntityTypeConfiguration<RatinProduct>
    {
        public void Configure(EntityTypeBuilder<RatinProduct> builder)
        {
            builder.HasKey(x => new { x.Id, x.UserId });
            builder.HasOne(x => x.Product).WithMany(y => y.RatinProducts).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Ratin).WithMany(y => y.RatinProducts).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(_ratin());
        }

        private List<RatinProduct> _ratin()
        {
            return new List<RatinProduct>
            {
                new RatinProduct { Id = 1, ProductId = 1, RatinId = 1, UserId = 1 },
                new RatinProduct { Id = 2, ProductId = 2, RatinId = 2, UserId = 1 },
                new RatinProduct { Id = 3, ProductId = 3, RatinId = 3, UserId = 1 },
                new RatinProduct { Id = 4, ProductId = 4, RatinId = 4, UserId = 1 },
                new RatinProduct { Id = 5, ProductId = 5, RatinId = 5, UserId = 1 }
            };
        }
    }
}
