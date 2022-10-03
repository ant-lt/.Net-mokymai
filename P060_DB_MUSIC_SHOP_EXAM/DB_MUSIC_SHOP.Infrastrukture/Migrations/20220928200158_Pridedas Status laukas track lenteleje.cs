using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_MUSIC_SHOP.Infrastrukture.Migrations
{
    public partial class PridedasStatuslaukastracklenteleje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "tracks",
                type: "NVARCHAR(200)",
                nullable: false,
                defaultValue: "Active");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "tracks");
        }
    }
}
