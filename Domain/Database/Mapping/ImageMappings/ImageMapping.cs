using eticaret.Domain.Core.Entities;
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
                new Image { Id = "55B71743-A6C4-4619-9857-0446AEB59AE7", ProductId = "DD292E73-C940-452A-BCA2-6B2AFA551475", Name = "1.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "C7CE4F0A-22A1-4D9C-87D8-2FBE3D243FC2", ProductId = "D4573119-644C-4F5F-B861-57FA481722AA", Name = "back-1.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "91C0D743-5F78-4BFD-89FA-272CB89030F5", ProductId = "4F89BCAF-DA9A-45D3-9BF5-2C1FD540327B", Name = "2.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "2DCB40A4-2282-4774-ABBB-802784FF4B0C", ProductId = "519905D0-34A6-4B48-BCDB-7F4CD073C4DE", Name = "back-2.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "BB92D949-FB4F-4B90-A45B-D3702C6A9CAC", ProductId = "39E30FFA-9035-447B-9191-71DA795F082F", Name = "3.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "46127C3F-E3ED-4F4D-B7A9-CEF5F37A7D05", ProductId = "05699C19-3945-4501-A946-683A171DC7BD", Name = "back-3.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "02365BB3-9DDA-4B4B-B128-A328396E9D83", ProductId = "854AD4D3-0465-47AD-8D07-98E8ECAA8C5D", Name = "4.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "BE1EE8C4-54FC-4895-960E-A04555317CF1", ProductId = "0F94273F-721C-40C7-8053-9F68A4CC5333", Name = "back-4.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "628ECE28-BC05-4F9E-8D11-4987E5EAEA7E", ProductId = "7E4E0809-7ECB-43BD-8198-29404B3F46FE", Name = "5.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "66E7D9A7-5C36-4C3E-86F2-FADC94B63AA4", ProductId = "EBBBDDD7-9DCB-4F64-A3A6-67115A98040A", Name = "back-5.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "F21CCB4E-FDD0-4B4D-8A4F-099476754D07", ProductId = "84A16343-4EB7-4BB0-91C9-DC9CAF520A70", Name = "6.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "E00B9151-AFE4-4E54-ABC3-2AA1850E1936", ProductId = "E464C491-88A5-4B3A-BFA1-A6D2ADFF2AEF", Name = "back-6.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "413F96B9-3A36-4677-B8FB-348F3F00A07B", ProductId = "CAC4CF1A-9C0F-4ED2-9D70-39C47F25CABE", Name = "7.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "7DD2F442-C1B9-4E4A-A37D-DB929961E531", ProductId = "A2AE5665-6E4A-4187-8A94-80FC03FBB11D", Name = "back-7.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "AA8434B8-EDB6-4378-A4AD-39B7E73E9227", ProductId = "7B86DFEE-775E-465E-88A1-C115B7905FDB", Name = "8.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "DFE8298A-ADCD-4624-A2C2-A6E2FBB70561", ProductId = "F6406AFB-73E1-4082-87A9-AEE1CC9C1BC4", Name = "back-8.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "E9B76408-2A4D-4A82-ABE5-662393EC712F", ProductId = "2846EA3F-AA52-41B5-AD48-46C08605106B", Name = "1.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "986EAEF9-F86B-4025-9ABF-D8A176E4BF3C", ProductId = "CBDB1054-A9C0-477E-9EF8-AD8D7480F6C1", Name = "back-1.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "66640387-1B7A-4762-A359-E325E9EE2B53", ProductId = "0D6C0D47-A4F3-43E9-BD44-090C4584281B", Name = "2.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "126D8D55-5796-4460-BC30-FDD613018EED", ProductId = "FD52A470-AD14-4D61-B0F3-1D154FE14E26", Name = "back-2.jpg", CreateBy = "Sistem", IsShowcase = false, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "E4E251BC-033E-47AD-9233-30DA8D2D9246", ProductId = "80240430-AD39-4492-A6BB-3FB6FEBF071D", Name = "3.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "0B606C0A-70D1-4840-B654-969068ABFCF6", ProductId = "D739C019-C701-456A-9F21-8A2394F6FA65", Name = "back-3.jpg", CreateBy = "Sistem", IsShowcase = false, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "E18491CB-882A-48DA-9101-549146FEFE95", ProductId = "56C29C94-2D94-4D69-A556-23F43412C465", Name = "4.jpg", CreateBy = "Sistem", IsShowcase = true, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "DFA01602-B1C7-4620-B922-633210BF0AD7", ProductId = "6BD8DFA5-F0AC-403B-BC3B-2F67857837B7", Name = "back-4.jpg", CreateBy = "Sistem", IsShowcase = false, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false },
                new Image { Id = "8285701D-3311-42BA-9FDA-4D0241C1309F", ProductId = "7444427B-F8DE-44D1-844B-AEFC86E3062B", Name = "5.jpg", CreateBy = "Sistem", IsShowcase = false, Flag = Guid.NewGuid().ToString(), CreateDate = DateTime.Now.ToString(), IsDeleted = false }
            };
        }
    }
}
