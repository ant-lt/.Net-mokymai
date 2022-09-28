using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_MUSIC_SHOP.Infrastrukture.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "artists",
                columns: table => new
                {
                    ArtistId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR(120)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(30)", nullable: true),
                    ReportsTo = table.Column<long>(type: "INTEGER", nullable: true),
                    BirthDate = table.Column<byte[]>(type: "DATETIME", nullable: true),
                    HireDate = table.Column<byte[]>(type: "DATETIME", nullable: true),
                    Address = table.Column<string>(type: "NVARCHAR(70)", nullable: true),
                    City = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    State = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    Country = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    PostalCode = table.Column<string>(type: "NVARCHAR(10)", nullable: true),
                    Phone = table.Column<string>(type: "NVARCHAR(24)", nullable: true),
                    Fax = table.Column<string>(type: "NVARCHAR(24)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR(60)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_employees_employees_ReportsTo",
                        column: x => x.ReportsTo,
                        principalTable: "employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    GenreId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR(120)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "media_types",
                columns: table => new
                {
                    MediaTypeId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR(120)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_media_types", x => x.MediaTypeId);
                });

            migrationBuilder.CreateTable(
                name: "playlists",
                columns: table => new
                {
                    PlaylistId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR(120)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playlists", x => x.PlaylistId);
                });

            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    AlbumId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "NVARCHAR(160)", nullable: false),
                    ArtistId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_albums_artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "artists",
                        principalColumn: "ArtistId");
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Company = table.Column<string>(type: "NVARCHAR(80)", nullable: true),
                    Address = table.Column<string>(type: "NVARCHAR(70)", nullable: true),
                    City = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    State = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    Country = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    PostalCode = table.Column<string>(type: "NVARCHAR(10)", nullable: true),
                    Phone = table.Column<string>(type: "NVARCHAR(24)", nullable: true),
                    Fax = table.Column<string>(type: "NVARCHAR(24)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR(60)", nullable: false),
                    SupportRepId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_customers_employees_SupportRepId",
                        column: x => x.SupportRepId,
                        principalTable: "employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "tracks",
                columns: table => new
                {
                    TrackId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    AlbumId = table.Column<long>(type: "INTEGER", nullable: true),
                    MediaTypeId = table.Column<long>(type: "INTEGER", nullable: false),
                    GenreId = table.Column<long>(type: "INTEGER", nullable: true),
                    Composer = table.Column<string>(type: "NVARCHAR(220)", nullable: true),
                    Milliseconds = table.Column<long>(type: "INTEGER", nullable: false),
                    Bytes = table.Column<long>(type: "INTEGER", nullable: true),
                    UnitPrice = table.Column<byte[]>(type: "NUMERIC(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tracks", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_tracks_albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "albums",
                        principalColumn: "AlbumId");
                    table.ForeignKey(
                        name: "FK_tracks_genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "genres",
                        principalColumn: "GenreId");
                    table.ForeignKey(
                        name: "FK_tracks_media_types_MediaTypeId",
                        column: x => x.MediaTypeId,
                        principalTable: "media_types",
                        principalColumn: "MediaTypeId");
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<long>(type: "INTEGER", nullable: false),
                    InvoiceDate = table.Column<byte[]>(type: "DATETIME", nullable: false),
                    BillingAddress = table.Column<string>(type: "NVARCHAR(70)", nullable: true),
                    BillingCity = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    BillingState = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    BillingCountry = table.Column<string>(type: "NVARCHAR(40)", nullable: true),
                    BillingPostalCode = table.Column<string>(type: "NVARCHAR(10)", nullable: true),
                    Total = table.Column<byte[]>(type: "NUMERIC(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_invoices_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "playlist_track",
                columns: table => new
                {
                    PlaylistId = table.Column<long>(type: "INTEGER", nullable: false),
                    TrackId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playlist_track", x => new { x.PlaylistId, x.TrackId });
                    table.ForeignKey(
                        name: "FK_playlist_track_playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "playlists",
                        principalColumn: "PlaylistId");
                    table.ForeignKey(
                        name: "FK_playlist_track_tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "tracks",
                        principalColumn: "TrackId");
                });

            migrationBuilder.CreateTable(
                name: "invoice_items",
                columns: table => new
                {
                    InvoiceLineId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceId = table.Column<long>(type: "INTEGER", nullable: false),
                    TrackId = table.Column<long>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<byte[]>(type: "NUMERIC(10,2)", nullable: false),
                    Quantity = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoice_items", x => x.InvoiceLineId);
                    table.ForeignKey(
                        name: "FK_invoice_items_invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "invoices",
                        principalColumn: "InvoiceId");
                    table.ForeignKey(
                        name: "FK_invoice_items_tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "tracks",
                        principalColumn: "TrackId");
                });

            migrationBuilder.CreateIndex(
                name: "IFK_AlbumArtistId",
                table: "albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IFK_CustomerSupportRepId",
                table: "customers",
                column: "SupportRepId");

            migrationBuilder.CreateIndex(
                name: "IFK_EmployeeReportsTo",
                table: "employees",
                column: "ReportsTo");

            migrationBuilder.CreateIndex(
                name: "IFK_InvoiceLineInvoiceId",
                table: "invoice_items",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IFK_InvoiceLineTrackId",
                table: "invoice_items",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IFK_InvoiceCustomerId",
                table: "invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IFK_PlaylistTrackTrackId",
                table: "playlist_track",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IFK_TrackAlbumId",
                table: "tracks",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IFK_TrackGenreId",
                table: "tracks",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IFK_TrackMediaTypeId",
                table: "tracks",
                column: "MediaTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "invoice_items");

            migrationBuilder.DropTable(
                name: "playlist_track");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "playlists");

            migrationBuilder.DropTable(
                name: "tracks");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "albums");

            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "media_types");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "artists");
        }
    }
}
