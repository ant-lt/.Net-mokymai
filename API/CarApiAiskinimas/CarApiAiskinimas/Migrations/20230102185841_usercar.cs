using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApiAiskinimas.Migrations
{
    /// <inheritdoc />
    public partial class usercar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarUser",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    LocalUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarUser", x => new { x.CarId, x.LocalUserId });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarUser");
        }
    }
}
