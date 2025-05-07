using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class InitColorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Colorvalue", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "#f0f8ff", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Alice Blue" },
                    { 2, "#faebd7", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Antik Beyaz" },
                    { 3, "#00ffff", "System", "6.05.2025 11:51:27", null, null, false, null, null, "AQUA" },
                    { 4, "#7fffd4", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Akuamarin" },
                    { 5, "#f0ffff", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Masmavi" },
                    { 6, "#f5f5dc", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Bej" },
                    { 7, "#ffe4c4", "System", "6.05.2025 11:51:27", null, null, false, null, null, "BISQUE" },
                    { 8, "#000000", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Siyah" },
                    { 9, "#ffebcd", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Blanchedalmond" },
                    { 10, "#0000ff", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Mavi" },
                    { 11, "#8a2be2", "System", "6.05.2025 11:51:27", null, null, false, null, null, "MAVİMENEKŞE" },
                    { 12, "#a52a2a", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Kahverengi" },
                    { 13, "#deb887", "System", "6.05.2025 11:51:27", null, null, false, null, null, "Burlywood" },
                    { 14, "#5f9ea0", "System", "6.05.2025 11:51:27", null, null, false, null, null, "CadetBlue" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: "6.05.2025 11:03:15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: "6.05.2025 11:03:15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "d381bac8-219b-404f-8803-f41af731de89", "6.05.2025 11:03:15", "AQAAAAIAAYagAAAAEH0bhG4UegPaotKfZ8NO48uiZTOVNME3Hzl+GksYRnzURcgXZLhLWSML5Br2I4z5dQ==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "996e9324-12e2-4cfd-bb14-e7126dd0087b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "bc241e95-6a0c-4ed5-8732-abcd6539d60e" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "5504906d-6405-4864-9b26-53bd0c733c3d" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "04ae4857-2d10-4aec-b17a-edd72c390447" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "6d27970d-dedd-495b-ad6f-1505bca2df19" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "39171556-4420-43a7-b386-f04375d28846" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "4da7ec32-2fe2-4bbe-bedf-eabfff4b11fe" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "de2903fc-3a5e-4be7-a4f7-a8f19bac84e7" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "71536cdd-1b77-415d-9c67-4d4b8b8511ec" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "dea3bffe-862a-48ee-a1d5-76132ba4ac3e" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "92bec768-7b3d-4e8f-b0f8-be6047ccd81b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "a64b7eed-6a45-421d-b658-e50e0e39ec3d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "167d7ed4-fe38-4238-ba5f-fb785af6f692" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "64eb027d-fcbe-4531-928a-5d68621485b1" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "a32da0d6-c017-4c9f-a49d-6258315f8180" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "7f21a426-5f1c-4387-be53-478d70c39c48" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "46562511-7f92-4703-9821-24c755fb0286" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "9da0ae05-2e05-4955-a1c3-b801c184638b" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "6d355277-1652-48f1-b1c2-a406a0a5925f" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "a8f4fc50-b83d-4107-89d9-15f2f450e5f0" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "5c4c94df-1a07-4fbc-8748-c105fdaeb88c" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "f0cb76cc-5851-4674-8bf1-8e5472bc3586" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "4d0e1457-a47b-4a20-8da9-effdea7e5971" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "4d889dbb-3ca2-4bde-b344-ca838c3a4da6" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "c0fee073-b16c-41fc-9d98-c13217303df8" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "30095147-00d2-449d-8b91-11001d05f49d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "12d116e0-f6dd-45f0-a109-e2418631faab" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "f5f94fb7-eae4-4491-912e-8e52596f356d" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "0de89c24-d44e-4267-909c-6ea3b3724f15" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "183fbffb-d1e0-43cd-befb-fcd4ee588de2" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "36338ade-7064-4d5c-8642-40105463b9a2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "a60b573c-7fc2-44c6-94af-72fdd9998d84" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "d8667c26-3169-40a8-87c4-a33eeac997d2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "30cb34ae-db86-4211-8d67-891410fa7d70" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "ba9b152f-bc0c-445e-bf52-2a6bd50d1871" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "7795514e-880e-4ead-87c9-888322fdbc08" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "d71ec37b-11d1-48fc-a179-ddf66093950f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "9746a9b8-4355-40ba-ba5c-b57c3aa8ac47" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "3847cc7e-de19-4d21-95bc-f28b0251d126" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "2a235e11-ccca-4d07-b5e1-92ac0ec61241" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "9ea6973e-0fcf-4d5e-a543-bd01c3842788" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "f48f64e0-f7c5-4140-a4d8-346f426b4e90" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "c8b90af4-e0c3-49a2-a6c6-e07363e7d974" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "09acb22c-ee29-4787-985c-8de11ff64546" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "92c61b83-4bd9-4b35-a29b-910b68a5005d" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "ba52afb3-8baf-412e-9b98-df13117b5aad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "86890ac5-7861-4cf1-b906-86ee74f6707c" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "4800f137-a67d-4f82-8f53-46f22dbe542a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "e22a42ed-5677-4f3b-aa6d-6bfedfcda00f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "69bf8366-3cd5-49d5-9e6d-4a6790cf63ac" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "500c4aaa-1802-4ad1-b7cf-15042ee532d8" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "de288b02-0492-490b-b566-e45478071cbc" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "82de14c2-a92e-4c68-824a-f3a6d5d3e7a3" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "2cef7e38-df19-4df5-a542-c059e277b3c9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "bfde7c99-2a63-4e50-9ceb-2bdff66278ba" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "33d476a8-3c5b-46bb-a18a-6bee2b0926d0" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "c646e59c-3316-4432-84d7-31bce0dbe666" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "5888f769-9a18-4c47-bc8b-f9a9eb90efb9" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "acb32041-be7b-41d4-ace2-b7078bf0861b" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "04477ea7-4b09-4b69-aa6f-8b9012e0eafe" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "d36ff833-2a05-4ccf-81d8-d997c5f24d18" });

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Flag" },
                values: new object[] { "6.05.2025 11:03:15", "bf72c871-8fcd-440f-bd78-390407b22e7b" });
        }
    }
}
