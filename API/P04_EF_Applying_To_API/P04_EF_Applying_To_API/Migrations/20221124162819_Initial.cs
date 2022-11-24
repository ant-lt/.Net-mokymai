using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    SpiceLevel = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    ImagePath = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishId);
                });

            migrationBuilder.CreateTable(
                name: "RecipeItems",
                columns: table => new
                {
                    RecipeItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Calories = table.Column<double>(type: "REAL", nullable: false),
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeItems", x => x.RecipeItemId);
                    table.ForeignKey(
                        name: "FK_RecipeItems_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Country", "CreateDateTime", "ImagePath", "Name", "SpiceLevel", "Type" },
                values: new object[,]
                {
                    { 1, "Lithuanian", new DateTime(2022, 11, 24, 18, 28, 19, 490, DateTimeKind.Local).AddTicks(1199), "gg", "Fried Bread Sticks", "Mild", "Snacks" },
                    { 2, "Lithuanian", new DateTime(2022, 11, 24, 18, 28, 19, 490, DateTimeKind.Local).AddTicks(1233), "gg", "Potato dumplings", "Low", "Main dish" },
                    { 3, "Lithuanian", new DateTime(2022, 11, 24, 18, 28, 19, 490, DateTimeKind.Local).AddTicks(1235), "gg", "Kibinai", "Low", "Street food" }
                });

            migrationBuilder.InsertData(
                table: "RecipeItems",
                columns: new[] { "RecipeItemId", "Calories", "DishId", "Name" },
                values: new object[,]
                {
                    { 1, 150.0, 1, "Bread" },
                    { 2, 300.0, 1, "Cheese" },
                    { 3, 300.0, 1, "Mayo" },
                    { 4, 50.0, 1, "Garlic" },
                    { 5, 400.0, 2, "Potatoes" },
                    { 6, 400.0, 2, "Meat" },
                    { 7, 300.0, 2, "Sour Cream" },
                    { 8, 300.0, 3, "Dough" },
                    { 9, 200.0, 3, "Meat" },
                    { 10, 150.0, 3, "Salt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeItems_DishId",
                table: "RecipeItems",
                column: "DishId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeItems");

            migrationBuilder.DropTable(
                name: "Dishes");
        }
    }
}
