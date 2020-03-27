using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerWebApp.Migrations
{
    public partial class FixSeedDataWithSecurityStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ca2d7eb5-6c9f-4869-b40c-0feced81c420");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c256e419-4b05-4c9e-83cf-be0f0a32267a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cca64790-8b9c-46bf-9e42-a9f6d1c05e0e", "AQAAAAEAACcQAAAAEBWoYRwjjRDsxPiE1BFU/hpR2EgwRoh6xMqrgPJEA/rLfTrIA80ThDPjhM60QbhvUw==", "c316e126-2897-4768-9a78-e7efe668bbc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcf18137-2f9a-4e54-847b-342cf43db1b0", "AQAAAAEAACcQAAAAEGEj80+Ux1rmQiP0qyYDtC6esMFLVNxgfuYHLYmWkGbqJAn9Q5Gm7g2Oau0dkE/nDg==", "7eb2bbe9-d26d-4036-bbab-c78340865ad6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "850a614c-19d0-4f07-9db2-afa56a47ab8c", "AQAAAAEAACcQAAAAEEn7qTORGJl9AutBOs5UrcCSfuGu6XFbSnVJ/8BQ0PZlzNBz1y8WWv3HmzfWmf3w4Q==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "495996ed-2df4-484f-b223-a8a4805aed37", "AQAAAAEAACcQAAAAEPQ/KU0R08hE5kZjXLe2H3XpMJmTNScITxJ61T5M5Y3Ns85kJBUoJPh1RuQ8NBxhDg==", null });
        }
    }
}
