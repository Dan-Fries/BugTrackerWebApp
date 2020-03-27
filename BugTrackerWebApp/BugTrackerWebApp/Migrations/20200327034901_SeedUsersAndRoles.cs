using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerWebApp.Migrations
{
    public partial class SeedUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "591b7d2a-21ea-4f28-b01a-3a73ee28afdb", "Admin", "ADMIN" },
                    { 2, "a24a2116-a687-4ff5-8e5a-6e7ab96b577f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "a75af77e-930c-4253-9915-1fb14b789377", "BTadmin@BTApp.com", false, null, null, false, null, "BTADMIN@BTAPP.COM", "TESTADMIN", "AQAAAAEAACcQAAAAELfgKgVkARP08d8lQKNXbI1pX0pYYNNs5zHhZBDYOqAvqL4BtJCR7KnHLBZ4+U4ZMA==", null, false, null, false, "TestAdmin" },
                    { 2, 0, "6c99321f-a379-470d-8e2f-e505b73cb63c", "BTuser@BTApp.com", false, null, null, false, null, "BTUSER@BTAPP.COM", "TESTUSER", "AQAAAAEAACcQAAAAEByGZJ4pT0hDccaPRdB2H/20Est5pkH0uht+cLQgpA1H5taPUPSzBGKtbxy+5Cqljw==", null, false, null, false, "TestUser" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
