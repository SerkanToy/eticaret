using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class initCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
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
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Sistem", "3.02.2025 11:02:54", null, null, "fd4e3b5b-c37e-4cba-af08-c0c4b1fa59f0", false, null, null, "Category 1" },
                    { 2, "Sistem", "3.02.2025 11:02:54", null, null, "80a5a144-799e-4e2f-89c2-77b54c0ee825", false, null, null, "Category 2" },
                    { 3, "Sistem", "3.02.2025 11:02:54", null, null, "24a4bc24-417a-41a0-b797-5165eab9696c", false, null, null, "Category 3" },
                    { 4, "Sistem", "3.02.2025 11:02:54", null, null, "03934cb1-9865-4fd9-82f6-bc3b8c2f2cc2", false, null, null, "Category 4" },
                    { 5, "Sistem", "3.02.2025 11:02:54", null, null, "2085318f-83e7-4a9c-9450-b3067697832e", false, null, null, "Category 5" },
                    { 6, "Sistem", "3.02.2025 11:02:54", null, null, "736d3a95-302c-437b-afb5-be98d2966ddc", false, null, null, "Category 6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

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
    }
}
