using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.ProductMappings
{
    public class CategoryProductMapping : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.HasOne(x => x.Product).WithMany(m => m.CategoryProducts).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Category).WithMany(m => m.CategoryProducts).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(_categoryproduct());
        }

        private List<CategoryProduct> _categoryproduct()
        {
            return new List<CategoryProduct>
            {
                new CategoryProduct { ProductId = 1, CategoryId = 1},
                new CategoryProduct { ProductId = 2, CategoryId = 1},
                new CategoryProduct { ProductId = 3, CategoryId = 1},
                new CategoryProduct { ProductId = 4, CategoryId = 1},
                new CategoryProduct { ProductId = 5, CategoryId = 1},
                new CategoryProduct { ProductId = 1, CategoryId = 2},
                new CategoryProduct { ProductId = 2, CategoryId = 2},
                new CategoryProduct { ProductId = 3, CategoryId = 2},
                new CategoryProduct { ProductId = 4, CategoryId = 2},
                new CategoryProduct { ProductId = 5, CategoryId = 2},
                new CategoryProduct { ProductId = 6, CategoryId = 2},
                new CategoryProduct { ProductId = 7, CategoryId = 3},
                new CategoryProduct { ProductId = 8, CategoryId = 3},
                new CategoryProduct { ProductId = 9, CategoryId = 3},
                new CategoryProduct { ProductId = 10, CategoryId = 4},
                new CategoryProduct { ProductId = 11, CategoryId = 4},
                new CategoryProduct { ProductId = 12, CategoryId = 4},
                new CategoryProduct { ProductId = 13, CategoryId = 4},
                new CategoryProduct { ProductId = 14, CategoryId = 5},
                new CategoryProduct { ProductId = 15, CategoryId = 5},
                new CategoryProduct { ProductId = 17, CategoryId = 6},
                new CategoryProduct { ProductId = 18, CategoryId = 6},
                new CategoryProduct { ProductId = 19, CategoryId = 6},
                new CategoryProduct { ProductId = 20, CategoryId = 5},
                new CategoryProduct { ProductId = 21, CategoryId = 6},
                new CategoryProduct { ProductId = 21, CategoryId = 5},
                new CategoryProduct { ProductId = 22, CategoryId = 5},
                new CategoryProduct { ProductId = 22, CategoryId = 6},
                new CategoryProduct { ProductId = 23, CategoryId = 6},
                new CategoryProduct { ProductId = 23, CategoryId = 5},
                new CategoryProduct { ProductId = 24, CategoryId = 5},
                new CategoryProduct { ProductId = 24, CategoryId = 6},
                new CategoryProduct { ProductId = 25, CategoryId = 6}
            };
        }

    }
}
