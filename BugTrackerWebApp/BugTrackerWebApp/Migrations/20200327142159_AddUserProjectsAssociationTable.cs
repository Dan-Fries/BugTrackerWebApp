using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerWebApp.Migrations
{
    public partial class AddUserProjectsAssociationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserProjects",
                columns: table => new
                {
                    BTUserId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjects", x => new { x.BTUserId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_UserProjects_AspNetUsers_BTUserId",
                        column: x => x.BTUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b528afca-f38a-416a-9a8e-d1b8bb8a5a61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f52f02e7-e764-4834-99e3-440dee51777d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8a7d7b6-9d71-49b5-9d00-c9227a702be1", "AQAAAAEAACcQAAAAECm2T/1KT3/CRl5gbAHOg+cSn9Fnh0XXzdNMORLM3urZyAYxjpoPENyey/w1H1Ab0w==", "acdc4c32-9cd3-4cc2-b800-c523aae75ad1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6f988f3-3c48-4304-9f35-e566024450e0", "AQAAAAEAACcQAAAAEBe75o5mx4Zs9LyEe1NbVmcZjKU5iY+keQXhy7L7nBhRwH84B0KZqNStcGns39ETlw==", "3f6834e9-78d6-4c04-8132-c0322f558d7b" });

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_ProjectId",
                table: "UserProjects",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProjects");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "24caa051-d084-4d58-aa2b-28307f957199");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "99ebc46f-2ad3-44f3-aac3-76101cd55ed6");

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
    }
}
