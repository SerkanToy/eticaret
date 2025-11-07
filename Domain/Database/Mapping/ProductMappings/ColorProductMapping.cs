using eticaret.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaret.Domain.Database.Mapping.ProductMappings
{
    public class ColorProductMapping : IEntityTypeConfiguration<ColorProduct>
    {
        public void Configure(EntityTypeBuilder<ColorProduct> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(y => y.ColorProduct).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            builder.HasOne(x => x.Colors).WithMany(y => y.ColorProduct).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            builder.HasData(_productcolors());
        }

        private List<ColorProduct> _productcolors()
        {
            return new List<ColorProduct>
            {
                new ColorProduct { Id = "D8E1F71A-08EA-4A30-AC59-D0D23663714E", ColorsId = "1BA90E67-7F3C-44AA-AC7A-54F9E9225E04", ProductId = "DD292E73-C940-452A-BCA2-6B2AFA551475"},                
                new ColorProduct { Id = "109E30D7-1254-481C-9152-0E42A653CDBB", ColorsId = "DCB6324E-7154-4E44-91C7-FFABA3B28B5E", ProductId = "D4573119-644C-4F5F-B861-57FA481722AA"},                
                new ColorProduct { Id = "3669EACA-F9CB-4914-8973-9AE8BBB36BFB", ColorsId = "70305E3C-CE16-4154-AF57-B9C4C458E5EA", ProductId = "4F89BCAF-DA9A-45D3-9BF5-2C1FD540327B"},                
                new ColorProduct { Id = "5D97F616-3968-45F3-8C5D-F6BCB14E45CC", ColorsId = "5F6C3716-C9A0-4BE0-9FAF-8C7A1AB5EC42", ProductId = "519905D0-34A6-4B48-BCDB-7F4CD073C4DE"},                
                new ColorProduct { Id = "6C38D2C4-C11A-48F0-8AA1-F4F9A8D976AD", ColorsId = "E9212F8E-B877-4178-8539-20FB7AB5E00C", ProductId = "39E30FFA-9035-447B-9191-71DA795F082F"},                
                new ColorProduct { Id = "C17E33A9-24CC-4F93-BB45-EDFECE8D1EB7", ColorsId = "9C381C16-3198-47F8-A47F-D218DEFDA64F", ProductId = "05699C19-3945-4501-A946-683A171DC7BD"},                
                new ColorProduct { Id = "314E1713-573C-4B7C-ADE2-B55A76242A9C", ColorsId = "390E0394-7160-49FF-917D-FD44971610FF", ProductId = "854AD4D3-0465-47AD-8D07-98E8ECAA8C5D"},                
                new ColorProduct { Id = "E8A7786E-F248-4AEE-97D9-0A57FF3FFE60", ColorsId = "68751A54-0433-41DE-8527-5F17B341195A", ProductId = "0F94273F-721C-40C7-8053-9F68A4CC5333"},                
                new ColorProduct { Id = "AB960EC3-C47F-4C60-AE94-64287BC6C1D3", ColorsId = "6A8FAC7A-590A-47CA-B018-EBDB824822B6", ProductId = "7E4E0809-7ECB-43BD-8198-29404B3F46FE"},                
                new ColorProduct { Id = "E8A188DC-26C9-4B77-ABA8-85A24BA5D060", ColorsId = "294A4FD6-7614-4205-B6F0-4162F33EAEB4", ProductId = "EBBBDDD7-9DCB-4F64-A3A6-67115A98040A"},                
                new ColorProduct { Id = "04AE709C-9D3C-4077-A4F7-C57107567693", ColorsId = "F8A97944-AE75-4093-866D-C286A355BD23", ProductId = "84A16343-4EB7-4BB0-91C9-DC9CAF520A70"},                
                new ColorProduct { Id = "7F5991E4-A435-4E08-B987-5A458F133C8A", ColorsId = "E51833F7-A3A5-4EC7-B8C2-9A22F87F1D39", ProductId = "E464C491-88A5-4B3A-BFA1-A6D2ADFF2AEF"},                
                new ColorProduct { Id = "D75B12ED-EB14-4EBD-9670-28FE6EBD5EA7", ColorsId = "AEF3C637-1CA0-4CC2-81E8-0639E55F9B97", ProductId = "CAC4CF1A-9C0F-4ED2-9D70-39C47F25CABE"},                
                new ColorProduct { Id = "4C32BC1E-8A4C-4AD1-A331-3687D46C83B0", ColorsId = "7DD698F2-37A7-44B6-BB3B-60673B13E226", ProductId = "A2AE5665-6E4A-4187-8A94-80FC03FBB11D"},                
                new ColorProduct { Id = "C5135EFF-A521-4A12-9285-57F5309CE713", ColorsId = "1BA90E67-7F3C-44AA-AC7A-54F9E9225E04", ProductId = "7B86DFEE-775E-465E-88A1-C115B7905FDB"},                
                new ColorProduct { Id = "C2C6553B-D116-4406-90C1-24BC0E0DC1BA", ColorsId = "DCB6324E-7154-4E44-91C7-FFABA3B28B5E", ProductId = "F6406AFB-73E1-4082-87A9-AEE1CC9C1BC4"},                
                new ColorProduct { Id = "285221C2-4134-46A8-B96F-6300E848B445", ColorsId = "70305E3C-CE16-4154-AF57-B9C4C458E5EA", ProductId = "2846EA3F-AA52-41B5-AD48-46C08605106B"},                
                new ColorProduct { Id = "9CE042CB-CE72-4717-8731-897393021D2B", ColorsId = "5F6C3716-C9A0-4BE0-9FAF-8C7A1AB5EC42", ProductId = "CBDB1054-A9C0-477E-9EF8-AD8D7480F6C1"},                
                new ColorProduct { Id = "762F9A4D-FEC7-4CC6-AE0D-404A8BEBD3CF", ColorsId = "E9212F8E-B877-4178-8539-20FB7AB5E00C", ProductId = "0D6C0D47-A4F3-43E9-BD44-090C4584281B"},                
                new ColorProduct { Id = "0FCAEF4A-FB2C-49CE-B3C8-9C44E525D71C", ColorsId = "9C381C16-3198-47F8-A47F-D218DEFDA64F", ProductId = "FD52A470-AD14-4D61-B0F3-1D154FE14E26"},                
                new ColorProduct { Id = "1227DA62-6872-46AC-BF32-3DFB8D5E6BF5", ColorsId = "390E0394-7160-49FF-917D-FD44971610FF", ProductId = "80240430-AD39-4492-A6BB-3FB6FEBF071D"},                
                new ColorProduct { Id = "16AA4376-DC85-42FE-BD2B-31D36FDB1D86", ColorsId = "68751A54-0433-41DE-8527-5F17B341195A", ProductId = "D739C019-C701-456A-9F21-8A2394F6FA65"},                
                new ColorProduct { Id = "9203E95B-59AD-40BE-8434-5DF155404287", ColorsId = "6A8FAC7A-590A-47CA-B018-EBDB824822B6", ProductId = "56C29C94-2D94-4D69-A556-23F43412C465"},                
                new ColorProduct { Id = "9203E95B-59AD-40BE-8434-5DF155404287", ColorsId = "294A4FD6-7614-4205-B6F0-4162F33EAEB4", ProductId = "6BD8DFA5-F0AC-403B-BC3B-2F67857837B7"},                
                new ColorProduct { Id = "816BEBC0-30AC-4377-B83E-6EA3A2E1F195", ColorsId = "F8A97944-AE75-4093-866D-C286A355BD23", ProductId = "7444427B-F8DE-44D1-844B-AEFC86E3062B"},                
            };
        }

    }
}
