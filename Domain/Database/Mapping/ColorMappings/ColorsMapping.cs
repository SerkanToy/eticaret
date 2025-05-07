using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Mapping.ColorMappings;
using eticaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace eticaret.Domain.Database.Context.Mapping.AboutMappings
{
    public class ColorsMapping : IEntityTypeConfiguration<Colors>
    {
        public void Configure(EntityTypeBuilder<Colors> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(ColorValues.GetColorValues());
        }
    }
}
