using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.RatinMappings
{
    public class RatinProductMapping : IEntityTypeConfiguration<RatinProduct>
    {
        public void Configure(EntityTypeBuilder<RatinProduct> builder)
        {
            builder.HasKey(x => new { x.Id, x.UserId });
            builder.HasOne(x => x.Product).WithMany(y => y.RatinProducts).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Ratin).WithMany(y => y.RatinProducts).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(_ratin());
        }

        private List<RatinProduct> _ratin()
        {
            return new List<RatinProduct>
            {
                new RatinProduct { Id = "6A127394-11E9-4A2C-BE65-84F0C9A10430", ProductId = "DD292E73-C940-452A-BCA2-6B2AFA551475", RatinId = "22A85231-588D-42A0-A959-5F761396EDBE", UserId = "9E400748-88B1-40DE-965C-CD6D005B1A62" },
                new RatinProduct { Id = "1A00ED89-5044-474C-B5C5-01227B210195", ProductId = "D4573119-644C-4F5F-B861-57FA481722AA", RatinId = "1D7E99B3-7CD3-4819-BDDC-7C1C82CC4BED", UserId = "9E400748-88B1-40DE-965C-CD6D005B1A62" },
                new RatinProduct { Id = "6DEF28FF-FCF7-4F32-811A-A89789B3D1F6", ProductId = "4F89BCAF-DA9A-45D3-9BF5-2C1FD540327B", RatinId = "C49DCFAB-1E84-4D02-A033-5EA063DD1909", UserId = "9E400748-88B1-40DE-965C-CD6D005B1A62" },
                new RatinProduct { Id = "F2A25BAA-011A-4904-8877-5E90ACC9CA4B", ProductId = "519905D0-34A6-4B48-BCDB-7F4CD073C4DE", RatinId = "44EBDD14-56BD-4689-AB3A-91EB6A521248", UserId = "9E400748-88B1-40DE-965C-CD6D005B1A62" },
                new RatinProduct { Id = "B05C3FF4-7755-401B-85DF-11B8FF0DC4FC", ProductId = "DD292E73-C940-452A-BCA2-6B2AFA551475", RatinId = "FDBAC08B-35C8-4072-97ED-35ECAC1F4910", UserId = "9E400748-88B1-40DE-965C-CD6D005B1A62" }
            };
        }
    }
}
