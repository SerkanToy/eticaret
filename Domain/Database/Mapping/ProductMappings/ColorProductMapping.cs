using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.ProductMappings
{
    public class ColorProductMapping : IEntityTypeConfiguration<ColorProduct>
    {
        public void Configure(EntityTypeBuilder<ColorProduct> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(y => y.ColorProduct).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            builder.HasOne(x => x.Colors).WithMany(y => y.ColorProduct).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            builder.HasData(_productcolors());
        }

        private List<ColorProduct> _productcolors()
        {
            return new List<ColorProduct>
            {
                new ColorProduct { Id = 1, ColorsId = 1, ProductId = 1},                
                new ColorProduct { Id = 2, ColorsId = 2, ProductId = 2},                
                new ColorProduct { Id = 3, ColorsId = 3, ProductId = 3},                
                new ColorProduct { Id = 4, ColorsId = 4, ProductId = 4},                
                new ColorProduct { Id = 5, ColorsId = 5, ProductId = 5},                
                new ColorProduct { Id = 6, ColorsId = 6, ProductId = 6},                
                new ColorProduct { Id = 7, ColorsId = 7, ProductId = 7},                
                new ColorProduct { Id = 8, ColorsId = 8, ProductId = 8},                
                new ColorProduct { Id = 9, ColorsId = 9, ProductId = 9},                
                new ColorProduct { Id = 10, ColorsId = 10, ProductId = 10},                
                new ColorProduct { Id = 11, ColorsId = 11, ProductId = 11},                
                new ColorProduct { Id = 12, ColorsId = 12, ProductId = 12},                
                new ColorProduct { Id = 13, ColorsId = 13, ProductId = 13},                
                new ColorProduct { Id = 14, ColorsId = 14, ProductId = 14},                
                new ColorProduct { Id = 15, ColorsId = 1, ProductId = 15},                
                new ColorProduct { Id = 16, ColorsId = 2, ProductId = 16},                
                new ColorProduct { Id = 17, ColorsId = 3, ProductId = 17},                
                new ColorProduct { Id = 18, ColorsId = 4, ProductId = 18},                
                new ColorProduct { Id = 19, ColorsId = 5, ProductId = 19},                
                new ColorProduct { Id = 20, ColorsId = 6, ProductId = 20},                
                new ColorProduct { Id = 21, ColorsId = 7, ProductId = 21},                
                new ColorProduct { Id = 22, ColorsId = 8, ProductId = 22},                
                new ColorProduct { Id = 23, ColorsId = 9, ProductId = 23},                
                new ColorProduct { Id = 24, ColorsId = 10, ProductId = 24},                
                new ColorProduct { Id = 25, ColorsId = 11, ProductId = 25},                
            };
        }

    }
}
