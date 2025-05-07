using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class ColorUpdateThere : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorProduct_Color_ColorsId",
                table: "ColorProduct");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "7.05.2025 09:24:11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "7.05.2025 09:24:11");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "86ef673a-7347-4790-be09-1b943be61159", "7.05.2025 09:24:10", "AQAAAAIAAYagAAAAEJCGS4QP+N5e3rYv8skO3cwrb6oMR63QNDelF9aMmFGLUaOOvei88Fjnrbc2Kql8qw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "42ebe62a-7dab-4763-9eda-7761b323d200" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "b348adba-42a1-490d-8cd5-ebd7ef56c6a3" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "772d8bec-3d46-4129-b431-a36e191f0593" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "40ac2cef-4015-487b-a983-55dea459bc0b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "337834b1-8bec-49c7-bdaa-20c2f7a80c45" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "3bda1106-db5b-4bca-9da3-d20f9f8bce8f" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: "7.05.2025 09:24:10");

            migrationBuilder.InsertData(
                table: "ColorProduct",
                columns: new[] { "Id", "ColorsId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 },
                    { 11, 11, 11 },
                    { 12, 12, 12 },
                    { 13, 13, 13 },
                    { 14, 14, 14 },
                    { 15, 1, 15 },
                    { 16, 2, 16 },
                    { 17, 3, 17 },
                    { 18, 4, 18 },
                    { 19, 5, 19 },
                    { 20, 6, 20 },
                    { 21, 7, 21 },
                    { 22, 8, 22 },
                    { 23, 9, 23 },
                    { 24, 10, 24 },
                    { 25, 11, 25 }
                });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "f13e6582-f8fb-4938-93dd-ea293beb4f72" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "0f5872a8-6e45-4f6d-91af-e00de3719124" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "67dc214a-f16e-452a-98a2-75e55a6c6326" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "82d23c43-c198-4a00-96ac-431663839912" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "0a01dbae-4b93-45cf-8ecd-49649aefd257" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "30e8b8f4-1625-46af-ab29-1baafd4bf3ba" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "13b84f49-394f-42ab-8cd6-d7f06a330bea" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "62233f32-d5e8-494b-bddb-afd4cabd544e" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "81483134-f235-4f79-9c31-305394f04a80" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "fc99baeb-edf8-4d28-8fce-60941e38f232" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "5d36fa02-9231-4dc7-b3c1-a390a26a2726" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "8c74ad88-ea72-480d-85d7-d2988c1f4b17" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "d602d36b-c711-47cd-b6c0-000b0dff9480" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "087a8788-315c-4d05-9067-2594ae2c420e" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "0fcbf943-118a-444a-b0df-9dba3bf2f5ee" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "d087442f-2ea8-4b84-bfca-d214f0e93366" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "1d9d6bda-b474-42a1-ba8a-6425331e352e" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "5626b370-97c3-4a89-ba50-25c7cca6b226" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "51a5a7b4-c8c1-41dd-a2e3-aa9fa0ebc313" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "d5109d9c-d230-49fe-ad01-c794798d388f" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "f64e05d1-4872-4c80-a500-b0dd56cfb0f5" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "a02d4801-2c75-4194-9f4e-02229b0b5d54" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "53fe71a8-1f8e-4677-8ef5-c40a2f2fb969" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "8de4faf1-33d2-40a5-9030-efb7d924b492" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "f82c2ca5-ff3b-4109-9293-9dfef86db812" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "79cb6385-7ba2-44a6-8b3d-3d3a5c634fc9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "193fe865-177b-4c27-8f54-eb05a27b3128" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "f3b21ea2-3f0e-4d0f-8185-09f8923c4294" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "a3ddca51-9a29-41a3-9ee1-07b155d15ca4" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "3d83065d-e213-4211-a781-437216b40f71" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "6997b93e-b7d2-4eab-b15d-a4486c996f6f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "0e0d11a6-3b37-4733-b304-6530c3c57cf2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "da6f933a-63ec-46c1-a681-b1f3de9cb981" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "b1ae4a34-3d57-44ed-bf6c-f1f293c00deb" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "39408dbc-2793-41a1-ad40-d22d0651a962" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "eb2dcdfb-1fb0-4d59-ab04-47161efe77ac" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "eba58189-32a1-42cb-92cb-b06294b5d00d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "f9358342-57f4-4d39-bd7a-2cf33bcdf2b5" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "bf698e23-f2f6-441c-b649-02cc047d0018" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "4d9f9ca1-7e25-4230-b246-444df0af5e3b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "6f9d9059-f65e-4d76-946a-0d4f1b1a0e66" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "b6dcac1f-c645-4e00-b1d7-2f9ff67df19d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "26c1c05a-43a8-4225-adfb-5469189490b4" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "dfdcb0ca-4443-406f-bb93-60be09aa2f1f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "1b59ece6-73f8-4fb6-b945-8bc255c6dd79" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "b9da80e7-f89b-47aa-8a9a-0c48189ec6b1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "4ce388b5-07d4-47e8-9045-490e33916aeb" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "001ce29e-3a58-4963-9678-f6ee0313de3f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "94ac8c25-b61c-440c-9a10-d5007bcc6184" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "f6618f9f-9e45-425d-905a-4adcbc61d420" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "f262bff8-da65-474e-9ec5-11c9106f09b7" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "bb12e5e2-0617-4532-94ba-0ee3a4c4677b" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "85f31e48-ab38-4e2c-bfa8-8980d1823919" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "ae1417e4-14b8-41c8-aa09-5d19c7f33858" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "411b920b-1985-4744-8719-724ca6dd12a3" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:24:10", "a267ef69-2373-40dc-ad6f-11307345ddb8" });

            migrationBuilder.AddForeignKey(
                name: "FK_ColorProduct_Color_ColorsId",
                table: "ColorProduct",
                column: "ColorsId",
                principalTable: "Color",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorProduct_Color_ColorsId",
                table: "ColorProduct");

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "7.05.2025 09:22:00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "7.05.2025 09:22:00");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "d4492310-3889-4a3a-8d02-0f1ae40c1dca", "7.05.2025 09:21:59", "AQAAAAIAAYagAAAAED8bw3pk3mgV/EJ/PvyR1zN1fxFXgccBZ3l/5ha5lModNUkYQ3BKBesV9RcxItPdOw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "2aa3b9e6-7963-461a-b311-9eefda900f53" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "aa2934c4-4b34-4266-91bf-1b8efd505919" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "aa9ec667-5fe0-4505-a4ae-31c250c0dded" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "f69ce78c-9a76-458d-ae60-2aef9a42d722" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "bb3ded81-7fb8-4259-a4c6-087a9ef6fc43" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "01a6fd8f-78cd-4ecd-ab27-78dc41d07807" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: "7.05.2025 09:21:59");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "c92fe481-997f-4c9e-baa4-e0670995fd81" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "bf8f31af-a6f7-4a35-9829-91e6ff46c31b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "613eab25-44cc-4705-9e69-0dcf61e050d3" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "6de065fb-6591-42a9-bc8c-f9ba16bc7f41" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "4f18400f-95a9-4ef0-acaa-050e5092144c" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "21a8acdf-a6df-4d0f-b8e6-b22f6cb5e369" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "7359e55f-e287-4c02-ae0e-1c2c6ede9064" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "55c56f0f-a7a0-4b0d-82a9-94e3a594cb53" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "87f26c0e-7e01-427f-a2c2-d057f4f03152" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "32a1a3b9-1cb0-4090-bb34-6e839672842f" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "9f6185e9-488f-42fa-8603-bfa1ffcbfdb4" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "28fd480b-38c7-4205-9f8d-f1125b5ccecc" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "b2d91a1e-33df-4789-8328-69d8dfcc616a" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "6c1ec5ab-e231-45f1-9529-ce29b5ce2c25" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "2e12e6a2-0d4c-46e5-9657-122dace19660" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "98652d81-b8c5-421d-aeba-f3e4acb23130" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "a6474ff9-9e81-4e61-8ca3-1c9c13feaa47" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "c67a4a5d-801b-4ddb-a58e-df6a05a547f6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "40e88c05-4e51-4d76-ab0b-67c2f478a405" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "c72603ae-6fe3-4b2e-a695-7e58237b02cc" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "1ebef27a-0b25-41ce-a806-91e8cf3b9f6b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "d3107d6e-759b-47af-bd14-5a87632cd842" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "13349c3f-817c-48ad-a5cb-6fd192f41557" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "3fe2504b-7610-40f7-8fa9-569688db599b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "fd338cbf-2a46-4806-a775-8e7c3137e7bc" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "39d287fb-50ab-4a3f-a7f2-b2d5ffe94aa0" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "011eb6d8-d93d-4a6b-b6f9-425c2dcc1b0a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "5724381d-ec20-479f-9e07-5a2ff0cdd339" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "f5bd4e7e-6e39-45d7-9054-44ef395ce64a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "0197b97d-6245-48d8-92df-e4f570d7b01a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "c8524ffc-1e78-4f2a-920b-1a2089ff216b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "33454ccf-73c6-4c73-861a-1758ff773d01" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "f58a8900-6e5a-4590-8fa5-0df034e94331" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "327fe8d0-0f6b-453b-b0c7-80f6be63a920" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "5a55d382-2563-4044-8806-2d1ffab56c0e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "6dd5488f-7eef-4bc1-b2d8-40899f71921f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "7ced163b-1f6e-47c9-8d54-8d5e90c231aa" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "b0492cc0-78c7-481b-9b92-b70ac5aec044" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "72a55412-ae7b-49db-84cf-cc4764fa9561" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "4c69c4fa-8cdc-455d-b779-989fc4d408de" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "7e6ab213-4206-45e5-bb1e-b74f1b6f5dd9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "9a5f88c8-a67e-47e6-9c7f-2d8474267b73" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "3808225e-feaa-41c6-ac75-8eb94d167824" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "ee6d134e-c3a6-42b7-be2d-07937ea00cee" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "9236f5d3-38c8-475f-b541-3dbf8b7bbc1a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "6af2d02f-62f0-448e-ae54-268ec09f2499" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "13994f3c-f2f7-416b-b03c-720673d37aaf" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "d5c06840-fa36-4037-9097-4e0f103e3c16" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "9223d221-ebeb-424f-985c-9e724bd0d40c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "86e8a8db-c3bb-4c57-be5e-78a6bcdbddb6" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "dcc938ac-72f6-48b1-8a7a-c18cf48fe4c6" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "81a5459c-db1b-494b-8b37-4a908b7ee097" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "3a6548ac-88ac-4b4f-aca3-0ef142527028" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "745a9a07-0703-459c-8f84-ba33b221c5a1" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "e3a2633c-7384-4e5f-ba80-6a914b2e69a5" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:21:59", "8578acae-a15a-4042-911c-11bb2f8017b5" });

            migrationBuilder.AddForeignKey(
                name: "FK_ColorProduct_Color_ColorsId",
                table: "ColorProduct",
                column: "ColorsId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
