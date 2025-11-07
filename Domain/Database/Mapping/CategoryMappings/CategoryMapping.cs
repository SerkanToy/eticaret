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
            builder.HasMany(x => x.SubCategorys).WithOne(y => y.Category).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(_categories());
        }

        private List<Category> _categories()
        {
            return new List<Category>
            {
                new Category { Id = "2FC12E63-4E2C-451B-92D3-076ECF63B722", Name = "Category 1", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = "8CDE771D-1EFF-4CC6-A7C1-3CB86D19743B", Name = "Category 2", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = "64105586-51F5-4800-AC47-A25D96A38D2A", Name = "Category 3", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = "467DFE4A-40D0-455D-875A-758A776D49C9", Name = "Category 4", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = "ADB4AC66-F8B7-4316-89CB-F638E723498D", Name = "Category 5", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Category { Id = "A7DA7883-9C55-424B-ACC6-8A1DE6C14881", Name = "Category 6", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false }
            };
        }

    }
}
