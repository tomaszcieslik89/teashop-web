using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Firma.Data.Migrations
{
    public partial class addshopandwebsite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMSAktualnosc",
                columns: table => new
                {
                    IdAktualnosci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTytul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tytul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Pozycja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSAktualnosc", x => x.IdAktualnosci);
                });

            migrationBuilder.CreateTable(
                name: "CMSParametr",
                columns: table => new
                {
                    IdParametru = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Wartosc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSParametr", x => x.IdParametru);
                });

            migrationBuilder.CreateTable(
                name: "CMSStrona",
                columns: table => new
                {
                    IdStrony = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTytul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tytul = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tresc = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Pozycja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSStrona", x => x.IdStrony);
                });

            migrationBuilder.CreateTable(
                name: "SklepRodzaj",
                columns: table => new
                {
                    IdRodzaju = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SklepRodzaj", x => x.IdRodzaju);
                });

            migrationBuilder.CreateTable(
                name: "SklepTowar",
                columns: table => new
                {
                    IdTowaru = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<decimal>(type: "money", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRodzaju = table.Column<int>(type: "int", nullable: false),
                    Promocja = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SklepTowar", x => x.IdTowaru);
                });

            migrationBuilder.CreateTable(
                name: "SklepElementKoszyka",
                columns: table => new
                {
                    IdElementuKoszyka = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSesjiKoszyka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTowaru = table.Column<int>(type: "int", nullable: false),
                    SklepTowarIdTowaru = table.Column<int>(type: "int", nullable: false),
                    Ilosc = table.Column<int>(type: "int", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SklepElementKoszyka", x => x.IdElementuKoszyka);
                    table.ForeignKey(
                        name: "FK_SklepElementKoszyka_SklepTowar_SklepTowarIdTowaru",
                        column: x => x.SklepTowarIdTowaru,
                        principalTable: "SklepTowar",
                        principalColumn: "IdTowaru",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SklepElementKoszyka_SklepTowarIdTowaru",
                table: "SklepElementKoszyka",
                column: "SklepTowarIdTowaru");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMSAktualnosc");

            migrationBuilder.DropTable(
                name: "CMSParametr");

            migrationBuilder.DropTable(
                name: "CMSStrona");

            migrationBuilder.DropTable(
                name: "PlanUrlopu");

            migrationBuilder.DropTable(
                name: "Reklamacje");

            migrationBuilder.DropTable(
                name: "SklepElementKoszyka");

            migrationBuilder.DropTable(
                name: "SortowanieDokumentow");

            migrationBuilder.DropTable(
                name: "SortowaniePracownikow");

            migrationBuilder.DropTable(
                name: "SortowanieReklamacji");

            migrationBuilder.DropTable(
                name: "SortowanieTowaru");

            migrationBuilder.DropTable(
                name: "SortowanieUrlopow");

            migrationBuilder.DropTable(
                name: "SortowanieUzytkownikow");

            migrationBuilder.DropTable(
                name: "Wynagrodzenie");

            migrationBuilder.DropTable(
                name: "ZakresWyszukiwaniaDaty");

            migrationBuilder.DropTable(
                name: "ZakupTowaru");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "ZadanieReklamujacego");

            migrationBuilder.DropTable(
                name: "SklepTowar");

            migrationBuilder.DropTable(
                name: "Pracownik");

            migrationBuilder.DropTable(
                name: "DokumentSprzedazy");

            migrationBuilder.DropTable(
                name: "Uzytkownik");

            migrationBuilder.DropTable(
                name: "Zatrudnienie");

            migrationBuilder.DropTable(
                name: "Kontrahent");

            migrationBuilder.DropTable(
                name: "SposobPlatnosci");

            migrationBuilder.DropTable(
                name: "SzczegolyTowaru");

            migrationBuilder.DropTable(
                name: "Towar");

            migrationBuilder.DropTable(
                name: "DaneLogowania");

            migrationBuilder.DropTable(
                name: "RodzajUmowy");

            migrationBuilder.DropTable(
                name: "RodzajZatrudnienia");

            migrationBuilder.DropTable(
                name: "StanowiskoPracownika");

            migrationBuilder.DropTable(
                name: "Urlop");

            migrationBuilder.DropTable(
                name: "Platnosci");

            migrationBuilder.DropTable(
                name: "Plec");

            migrationBuilder.DropTable(
                name: "Rabat");

            migrationBuilder.DropTable(
                name: "KategoriaTowaru");

            migrationBuilder.DropTable(
                name: "Marka");

            migrationBuilder.DropTable(
                name: "Producent");

            migrationBuilder.DropTable(
                name: "SklepRodzaj");

            migrationBuilder.DropTable(
                name: "TypKontrahenta");

            migrationBuilder.DropTable(
                name: "RodzajWolnego");

            migrationBuilder.DropTable(
                name: "PlatnoscBlikiem");

            migrationBuilder.DropTable(
                name: "PlatnoscGotowka");

            migrationBuilder.DropTable(
                name: "PlatnoscKarta");

            migrationBuilder.DropTable(
                name: "PlatnoscPrzelewem");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "DanePersonalne");

            migrationBuilder.DropTable(
                name: "Dodatkowe");

            migrationBuilder.DropTable(
                name: "RodzajDokumentu");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "PlatnoscDoDostawcy");

            migrationBuilder.DropTable(
                name: "PlatnoscOdKontrahenta");

            migrationBuilder.DropTable(
                name: "Kraj");

            migrationBuilder.DropTable(
                name: "Wojewodzctwo");
        }
    }
}
