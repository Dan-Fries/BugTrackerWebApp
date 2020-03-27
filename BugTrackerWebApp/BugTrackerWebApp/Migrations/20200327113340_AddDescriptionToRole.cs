using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerWebApp.Migrations
{
    public partial class AddDescriptionToRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "65ad730f-8ef7-4006-b21f-65b7dc05399c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3e7b0adf-b6f8-4e51-89d2-841e5f9076a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e22d291e-142a-4696-afc9-de976d3de920", "AQAAAAEAACcQAAAAEP0STrBGqAZI6IPqUP5QBqBhKlTr9GO8gOp4cmAcpZCmv9XDCMcGGNk6A073kjoX+Q==", "63d56cc7-d91d-4f60-ac89-1e28bf09498b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c63a92fc-2c74-46b5-97f3-9712f0973c44", "AQAAAAEAACcQAAAAELePuyOxx/EGXfigGzzLcsGPKSSQW7IB8+fYQJDhz1ieyahIrsNgsAnbQLJfEd4c7w==", "31e9df41-04f4-4aaf-b35a-5d772f307a4d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");

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
    }
}
