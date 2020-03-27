using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerWebApp.Migrations
{
    public partial class updateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "78485c1b-c827-4e23-bdea-1ed5d7285948");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "28da1550-da6d-442a-897e-6d64bfceeb2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "850a614c-19d0-4f07-9db2-afa56a47ab8c", "BTADMIN@BTAPP.COM", "AQAAAAEAACcQAAAAEEn7qTORGJl9AutBOs5UrcCSfuGu6XFbSnVJ/8BQ0PZlzNBz1y8WWv3HmzfWmf3w4Q==", "BTadmin@BTApp.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "495996ed-2df4-484f-b223-a8a4805aed37", "BTUSER@BTAPP.COM", "AQAAAAEAACcQAAAAEPQ/KU0R08hE5kZjXLe2H3XpMJmTNScITxJ61T5M5Y3Ns85kJBUoJPh1RuQ8NBxhDg==", "BTuser@BTApp.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "87df726d-4988-4882-bc40-306838aa8bfe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "38676c53-fe1d-441a-80ae-60d60e1f2ae2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "03bf94d1-f1e0-4aaf-b08a-e79653dbf0c5", "TESTADMIN", "AQAAAAEAACcQAAAAEJ/lpmwpTOjtPemZ62hfzvIsirdNBh2Sh6Yw4hTW863sVz66P+Aec0TIuQaKmQAgfQ==", "TestAdmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "528903a7-9120-447b-a0f7-8d59d26afaa2", "TESTUSER", "AQAAAAEAACcQAAAAEKnOJlGxiMKJdrlbckHf5eFgcfQWAEcSth90izbSw2Vj3p8ODyV8hodETkObwNyLJQ==", "TestUser" });
        }
    }
}
