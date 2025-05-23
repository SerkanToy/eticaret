﻿using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.ImageMappings
{
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(y => y.Images).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(_image());
        }

        private List<Image> _image()
        {          
            return new List<Image>
            {
                new Image { Id = 1, ProductId = 1, Name = "1.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 2, ProductId = 2, Name = "back-1.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 3, ProductId = 3, Name = "2.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 4, ProductId = 4, Name = "back-2.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 5, ProductId = 5, Name = "3.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 6, ProductId = 6, Name = "back-3.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 7, ProductId = 7, Name = "4.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 8, ProductId = 8, Name = "back-4.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 9, ProductId = 9, Name = "5.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 10, ProductId = 10, Name = "back-5.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 11, ProductId = 11, Name = "6.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 12, ProductId = 12, Name = "back-6.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 13, ProductId = 13, Name = "7.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 14, ProductId = 14, Name = "back-7.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 15, ProductId = 14, Name = "8.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 16, ProductId = 16, Name = "back-8.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 17, ProductId = 17, Name = "1.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 18, ProductId = 18, Name = "back-1.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 19, ProductId = 19, Name = "2.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 20, ProductId = 20, Name = "back-2.jpg", CreateBy = "Sistem", IsShowcase = false, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 21, ProductId = 21, Name = "3.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 22, ProductId = 22, Name = "back-3.jpg", CreateBy = "Sistem", IsShowcase = false, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 23, ProductId = 23, Name = "4.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 24, ProductId = 24, Name = "back-4.jpg", CreateBy = "Sistem", IsShowcase = false, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = 25, ProductId = 25, Name = "5.jpg", CreateBy = "Sistem", IsShowcase = false, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false }
            };
        }
    }
}
