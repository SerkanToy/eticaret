using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class RattingAVG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RatinAVG",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "27.02.2025 10:58:19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "27.02.2025 10:58:19");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "ece0da4c-5a62-4f75-8916-e41626cdd023", "27.02.2025 10:58:19", "AQAAAAIAAYagAAAAEHoxZbBS89mhTTdoIc4wV0QWf0V345xWbxcZTQ0PeXLkwJciPIgG3Ad3T3/zoxRJUg==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "27.02.2025 10:58:19", "20d549cd-ddc7-4f88-9102-5db8e516fae3" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "27.02.2025 10:58:19", "d05ff479-fc75-42a5-a709-2fc0109bf3af" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "27.02.2025 10:58:19", "a2c188ea-62c0-46dc-a680-244eb27ddbc6" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "27.02.2025 10:58:19", "1f7efc10-62ea-4320-93da-9f9faaa4c000" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "27.02.2025 10:58:19", "51044383-4606-41da-a79e-23dc08b81f21" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "27.02.2025 10:58:19", "2e2c3fba-5a8e-453a-a3ba-b0963c5ed16f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "75f45653-6483-4ae4-acd9-bab45f5c359d", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "0bb94b8c-538a-4502-af3f-5e06e1a36511", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "7962b9b1-7653-4502-8a9a-09129e6334dc", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "679aa956-9b49-4d3d-bc68-d1d13964bff3", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "2e775b79-c12f-487b-b7fc-4848ce3b2f43", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "6c359dcb-3843-43e0-8a53-d1ca1cf1ce03", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "dcf2de4c-46b7-4dee-a8de-8606f284ae8c", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "6e356d4f-f33c-4d66-8518-e4803091e53b", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "8e611357-58ed-45f3-98ed-706fd6e0ceec", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "f7f26eb1-fa27-4015-9f5b-55508a53e729", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "f91605d1-ba11-40f0-9fb3-33c1020f0e9e", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "ba8a4e82-356e-4eea-a754-0997b755b23f", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "eb5074f7-7377-4cad-9a2e-8890cb9286c9", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "89c1b77e-18a0-4dc8-a485-e09b6311585f", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "0a3885e8-9f59-48a7-a46b-2cd6178c01a9", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "74f237b6-5f81-422c-b903-c6ad38d3a83a", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "af79fb92-cf72-4e02-9d0a-b94ec3487213", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "3ae442ae-675e-41a9-94a3-ca5ffb516b69", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "b32ac3e0-186b-4f1c-a161-aaa4606358af", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "3fdf56d7-2ca1-4cac-8dba-4547f0529efd", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "78c57da5-aada-4d92-bdf6-f5afc33356e0", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "f1f65cc5-4a9a-4204-acdc-2f03311431f8", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "939a5a36-d00d-46bf-8d64-16cc40edff40", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "f8fdf6f5-2779-41c7-8cbe-8badb8af5a4d", 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag", "RatinAVG" },
                values: new object[] { "27.02.2025 10:58:19", "a58d8cf4-64a3-4f52-970b-6bc3927b37af", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RatinAVG",
                table: "Product");

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
        }
    }
}
