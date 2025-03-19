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
            builder.HasMany(x => x.CategoryProducts).WithOne(y => y.Product).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.RatinProducts).WithOne(y => y.Product).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            builder.HasData(_products());
        }

        private List<Product> _products()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 2, Name = "Product 2", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 3, Name = "Product 3", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 4, Name = "Product 4", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 5, Name = "Product 5", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 6, Name = "Product 6", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 7, Name = "Product 7", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 8, Name = "Product 8", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 9, Name = "Product 9", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 10, Name = "Product 10", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 11, Name = "Product 11", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 12, Name = "Product 12", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 13, Name = "Product 13", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 14, Name = "Product 14", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 15, Name = "Product 15", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 16, Name = "Product 16", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 17, Name = "Product 17", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 18, Name = "Product 18", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 19, Name = "Product 19", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 20, Name = "Product 20", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 21, Name = "Product 21", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 22, Name = "Product 22", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 23, Name = "Product 23", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 24, Name = "Product 24", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 },
                new Product { Id = 25, Name = "Product 25", CreateBy = "Sistem", Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false, RatinAVG = 0 }
            };
        }

    }
}
