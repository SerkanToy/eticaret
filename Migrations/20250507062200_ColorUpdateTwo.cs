using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class ColorUpdateTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ColorProduct");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ColorProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "3ea67c1d-a723-453e-9838-ec39b8b2d313", "7.05.2025 09:19:20", "AQAAAAIAAYagAAAAEL1I9F+WzXcHSCi/hfC6omg3nAErRvF6mKnATm9P+SkFy/7gmSqv1V7ZtvNwtTrWaw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "42d60b11-9830-4ebc-ae44-afb663b8b6bf" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "7b57eaea-0569-4962-a483-63363ed17335" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "556ad4ea-5135-4890-9632-3306d46ee8ac" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "c9eed49e-dbcd-4756-b365-879a97b4bc89" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "a387874f-09c4-4056-917a-ab41504f4464" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "3c89c882-631b-43ea-8e39-21d4d2746472" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: "7.05.2025 09:19:20");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "1956a960-9cb4-4997-afe6-5a6e348c3c61" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "9603a385-25f7-40cd-a99d-5421091eedaf" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "a5dc95b2-3c29-48df-83d7-957ff02e7c23" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "9492b575-a259-437a-b0fe-58d5ad6795e2" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "318b7eb6-1efa-44a2-b7c5-0c4a138a4692" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "40987d70-48ae-4ad0-9c01-36ec77694478" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "fb145044-7200-4a3b-9dd1-a13075437b80" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "b4b97e61-73f2-439f-8668-8234b3901df2" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "a58e328f-2334-42f4-8f0d-e639c8672042" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "cbd1c13f-f761-4a89-af06-0deea57b9ce6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "6c7b174c-8fb6-4da8-afd0-e959a36e568d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "3cf33a70-e7b1-4006-8656-17a78a7f0783" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "5a035bf4-de78-459b-8855-9d06d049ad03" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "3e538ff1-7063-4db5-932c-f3a7ccc990a5" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "700a28fb-fe98-4c0d-bb02-4458f8b45614" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "50e6bd61-ac1c-472e-ac8c-50b4f7f8f509" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "eb0ca6c3-6abf-4108-8af0-8ce7363a1e33" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "80d030f7-7e8a-456f-9915-47379c689955" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "3e4b1edf-2ae1-49bd-9398-067150697148" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "62d49084-33d3-446d-88d2-deca1aa0c546" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "917dec44-d404-4f3b-a415-cb24998414a2" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "347f390e-995a-445d-b003-c5e5b7042c47" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "35c5f7d2-96e3-4994-bd43-3d17fb22c274" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "8ce833ff-973a-4a24-b4a3-09257cee749b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "7840e614-bd8f-45fa-bd1f-311c004a8984" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "d508e459-07e0-4e7a-8a2c-ecc456bbfa7f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "88bc5266-65c4-48a3-b03f-1b2fed8b8dc3" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "ff2b3f96-95d5-4641-a266-141c90e2ec4b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "eabff08e-6bee-4e57-adaa-42270ea01054" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "d358519c-1ade-4ba2-b768-447f7bb7e73e" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "ddef72e6-574d-49af-8cd1-38b04ca3a8ca" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "a38ee0be-3d77-46da-b704-7349215e73f0" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "9c147f86-f4c5-4029-900c-c693f8996e70" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "19fce22b-6401-46c8-afd5-44e3d470a2d9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "a85f2bc3-621b-421c-91dd-1baba5342bf0" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "ab9c4193-dc4c-4ab2-8ab9-037309da9764" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "8f4fa597-a43c-4857-a03d-9139b7ab02d2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "e476e7bd-af55-4f1e-8f72-37b172fc17ad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "2311986b-278b-49ba-b5a0-d078237a6809" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "ddc68c2e-b9fa-4a2b-b4c1-484b99b4d09b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "97c6dbe4-aa2f-4675-a527-4be619a7e8b6" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "acc047a5-dfd8-4598-9f34-1d9bf1244752" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "8b9ccec3-95f7-4858-b853-3cad75d73439" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "6596a80b-9efe-4971-be82-687201e84e2f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "98466fdb-ca43-4bd2-b7d4-68b22ea7eb7c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "aec57b29-4c53-415c-abf8-4e9117038878" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "127a8b0d-9f16-475c-83f6-9fa4450891d1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "4aa3adf7-e0c2-42df-945b-368bc188d2f8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "06c997e3-7ae3-4633-b48d-ad24164ea1dc" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "5dac62be-8de9-4be3-ac04-032904d23a59" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "600166c3-627b-4844-9ec3-3bc4dd660720" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "6dcf61bd-3f03-45d9-a0c5-f9194ac80b6d" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "39c9b13c-b4df-459f-b9f6-41d3fd1f902a" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "e8e34842-89f8-4a52-98c8-85bead545904" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "8383427a-ea21-4b2d-b01c-0b66b1f10a07" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "7.05.2025 09:19:20", "59303c1e-7a61-44c1-ab70-f420b3a21eea" });
        }
    }
}
