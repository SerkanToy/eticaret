using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class ratinginit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RatinProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RatinId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatinProduct", x => new { x.Id, x.UserId });
                    table.ForeignKey(
                        name: "FK_RatinProduct_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RatinProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RatinProduct_Ratin_RatinId",
                        column: x => x.RatinId,
                        principalTable: "Ratin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "19.02.2025 10:11:45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "19.02.2025 10:11:45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "d6c6004c-9464-4db9-bbd5-d34727fd0c9b", "19.02.2025 10:11:45", "AQAAAAIAAYagAAAAEKOpqMyHOYghmmWGv1SzWVmd+so5Uk8pc7M3yAEn6hyJDwtk/HBWk0RqYq6f4jXn2A==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "9ed3bf25-b522-4738-87d4-68767d3bb692" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "75b69975-936d-4d2e-8072-ab0a77b82957" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "f06e6aad-17c6-4b4e-90d0-82e697b18a0b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "564c34be-707a-475d-bc50-9d67b951f29d" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "860ce355-5cbd-4a14-93a2-142d887b6904" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "1a6ea34a-bc42-4af0-ae6d-f728ef0f3732" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "28bd5065-73f0-4c6f-895e-ae1efeca4321" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "e11b7dc5-cbfb-43b2-b2ac-daff28582b68" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "908bc6e1-a52c-4078-ba3a-d894f35d816d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "838a8cbf-ae9f-499b-9f1b-cbdf22bb6450" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "f9963a33-3408-4357-85c7-8eede54c2218" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "8868efb6-2d3b-4a86-b336-337778fd30b9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "30ca2d36-c638-446d-841b-17c3a1003482" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "4d7b6c34-f08e-4d41-94eb-24ab0acf7550" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "a256d316-66ee-4b5f-b822-4e0988e353ef" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "54942400-cd92-435e-a353-d96227755a27" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "bf3711cb-c6cf-44a9-a601-e9884b03c526" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "63e894fb-885b-42ae-889a-0d3147b6d649" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "8004f60d-4ac1-4933-8cae-7871985b3d25" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "63be050d-b678-4418-b9ad-117832aa659e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "9a743da1-be6b-4c16-a535-bfedfed4922a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "6a73d407-c950-4ca7-8d5a-4cee1ea870f1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "ec7199db-656e-4f09-b3b9-5965e5ee4b68" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "0c3b2a13-5d58-4356-abad-4502ce611967" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "66085760-166a-4c6d-a6c3-2911bbcae19b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "4c9eaac3-4f3d-4ffd-9050-0f46172a9dba" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "f3f9e91a-cf4a-438e-a0ce-8f98f27e0c91" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "de102abc-dcae-4629-9ccc-dca0eeb9f883" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "8fe99aae-48ec-4a36-860a-8cc5dffecfd7" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "d1a0fede-46c9-43f4-bfc7-889c6d8f0dab" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "19.02.2025 10:11:45", "a5034386-1add-4c3b-9e1e-34c71e79e303" });

            migrationBuilder.InsertData(
                table: "Ratin",
                columns: new[] { "Id", "Rating" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "RatinProduct",
                columns: new[] { "Id", "UserId", "ProductId", "RatinId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 2, 1 },
                    { 3, 1, 3, 1 },
                    { 4, 1, 4, 1 },
                    { 5, 1, 5, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RatinProduct_ProductId",
                table: "RatinProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RatinProduct_RatinId",
                table: "RatinProduct",
                column: "RatinId");

            migrationBuilder.CreateIndex(
                name: "IX_RatinProduct_UserId",
                table: "RatinProduct",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RatinProduct");

            migrationBuilder.DropTable(
                name: "Ratin");

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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "ee7f4956-8289-455e-b2b2-8a71a7144574" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "01d9fd05-c1b9-4af6-ba32-53a75c948e06" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "b51ea7ce-d5bb-402f-afad-f269c596cdf9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "bcd95aab-2bfa-4ae7-a055-06d26e043687" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "ebe520c0-a236-45ef-a259-a9939509ddea" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "2dcf9a54-4205-4632-b095-e9645c20d6d0" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "2fa63099-af84-4c06-b174-f4070f966a53" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "61561ec1-7303-44ad-817a-3c0d81d059a3" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "a148de70-79c0-4edc-94ac-9e20ed3d3e89" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "2b625a10-bae6-45fb-b1f8-be5bef7a8063" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "76c8e0c3-5806-4645-83e7-e30594e58a13" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "4b154d76-6a7e-4f13-b19a-9f1033a13356" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "125c4bad-51a9-40a6-aa39-d00309f06af3" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "1ff615e2-3123-47b5-99f0-5d1758d13c29" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "de584b1b-48af-486f-acfa-43897d34ab8d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "e50e5fd0-e635-42bf-8ffa-6c0f4a1d4b62" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "ab05e4f9-cedf-4e77-b7d0-53daee6dafe7" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "06fec324-2288-4cc7-8e09-74694bd748aa" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "9db33e62-e486-44eb-b987-7f289bc358d9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "55e72c8e-24cb-4438-b8cc-991335a9fc61" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "6536fee0-8545-4d00-89e2-71cf0b65b134" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "7fe89e46-a77a-47d9-8790-a8e9c771dd49" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "4899cd62-2a10-48ad-b359-65dd337bb857" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "5555822c-a5eb-4773-905a-1d3fc969c5cf" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "4.02.2025 11:33:05", "72b1eb23-4257-4561-99cb-32edfa719da2" });
        }
    }
}
