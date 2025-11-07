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
            builder.HasOne(x => x.Category).WithMany(y => y.SubCategorys).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(_categories());
        }

        private List<SubCategory> _categories()
        {
            return new List<SubCategory>
            {
                new SubCategory { Id = "7FC9EA1E-D197-4491-8875-A897A9C9B261", Name = "Çanta", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = "2FC12E63-4E2C-451B-92D3-076ECF63B722" },
                new SubCategory { Id = "444949DB-680E-4903-9557-E3D83F38B582", Name = "Halı", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = "8CDE771D-1EFF-4CC6-A7C1-3CB86D19743B" },
                new SubCategory { Id = "4A83D6EA-E13B-4EB2-9982-C9E35B6BDCCC", Name = "Aksesuar", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = "64105586-51F5-4800-AC47-A25D96A38D2A" },
                new SubCategory { Id = "06795889-6183-4DC6-B1CA-7F49C8DD4E28", Name = "Spor", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = "467DFE4A-40D0-455D-875A-758A776D49C9" },
                new SubCategory { Id = "539413DA-64BA-4CFB-AFC7-8981F9EC763A", Name = "Giyim", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = "ADB4AC66-F8B7-4316-89CB-F638E723498D" },
                new SubCategory { Id = "1FDA6B9A-0BD6-42FF-9DC0-C141B637A095", Name = "Outdoor", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, CategoryId = "A7DA7883-9C55-424B-ACC6-8A1DE6C14881" }
            };
        }

    }
}
