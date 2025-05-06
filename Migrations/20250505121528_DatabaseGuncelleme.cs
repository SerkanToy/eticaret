using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseGuncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "5.05.2025 15:15:28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "5.05.2025 15:15:28");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "e5746f05-cdcc-429e-b029-e528d6edbfc8", "5.05.2025 15:15:28", "AQAAAAIAAYagAAAAEHdMlWi3HLY2A1fIsaS7g2fYjxRAigveY+JvP//ckdYpHCu55C2uQL9Yl7OKH1QHQQ==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "9bf07195-bf7c-4656-894d-adc64b5264ed" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "4d933a0e-1413-474b-b245-1057cc9fc22b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "050a2489-0adc-475f-99de-c26af8e89658" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "1650528b-8333-4419-b858-f56f32a80a3f" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "815b63f7-b5b0-4774-88e8-5dda2327ba62" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "c256d4c8-a5c8-4b3c-9ac4-66b8ea5bc80c" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "d3944053-5a36-4e83-8a34-bdefc1e21fb4" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "1be5f909-ab48-47f1-b4d1-15b8b206b178", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "53d106f3-8251-434e-bb81-e0de9f7dffec" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "8b749cec-2d43-470b-a67a-35451ced5238", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "3d38b2a5-3e4c-4667-a143-29bab7cf37f9" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "27184ff1-8c85-418b-99cb-126bc11b9d25", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "adb324c2-b5b3-4ba8-91b9-945c936a3aa6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "740a2807-30c6-49d9-8b47-7b71d0d56585", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "54c2d409-1038-4c36-bd2f-d0c3e1915baf" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "5955aaf3-d77e-4917-a41b-ff46ba09fc8e", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "c1b0d7db-731b-4daa-818e-f324ed7b5752" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "f79c677a-5f50-4a1a-857a-438efb789023", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "358c50c6-7baa-4437-8e8e-d8bbb202bc1c" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "d08068a5-d58f-4eec-842d-30973f58bda2", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "4833eb88-e748-4dd3-b66a-6ee973fb572b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "8ef2c8a4-2c2b-4a64-a844-ad3f8edcc373", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "8e64e0e0-2886-459b-8e2c-45c84ba574a6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "144ae2a7-343c-4e2e-9da6-c34a1af7b981", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "e5e05781-79db-4ec0-8ef2-8233fe15f94f" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "7ff96cdf-2cc4-4627-9428-4058b8de7796", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "824a3df5-b025-453c-9cd5-f91e6ada95db" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "74ca43f9-76c1-4c6b-82e6-390022a2f5bd", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "abdb97df-1c2d-4f81-b00a-37fbc5efadb7" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "5.05.2025 15:15:28", "881d616a-8a0d-4a26-aea9-c37ecb00cd2b", false });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "053e90d2-99b3-4b2d-bec3-e2109d7fea9b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "3e2adda5-2c9e-4d9b-b698-ae41e31a05f5" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "9f0c1867-57a3-43f3-9302-38aa3b604e0c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "267e153d-10cf-4fab-bafc-91855b43b682" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "a87b3b39-f42a-4039-9deb-d88bdcb5db63" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "df4cc8db-f0b3-43d7-ba81-881c9c5a1557" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "93f6af2c-0a83-4a1e-a2bf-18459ea49018", 2 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "26c090f2-7be5-4993-9cd6-4e4e91f3eda0", 2 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "401be6ee-b65d-4925-bac0-9ae0149aae48", 2 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "862e63cc-3be4-48d8-a55f-cb7e482a997a", 2 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "b8569fe2-5f03-45be-9766-ddd908c034ed" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "60c77f46-0a0f-44e6-84ec-6b268c6c2275", 3 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "c8a19b51-f639-4a79-bd1e-3b8de7c4f3ee", 3 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "ff12aab0-4e99-48b6-b9e7-1c0a79de964c", 3 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "45cf8308-b2f6-4e85-ac2e-2fb9acbf0aa7" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "7b73f0fa-713f-42f3-aa35-9901324d2457", 4 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "a63ba7d8-9b35-478d-a5e8-c164c050271b", 4 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "c6bbb83d-023d-44ae-ab78-62830e688651", 4 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "79f7670a-34f8-4c97-8b5c-814dd6299256", 5 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "6967a9c1-cca1-4fee-a488-8ba16823f427" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "70e0d386-a436-423f-bac2-91da7685cab0" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "b737d950-7cdf-40a8-a6f0-26fe60479be6", 5 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "45ce9e7f-ae06-4c27-856f-d3f0307ab05a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "295c0d8e-1252-418a-9ea3-7e8d41630e8f", 6 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "5.05.2025 15:15:28", "2188e7cd-afe6-4491-8322-1036cecaa23c", 6 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "1df09011-ed38-4b14-83e1-1992a0cb945f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "7f87cd7e-5de0-41c1-b436-2029bcdd9316" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "5eb43051-6fb8-4458-a9a3-a34d6796f58f" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "212a2115-9cf3-43cf-86a2-570a16595532" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "7096b1fd-3d1e-4ceb-ae73-f8d1a9a7039d" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "5.05.2025 15:15:28", "eca6cc05-9692-4a84-9bb2-088b0b757533", "Spor" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "5.05.2025 15:15:28", "67f874ed-86a9-4fde-96da-569cf3266a63", "Giyim" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "5.05.2025 15:15:28", "b465e528-fd80-4379-ac8a-7a890eebd489", "Outdoor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "30.04.2025 11:14:22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "30.04.2025 11:14:22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "631ae50f-f4d6-40b4-8799-855c36c09743", "30.04.2025 11:14:22", "AQAAAAIAAYagAAAAEEEc9R8Q3NM5ihbg9qFki7lDXcqir4TkmedH09tleAMFp4LkqHCRZ6d9arQV4rLVrw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "bc74cef0-9844-4a1e-9a25-9bb98430a1a3" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "54b34e5e-5413-4c22-81fd-231c7c60220b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "fb6a5f9e-743e-46ce-9ce8-5eac25f31848" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "cbbdb639-ed42-4ab5-b642-cff0fe332b3d" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "3492e1d4-25db-4041-bed9-16aa8a383632" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "c8cf0ef9-4b4a-4ad0-a919-bb27fe2675b1" });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 4, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 5, 20 },
                    { 5, 21 },
                    { 6, 21 },
                    { 5, 22 },
                    { 6, 22 },
                    { 5, 23 },
                    { 6, 23 },
                    { 5, 24 },
                    { 6, 24 },
                    { 6, 25 }
                });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "3e8a63be-7f64-436b-8885-e398db4c8460" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "e2a97640-6c81-417f-9373-f2ed94522b0f", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "c6fb5a41-f7f0-4ca1-9b3b-09d6ba741e51" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "1c00f13f-9fde-4497-aae1-8fa1fc257b85", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "1f531bcf-884e-4465-8d76-76798b890065" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "d2afb9a6-3c88-4cac-beef-c35316de5abc", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "b442d499-9d3c-49df-820e-2c3fbbcf0a37" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "40d09ef5-7d00-4983-bb76-8c338335923f", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "60b731b4-6f1f-485d-8d8e-478d54abd84f" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "49c50208-a084-4f79-b2e7-fcaaf3d1bd4b", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "81f1ab1d-cae2-44c0-9436-afaea7574077" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "82ac715a-5024-46c3-ba11-2c1e3c9af0c8", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "658bfa2f-779f-489c-bc73-1fd4b34d243a" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "b00e8a75-74d9-441c-a9cb-9c53d302c475", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "089f4a77-6561-49af-91ce-3985343e374a" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "cb20bdfe-14bf-43db-9575-48dc39ee2a6d", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "6461a1e8-5d6c-4f11-83ec-50661627ac71" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "cc5ced82-37d3-48f6-b172-861065707922", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "9eaac5b7-71ff-4922-bede-ce54accfefc6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "5972b832-12fb-4a25-9eb7-82107b9841da", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "6b182c6f-d483-4e53-8928-c6665eb668db" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "3968d34e-c0c4-467d-a0af-6324ed5a92af", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "1b678225-2897-4fe6-a760-616d222327dc" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 11:14:22", "8f4d3213-e8e0-4170-82c1-a36f6195fb1d", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "37df4b83-2015-4e0c-a9af-a9980484375b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "26fa1483-5995-4ec3-9019-3c561069dde2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "aba8d0e6-ad75-47f6-bfd7-28b0f7cf17bd" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "066f442b-45de-4dd3-9521-f40bf4a8e09c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "790ab367-8cf8-4537-8dd4-2720e6dae013" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "d975ff22-761a-421a-a913-87dbdefa0614" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "19095d42-f8b4-480b-923f-6a3f0cd639d6", 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "cc11f55c-ca3c-4f1b-8a6e-7dd4dacf7d5b", 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "928d8b31-d868-4da2-bad8-5bdbd53744ab", 3 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "8fe12d1d-9a0d-4f5e-8b89-c0ef50bbac00", 3 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "3fa41fed-0af3-49e9-be30-38f0993fb6a7" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "238c4b2c-fae3-4503-9e14-c3fffd0f515d", 4 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "765a3398-cbf4-4f93-9a00-8b1f6bc72b2b", 4 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "caaacd2a-dc8d-41fb-b862-288316f81cd1", 4 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "4a36f4bc-5ef8-434c-b2c0-cbc2f09d229f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "c0cb2d9e-3ea5-4341-9652-71c8b4ac1620", 5 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "d993c638-6742-49d5-b822-8991208b61d4", 5 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "1640651c-b699-4d03-803f-dc0a1037a10a", 6 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "d492de26-008b-4dd2-9f99-fc5f5399716f", 6 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "ec22ff20-ffba-4bea-aee6-a57a6297c5da" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "21e2a2f2-7120-454d-a596-42c0014cd18a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "e0f38dd1-185d-4332-9479-b349f7fff751", 6 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "6529c3b9-acdf-4eb0-9737-f36b39b3f3ae" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "1ef3f7ae-7a8e-49fb-a02b-8757821bbe14", 5 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag", "SubCategoryId" },
                values: new object[] { "30.04.2025 11:14:22", "664ccc54-10e3-4577-9e40-f1c1219b797b", 5 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "a08695c4-be97-4779-8df7-c77ddeed5260" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "a986ee2f-88ff-4832-9b40-a2c295b9ea05" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "8891b313-7707-4a54-981a-2e5534daedd0" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "db328015-5632-4471-ab66-1bb8a1170c39" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 11:14:22", "32fc6538-56dc-4d3b-9de2-12745b28d0ca" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "30.04.2025 11:14:22", "6fb19ca3-c719-45c4-8318-98e0c67e4746", "SubCategory 1" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "30.04.2025 11:14:22", "4ffdc2ef-875e-4bc5-943d-dc1c5f8c0560", "SubCategory 2" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "30.04.2025 11:14:22", "99a8aeee-0abf-4377-ba29-ae6c28d55752", "SubCategory 3" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_CategoryId",
                table: "CategoryProduct",
                column: "CategoryId");
        }
    }
}
