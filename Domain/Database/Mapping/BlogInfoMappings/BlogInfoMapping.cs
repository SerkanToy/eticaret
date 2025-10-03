using eticaret.Domain.Core.Entities;
using eticaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Context.Mapping.BlogInfoMappings
{
    public class BlogInfoMapping : IEntityTypeConfiguration<BlogInfo>
    {
        public void Configure(EntityTypeBuilder<BlogInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.BlogInfoAndComment).WithOne(x => x.BlogInfo).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.User).WithMany(x => x.BlogInfos).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
