using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class initOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TC",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "3.02.2025 10:09:39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "3.02.2025 10:09:39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "609b80af-0105-4218-bf37-6b3f10c1dfa8", "3.02.2025 10:09:39", "AQAAAAIAAYagAAAAEOEW29lHS5PFVrBDo+BINDU4zVxm6/PE85hEhjvdGTwSGFwSPsPrgszNY7xJcfwZzQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TC",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "15.01.2025 16:09:50");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "15.01.2025 16:09:50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "0357714e-f232-452c-9e87-15bc2d3c7f14", "15.01.2025 16:09:49", "AQAAAAIAAYagAAAAEPtG3UJVhzLE34kOKt4POvv/TAc551g06OQ3H3FQEbeC04rEG/3mbIa86td7MvBvzw==" });
        }
    }
}
