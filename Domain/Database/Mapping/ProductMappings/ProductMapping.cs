using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.ProductMappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(d => d.OldPrice).HasColumnType("money");
            builder.Property(d => d.NewPrice).HasColumnType("money");
            builder.HasOne(x => x.SubCategory).WithMany(y => y.Products).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.RatinProducts).WithOne(y => y.Product).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            builder.HasMany(x => x.ColorProduct).WithOne(y => y.Product).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            builder.HasMany(x => x.Images).WithOne(y => y.Product).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            builder.HasData(_products());
        }

        private List<Product> _products()
        {
            string d = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!";
            return new List<Product>
            {
                new Product { Id = "DD292E73-C940-452A-BCA2-6B2AFA551475", Name = "Product 1", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 1, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "D4573119-644C-4F5F-B861-57FA481722AA", Name = "Product 2", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 1, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "4F89BCAF-DA9A-45D3-9BF5-2C1FD540327B", Name = "Product 3", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 1, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "519905D0-34A6-4B48-BCDB-7F4CD073C4DE", Name = "Product 4", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 1, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "39E30FFA-9035-447B-9191-71DA795F082F", Name = "Product 5", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 2, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "05699C19-3945-4501-A946-683A171DC7BD", Name = "Product 6", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 2, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "854AD4D3-0465-47AD-8D07-98E8ECAA8C5D", Name = "Product 7", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 2, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "0F94273F-721C-40C7-8053-9F68A4CC5333", Name = "Product 8", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 2, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "7E4E0809-7ECB-43BD-8198-29404B3F46FE", Name = "Product 9", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 3, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "EBBBDDD7-9DCB-4F64-A3A6-67115A98040A", Name = "Product 10", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 3, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "84A16343-4EB7-4BB0-91C9-DC9CAF520A70", Name = "Product 11", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 3, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "E464C491-88A5-4B3A-BFA1-A6D2ADFF2AEF", Name = "Product 12", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 3, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "CAC4CF1A-9C0F-4ED2-9D70-39C47F25CABE", Name = "Product 13", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 4, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "A2AE5665-6E4A-4187-8A94-80FC03FBB11D", Name = "Product 14", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 4, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "7B86DFEE-775E-465E-88A1-C115B7905FDB", Name = "Product 15", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 4, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "F6406AFB-73E1-4082-87A9-AEE1CC9C1BC4", Name = "Product 16", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 4, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "2846EA3F-AA52-41B5-AD48-46C08605106B", Name = "Product 17", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 5, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "CBDB1054-A9C0-477E-9EF8-AD8D7480F6C1", Name = "Product 18", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 5, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "0D6C0D47-A4F3-43E9-BD44-090C4584281B", Name = "Product 19", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 5, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "FD52A470-AD14-4D61-B0F3-1D154FE14E26", Name = "Product 20", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 5, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "80240430-AD39-4492-A6BB-3FB6FEBF071D", Name = "Product 21", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 6, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "D739C019-C701-456A-9F21-8A2394F6FA65", Name = "Product 22", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 6, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "56C29C94-2D94-4D69-A556-23F43412C465", Name = "Product 23", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 6, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "6BD8DFA5-F0AC-403B-BC3B-2F67857837B7", Name = "Product 24", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 6, Description = d, OldPrice = 340588, NewPrice = 0 },
                new Product { Id = "7444427B-F8DE-44D1-844B-AEFC86E3062B", Name = "Product 25", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0, SubCategoryId = 6, Description = d, OldPrice = 340588, NewPrice = 0 }
            };
        }

    }
}
