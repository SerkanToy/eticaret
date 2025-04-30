using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class IsShowcase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsShowcase",
                table: "Image",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "30.04.2025 10:36:26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "30.04.2025 10:36:26");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "567721ce-b27d-489a-aba3-8e74c06ee508", "30.04.2025 10:36:26", "AQAAAAIAAYagAAAAEEss27dhZaL7kJx2JvSn9zAuNvscqVbC+rSP3FR4+WN90Xj5dyOZd1LgbDe5je7fdw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "815ae1d8-a8e4-4866-b69b-aa5ecdc45b5c" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "dabcf1a0-0e51-49a0-9562-989f415ff061" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "66827810-cc82-4ea1-aa95-bef857134c43" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "6c0005a9-e36a-4bce-9c6c-5735984d5034" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "6c4b22f4-8405-4bfb-8ca6-c5e45ae89d6f" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "ecac23f9-facb-42d9-a7dd-e22d97b930e0" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "8c6b5024-ae4b-48f7-84e1-2cad0d0e2bb2", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "03418d09-6b05-41fc-a5c9-4fcd8b3ed177", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "1a810f71-33f6-4213-bcb2-435ba638493a", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "4a28f77e-e5a8-4f1b-8989-b0068e5c8783", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "8b3eab24-2c3c-4a00-8e96-412c136dfbac", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "7201adf2-48dd-4d61-8dce-c7f04bc9156d", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "d645a356-cb52-4018-ad01-655070503a10", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "18090cd8-e110-4537-b4b4-ffd8880870e7", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "cd454730-afb6-4c58-8fd4-2523611ee152", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "2f2a673c-d91d-414c-b078-0c942b6244a0", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "9b46a78e-e590-40ad-835e-49c4d4c9f765", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "462eede5-4199-4ea8-836c-54ccef16b517", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "5dd3fab8-07b0-46ac-9939-fbfe575efc3e", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "a58500ac-6202-4486-9a88-6526bcfa0748", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "c023ee79-f392-4e3c-a085-08c7dc02bfc6", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "5a6ef460-7943-4491-8be5-d2b8f3a92e39", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "6aa155b1-f98b-4d82-9ed3-c31f2f23407b", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "81542d4f-5fa8-4a78-a8fc-f70bf68fd523", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "53039dbd-24ab-4e63-868c-ed84860d13ba", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "f0c6e84b-1461-4a98-8979-0b21b9a3287e", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "22128d18-cef5-4c2f-93a2-6d2df949500d", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "17b27558-1782-4d32-9386-9cbaa9312329", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "f8c8c9d1-ef34-4767-b448-84c86fce852c", true });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag", "IsShowcase" },
                values: new object[] { "30.04.2025 10:36:26", "a9591a4c-052a-4129-9f2c-6f126f399f29", true });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "IsShowcase", "ModifiedBy", "ModifiedDate", "Name", "ProductId" },
                values: new object[,]
                {
                    { 25, "Sistem", "30.04.2025 10:36:26", null, null, "2bc7fa96-ca6b-415d-a358-0dc444eb7032", false, false, null, null, "5.jpg", 13 },
                    { 26, "Sistem", "30.04.2025 10:36:26", null, null, "c244b55c-1004-4c86-9ce6-d8eaffeb8a63", false, false, null, null, "back-5.jpg", 13 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "0fa9a7cb-1069-4d7e-a99c-8f083c5e38ab" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "ca1ad650-e006-4ee7-822e-417d6a4c01f8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "31aead4b-45df-44bd-aeae-5c3ecd2ea0a0" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "d298a89e-56d1-4e1d-957f-5b7fd508ae11" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "b2c33494-947f-4849-9762-62a7aec522bf" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "c433a84d-cc28-49cb-9577-c7d136e67342" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "36ad9ecb-e7ea-4e47-be92-509346cdcd89" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "f70af96c-c44a-488b-94b5-ad09284ab88c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "2b7bc81e-052b-4295-adb8-bbefd137f044" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "62e41dae-4062-4234-8842-b699ef4626e5" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "41f40940-d0df-4d3c-9c1b-2dbdae600801" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "4f98d893-e1de-4774-8ddd-5754b51a5105" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "ee705c43-6a67-4a1f-a5ce-c8bac8e4c140" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "6724fe44-c514-4755-a083-b7a839efd0e1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "b5e3d6c0-673d-46b2-a406-28da0d24840e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "a6ed95b0-00b6-4d4d-9829-4c3f7ed6e53e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "1cffb9c8-d534-497f-a149-4595a8289723" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "3cf767c5-e03e-44d6-b51e-ed4481516a1f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "4c4efd9b-ac94-46f0-8d00-c18df33be922" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "b76316f2-7b29-4845-bc98-49e7f7c1856c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "183cc781-5335-4e9f-a251-e506f14ce2e9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "5e874de2-a6ff-4d14-a477-2bd08eba166e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "2c6a8f6c-66a9-4657-9755-b2720ad4d8e2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "d2e079f8-c79d-41f2-826b-9fa15c848f09" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "20a5512a-2a78-4c00-8df1-1060be7145d8" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "52286a45-3ff2-4c82-9c7f-7fd9abfba470" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "130aa99a-8a8f-424c-a832-18885da37c16" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "02a61549-4d20-434b-83aa-ef2ddb36430a" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "422d289b-252a-4d89-988e-2553848031ef" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "f7aefa05-90bb-4c1b-8996-1d9bee533b19" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "30.04.2025 10:36:26", "54c33b62-a2f5-411b-8270-84bb1f4d5e8c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DropColumn(
                name: "IsShowcase",
                table: "Image");

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

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "c303be36-31bc-4935-8ea2-eff202ee949b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "0d018043-5420-476b-a2ea-88c525a6ab4a" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "1c4561a2-e269-4b32-844f-70f2e119b8d5" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "e7e1303b-6ab6-4452-81be-9f3f5690539d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "8cfce3ae-d58e-4a20-a05a-e3ed156f082c" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "b877f04c-cbea-4703-ac95-80b6f6d2f233" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "f155223e-1307-4b0e-97f0-55c2cf8c9782" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "494cab9c-9c6b-4121-b7d9-1fbb3918c4fa" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "b76850d1-b6b5-4866-bf32-c2a66dc60702" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "52bf8e97-a5d4-4cf9-8979-115292d8e172" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "10060094-7d27-4d8b-8f2c-d06de6955949" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "1ce5669a-fa21-4aeb-a439-f9c73a9debed" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "ead8438e-17a9-4639-af2d-a5373ccb64f3" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "65837180-d170-488a-906e-938934b50e36" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "9dc1a58a-702c-45db-a7dc-2ce945969d21" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "a9dc98d6-5647-40d1-b4c7-e12542d21175" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "1bfbf368-b863-4519-83d8-b776ddeb116e" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "8e7bb709-1010-4701-933f-d02232e16b11" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "8bd055b4-0568-4b42-a3b4-65259542c1ee" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "13161aed-d159-4695-9947-0d5b6ffe3be5" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "6a4833b6-fa64-40e0-a7f0-5f29b7b12ab5" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "a8214aeb-e766-4dc2-94f8-1641b9d303f4" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "ffbe178e-7272-402a-8e33-1e7b10bd9ec0" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "19b8b42b-f02e-479c-bc64-253328b4f555" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "2502f84a-20f6-49ce-9def-b921b48209fa" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "c08f0178-bcdb-4254-856e-fb266180046a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "19624227-4883-4f8d-a239-13be1435f755" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "0d464da5-6613-4df2-8ec9-bf34e9bba254" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "3e4be1cd-521c-4d05-bc1e-b0523be0fda6" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "9b63c5ea-53aa-4e1e-a4b3-05b7ccea684c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "dfde5f54-8653-44a1-a439-13cd9b84910a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "299ed704-5bad-4b45-8fbd-e159bd903b98" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "fed1a990-9ff6-485b-b200-045e0279c16e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "d0b23b0c-41ae-4c72-8e99-3523a45e6ced" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "38cd1737-c217-4be8-b078-a7422a1e5aa1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "5f41312b-3d79-4582-9aac-9adb75df4fac" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "aaf90d59-1cd2-42b4-a344-3103c1900494" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "14d8c10f-c150-4e22-81e6-3bc63048f052" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "7de36f1a-a820-4613-b8cb-9906cd086104" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "3dfebc8b-4ef5-4c2b-a691-acbd04cfff2b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "84a93fe0-095d-4636-ba6b-17188b7d5b9e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "e8fee87c-bbf9-4ade-a264-c00ff5406ed2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "384aee77-3949-46b1-bebc-ce00f3f74f9c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "debe6cc5-0c2c-48e1-8f0d-5774ff48c78f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "019f454e-b866-4c9c-be94-75e7e094f5d2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "eb28f0dd-2776-4f57-b75f-7468f21df5ab" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "83d2a365-d22e-4996-9bc4-45490d0545fa" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "3936c4ec-bf3b-4508-b271-4b574bcea8da" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "f1aaf3f8-cfa6-438e-bf61-222463f5db86" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "7453676d-2616-4304-969c-85552022afe9" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "ad2ffe1b-fa28-4332-ac3e-e55071d278ab" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "7ee5c384-a76b-45dd-bac5-4cc63d9598b7" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "7f83454b-a25c-49fb-b18d-995e44ac4dc5" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "2776ea96-22a3-452e-82f1-5194895f5981" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "29.04.2025 11:55:30", "54357f8a-02fd-408d-8f04-e3b7701d7367" });
        }
    }
}
