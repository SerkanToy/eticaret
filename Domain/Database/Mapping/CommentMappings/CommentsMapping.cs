using eticaret.Domain.Core.Entities;
using eticaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Context.Mapping.CommentsMappings
{
    public class CommentsMapping : IEntityTypeConfiguration<Comments>
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.BlogInfoAndComment)
                   .WithOne(x => x.Comment)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Reply)
                   .WithMany(x => x.Replys)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Replys)
                   .WithOne(x => x.Reply)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
