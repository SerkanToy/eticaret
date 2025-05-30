using eticaret.Domain.Core.Entities;
using eticaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Context.Mapping.BlogInfoAndCommentMappings
{
    public class BlogInfoAndCommentMapping : IEntityTypeConfiguration<BlogInfoAndComment>
    {
        public void Configure(EntityTypeBuilder<BlogInfoAndComment> builder)
        {
            builder.HasKey(x => new { x.BlogInfoId, x.CommentId });
            builder.HasOne(x => x.BlogInfo).WithMany(x => x.BlogInfoAndComment).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Comment).WithMany(x => x.BlogInfoAndComment).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.User).WithMany(x => x.BlogInfoAndComment).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
