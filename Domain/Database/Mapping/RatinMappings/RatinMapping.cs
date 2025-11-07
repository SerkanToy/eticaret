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
                new Ratin { Id = "22A85231-588D-42A0-A959-5F761396EDBE", Rating = 1 },
                new Ratin { Id = "1D7E99B3-7CD3-4819-BDDC-7C1C82CC4BED", Rating = 2 },
                new Ratin { Id = "C49DCFAB-1E84-4D02-A033-5EA063DD1909", Rating = 3 },
                new Ratin { Id = "44EBDD14-56BD-4689-AB3A-91EB6A521248", Rating = 4 },               
                new Ratin { Id = "FDBAC08B-35C8-4072-97ED-35ECAC1F4910", Rating = 5 }               
            };
        }
    }
}
