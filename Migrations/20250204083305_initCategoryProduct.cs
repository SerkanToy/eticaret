using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class initCategoryProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
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
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
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
                value: "4.02.2025 11:33:05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "4.02.2025 11:33:05");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "25aa43cd-cdbd-4f86-baff-ccc1585ba2b9", "4.02.2025 11:33:05", "AQAAAAIAAYagAAAAELy00dxqPQffn41pGVWpR1kWQpCR90Gz0Se8aGCg7SyhYNxryAw6pLJGLiEbfPl/dw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "8ab711f1-da27-4100-8147-b5a6f4451813" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "7f42e5d1-bc09-464a-9f7d-1ef43af8f719" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "160e1e4c-5b06-4d17-b50c-f6ea9ba49288" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "90674d3c-b2c0-44a2-81fb-16f1ccbcfe0d" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "a647672b-409f-427d-9b32-4bc51e53d5f6" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "ec244fe6-7e6e-46aa-9003-56ca107fc3a0" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Sistem", "4.02.2025 11:33:05", null, null, "ee7f4956-8289-455e-b2b2-8a71a7144574", false, null, null, "Product 1" },
                    { 2, "Sistem", "4.02.2025 11:33:05", null, null, "01d9fd05-c1b9-4af6-ba32-53a75c948e06", false, null, null, "Product 2" },
                    { 3, "Sistem", "4.02.2025 11:33:05", null, null, "b51ea7ce-d5bb-402f-afad-f269c596cdf9", false, null, null, "Product 3" },
                    { 4, "Sistem", "4.02.2025 11:33:05", null, null, "bcd95aab-2bfa-4ae7-a055-06d26e043687", false, null, null, "Product 4" },
                    { 5, "Sistem", "4.02.2025 11:33:05", null, null, "ebe520c0-a236-45ef-a259-a9939509ddea", false, null, null, "Product 5" },
                    { 6, "Sistem", "4.02.2025 11:33:05", null, null, "2dcf9a54-4205-4632-b095-e9645c20d6d0", false, null, null, "Product 6" },
                    { 7, "Sistem", "4.02.2025 11:33:05", null, null, "2fa63099-af84-4c06-b174-f4070f966a53", false, null, null, "Product 7" },
                    { 8, "Sistem", "4.02.2025 11:33:05", null, null, "61561ec1-7303-44ad-817a-3c0d81d059a3", false, null, null, "Product 8" },
                    { 9, "Sistem", "4.02.2025 11:33:05", null, null, "a148de70-79c0-4edc-94ac-9e20ed3d3e89", false, null, null, "Product 9" },
                    { 10, "Sistem", "4.02.2025 11:33:05", null, null, "2b625a10-bae6-45fb-b1f8-be5bef7a8063", false, null, null, "Product 10" },
                    { 11, "Sistem", "4.02.2025 11:33:05", null, null, "76c8e0c3-5806-4645-83e7-e30594e58a13", false, null, null, "Product 11" },
                    { 12, "Sistem", "4.02.2025 11:33:05", null, null, "4b154d76-6a7e-4f13-b19a-9f1033a13356", false, null, null, "Product 12" },
                    { 13, "Sistem", "4.02.2025 11:33:05", null, null, "125c4bad-51a9-40a6-aa39-d00309f06af3", false, null, null, "Product 13" },
                    { 14, "Sistem", "4.02.2025 11:33:05", null, null, "1ff615e2-3123-47b5-99f0-5d1758d13c29", false, null, null, "Product 14" },
                    { 15, "Sistem", "4.02.2025 11:33:05", null, null, "de584b1b-48af-486f-acfa-43897d34ab8d", false, null, null, "Product 15" },
                    { 16, "Sistem", "4.02.2025 11:33:05", null, null, "e50e5fd0-e635-42bf-8ffa-6c0f4a1d4b62", false, null, null, "Product 16" },
                    { 17, "Sistem", "4.02.2025 11:33:05", null, null, "ab05e4f9-cedf-4e77-b7d0-53daee6dafe7", false, null, null, "Product 17" },
                    { 18, "Sistem", "4.02.2025 11:33:05", null, null, "06fec324-2288-4cc7-8e09-74694bd748aa", false, null, null, "Product 18" },
                    { 19, "Sistem", "4.02.2025 11:33:05", null, null, "9db33e62-e486-44eb-b987-7f289bc358d9", false, null, null, "Product 19" },
                    { 20, "Sistem", "4.02.2025 11:33:05", null, null, "55e72c8e-24cb-4438-b8cc-991335a9fc61", false, null, null, "Product 20" },
                    { 21, "Sistem", "4.02.2025 11:33:05", null, null, "6536fee0-8545-4d00-89e2-71cf0b65b134", false, null, null, "Product 21" },
                    { 22, "Sistem", "4.02.2025 11:33:05", null, null, "7fe89e46-a77a-47d9-8790-a8e9c771dd49", false, null, null, "Product 22" },
                    { 23, "Sistem", "4.02.2025 11:33:05", null, null, "4899cd62-2a10-48ad-b359-65dd337bb857", false, null, null, "Product 23" },
                    { 24, "Sistem", "4.02.2025 11:33:05", null, null, "5555822c-a5eb-4773-905a-1d3fc969c5cf", false, null, null, "Product 24" },
                    { 25, "Sistem", "4.02.2025 11:33:05", null, null, "72b1eb23-4257-4561-99cb-32edfa719da2", false, null, null, "Product 25" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_CategoryId",
                table: "CategoryProduct",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "3.02.2025 11:02:54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "3.02.2025 11:02:54");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "5abc6df4-073e-4696-94b9-1bb208ac41d0", "3.02.2025 11:02:54", "AQAAAAIAAYagAAAAEGeUDS2WgaGC14XNnrlnwR7g12thkMNhQO+HaocYXNK/21dTvhk4gVaR2CJyBIJLDw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "3.02.2025 11:02:54", "fd4e3b5b-c37e-4cba-af08-c0c4b1fa59f0" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "3.02.2025 11:02:54", "80a5a144-799e-4e2f-89c2-77b54c0ee825" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "3.02.2025 11:02:54", "24a4bc24-417a-41a0-b797-5165eab9696c" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "3.02.2025 11:02:54", "03934cb1-9865-4fd9-82f6-bc3b8c2f2cc2" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "3.02.2025 11:02:54", "2085318f-83e7-4a9c-9450-b3067697832e" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "3.02.2025 11:02:54", "736d3a95-302c-437b-afb5-be98d2966ddc" });
        }
    }
}
