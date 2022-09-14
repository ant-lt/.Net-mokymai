using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P052_CodeFirstSqliteDb.Infrastrukture.Migrations
{
    public partial class ChangePersonBirthDateAddedEmailHeigth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Person",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Person",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
