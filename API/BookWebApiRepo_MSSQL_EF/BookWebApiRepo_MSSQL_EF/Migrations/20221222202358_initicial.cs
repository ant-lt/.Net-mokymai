using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWebApiRepoMSSQLEF.Migrations
{
    /// <inheritdoc />
    public partial class initicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Years = table.Column<int>(type: "int", nullable: false),
                    CoverType = table.Column<int>(type: "int", nullable: false),
                    OwnedQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PointsLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalUsers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocalUsers_UserLevels_UserLevelId",
                        column: x => x.UserLevelId,
                        principalTable: "UserLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    LocalUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocalUserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ReservationStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationStatus_ReservationStatusId",
                        column: x => x.ReservationStatusId,
                        principalTable: "ReservationStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishbooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    LocalUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishbooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishbooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishbooks_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FineDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FineAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LocalUserId = table.Column<int>(type: "int", nullable: false),
                    LoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fines_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fines_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverType", "OwnedQty", "Title", "Years" },
                values: new object[,]
                {
                    { 1, "Kristina Pišniukaitė - Šimkienė", 0, 1, "Ant medinės lentelės II", 2022 },
                    { 2, "Lina Žutautė", 1, 2, "Kakė Makė ir magiška kelionė", 2022 },
                    { 3, "Santa Montefiore", 2, 3, "Tolimi krantai", 2022 },
                    { 4, "Nino Haratischwili", 2, 1, "Aštuntas gyvenimas (Brilkai)", 2022 },
                    { 5, "Kristina Pišniukaitė - Šimkienė", 2, 2, "Ant medinės lentelės III", 2022 },
                    { 6, "Salman Rushdie", 1, 3, "Kichotas", 2020 },
                    { 7, "Kristina Pišniukaitė - Šimkienė", 2, 1, "Ant medinės lentelės IIV", 2022 }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Active" },
                    { 2, "Returned" },
                    { 3, "Canceled" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Secretary" },
                    { 3, "Librarian" },
                    { 4, "Reader" }
                });

            migrationBuilder.InsertData(
                table: "UserLevels",
                columns: new[] { "Id", "Name", "PointsLevel" },
                values: new object[,]
                {
                    { 1, "Pradinukas", 0 },
                    { 2, "Megejas", 2000 },
                    { 3, "Ekspertas", 10000 },
                    { 4, "Guru", 25000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fines_LoanId",
                table: "Fines",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_Fines_LocalUserId",
                table: "Fines",
                column: "LocalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LocalUserId",
                table: "Loans",
                column: "LocalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalUsers_RoleId",
                table: "LocalUsers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalUsers_UserLevelId",
                table: "LocalUsers",
                column: "UserLevelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BookId",
                table: "Reservations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_LocalUserId",
                table: "Reservations",
                column: "LocalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationStatusId",
                table: "Reservations",
                column: "ReservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishbooks_BookId",
                table: "Wishbooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishbooks_LocalUserId",
                table: "Wishbooks",
                column: "LocalUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fines");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Wishbooks");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "ReservationStatus");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserLevels");
        }
    }
}
