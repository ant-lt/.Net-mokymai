using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P055_DB_DataSeed.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batai",
                columns: table => new
                {
                    BatasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pavadinimas = table.Column<string>(type: "TEXT", nullable: false),
                    Tipas = table.Column<string>(type: "TEXT", nullable: false),
                    Kaina = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batai", x => x.BatasId);
                });

            migrationBuilder.CreateTable(
                name: "BatuDydziai",
                columns: table => new
                {
                    BatuDydisId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dydis = table.Column<int>(type: "INTEGER", nullable: false),
                    Kiekis = table.Column<int>(type: "INTEGER", nullable: false),
                    BatasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatuDydziai", x => x.BatuDydisId);
                    table.ForeignKey(
                        name: "FK_BatuDydziai_Batai_BatasId",
                        column: x => x.BatasId,
                        principalTable: "Batai",
                        principalColumn: "BatasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pardavimai",
                columns: table => new
                {
                    PardavimasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BatuDydisId = table.Column<int>(type: "INTEGER", nullable: false),
                    Kiekis = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pardavimai", x => x.PardavimasId);
                    table.ForeignKey(
                        name: "FK_Pardavimai_BatuDydziai_BatuDydisId",
                        column: x => x.BatuDydisId,
                        principalTable: "BatuDydziai",
                        principalColumn: "BatuDydisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Batai",
                columns: new[] { "BatasId", "Kaina", "Pavadinimas", "Tipas" },
                values: new object[] { 1, 100m, "Kedai", "Vyriški" });

            migrationBuilder.InsertData(
                table: "Batai",
                columns: new[] { "BatasId", "Kaina", "Pavadinimas", "Tipas" },
                values: new object[] { 2, 200m, "Kedai", "Moteriški" });

            migrationBuilder.InsertData(
                table: "Batai",
                columns: new[] { "BatasId", "Kaina", "Pavadinimas", "Tipas" },
                values: new object[] { 3, 20.01m, "Kroksai", "Vaikiški" });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 1, 1, 42, 10 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 2, 1, 43, 11 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 3, 1, 44, 12 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 4, 1, 45, 13 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 5, 2, 36, 10 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 6, 2, 37, 11 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 7, 2, 38, 12 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 8, 2, 39, 13 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 9, 3, 30, 10 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 10, 3, 31, 11 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 11, 3, 32, 12 });

            migrationBuilder.InsertData(
                table: "BatuDydziai",
                columns: new[] { "BatuDydisId", "BatasId", "Dydis", "Kiekis" },
                values: new object[] { 12, 3, 33, 13 });

            migrationBuilder.CreateIndex(
                name: "IX_BatuDydziai_BatasId",
                table: "BatuDydziai",
                column: "BatasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pardavimai_BatuDydisId",
                table: "Pardavimai",
                column: "BatuDydisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pardavimai");

            migrationBuilder.DropTable(
                name: "BatuDydziai");

            migrationBuilder.DropTable(
                name: "Batai");
        }
    }
}
