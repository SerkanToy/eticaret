using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.CategoryMappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.CategoryProducts).WithOne(y => y.Category).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(_categories());
        }

        private List<Category> _categories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Category 1", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = 2, Name = "Category 2", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = 3, Name = "Category 3", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = 4, Name = "Category 4", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = 5, Name = "Category 5", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = 6, Name = "Category 6", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false }
            };
        }

    }
}
