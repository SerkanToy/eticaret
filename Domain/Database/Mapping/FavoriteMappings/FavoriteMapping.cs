using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.FavoriteMappings
{
    public class FavoriteMapping : IEntityTypeConfiguration<Favorites>
    {
        public void Configure(EntityTypeBuilder<Favorites> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(y => y.Favorites).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.User).WithMany(y => y.Favorites).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
