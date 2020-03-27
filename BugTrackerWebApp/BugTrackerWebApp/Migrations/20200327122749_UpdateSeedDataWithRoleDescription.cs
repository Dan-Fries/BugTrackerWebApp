using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerWebApp.Migrations
{
    public partial class UpdateSeedDataWithRoleDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Description" },
                values: new object[] { "24caa051-d084-4d58-aa2b-28307f957199", "Standard Administrator Role" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Description" },
                values: new object[] { "99ebc46f-2ad3-44f3-aac3-76101cd55ed6", "Default User Role" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc2a6336-74bc-4c38-adab-3c447c7da43a", "AQAAAAEAACcQAAAAEOiVBmWHkTs4SQogKscSPvz7/+rDWNxrDgUkI5/lHDhQrdJBoIrs4dVHxuBNnptYBA==", "551aa4b2-df3d-46eb-a601-bf6b129f56af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e341b58-e4fa-47f5-9448-e633ab88ab48", "AQAAAAEAACcQAAAAEDY66gASkAGjbSJWz3M6aRZa4VUFZZ2P8esS3Fwx+PHkpDpJx6l7jM8X3Tdg9wsmCA==", "b7355b16-76f1-4808-ab2b-4127b71c81a5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Description" },
                values: new object[] { "65ad730f-8ef7-4006-b21f-65b7dc05399c", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Description" },
                values: new object[] { "3e7b0adf-b6f8-4e51-89d2-841e5f9076a5", null });

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
    }
}
