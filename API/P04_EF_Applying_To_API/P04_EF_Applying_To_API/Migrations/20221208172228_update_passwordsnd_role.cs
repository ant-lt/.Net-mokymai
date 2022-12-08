using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatepasswordsndrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "LocalUsers",
                newName: "Role");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "LocalUsers",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "LocalUsers",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "LocalUsers");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "LocalUsers");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "LocalUsers",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 7, 18, 46, 18, 837, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 7, 18, 46, 18, 837, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2022, 12, 7, 18, 46, 18, 837, DateTimeKind.Local).AddTicks(9999));
        }
    }
}
