using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerWebApp.Migrations
{
    public partial class SeedUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03bf94d1-f1e0-4aaf-b08a-e79653dbf0c5", "AQAAAAEAACcQAAAAEJ/lpmwpTOjtPemZ62hfzvIsirdNBh2Sh6Yw4hTW863sVz66P+Aec0TIuQaKmQAgfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "528903a7-9120-447b-a0f7-8d59d26afaa2", "AQAAAAEAACcQAAAAEKnOJlGxiMKJdrlbckHf5eFgcfQWAEcSth90izbSw2Vj3p8ODyV8hodETkObwNyLJQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "591b7d2a-21ea-4f28-b01a-3a73ee28afdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a24a2116-a687-4ff5-8e5a-6e7ab96b577f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a75af77e-930c-4253-9915-1fb14b789377", "AQAAAAEAACcQAAAAELfgKgVkARP08d8lQKNXbI1pX0pYYNNs5zHhZBDYOqAvqL4BtJCR7KnHLBZ4+U4ZMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c99321f-a379-470d-8e2f-e505b73cb63c", "AQAAAAEAACcQAAAAEByGZJ4pT0hDccaPRdB2H/20Est5pkH0uht+cLQgpA1H5taPUPSzBGKtbxy+5Cqljw==" });
        }
    }
}
