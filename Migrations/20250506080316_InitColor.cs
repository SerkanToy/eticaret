using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class InitColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colorvalue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "6.05.2025 11:03:15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "6.05.2025 11:03:15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "d381bac8-219b-404f-8803-f41af731de89", "6.05.2025 11:03:15", "AQAAAAIAAYagAAAAEH0bhG4UegPaotKfZ8NO48uiZTOVNME3Hzl+GksYRnzURcgXZLhLWSML5Br2I4z5dQ==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "996e9324-12e2-4cfd-bb14-e7126dd0087b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "bc241e95-6a0c-4ed5-8732-abcd6539d60e" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "5504906d-6405-4864-9b26-53bd0c733c3d" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "04ae4857-2d10-4aec-b17a-edd72c390447" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "6d27970d-dedd-495b-ad6f-1505bca2df19" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "39171556-4420-43a7-b386-f04375d28846" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "4da7ec32-2fe2-4bbe-bedf-eabfff4b11fe" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "de2903fc-3a5e-4be7-a4f7-a8f19bac84e7" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "71536cdd-1b77-415d-9c67-4d4b8b8511ec" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "dea3bffe-862a-48ee-a1d5-76132ba4ac3e" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "92bec768-7b3d-4e8f-b0f8-be6047ccd81b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "a64b7eed-6a45-421d-b658-e50e0e39ec3d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "167d7ed4-fe38-4238-ba5f-fb785af6f692" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "64eb027d-fcbe-4531-928a-5d68621485b1" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "a32da0d6-c017-4c9f-a49d-6258315f8180" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "7f21a426-5f1c-4387-be53-478d70c39c48" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "46562511-7f92-4703-9821-24c755fb0286" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "9da0ae05-2e05-4955-a1c3-b801c184638b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "6d355277-1652-48f1-b1c2-a406a0a5925f" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "a8f4fc50-b83d-4107-89d9-15f2f450e5f0" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "5c4c94df-1a07-4fbc-8748-c105fdaeb88c" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "f0cb76cc-5851-4674-8bf1-8e5472bc3586" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "4d0e1457-a47b-4a20-8da9-effdea7e5971" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "4d889dbb-3ca2-4bde-b344-ca838c3a4da6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "c0fee073-b16c-41fc-9d98-c13217303df8" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "30095147-00d2-449d-8b91-11001d05f49d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "12d116e0-f6dd-45f0-a109-e2418631faab" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "f5f94fb7-eae4-4491-912e-8e52596f356d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "0de89c24-d44e-4267-909c-6ea3b3724f15" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "183fbffb-d1e0-43cd-befb-fcd4ee588de2" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "36338ade-7064-4d5c-8642-40105463b9a2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "a60b573c-7fc2-44c6-94af-72fdd9998d84" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "d8667c26-3169-40a8-87c4-a33eeac997d2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "30cb34ae-db86-4211-8d67-891410fa7d70" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "ba9b152f-bc0c-445e-bf52-2a6bd50d1871" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "7795514e-880e-4ead-87c9-888322fdbc08" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "d71ec37b-11d1-48fc-a179-ddf66093950f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "9746a9b8-4355-40ba-ba5c-b57c3aa8ac47" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "3847cc7e-de19-4d21-95bc-f28b0251d126" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "2a235e11-ccca-4d07-b5e1-92ac0ec61241" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "9ea6973e-0fcf-4d5e-a543-bd01c3842788" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "f48f64e0-f7c5-4140-a4d8-346f426b4e90" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "c8b90af4-e0c3-49a2-a6c6-e07363e7d974" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "09acb22c-ee29-4787-985c-8de11ff64546" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "92c61b83-4bd9-4b35-a29b-910b68a5005d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "ba52afb3-8baf-412e-9b98-df13117b5aad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "86890ac5-7861-4cf1-b906-86ee74f6707c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "4800f137-a67d-4f82-8f53-46f22dbe542a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "e22a42ed-5677-4f3b-aa6d-6bfedfcda00f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "69bf8366-3cd5-49d5-9e6d-4a6790cf63ac" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "500c4aaa-1802-4ad1-b7cf-15042ee532d8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "de288b02-0492-490b-b566-e45478071cbc" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "82de14c2-a92e-4c68-824a-f3a6d5d3e7a3" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "2cef7e38-df19-4df5-a542-c059e277b3c9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "bfde7c99-2a63-4e50-9ceb-2bdff66278ba" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "33d476a8-3c5b-46bb-a18a-6bee2b0926d0" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "c646e59c-3316-4432-84d7-31bce0dbe666" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "5888f769-9a18-4c47-bc8b-f9a9eb90efb9" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "acb32041-be7b-41d4-ace2-b7078bf0861b" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "04477ea7-4b09-4b69-aa6f-8b9012e0eafe" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "d36ff833-2a05-4ccf-81d8-d997c5f24d18" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "bf72c871-8fcd-440f-bd78-390407b22e7b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "6.05.2025 10:12:16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "6.05.2025 10:12:16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "32338e11-1f1b-42e7-98d5-bde627e1e564", "6.05.2025 10:12:16", "AQAAAAIAAYagAAAAEAH9Yb5+XUNcRIsCk0jRlecCvSYOfjF/5Kexbaef+8LRWzH6TOZAqETKkmaaGakfJQ==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "5fdc93ee-438c-4ab3-a355-d3029b85ec73" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "cd5c5f04-53c1-448f-beb3-08dbd0f8f25e" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "f132ad77-2636-4517-b709-8bd6fa6e4846" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "4be8c888-39c1-4995-85db-944bef7322b0" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "b5548e8c-ae13-48a2-8e34-841e3b198026" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "c93fb39c-abff-4f36-8c39-adb47e86a2ad" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "754edb62-2d15-44b6-8bfc-66fc94098268" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "21bcb138-7f06-4e4f-b48f-f865eed58433" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "136f4779-7782-480b-8d79-b23c513fe22c" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "db7939c8-8eee-4674-b999-b0f91ed4eea4" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "f6b99cf1-f759-445e-8dbb-03950c4614f7" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "6d393860-ee44-421c-b592-3709d3ff0072" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "1333dd64-840d-4277-80de-850319c4801a" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "f0eef8b7-8455-47f3-966c-9fa6d3565ea3" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "ae96e5b0-8993-4558-afda-b836fad3700b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "04520387-052b-4fa9-98a4-eb24f7b5c434" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "70be8e1d-6ac1-4e41-a631-8f340450d82d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "5500975d-7b5b-4184-8e2e-05fb13ab2aa2" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "f404c75a-598a-4d3e-987f-df8c18bdd0af" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "dda39252-4901-448a-8a1d-10ce13f0f3e6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "906d65ea-3b92-4c53-9dbd-491187c38e41" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "e29eb424-dc40-4b93-b221-c44b8b68b0ec" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "664aefb2-28d8-4058-a8fa-1d984fe79a16" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "bc87d8b3-9ca1-442e-b7db-8644302111ad" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "63a84fec-0b71-4856-b8b8-ffefcc23e53d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "ebc8eb85-b030-465c-9c76-a3a116124bd4" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "ee8d712c-e11f-40b2-b877-6603e98f6b1a" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "849e1656-1c9a-4716-b460-c48d94e505fe" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "4b37a23f-adc0-43c9-b4da-26d160a363bc" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "588256c0-49a0-45be-9c2e-bb2230e0e6dd" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "51b1ffc6-50f7-4513-ab4f-acbdaa1b9cf4" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "8af8b989-dc44-4498-973b-0d07943270c1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "b02a1703-a3db-4356-9cdd-3efa76246ebb" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "15c90ba2-9182-466a-91ed-a7d82f6cde7c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "6c3f014e-c6be-4d68-8ee6-3978f5ff2bd8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "7ec85d8a-a11a-4ceb-9d5d-0fabf00a2889" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "26cc40fb-d5c0-4cae-bf15-d92b41ddc701" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "078aec28-70d0-4efd-9e60-88af92975943" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "9aa828f9-db57-4ae9-a042-482e29ea8748" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "28c4bc7b-f006-48f5-86b7-8d9abc113ce0" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "156f252a-b60c-4706-aa96-bf385526d2e6" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "67f9a4c3-42b8-4e04-a0f2-44645faf875a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "447710c5-c831-45a7-a655-4e41bad5aeb1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "2cb6ff89-8a39-41a0-a9e8-9d06029b52f5" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "d796673b-cb70-4908-a50b-118a2e061ffd" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "6ce18d84-0f4d-49f3-8d80-442806b8e487" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "743ca17d-3f32-4950-8d3f-c0be1d47e3ab" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "f8aa4313-f13c-4bb8-81de-79f15d60e39d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "e01ab6e7-cb3a-4268-89ea-1ec421b9455f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "e88dcd68-9d71-4676-b825-afdf87b6fc19" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "5424a6e3-9eb7-4740-bf8f-9c1fa16b0e0d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "eef0bf95-3bd0-46a5-8042-f07ea6d8f009" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "7293cb45-bcc3-4eda-b81f-b7eb7a05091d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "c36d8869-da7f-4130-adb6-006fc668a95a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "45b13944-6efc-4036-82ec-9e748cdcc0bf" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "c0eb9590-e199-4813-a754-10a1b1e7f1b9" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "be2634ef-f9f4-42d4-aa44-78a18698df4e" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "9f84e2c2-6f55-46d6-9d0c-7c06b24ccf39" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "b74bded0-9a00-421f-af2b-d914db876166" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "df66eaab-2bd7-4304-ad10-1d571f4b84d2" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "99b20786-57bf-4788-b89b-e9f305aa0520" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 10:12:16", "2a48b1bf-1f57-4978-8375-4cddb32a9ea0" });
        }
    }
}
