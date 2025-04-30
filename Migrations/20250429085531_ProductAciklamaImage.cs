using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class ProductAciklamaImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NewPrice",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OldPrice",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "29.04.2025 11:55:30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "29.04.2025 11:55:30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "e2642d0b-00f9-4c54-b9f2-db4b6a2dc373", "29.04.2025 11:55:30", "AQAAAAIAAYagAAAAENnYDZC+ayX16xWSIf8CqW0z1nL+8QqKD8r5HrcHPUyk4xXMbkhzA3VelfSylBGXBg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "304b7bf4-2bf2-4b6e-b061-4454bc7803c2" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "52c37399-81d6-4695-b3e0-ad4bbe83a753" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "edd3b981-d70f-4cbf-b8b7-a25b80fc7b12" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "ed174e7c-573c-4bf9-8fc5-a74a2f5b95dc" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "93d958dc-e149-461b-bbff-d12c57843c7d" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "edc75696-44d3-4670-bad2-168ed263fb48" });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, "Sistem", "29.04.2025 11:55:30", null, null, "c303be36-31bc-4935-8ea2-eff202ee949b", false, null, null, "1.jpg", 1 },
                    { 2, "Sistem", "29.04.2025 11:55:30", null, null, "0d018043-5420-476b-a2ea-88c525a6ab4a", false, null, null, "back-1.jpg", 1 },
                    { 3, "Sistem", "29.04.2025 11:55:30", null, null, "1c4561a2-e269-4b32-844f-70f2e119b8d5", false, null, null, "2.jpg", 2 },
                    { 4, "Sistem", "29.04.2025 11:55:30", null, null, "e7e1303b-6ab6-4452-81be-9f3f5690539d", false, null, null, "back-2.jpg", 2 },
                    { 5, "Sistem", "29.04.2025 11:55:30", null, null, "8cfce3ae-d58e-4a20-a05a-e3ed156f082c", false, null, null, "3.jpg", 3 },
                    { 6, "Sistem", "29.04.2025 11:55:30", null, null, "b877f04c-cbea-4703-ac95-80b6f6d2f233", false, null, null, "back-3.jpg", 3 },
                    { 7, "Sistem", "29.04.2025 11:55:30", null, null, "f155223e-1307-4b0e-97f0-55c2cf8c9782", false, null, null, "4.jpg", 4 },
                    { 8, "Sistem", "29.04.2025 11:55:30", null, null, "494cab9c-9c6b-4121-b7d9-1fbb3918c4fa", false, null, null, "back-4.jpg", 4 },
                    { 9, "Sistem", "29.04.2025 11:55:30", null, null, "b76850d1-b6b5-4866-bf32-c2a66dc60702", false, null, null, "5.jpg", 5 },
                    { 10, "Sistem", "29.04.2025 11:55:30", null, null, "52bf8e97-a5d4-4cf9-8979-115292d8e172", false, null, null, "back-5.jpg", 5 },
                    { 11, "Sistem", "29.04.2025 11:55:30", null, null, "10060094-7d27-4d8b-8f2c-d06de6955949", false, null, null, "6.jpg", 6 },
                    { 12, "Sistem", "29.04.2025 11:55:30", null, null, "1ce5669a-fa21-4aeb-a439-f9c73a9debed", false, null, null, "back-6.jpg", 6 },
                    { 13, "Sistem", "29.04.2025 11:55:30", null, null, "ead8438e-17a9-4639-af2d-a5373ccb64f3", false, null, null, "7.jpg", 7 },
                    { 14, "Sistem", "29.04.2025 11:55:30", null, null, "65837180-d170-488a-906e-938934b50e36", false, null, null, "back-7.jpg", 7 },
                    { 15, "Sistem", "29.04.2025 11:55:30", null, null, "9dc1a58a-702c-45db-a7dc-2ce945969d21", false, null, null, "8.jpg", 8 },
                    { 16, "Sistem", "29.04.2025 11:55:30", null, null, "a9dc98d6-5647-40d1-b4c7-e12542d21175", false, null, null, "back-8.jpg", 8 },
                    { 17, "Sistem", "29.04.2025 11:55:30", null, null, "1bfbf368-b863-4519-83d8-b776ddeb116e", false, null, null, "1.jpg", 9 },
                    { 18, "Sistem", "29.04.2025 11:55:30", null, null, "8e7bb709-1010-4701-933f-d02232e16b11", false, null, null, "back-1.jpg", 9 },
                    { 19, "Sistem", "29.04.2025 11:55:30", null, null, "8bd055b4-0568-4b42-a3b4-65259542c1ee", false, null, null, "2.jpg", 10 },
                    { 20, "Sistem", "29.04.2025 11:55:30", null, null, "13161aed-d159-4695-9947-0d5b6ffe3be5", false, null, null, "back-2.jpg", 10 },
                    { 21, "Sistem", "29.04.2025 11:55:30", null, null, "6a4833b6-fa64-40e0-a7f0-5f29b7b12ab5", false, null, null, "3.jpg", 11 },
                    { 22, "Sistem", "29.04.2025 11:55:30", null, null, "a8214aeb-e766-4dc2-94f8-1641b9d303f4", false, null, null, "back-3.jpg", 11 },
                    { 23, "Sistem", "29.04.2025 11:55:30", null, null, "ffbe178e-7272-402a-8e33-1e7b10bd9ec0", false, null, null, "4.jpg", 12 },
                    { 24, "Sistem", "29.04.2025 11:55:30", null, null, "19b8b42b-f02e-479c-bc64-253328b4f555", false, null, null, "back-4.jpg", 12 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "2502f84a-20f6-49ce-9def-b921b48209fa", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "c08f0178-bcdb-4254-856e-fb266180046a", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "19624227-4883-4f8d-a239-13be1435f755", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "0d464da5-6613-4df2-8ec9-bf34e9bba254", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "3e4be1cd-521c-4d05-bc1e-b0523be0fda6", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "9b63c5ea-53aa-4e1e-a4b3-05b7ccea684c", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "dfde5f54-8653-44a1-a439-13cd9b84910a", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "299ed704-5bad-4b45-8fbd-e159bd903b98", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "fed1a990-9ff6-485b-b200-045e0279c16e", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "d0b23b0c-41ae-4c72-8e99-3523a45e6ced", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "38cd1737-c217-4be8-b078-a7422a1e5aa1", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "5f41312b-3d79-4582-9aac-9adb75df4fac", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "aaf90d59-1cd2-42b4-a344-3103c1900494", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "14d8c10f-c150-4e22-81e6-3bc63048f052", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "7de36f1a-a820-4613-b8cb-9906cd086104", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "3dfebc8b-4ef5-4c2b-a691-acbd04cfff2b", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "84a93fe0-095d-4636-ba6b-17188b7d5b9e", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "e8fee87c-bbf9-4ade-a264-c00ff5406ed2", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "384aee77-3949-46b1-bebc-ce00f3f74f9c", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "debe6cc5-0c2c-48e1-8f0d-5774ff48c78f", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "019f454e-b866-4c9c-be94-75e7e094f5d2", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "eb28f0dd-2776-4f57-b75f-7468f21df5ab", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "83d2a365-d22e-4996-9bc4-45490d0545fa", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "3936c4ec-bf3b-4508-b271-4b574bcea8da", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Description", "Flag", "NewPrice", "OldPrice" },
                values: new object[] { "29.04.2025 11:55:30", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quas nihil laboriosam voluptatem ab consectetur dolorum id, soluta sunt at culpa commodi totam quod natus qui!", "f1aaf3f8-cfa6-438e-bf61-222463f5db86", null, "3.408,22" });

            migrationBuilder.UpdateData(
                table: "RatinProduct",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "RatinId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RatinProduct",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 3, 1 },
                column: "RatinId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RatinProduct",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 4, 1 },
                column: "RatinId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "RatinProduct",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "RatinId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "29.04.2025 11:55:30", "7453676d-2616-4304-969c-85552022afe9", "Çanta" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "29.04.2025 11:55:30", "ad2ffe1b-fa28-4332-ac3e-e55071d278ab", "Halı" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "29.04.2025 11:55:30", "7ee5c384-a76b-45dd-bac5-4cc63d9598b7", "Aksesuar" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "29.04.2025 11:55:30", "7f83454b-a25c-49fb-b18d-995e44ac4dc5", "SubCategory 1" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "29.04.2025 11:55:30", "2776ea96-22a3-452e-82f1-5194895f5981", "SubCategory 2" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "29.04.2025 11:55:30", "54357f8a-02fd-408d-8f04-e3b7701d7367", "SubCategory 3" });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "NewPrice",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "19.03.2025 16:25:40");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "19.03.2025 16:25:40");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "4bc88bbf-c939-4c41-824e-545b300f51c5", "19.03.2025 16:25:40", "AQAAAAIAAYagAAAAEAYzpp26IgUPCXNPQWsGIt+LpzWs8wqvd1fKNI+8x6I/3wWfDmkszPHbaAzxj3oEog==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "3f612125-22af-45b1-80fe-d2caf9eeb8c7" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "8bc16f85-3ec9-46d9-9644-89b4860a1e22" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "c049463a-7f16-4ad8-8a43-ee61d540c796" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "b91f8ba8-c462-424a-bb65-2bf9c59a6502" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "94b2f655-6a06-4a03-9032-fa8141ccbd90" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "0684d5d7-7cb3-4448-a8a7-95ef05bc7b19" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "f7ca4124-3294-4806-9675-e88ffebe541d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "8e3da1e7-2209-46e8-8bd4-afc74b858af1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "0cd44917-f318-4453-b39f-c9cf50ba3ba5" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "451843b5-e9af-4a21-a001-88bc20cb3cd2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "27012d19-1c41-4a83-9395-c2d3007f9379" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "5aa80bc6-1725-4f30-8828-ea9eed54d350" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "55a443e5-a453-42c1-be3e-8d449b45d494" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "894d962e-4ac5-412a-8c39-ceb4aa48c1bf" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "fd895cb5-5c04-4403-83b8-fa0e6c5c649a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "cc6d0c95-c62a-486f-8fd8-d944547890eb" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "d627d29b-a86f-4881-bdd8-8d991b6c530c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "396da384-b399-4ddd-842a-31583094a3c8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "dd6a222c-8292-4fbc-9623-d4c1fbfb6591" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "e9a23a56-b899-479c-83d4-1258b46499b7" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "60a97777-e0bf-49cc-9c24-91585f8b37e8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "e399c1af-0193-4a4f-b181-c69965c421f1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "3bfa310b-290a-45f8-abb0-531163dec0d1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "55b29c21-c6c4-4188-9587-165f559fea27" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "475b33d1-413a-4cc1-9f2b-9f8d1bd672f2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "a9d71e4d-a66b-4c59-8ec7-ea6d0ea75b54" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "33ca9a12-6a3f-4f23-9390-b623e94f5059" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "e90e2fcb-5bc5-41da-978d-c8e09a82e87d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "84027766-5664-48b5-a705-4669558dbe27" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "e6ce00cc-0f18-4440-9f0c-30d39f1aaa76" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.03.2025 16:25:40", "15d8d1ec-2a97-456f-9d22-7ae06766f156" });

            migrationBuilder.UpdateData(
                table: "RatinProduct",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "RatinId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RatinProduct",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 3, 1 },
                column: "RatinId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RatinProduct",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 4, 1 },
                column: "RatinId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RatinProduct",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 5, 1 },
                column: "RatinId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "19.03.2025 16:25:40", "e07be7df-2d4d-46df-b212-9ae10826f597", "SubCategory 1" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "19.03.2025 16:25:40", "4432e216-f9b9-4e58-9632-17e464666915", "SubCategory 2" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "19.03.2025 16:25:40", "09d69cb2-8082-485b-8948-34da1805bf8a", "SubCategory 3" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "19.03.2025 16:25:40", "43fa02e3-c8cb-42c4-b01d-4c4323b8789e", "SubCategory 4" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "19.03.2025 16:25:40", "6c225687-68ac-45b9-87e4-91ea2d168901", "SubCategory 5" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "Name" },
                values: new object[] { "19.03.2025 16:25:40", "c81a154a-61d6-4c7b-86bf-8cfa4583bd49", "SubCategory 6" });
        }
    }
}
