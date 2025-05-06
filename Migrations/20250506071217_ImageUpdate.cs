using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class ImageUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26);

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
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "21bcb138-7f06-4e4f-b48f-f865eed58433", true, 2 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "136f4779-7782-480b-8d79-b23c513fe22c", 3 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "db7939c8-8eee-4674-b999-b0f91ed4eea4", true, 4 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "f6b99cf1-f759-445e-8dbb-03950c4614f7", 5 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "6d393860-ee44-421c-b592-3709d3ff0072", true, 6 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "1333dd64-840d-4277-80de-850319c4801a", 7 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "f0eef8b7-8455-47f3-966c-9fa6d3565ea3", true, 8 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "ae96e5b0-8993-4558-afda-b836fad3700b", 9 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "04520387-052b-4fa9-98a4-eb24f7b5c434", true, 10 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "70be8e1d-6ac1-4e41-a631-8f340450d82d", 11 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "5500975d-7b5b-4184-8e2e-05fb13ab2aa2", true, 12 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "f404c75a-598a-4d3e-987f-df8c18bdd0af", 13 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "dda39252-4901-448a-8a1d-10ce13f0f3e6", true, 14 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "906d65ea-3b92-4c53-9dbd-491187c38e41", 14 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "e29eb424-dc40-4b93-b221-c44b8b68b0ec", true, 16 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "664aefb2-28d8-4058-a8fa-1d984fe79a16", 17 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "bc87d8b3-9ca1-442e-b7db-8644302111ad", true, 18 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "63a84fec-0b71-4856-b8b8-ffefcc23e53d", 19 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "ebc8eb85-b030-465c-9c76-a3a116124bd4", 20 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "ee8d712c-e11f-40b2-b877-6603e98f6b1a", 21 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "849e1656-1c9a-4716-b460-c48d94e505fe", 22 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "4b37a23f-adc0-43c9-b4da-26d160a363bc", 23 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "588256c0-49a0-45be-9c2e-bb2230e0e6dd", 24 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "6.05.2025 10:12:16", "51b1ffc6-50f7-4513-ab4f-acbdaa1b9cf4", 25 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "1be5f909-ab48-47f1-b4d1-15b8b206b178", false, 1 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "53d106f3-8251-434e-bb81-e0de9f7dffec", 2 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "8b749cec-2d43-470b-a67a-35451ced5238", false, 2 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "3d38b2a5-3e4c-4667-a143-29bab7cf37f9", 3 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "27184ff1-8c85-418b-99cb-126bc11b9d25", false, 3 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "adb324c2-b5b3-4ba8-91b9-945c936a3aa6", 4 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "740a2807-30c6-49d9-8b47-7b71d0d56585", false, 4 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "54c2d409-1038-4c36-bd2f-d0c3e1915baf", 5 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "5955aaf3-d77e-4917-a41b-ff46ba09fc8e", false, 5 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "c1b0d7db-731b-4daa-818e-f324ed7b5752", 6 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "f79c677a-5f50-4a1a-857a-438efb789023", false, 6 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "358c50c6-7baa-4437-8e8e-d8bbb202bc1c", 7 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "d08068a5-d58f-4eec-842d-30973f58bda2", false, 7 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "4833eb88-e748-4dd3-b66a-6ee973fb572b", 8 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "8ef2c8a4-2c2b-4a64-a844-ad3f8edcc373", false, 8 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "8e64e0e0-2886-459b-8e2c-45c84ba574a6", 9 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag", "IsShowcase", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "144ae2a7-343c-4e2e-9da6-c34a1af7b981", false, 9 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "e5e05781-79db-4ec0-8ef2-8233fe15f94f", 10 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "7ff96cdf-2cc4-4627-9428-4058b8de7796", 10 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "824a3df5-b025-453c-9cd5-f91e6ada95db", 11 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "74ca43f9-76c1-4c6b-82e6-390022a2f5bd", 11 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "abdb97df-1c2d-4f81-b00a-37fbc5efadb7", 12 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "881d616a-8a0d-4a26-aea9-c37ecb00cd2b", 12 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag", "ProductId" },
                values: new object[] { "5.05.2025 15:15:28", "053e90d2-99b3-4b2d-bec3-e2109d7fea9b", 13 });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "IsShowcase", "ModifiedBy", "ModifiedDate", "Name", "ProductId" },
                values: new object[] { 26, "Sistem", "5.05.2025 15:15:28", null, null, "3e2adda5-2c9e-4d9b-b698-ae41e31a05f5", false, false, null, null, "back-5.jpg", 13 });

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
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "93f6af2c-0a83-4a1e-a2bf-18459ea49018" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "26c090f2-7be5-4993-9cd6-4e4e91f3eda0" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "401be6ee-b65d-4925-bac0-9ae0149aae48" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "862e63cc-3be4-48d8-a55f-cb7e482a997a" });

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
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "60c77f46-0a0f-44e6-84ec-6b268c6c2275" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "c8a19b51-f639-4a79-bd1e-3b8de7c4f3ee" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "ff12aab0-4e99-48b6-b9e7-1c0a79de964c" });

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
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "7b73f0fa-713f-42f3-aa35-9901324d2457" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "a63ba7d8-9b35-478d-a5e8-c164c050271b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "c6bbb83d-023d-44ae-ab78-62830e688651" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "79f7670a-34f8-4c97-8b5c-814dd6299256" });

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
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "b737d950-7cdf-40a8-a6f0-26fe60479be6" });

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
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "295c0d8e-1252-418a-9ea3-7e8d41630e8f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "2188e7cd-afe6-4491-8322-1036cecaa23c" });

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
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "eca6cc05-9692-4a84-9bb2-088b0b757533" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "67f874ed-86a9-4fde-96da-569cf3266a63" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "5.05.2025 15:15:28", "b465e528-fd80-4379-ac8a-7a890eebd489" });
        }
    }
}
