using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
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
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

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
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatinAVG = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_SubCategory_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "924B836D-B087-4D37-A52D-210ABD72CD96", "Sistem", "19.03.2025 16:25:40", null, null, "46D16588-9420-4F85-A768-D21419075284", false, null, null, "superuser", "SUPERUSER" },
                    { 2, "232D9C58-01CE-466A-90D0-EB7039C75465", "Sistem", "19.03.2025 16:25:40", null, null, "70449BCD-A6DC-4601-867E-35AD80657B28", false, null, null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Email", "EmailConfirmed", "Flag", "IsDeleted", "IsLocked", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedDate", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SurName", "TC", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "4bc88bbf-c939-4c41-824e-545b300f51c5", "Sistem", "19.03.2025 16:25:40", null, null, "stoy@windowslive.com", false, "D90E65E6-9611-4B5F-9F24-BBD468398D51", false, false, false, null, null, null, "Serkan", "STOY@WINDOWSLIVE.COM", "STOY", "AQAAAAIAAYagAAAAEAYzpp26IgUPCXNPQWsGIt+LpzWs8wqvd1fKNI+8x6I/3wWfDmkszPHbaAzxj3oEog==", "0(533) 656 30 95", false, "63742240-5787-4E6A-8AE2-FE8BA5381630", "TOY", "28301227926", false, "stoy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Sistem", "19.03.2025 16:25:40", null, null, "3f612125-22af-45b1-80fe-d2caf9eeb8c7", false, null, null, "Category 1" },
                    { 2, "Sistem", "19.03.2025 16:25:40", null, null, "8bc16f85-3ec9-46d9-9644-89b4860a1e22", false, null, null, "Category 2" },
                    { 3, "Sistem", "19.03.2025 16:25:40", null, null, "c049463a-7f16-4ad8-8a43-ee61d540c796", false, null, null, "Category 3" },
                    { 4, "Sistem", "19.03.2025 16:25:40", null, null, "b91f8ba8-c462-424a-bb65-2bf9c59a6502", false, null, null, "Category 4" },
                    { 5, "Sistem", "19.03.2025 16:25:40", null, null, "94b2f655-6a06-4a03-9032-fa8141ccbd90", false, null, null, "Category 5" },
                    { 6, "Sistem", "19.03.2025 16:25:40", null, null, "0684d5d7-7cb3-4448-a8a7-95ef05bc7b19", false, null, null, "Category 6" }
                });

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "CategoryId", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Sistem", "19.03.2025 16:25:40", null, null, "e07be7df-2d4d-46df-b212-9ae10826f597", false, null, null, "SubCategory 1" },
                    { 2, 2, "Sistem", "19.03.2025 16:25:40", null, null, "4432e216-f9b9-4e58-9632-17e464666915", false, null, null, "SubCategory 2" },
                    { 3, 3, "Sistem", "19.03.2025 16:25:40", null, null, "09d69cb2-8082-485b-8948-34da1805bf8a", false, null, null, "SubCategory 3" },
                    { 4, 4, "Sistem", "19.03.2025 16:25:40", null, null, "43fa02e3-c8cb-42c4-b01d-4c4323b8789e", false, null, null, "SubCategory 4" },
                    { 5, 5, "Sistem", "19.03.2025 16:25:40", null, null, "6c225687-68ac-45b9-87e4-91ea2d168901", false, null, null, "SubCategory 5" },
                    { 6, 6, "Sistem", "19.03.2025 16:25:40", null, null, "c81a154a-61d6-4c7b-86bf-8cfa4583bd49", false, null, null, "SubCategory 6" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Flag", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "RatinAVG", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, "Sistem", "19.03.2025 16:25:40", null, null, "f7ca4124-3294-4806-9675-e88ffebe541d", false, null, null, "Product 1", 0, 1 },
                    { 2, "Sistem", "19.03.2025 16:25:40", null, null, "8e3da1e7-2209-46e8-8bd4-afc74b858af1", false, null, null, "Product 2", 0, 1 },
                    { 3, "Sistem", "19.03.2025 16:25:40", null, null, "0cd44917-f318-4453-b39f-c9cf50ba3ba5", false, null, null, "Product 3", 0, 1 },
                    { 4, "Sistem", "19.03.2025 16:25:40", null, null, "451843b5-e9af-4a21-a001-88bc20cb3cd2", false, null, null, "Product 4", 0, 1 },
                    { 5, "Sistem", "19.03.2025 16:25:40", null, null, "27012d19-1c41-4a83-9395-c2d3007f9379", false, null, null, "Product 5", 0, 1 },
                    { 6, "Sistem", "19.03.2025 16:25:40", null, null, "5aa80bc6-1725-4f30-8828-ea9eed54d350", false, null, null, "Product 6", 0, 1 },
                    { 7, "Sistem", "19.03.2025 16:25:40", null, null, "55a443e5-a453-42c1-be3e-8d449b45d494", false, null, null, "Product 7", 0, 3 },
                    { 8, "Sistem", "19.03.2025 16:25:40", null, null, "894d962e-4ac5-412a-8c39-ceb4aa48c1bf", false, null, null, "Product 8", 0, 3 },
                    { 9, "Sistem", "19.03.2025 16:25:40", null, null, "fd895cb5-5c04-4403-83b8-fa0e6c5c649a", false, null, null, "Product 9", 0, 3 },
                    { 10, "Sistem", "19.03.2025 16:25:40", null, null, "cc6d0c95-c62a-486f-8fd8-d944547890eb", false, null, null, "Product 10", 0, 4 },
                    { 11, "Sistem", "19.03.2025 16:25:40", null, null, "d627d29b-a86f-4881-bdd8-8d991b6c530c", false, null, null, "Product 11", 0, 4 },
                    { 12, "Sistem", "19.03.2025 16:25:40", null, null, "396da384-b399-4ddd-842a-31583094a3c8", false, null, null, "Product 12", 0, 4 },
                    { 13, "Sistem", "19.03.2025 16:25:40", null, null, "dd6a222c-8292-4fbc-9623-d4c1fbfb6591", false, null, null, "Product 13", 0, 4 },
                    { 14, "Sistem", "19.03.2025 16:25:40", null, null, "e9a23a56-b899-479c-83d4-1258b46499b7", false, null, null, "Product 14", 0, 5 },
                    { 15, "Sistem", "19.03.2025 16:25:40", null, null, "60a97777-e0bf-49cc-9c24-91585f8b37e8", false, null, null, "Product 15", 0, 5 },
                    { 16, "Sistem", "19.03.2025 16:25:40", null, null, "e399c1af-0193-4a4f-b181-c69965c421f1", false, null, null, "Product 16", 0, 6 },
                    { 17, "Sistem", "19.03.2025 16:25:40", null, null, "3bfa310b-290a-45f8-abb0-531163dec0d1", false, null, null, "Product 17", 0, 6 },
                    { 18, "Sistem", "19.03.2025 16:25:40", null, null, "55b29c21-c6c4-4188-9587-165f559fea27", false, null, null, "Product 18", 0, 5 },
                    { 19, "Sistem", "19.03.2025 16:25:40", null, null, "475b33d1-413a-4cc1-9f2b-9f8d1bd672f2", false, null, null, "Product 19", 0, 5 },
                    { 20, "Sistem", "19.03.2025 16:25:40", null, null, "a9d71e4d-a66b-4c59-8ec7-ea6d0ea75b54", false, null, null, "Product 20", 0, 6 },
                    { 21, "Sistem", "19.03.2025 16:25:40", null, null, "33ca9a12-6a3f-4f23-9390-b623e94f5059", false, null, null, "Product 21", 0, 6 },
                    { 22, "Sistem", "19.03.2025 16:25:40", null, null, "e90e2fcb-5bc5-41da-978d-c8e09a82e87d", false, null, null, "Product 22", 0, 5 },
                    { 23, "Sistem", "19.03.2025 16:25:40", null, null, "84027766-5664-48b5-a705-4669558dbe27", false, null, null, "Product 23", 0, 5 },
                    { 24, "Sistem", "19.03.2025 16:25:40", null, null, "e6ce00cc-0f18-4440-9f0c-30d39f1aaa76", false, null, null, "Product 24", 0, 6 },
                    { 25, "Sistem", "19.03.2025 16:25:40", null, null, "15d8d1ec-2a97-456f-9d22-7ae06766f156", false, null, null, "Product 25", 0, 6 }
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
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_CategoryId",
                table: "CategoryProduct",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryId",
                table: "Product",
                column: "SubCategoryId");

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

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "RatinProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Ratin");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
