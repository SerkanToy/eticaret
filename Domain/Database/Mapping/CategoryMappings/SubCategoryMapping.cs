using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.CategoryMappings
{
    public class SubCategoryMapping : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Products).WithOne(y => y.SubCategory).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Categorys).WithMany(y => y.SubCategorys).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(_categories());
        }

        private List<SubCategory> _categories()
        {
            return new List<SubCategory>
            {
                new SubCategory { Id = 1, Name = "Çanta", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = 1 },
                new SubCategory { Id = 2, Name = "Halı", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = 2 },
                new SubCategory { Id = 3, Name = "Aksesuar", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = 3 },
                new SubCategory { Id = 4, Name = "SubCategory 1", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = 4 },
                new SubCategory { Id = 5, Name = "SubCategory 2", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = 5 },
                new SubCategory { Id = 6, Name = "SubCategory 3", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = 6 }
            };
        }

    }
}
