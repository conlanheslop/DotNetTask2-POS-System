using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS_System.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UserType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name", "Password", "UserType" },
                values: new object[] { 1, "Jane Doe", "password", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name", "Password", "UserType" },
                values: new object[] { 2, "John Doe", "password", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name", "Password", "UserType" },
                values: new object[] { 3, "Ronald McDonald", "password", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
