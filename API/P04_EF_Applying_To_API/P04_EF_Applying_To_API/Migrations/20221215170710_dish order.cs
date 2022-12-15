using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class dishorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DishOrders",
                columns: table => new
                {
                    DishOrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LocalUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishOrders", x => x.DishOrderId);
                    table.ForeignKey(
                        name: "FK_DishOrders_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId");
                    table.ForeignKey(
                        name: "FK_DishOrders_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 15, 19, 7, 10, 130, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 15, 19, 7, 10, 130, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 15, 19, 7, 10, 130, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_DishId",
                table: "DishOrders",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_LocalUserId",
                table: "DishOrders",
                column: "LocalUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishOrders");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 8, 19, 22, 28, 738, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 8, 19, 22, 28, 738, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 8, 19, 22, 28, 738, DateTimeKind.Local).AddTicks(3509));
        }
    }
}
