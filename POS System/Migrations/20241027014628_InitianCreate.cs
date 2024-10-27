using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS_System.Migrations
{
    public partial class InitianCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "POSItems",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSItems", x => x.ItemID);
                });

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
                table: "POSItems",
                columns: new[] { "ItemID", "Name", "Price" },
                values: new object[] { 1, "Big Mac", 6.50m });

            migrationBuilder.InsertData(
                table: "POSItems",
                columns: new[] { "ItemID", "Name", "Price" },
                values: new object[] { 2, "Medium Fries", 3.20m });

            migrationBuilder.InsertData(
                table: "POSItems",
                columns: new[] { "ItemID", "Name", "Price" },
                values: new object[] { 3, "Coke", 4.50m });

            migrationBuilder.InsertData(
                table: "POSItems",
                columns: new[] { "ItemID", "Name", "Price" },
                values: new object[] { 4, "Coke No Sugar", 4.50m });

            migrationBuilder.InsertData(
                table: "POSItems",
                columns: new[] { "ItemID", "Name", "Price" },
                values: new object[] { 5, "Oreo McFlurry", 4.75m });

            migrationBuilder.InsertData(
                table: "POSItems",
                columns: new[] { "ItemID", "Name", "Price" },
                values: new object[] { 6, "M&M McFlurry", 4.75m });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name", "Password", "UserType" },
                values: new object[] { 1, "Ronald McDonald", "password", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name", "Password", "UserType" },
                values: new object[] { 3, "Grimace", "password", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name", "Password", "UserType" },
                values: new object[] { 2, "The Hamburgler", "password", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POSItems");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
