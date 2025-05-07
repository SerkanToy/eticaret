using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class ColorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColorProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ColorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColorProduct_Color_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "e1e8eb96-d21b-4499-9a22-0ea8f5745622", "7.05.2025 09:10:27", "AQAAAAIAAYagAAAAEL4zetFVW+Nk0+w1GIr4H/q8Xo0Gph4YeBYskMWsommOgFxqZMysofdgxjlFzrPcmg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "e8cf96b2-6ec0-4ce3-80ea-7ec1c0440e99" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "38208ec2-29ed-4da2-865a-61bfad61787c" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "aaac330e-44a6-4302-9c2b-fadd94201276" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "8831dc0e-1aaa-4806-ba5e-80208ec933e9" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "8d1eeafe-bcba-4d37-9ab5-5169b9b57fd1" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "30a80c30-4ff7-47b7-b92d-84b93b163d2a" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: "7.05.2025 09:10:27");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "49db58ea-d6b0-434c-9685-398c6a48e146" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "aced62cd-6679-4170-a3db-c34dae6546e8" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "3f1a2178-6ee3-45e0-94ec-0f9014944940" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "45dafceb-dff6-4af9-b431-fd4df28d9d28" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "864cf134-c469-44e7-87f9-c9d454460561" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "7b813561-bda0-4e21-8225-80ebb32ad9f3" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "b4e07e8d-c921-40ca-aa00-52fd7d161783" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "0fed65e5-42c2-4f7b-93b3-cca80cd6f89c" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "ae11db5c-3a09-4b50-9657-b16b7c18f2f6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "8ffe3f38-017e-4b85-9da1-0c6bf61ab087" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "aba6e835-7188-4b31-95c2-c2df8f8066ee" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "ddbe187c-f67f-4990-8d30-fb027f8551a4" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "7a310ec6-73dc-4b7f-b141-5f42fe698ea9" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "38195e89-fed4-4fdf-83cc-6a72fa9111d6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "0a9ab68c-1777-4ad7-80df-e22467fd0654" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "6ee908fc-df80-4a29-a827-ba99c2510609" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "a0c186e6-395d-4ff3-9bb3-dc5fb5dad639" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "6204ab8e-f8c2-4431-b3bd-24c5bfac8343" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "6ccd6898-3820-4903-a5f6-afb450eeb1bb" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "92fc20c9-f911-4df5-9fc6-bc3c048d75a4" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "b86bfed1-539a-490b-a332-8919ced60b9b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "b8c00bbc-049a-4e1a-bd2c-5d735cf93394" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "b8f3ddd4-4fa6-4a26-a75c-b58467af26e5" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "d3ad1c16-32f1-4bb9-a2ba-d2b17e1e1559" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "8db4775b-0a35-4a4d-9cf1-4f8b1dd5d417" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "8d6f0301-a124-4459-8223-1bb5f4d59fe9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "c4ae56a7-bcaa-4a8c-b672-65e62a1a13bd" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "816380c2-41a4-45d3-a313-dc738ae86a01" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "d4379fce-88df-4797-9d4a-739c90924b74" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "a07e754f-7ccb-45bc-b7b7-161c2c7e0055" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "63ed6661-725c-448f-a3ba-ea8a5a3503e4" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "2bf1515f-4071-4f40-97b1-01db4ea391f7" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "8f07f5e8-083c-4a52-98b4-42afd90aac2e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "cd8a4946-4389-41a1-8d17-c37652ba5b9e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "1d1ba857-7cc8-4417-88c3-785e0ab36fd8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "eab47921-970f-4266-8451-119fe45c102e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "e15ed395-2e32-44b1-9893-d974773f45aa" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "2d7632ae-83ea-4dc3-8264-62760778ca06" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "c8948268-d180-4bb4-8899-b6749c750f8a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "debb82a9-8898-4ee6-b527-74739b3dcecc" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "b4c392f7-6a62-41dd-9d03-249cca3d1e88" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "548f4e71-f483-49cb-b842-baea3b534fb6" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "683f4a76-ebd1-438c-a6bd-25dc1a767f60" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "2ae8084d-db67-47b7-b036-0e66231362d9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "6f49c49b-6170-44b4-8912-406a0eff8ace" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "33b1c1d3-2d73-478a-8c2e-9fb5a25194b9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "75625d50-1e0f-4bfd-b324-ca6394575d24" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "06187949-6679-4e69-a511-7bb86b1c88ee" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "8307928b-2979-4916-a0c8-a7cc9ca6ea01" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "6b0137a0-e356-41f9-93ef-14406a3aa6cc" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "26dff2a4-225d-422d-ac4b-2e85a884e95d" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "8ca4b859-e300-42bd-825e-14f214e15a6b" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "a2871070-1efd-4801-9299-5bf67adbc276" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "1b6eca32-55bb-42cb-bfe3-c82de6e611c3" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "f8d29dd6-bf27-449a-ac35-229332a01f12" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:10:27", "ccc30625-f11b-46f7-8719-ffcce7b360c4" });

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ColorsId",
                table: "ColorProduct",
                column: "ColorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ProductId",
                table: "ColorProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "57930619-6c1a-4d92-b20a-67404ee1e706", "6.05.2025 11:51:27", "AQAAAAIAAYagAAAAENZ2+Y0+yRG8XaXdwA4jRYSGqd6JvbCGXKnNSCGXfN9tjeuVndLpbL2cE+jMxPLTpw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "6033b36c-c5ad-428a-b0df-44199c028e41" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "c4d82674-9d07-4846-9b2a-cfad5aeeca31" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "00b5301c-7342-4488-94ca-0ab512f23dc4" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "fb473d39-e313-402f-bf07-7f935c7ed2db" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "a7823044-20cb-4a38-ba33-f05012d6bf4a" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "0ff08d6b-20e5-4866-820e-83118f18cf28" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: "6.05.2025 11:51:27");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "08e6f1bd-a92c-4c19-a2dc-71e2eafeb5a1" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "f75fab91-70f4-4c2a-ac4a-75b2ce15ffbd" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "08559bf4-f18e-4604-8f5f-30f0f478bde1" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "7c986d67-5a75-4bcd-809a-5b76ae8e9010" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "34123fdd-45f4-4128-a65d-74d1cf2d2a5d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "5355d673-6da8-4062-aa00-355bfb52e6eb" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "00fe5844-b563-4870-aa2e-e3f5e3bc9d85" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "6143bb64-7ec1-4093-8d3c-412811c16d54" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "825ec25f-8b55-48d3-9152-d1bc4cac6606" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "4c6991b4-b4d2-43fc-be56-dd9b55452348" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "1cb52f79-3f18-48cf-8d5b-1a655eac512f" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "0a974e85-faeb-40e1-93d4-57e6a640e472" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "b2999f5a-9377-4080-adef-450bc79575bc" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "5a5975e9-0003-4e18-b03e-6e9ad87efdd3" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "53915e4a-2467-428b-891d-92df16a1a69a" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "6b0c5bb2-d741-441b-b54e-78d86a43c785" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "9658420c-cfc5-4ee2-ab08-f6bafe44786d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "a5cf9ca9-0fd3-45ed-aa50-e29c75379732" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "840311a8-d812-49f2-bbb6-20041c820826" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "18334b8b-266a-44db-a781-5c3f769c9e21" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "c50ab5fc-3880-4210-9ed3-8c4c0bae86cd" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "4ee2e9ef-cb41-4344-9188-d0587f421558" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "b891cbe9-2773-41a7-8050-81e149b9a14e" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "87e578ed-2620-496f-b2a5-20f842e773ab" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "0730423b-c183-4451-8cba-59fb3a554444" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "385a00d1-4572-4406-b99e-b4dedd874831" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "1a701da0-22cf-4cee-bb2c-14c489ea874a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "260599bf-4aea-405b-ab64-2547f664c077" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "6a70abda-546e-45fe-8c4a-ea1e1742ee27" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "a3717627-ef8e-4912-832d-908016ef99ef" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "ce280fe4-f2b2-45e9-8dd8-4e5a6c07e630" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "3fb6328a-6eaf-4216-8e27-4665c464f280" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "9fd8ac6a-f08e-4451-8585-2680c0841de6" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "21cbe7eb-1e61-41b0-8858-2c4ce5737cba" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "3648ea1d-5422-4747-a153-d1528e87135e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "148727a4-6b16-4d5d-b4c7-fefcf500d8b8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "034f27b9-b0ca-47c7-a80b-c63e7844f52d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "1b925228-390d-4a44-ab67-1f7f2a065a04" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "357bceb8-af4c-48b2-bab5-c290e44a29ad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "ee4a4d62-fbad-4c2f-b440-c94614326183" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "93f4654e-a234-42d7-a911-4179e1e6863b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "2b05ecd7-1d29-444a-9452-13246b61c050" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "a0259984-19ed-4dca-96b4-27802f7581ad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "f8f20e88-dcfd-4534-8d60-b7ccd9736610" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "c982c1dd-1244-4b16-bb48-39a826356a74" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "b14e4502-441c-4d9e-8fa2-0e4661e753d7" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "b28b756a-87b4-426f-933f-549a3c8bef73" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "5ba29c62-b2de-4598-a7e6-77f781b3533f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "df50017d-3f4c-495c-ba2d-b9ac6d3a3051" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "421295d1-d991-4116-96b7-a7c3863deca4" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "ac73a68b-53a1-45af-8b83-52d4b855a3b4" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "ab74052e-0944-4d9f-925f-a7bc5b458a8b" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "e3160c83-e6c7-4882-9b88-98dfc065fad6" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "b5e205ca-b948-4a18-9359-cfca24033e91" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "06e10082-aac4-4a78-b5c6-8c235ff3517f" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:51:27", "7dd6836e-c54a-40b2-9b02-a529369f26d8" });
        }
    }
}
