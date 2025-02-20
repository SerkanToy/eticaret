using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.RatinMappings
{
    public class RatinMapping : IEntityTypeConfiguration<Ratin>
    {
        public void Configure(EntityTypeBuilder<Ratin> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.RatinProducts).WithOne(y => y.Ratin).OnDelete(deleteBehavior:DeleteBehavior.NoAction);
            builder.HasData(_ratin());
        }

        private List<Ratin> _ratin()
        {
            return new List<Ratin>
            {
                new Ratin { Id = 1, Rating = 1 },
                new Ratin { Id = 2, Rating = 2 },
                new Ratin { Id = 3, Rating = 3 },
                new Ratin { Id = 4, Rating = 4 },               
                new Ratin { Id = 5, Rating = 5 }               
            };
        }
    }
}
