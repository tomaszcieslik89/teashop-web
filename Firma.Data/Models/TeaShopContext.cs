using System;
using System.Collections.Generic;
using Firma.Data.Models.CMS;
using Firma.Data.Models.Sklep;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Firma.Data.Models
{
    public partial class TeaShopContext : DbContext
    {
        public TeaShopContext()
        {
        }

        public TeaShopContext(DbContextOptions<TeaShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adres> Adres { get; set; } = null!;
        public virtual DbSet<Bank> Bank { get; set; } = null!;
        public virtual DbSet<CMSAktualnosc> CMSAktualnosc { get; set; } = null!;
        public virtual DbSet<CMSParametr> CMSParametr { get; set; } = null!;
        public virtual DbSet<CMSStrona> CMSStrona { get; set; } = null!;
        public virtual DbSet<DaneLogowania> DaneLogowania { get; set; } = null!;
        public virtual DbSet<DanePersonalne> DanePersonalne { get; set; } = null!;
        public virtual DbSet<Dodatkowe> Dodatkowe { get; set; } = null!;
        public virtual DbSet<DokumentSprzedazy> DokumentSprzedazy { get; set; } = null!;
        public virtual DbSet<DokumentSprzedazyTowar> DokumentSprzedazyTowar { get; set; } = null!;
        public virtual DbSet<KategoriaTowaru> KategoriaTowaru { get; set; } = null!;
        public virtual DbSet<Kontrahent> Kontrahent { get; set; } = null!;
        public virtual DbSet<KoszykTemp> KoszykTemp { get; set; } = null!;
        public virtual DbSet<Kraj> Kraj { get; set; } = null!;
        public virtual DbSet<Marka> Marka { get; set; } = null!;
        public virtual DbSet<PlanUrlopu> PlanUrlopu { get; set; } = null!;
        public virtual DbSet<PlatnoscBlikiem> PlatnoscBlikiem { get; set; } = null!;
        public virtual DbSet<PlatnoscDoDostawcy> PlatnoscDoDostawcy { get; set; } = null!;
        public virtual DbSet<PlatnoscGotowka> PlatnoscGotowka { get; set; } = null!;
        public virtual DbSet<PlatnoscKarta> PlatnoscKarta { get; set; } = null!;
        public virtual DbSet<PlatnoscOdKontrahenta> PlatnoscOdKontrahenta { get; set; } = null!;
        public virtual DbSet<PlatnoscPrzelewem> PlatnoscPrzelewem { get; set; } = null!;
        public virtual DbSet<Platnosci> Platnosci { get; set; } = null!;
        public virtual DbSet<Plec> Plec { get; set; } = null!;
        public virtual DbSet<Pracownik> Pracownik { get; set; } = null!;
        public virtual DbSet<Producent> Producent { get; set; } = null!;
        public virtual DbSet<Rabat> Rabat { get; set; } = null!;
        public virtual DbSet<Reklamacje> Reklamacje { get; set; } = null!;
        public virtual DbSet<RodzajDokumentu> RodzajDokumentu { get; set; } = null!;
        public virtual DbSet<RodzajUmowy> RodzajUmowy { get; set; } = null!;
        public virtual DbSet<RodzajWolnego> RodzajWolnego { get; set; } = null!;
        public virtual DbSet<RodzajZatrudnienia> RodzajZatrudnienia { get; set; } = null!;
        public virtual DbSet<SklepElementKoszyka> SklepElementKoszyka { get; set; } = null!;
        public virtual DbSet<SklepRodzaj> SklepRodzaj { get; set; } = null!;
        public virtual DbSet<SklepTowar> SklepTowar { get; set; } = null!;
        public virtual DbSet<SortowanieDokumentow> SortowanieDokumentow { get; set; } = null!;
        public virtual DbSet<SortowaniePracownikow> SortowaniePracownikow { get; set; } = null!;
        public virtual DbSet<SortowanieReklamacji> SortowanieReklamacji { get; set; } = null!;
        public virtual DbSet<SortowanieTowaru> SortowanieTowaru { get; set; } = null!;
        public virtual DbSet<SortowanieUrlopow> SortowanieUrlopow { get; set; } = null!;
        public virtual DbSet<SortowanieUzytkownikow> SortowanieUzytkownikow { get; set; } = null!;
        public virtual DbSet<SposobPlatnosci> SposobPlatnosci { get; set; } = null!;
        public virtual DbSet<StanowiskoPracownika> StanowiskoPracownika { get; set; } = null!;
        public virtual DbSet<Status> Status { get; set; } = null!;
        public virtual DbSet<SzczegolyTowaru> SzczegolyTowaru { get; set; } = null!;
        public virtual DbSet<Towar> Towar { get; set; } = null!;
        public virtual DbSet<TypKontrahenta> TypKontrahenta { get; set; } = null!;
        public virtual DbSet<Urlop> Urlop { get; set; } = null!;
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; } = null!;
        public virtual DbSet<Vat> Vat { get; set; } = null!;
        public virtual DbSet<Wojewodzctwo> Wojewodzctwo { get; set; } = null!;
        public virtual DbSet<Wynagrodzenie> Wynagrodzenie { get; set; } = null!;
        public virtual DbSet<ZadanieReklamujacego> ZadanieReklamujacego { get; set; } = null!;
        public virtual DbSet<ZakresWyszukiwaniaDaty> ZakresWyszukiwaniaDaty { get; set; } = null!;
        public virtual DbSet<ZakupTowaru> ZakupTowaru { get; set; } = null!;
        public virtual DbSet<Zatrudnienie> Zatrudnienie { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-C3HU2G3;Database=TeaShop;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adres>(entity =>
            {
                entity.HasKey(e => e.IdAdresu);

                entity.Property(e => e.Gmina).HasMaxLength(50);

                entity.Property(e => e.KodPocztowy).HasMaxLength(10);

                entity.Property(e => e.Miejscowosc).HasMaxLength(50);

                entity.Property(e => e.NrDomu).HasMaxLength(10);

                entity.Property(e => e.NrLokalu).HasMaxLength(10);

                entity.Property(e => e.Powiat).HasMaxLength(50);

                entity.Property(e => e.Ulica).HasMaxLength(50);

                entity.HasOne(d => d.IdKrajuNavigation)
                    .WithMany(p => p.Adres)
                    .HasForeignKey(d => d.IdKraju)
                    .HasConstraintName("FK_Adres_Kraj");

                entity.HasOne(d => d.IdWojewodzctwaNavigation)
                    .WithMany(p => p.Adres)
                    .HasForeignKey(d => d.IdWojewodzctwa)
                    .HasConstraintName("FK_Adres_Wojewodzctwo");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.IdBanku);

                entity.ToTable("Bank");

                entity.Property(e => e.NazwaBanku).HasMaxLength(50);

                entity.Property(e => e.NumerKonta).HasMaxLength(50);
            });

            modelBuilder.Entity<CMSAktualnosc>(entity =>
            {
                entity.HasKey(e => e.IdAktualnosci);

                entity.ToTable("CMSAktualnosc");

                entity.Property(e => e.LinkTytul).HasMaxLength(30);

                entity.Property(e => e.Tytul).HasMaxLength(30);
            });

            modelBuilder.Entity<CMSParametr>(entity =>
            {
                entity.HasKey(e => e.IdParametru);

                entity.ToTable("CMSParametr");

                entity.Property(e => e.Kod).HasMaxLength(30);

                entity.Property(e => e.Nazwa).HasMaxLength(30);
            });

            modelBuilder.Entity<CMSStrona>(entity =>
            {
                entity.HasKey(e => e.IdStrony);

                entity.ToTable("CMSStrona");

                entity.Property(e => e.LinkTytul).HasMaxLength(30);

                entity.Property(e => e.Tytul).HasMaxLength(30);
            });

            modelBuilder.Entity<DaneLogowania>(entity =>
            {
                entity.HasKey(e => e.IdDaneLogowania);

                entity.Property(e => e.DataUtworzenia).HasColumnType("datetime");

                entity.Property(e => e.HasloUzytkownika).HasMaxLength(50);

                entity.Property(e => e.NazwaUzytkownika).HasMaxLength(50);
            });

            modelBuilder.Entity<DanePersonalne>(entity =>
            {
                entity.HasKey(e => e.IdDanePersonalne);

                entity.ToTable("DanePersonalne");

                entity.Property(e => e.BankDane).HasMaxLength(50);

                entity.Property(e => e.DataUrodzenia).HasColumnType("datetime");

                entity.Property(e => e.DrugieImie).HasMaxLength(50);

                entity.Property(e => e.EmailDane).HasMaxLength(50);

                entity.Property(e => e.FormaPlatnosciDane).HasMaxLength(20);

                entity.Property(e => e.ImieDane).HasMaxLength(50);

                entity.Property(e => e.ImieMatki).HasMaxLength(50);

                entity.Property(e => e.ImieOjca).HasMaxLength(50);

                entity.Property(e => e.KodDane).HasMaxLength(50);

                entity.Property(e => e.KodPocztowyDane).HasMaxLength(10);

                entity.Property(e => e.Kraj).HasMaxLength(50);

                entity.Property(e => e.MiejscowoscDane).HasMaxLength(50);

                entity.Property(e => e.NazwiskoDane).HasMaxLength(50);

                entity.Property(e => e.NazwiskoRodoweMatki).HasMaxLength(50);

                entity.Property(e => e.Nipdane)
                    .HasMaxLength(20)
                    .HasColumnName("NIPDane");

                entity.Property(e => e.NrDomuDane).HasMaxLength(10);

                entity.Property(e => e.NrLokaluDane).HasMaxLength(10);

                entity.Property(e => e.NrPaszportu).HasMaxLength(20);

                entity.Property(e => e.Peseldane)
                    .HasMaxLength(20)
                    .HasColumnName("PESELDane");

                entity.Property(e => e.Plec).HasMaxLength(50);

                entity.Property(e => e.RabatDane).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RachunekNrDane).HasMaxLength(50);

                entity.Property(e => e.Regondane)
                    .HasMaxLength(20)
                    .HasColumnName("REGONDane");

                entity.Property(e => e.TelefonDane).HasMaxLength(20);

                entity.Property(e => e.UlicaDane).HasMaxLength(50);

                entity.Property(e => e.UwagiDane).HasMaxLength(50);

                entity.Property(e => e.WalutaDane).HasMaxLength(20);

                entity.Property(e => e.Wojewodztwo).HasMaxLength(50);
            });

            modelBuilder.Entity<Dodatkowe>(entity =>
            {
                entity.HasKey(e => e.IdDodatkowe);

                entity.ToTable("Dodatkowe");
            });

            modelBuilder.Entity<DokumentSprzedazy>(entity =>
            {
                entity.HasKey(e => e.IdDokumentuSprzedazy);

                entity.ToTable("DokumentSprzedazy");

                entity.Property(e => e.DataWystawienia).HasColumnType("datetime");

                entity.Property(e => e.NumerDokumentu).HasMaxLength(50);

                entity.Property(e => e.TerminPlatnosci).HasColumnType("datetime");

                entity.HasOne(d => d.IdAdresNavigation)
                    .WithMany(p => p.DokumentSprzedazy)
                    .HasForeignKey(d => d.IdAdres)
                    .HasConstraintName("FK_DokumentSprzedazy_Adres");

                entity.HasOne(d => d.IdDaneParsonalneNavigation)
                    .WithMany(p => p.DokumentSprzedazy)
                    .HasForeignKey(d => d.IdDaneParsonalne)
                    .HasConstraintName("FK_DokumentSprzedazy_DanePersonalne");

                entity.HasOne(d => d.IdDodatkoweNavigation)
                    .WithMany(p => p.DokumentSprzedazy)
                    .HasForeignKey(d => d.IdDodatkowe)
                    .HasConstraintName("FK_DokumentSprzedazy_Dodatkowe");

                entity.HasOne(d => d.IdKontrahentaNavigation)
                    .WithMany(p => p.DokumentSprzedazy)
                    .HasForeignKey(d => d.IdKontrahenta)
                    .HasConstraintName("FK_DokumentSprzedazy_Kontrahent");

                entity.HasOne(d => d.IdPlatnosciNavigation)
                    .WithMany(p => p.DokumentSprzedazy)
                    .HasForeignKey(d => d.IdPlatnosci)
                    .HasConstraintName("FK_DokumentSprzedazy_Platnosci");

                entity.HasOne(d => d.IdRabatuNavigation)
                    .WithMany(p => p.DokumentSprzedazy)
                    .HasForeignKey(d => d.IdRabatu)
                    .HasConstraintName("FK_DokumentSprzedazy_Rabat");

                entity.HasOne(d => d.IdRodzajuDokumentowNavigation)
                    .WithMany(p => p.DokumentSprzedazy)
                    .HasForeignKey(d => d.IdRodzajuDokumentow)
                    .HasConstraintName("FK_DokumentSprzedazy_RodzajDokumentu");

                entity.HasOne(d => d.IdSposobuPlatnosciNavigation)
                    .WithMany(p => p.DokumentSprzedazy)
                    .HasForeignKey(d => d.IdSposobuPlatnosci)
                    .HasConstraintName("FK_DokumentSprzedazy_SposobPlatnosci");
            });

            modelBuilder.Entity<DokumentSprzedazyTowar>(entity =>
            {
                entity.ToTable("DokumentSprzedazyTowar");

                entity.HasOne(d => d.IdDokumentSprzedazyNavigation)
                    .WithMany(p => p.DokumentSprzedazyTowar)
                    .HasForeignKey(d => d.IdDokumentSprzedazy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DokumentSprzedazyTowar_DokumentSprzedazy");

                entity.HasOne(d => d.IdTowarNavigation)
                    .WithMany(p => p.DokumentSprzedazyTowar)
                    .HasForeignKey(d => d.IdTowar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DokumentSprzedazyTowar_Towar1");
            });

            modelBuilder.Entity<KategoriaTowaru>(entity =>
            {
                entity.HasKey(e => e.IdKategoriiTowaru);

                entity.ToTable("KategoriaTowaru");

                entity.Property(e => e.NazwaKategorii).HasMaxLength(50);
            });

            modelBuilder.Entity<Kontrahent>(entity =>
            {
                entity.HasKey(e => e.IdKontrahenta);

                entity.ToTable("Kontrahent");

                entity.HasOne(d => d.IdAdresuNavigation)
                    .WithMany(p => p.Kontrahent)
                    .HasForeignKey(d => d.IdAdresu)
                    .HasConstraintName("FK_Kontrahent_Adres");

                entity.HasOne(d => d.IdBankuNavigation)
                    .WithMany(p => p.Kontrahent)
                    .HasForeignKey(d => d.IdBanku)
                    .HasConstraintName("FK_Kontrahent_Bank");

                entity.HasOne(d => d.IdDanePersonalneNavigation)
                    .WithMany(p => p.Kontrahent)
                    .HasForeignKey(d => d.IdDanePersonalne)
                    .HasConstraintName("FK_Kontrahent_DanePersonalne");

                entity.HasOne(d => d.IdDodatkoweNavigation)
                    .WithMany(p => p.Kontrahent)
                    .HasForeignKey(d => d.IdDodatkowe)
                    .HasConstraintName("FK_Kontrahent_Dodatkowe");

                entity.HasOne(d => d.IdPlatnosciNavigation)
                    .WithMany(p => p.Kontrahent)
                    .HasForeignKey(d => d.IdPlatnosci)
                    .HasConstraintName("FK_Kontrahent_Platnosci");

                entity.HasOne(d => d.IdPlciNavigation)
                    .WithMany(p => p.Kontrahent)
                    .HasForeignKey(d => d.IdPlci)
                    .HasConstraintName("FK_Kontrahent_Plec");

                entity.HasOne(d => d.IdRabatuNavigation)
                    .WithMany(p => p.Kontrahent)
                    .HasForeignKey(d => d.IdRabatu)
                    .HasConstraintName("FK_Kontrahent_Rabat");

                entity.HasOne(d => d.IdRodzajuDokumentowNavigation)
                    .WithMany(p => p.Kontrahent)
                    .HasForeignKey(d => d.IdRodzajuDokumentow)
                    .HasConstraintName("FK_Kontrahent_RodzajDokumentu");

                entity.HasOne(d => d.IdTypuKontrahentaNavigation)
                    .WithMany(p => p.Kontrahents)
                    .HasForeignKey(d => d.IdTypuKontrahenta)
                    .HasConstraintName("FK_Kontrahent_TypKontrahenta");
            });

            modelBuilder.Entity<KoszykTemp>(entity =>
            {
                entity.ToTable("KoszykTemp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Kraj>(entity =>
            {
                entity.HasKey(e => e.IdKraju);

                entity.ToTable("Kraj");

                entity.Property(e => e.NazwaKraju).HasMaxLength(50);
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.HasKey(e => e.IdMarki);

                entity.ToTable("Marka");
            });

            modelBuilder.Entity<PlanUrlopu>(entity =>
            {
                entity.HasKey(e => e.IdPlanuUrlopu);

                entity.ToTable("PlanUrlopu");

                entity.Property(e => e.DataRozpoczeciaUrlopu).HasColumnType("datetime");

                entity.Property(e => e.DataZakonczeniaUrlopu).HasColumnType("datetime");

                entity.Property(e => e.Dni).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdPracownikaNavigation)
                    .WithMany(p => p.PlanUrlopu)
                    .HasForeignKey(d => d.IdPracownika)
                    .HasConstraintName("FK_PlanUrlopu_Pracownik");

                entity.HasOne(d => d.IdRodzajWolnegoNavigation)
                    .WithMany(p => p.PlanUrlopu)
                    .HasForeignKey(d => d.IdRodzajWolnego)
                    .HasConstraintName("FK_PlanUrlopu_RodzajWolnego");

                entity.HasOne(d => d.IdUrlopuNavigation)
                    .WithMany(p => p.PlanUrlopu)
                    .HasForeignKey(d => d.IdUrlopu)
                    .HasConstraintName("FK_PlanUrlopu_Urlop");
            });

            modelBuilder.Entity<PlatnoscBlikiem>(entity =>
            {
                entity.HasKey(e => e.IdPlatnosciBlikiem);

                entity.ToTable("PlatnoscBlikiem");

                entity.Property(e => e.DataPaltnosci).HasColumnType("datetime");

                entity.HasOne(d => d.IdPlatnoscDoDostawcyNavigation)
                    .WithMany(p => p.PlatnoscBlikiem)
                    .HasForeignKey(d => d.IdPlatnoscDoDostawcy)
                    .HasConstraintName("FK_PlatnoscBlikiem_PlatnoscDoDostawcy");

                entity.HasOne(d => d.IdPlatnoscOdKontrahentaNavigation)
                    .WithMany(p => p.PlatnoscBlikiem)
                    .HasForeignKey(d => d.IdPlatnoscOdKontrahenta)
                    .HasConstraintName("FK_PlatnoscBlikiem_PlatnoscOdKontrahenta");
            });

            modelBuilder.Entity<PlatnoscDoDostawcy>(entity =>
            {
                entity.HasKey(e => e.IdPlatnosciDoDostawcy);

                entity.ToTable("PlatnoscDoDostawcy");

                entity.Property(e => e.KwotaBrutto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KwotaNetto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Marza).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Waluta).HasMaxLength(50);
            });

            modelBuilder.Entity<PlatnoscGotowka>(entity =>
            {
                entity.HasKey(e => e.IdPlatnosciGotowka);

                entity.ToTable("PlatnoscGotowka");

                entity.Property(e => e.DataPaltnosci).HasColumnType("datetime");

                entity.HasOne(d => d.IdPlatnoscDoDostawcyNavigation)
                    .WithMany(p => p.PlatnoscGotowka)
                    .HasForeignKey(d => d.IdPlatnoscDoDostawcy)
                    .HasConstraintName("FK_PlatnoscGotowka_PlatnoscDoDostawcy");

                entity.HasOne(d => d.IdPlatnoscOdKontrahentaNavigation)
                    .WithMany(p => p.PlatnoscGotowka)
                    .HasForeignKey(d => d.IdPlatnoscOdKontrahenta)
                    .HasConstraintName("FK_PlatnoscGotowka_PlatnoscOdKontrahenta");
            });

            modelBuilder.Entity<PlatnoscKarta>(entity =>
            {
                entity.HasKey(e => e.IdPlatnosciKarta);

                entity.Property(e => e.DataPaltnosci).HasColumnType("datetime");

                entity.HasOne(d => d.IdPlatnoscDoDostawcyNavigation)
                    .WithMany(p => p.PlatnoscKarta)
                    .HasForeignKey(d => d.IdPlatnoscDoDostawcy)
                    .HasConstraintName("FK_PlatnoscKarta_PlatnoscDoDostawcy");

                entity.HasOne(d => d.IdPlatnoscOdKontrahentaNavigation)
                    .WithMany(p => p.PlatnoscKarta)
                    .HasForeignKey(d => d.IdPlatnoscOdKontrahenta)
                    .HasConstraintName("FK_PlatnoscKarta_PlatnoscOdKontrahenta");
            });

            modelBuilder.Entity<PlatnoscOdKontrahenta>(entity =>
            {
                entity.HasKey(e => e.IdPlatnosciOdKontrahenta);

                entity.Property(e => e.KwotaBrutto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KwotaNetto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Marza).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Waluta).HasMaxLength(50);
            });

            modelBuilder.Entity<PlatnoscPrzelewem>(entity =>
            {
                entity.HasKey(e => e.IdPlatnosciPrzelewem);

                entity.ToTable("PlatnoscPrzelewem");

                entity.Property(e => e.DataPaltnosci).HasColumnType("datetime");

                entity.HasOne(d => d.IdBankuNavigation)
                    .WithMany(p => p.PlatnoscPrzelewem)
                    .HasForeignKey(d => d.IdBanku)
                    .HasConstraintName("FK_PlatnoscPrzelewem_Bank");

                entity.HasOne(d => d.IdPlatnoscDoDostawcyNavigation)
                    .WithMany(p => p.PlatnoscPrzelewem)
                    .HasForeignKey(d => d.IdPlatnoscDoDostawcy)
                    .HasConstraintName("FK_PlatnoscPrzelewem_PlatnoscDoDostawcy");

                entity.HasOne(d => d.IdPlatnoscOdKontrahentaNavigation)
                    .WithMany(p => p.PlatnoscPrzelewem)
                    .HasForeignKey(d => d.IdPlatnoscOdKontrahenta)
                    .HasConstraintName("FK_PlatnoscPrzelewem_PlatnoscOdKontrahenta");
            });

            modelBuilder.Entity<Platnosci>(entity =>
            {
                entity.HasKey(e => e.IdPlatnosci);

                entity.ToTable("Platnosci");

                entity.Property(e => e.Brutto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Netto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NrKontaBankowego).HasMaxLength(50);

                entity.Property(e => e.RejestrDluznikow).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Waluta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WartoscZamowienia).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdPlatnosciBlikiemNavigation)
                    .WithMany(p => p.Platnosci)
                    .HasForeignKey(d => d.IdPlatnosciBlikiem)
                    .HasConstraintName("FK_Platnosci_PlatnoscBlikiem");

                entity.HasOne(d => d.IdPlatnosciDoDostawcyNavigation)
                    .WithMany(p => p.Platnosci)
                    .HasForeignKey(d => d.IdPlatnosciDoDostawcy)
                    .HasConstraintName("FK_Platnosci_PlatnoscDoDostawcy");

                entity.HasOne(d => d.IdPlatnosciGotowkaNavigation)
                    .WithMany(p => p.Platnosci)
                    .HasForeignKey(d => d.IdPlatnosciGotowka)
                    .HasConstraintName("FK_Platnosci_PlatnoscGotowka");

                entity.HasOne(d => d.IdPlatnosciKartaNavigation)
                    .WithMany(p => p.Platnosci)
                    .HasForeignKey(d => d.IdPlatnosciKarta)
                    .HasConstraintName("FK_Platnosci_PlatnoscKarta");

                entity.HasOne(d => d.IdPlatnosciOdKontrahentaNavigation)
                    .WithMany(p => p.Platnosci)
                    .HasForeignKey(d => d.IdPlatnosciOdKontrahenta)
                    .HasConstraintName("FK_Platnosci_PlatnoscOdKontrahenta");

                entity.HasOne(d => d.IdPlatnosciPrzelewemNavigation)
                    .WithMany(p => p.Platnosci)
                    .HasForeignKey(d => d.IdPlatnosciPrzelewem)
                    .HasConstraintName("FK_Platnosci_PlatnoscPrzelewem");
            });

            modelBuilder.Entity<Plec>(entity =>
            {
                entity.HasKey(e => e.IdPlci);

                entity.ToTable("Plec");

                entity.Property(e => e.NazwaPlci).HasMaxLength(50);
            });

            modelBuilder.Entity<Pracownik>(entity =>
            {
                entity.HasKey(e => e.IdPracownika);

                entity.ToTable("Pracownik");

                entity.Property(e => e.DataRozpPracyP).HasColumnType("datetime");

                entity.Property(e => e.DataUrodzeniaP).HasColumnType("datetime");

                entity.Property(e => e.DataZatrudnieniaP).HasColumnType("datetime");

                entity.Property(e => e.DataZwolnieniaP).HasColumnType("datetime");

                entity.Property(e => e.DodatkoweDniUrlopuP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DrugieImieP).HasMaxLength(50);

                entity.Property(e => e.EmailP).HasMaxLength(50);

                entity.Property(e => e.GminaP).HasMaxLength(50);

                entity.Property(e => e.IdWynagrodzenie).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ImieMatkiP).HasMaxLength(50);

                entity.Property(e => e.ImieOjcaP).HasMaxLength(50);

                entity.Property(e => e.ImieP).HasMaxLength(50);

                entity.Property(e => e.KodPocztowyP).HasMaxLength(50);

                entity.Property(e => e.KrajP).HasMaxLength(50);

                entity.Property(e => e.LimitUrlopuP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MiejscowoscP).HasMaxLength(50);

                entity.Property(e => e.NazwiskoP).HasMaxLength(50);

                entity.Property(e => e.NazwiskoRodoweP).HasMaxLength(50);

                entity.Property(e => e.NrDomuP).HasMaxLength(50);

                entity.Property(e => e.NrLokaluP).HasMaxLength(50);

                entity.Property(e => e.NrPaszportuP).HasMaxLength(50);

                entity.Property(e => e.Peselp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PESELP");

                entity.Property(e => e.PlecP).HasMaxLength(50);

                entity.Property(e => e.PowiatP).HasMaxLength(50);

                entity.Property(e => e.PozostaloP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RodzajUmowyP).HasMaxLength(50);

                entity.Property(e => e.RodzajZatrudnieniaP).HasMaxLength(50);

                entity.Property(e => e.StanowiskoP).HasMaxLength(50);

                entity.Property(e => e.StawkaP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TelefonP).HasMaxLength(50);

                entity.Property(e => e.UlicaP).HasMaxLength(50);

                entity.Property(e => e.WojewodzctwoP).HasMaxLength(50);

                entity.Property(e => e.WykorzystanoP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WymiarEtatuP).HasMaxLength(20);

                entity.HasOne(d => d.IdAdresuNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdAdresu)
                    .HasConstraintName("FK_Pracownik_Adres");

                entity.HasOne(d => d.IdBankuNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdBanku)
                    .HasConstraintName("FK_Pracownik_Bank");

                entity.HasOne(d => d.IdDanePersonalneNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdDanePersonalne)
                    .HasConstraintName("FK_Pracownik_DanePersonalne");

                entity.HasOne(d => d.IdPlciNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdPlci)
                    .HasConstraintName("FK_Pracownik_Plec");

                entity.HasOne(d => d.IdStanowiskoPracownikaNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdStanowiskoPracownika)
                    .HasConstraintName("FK_Pracownik_StanowiskoPracownika");

                entity.HasOne(d => d.IdUrlopuNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdUrlopu)
                    .HasConstraintName("FK_Pracownik_Urlop");

                entity.HasOne(d => d.IdUzytkownikaNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdUzytkownika)
                    .HasConstraintName("FK_Pracownik_Uzytkownik");

                entity.HasOne(d => d.IdZatrudnieniaNavigation)
                    .WithMany(p => p.Pracownik)
                    .HasForeignKey(d => d.IdZatrudnienia)
                    .HasConstraintName("FK_Pracownik_Zatrudnienie");
            });

            modelBuilder.Entity<Producent>(entity =>
            {
                entity.HasKey(e => e.IdProducenta);

                entity.ToTable("Producent");

                entity.Property(e => e.Gwarancja).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NazwaProducenta).HasMaxLength(50);
            });

            modelBuilder.Entity<Rabat>(entity =>
            {
                entity.HasKey(e => e.IdRabatu);

                entity.ToTable("Rabat");

                entity.Property(e => e.Procent).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Reklamacje>(entity =>
            {
                entity.HasKey(e => e.IdReklamacji);

                entity.ToTable("Reklamacje");

                entity.Property(e => e.DataGwarancjiDo).HasColumnType("datetime");

                entity.Property(e => e.DataPowstaniaWady).HasColumnType("datetime");

                entity.Property(e => e.DataZakupu).HasColumnType("datetime");

                entity.Property(e => e.DokumentR).HasMaxLength(50);

                entity.Property(e => e.DostawcaR).HasMaxLength(50);

                entity.Property(e => e.EmailR).HasMaxLength(50);

                entity.Property(e => e.IloscR).HasMaxLength(50);

                entity.Property(e => e.ImieR).HasMaxLength(50);

                entity.Property(e => e.JednostkaR).HasMaxLength(50);

                entity.Property(e => e.KodPocztowyR).HasMaxLength(50);

                entity.Property(e => e.MiejscowoscR).HasMaxLength(50);

                entity.Property(e => e.NazwiskoR).HasMaxLength(50);

                entity.Property(e => e.NrDomuR).HasMaxLength(50);

                entity.Property(e => e.NrLokaluR).HasMaxLength(50);

                entity.Property(e => e.Peselr)
                    .HasMaxLength(50)
                    .HasColumnName("PESELR");

                entity.Property(e => e.TelefonR).HasMaxLength(50);

                entity.Property(e => e.TowaryR).HasMaxLength(50);

                entity.Property(e => e.UlicaR).HasMaxLength(50);

                entity.Property(e => e.ZadaniaReklamujacegoR).HasMaxLength(50);

                entity.HasOne(d => d.IdDodatkoweNavigation)
                    .WithMany(p => p.Reklamacje)
                    .HasForeignKey(d => d.IdDodatkowe)
                    .HasConstraintName("FK_Reklamacje_Dodatkowe");

                entity.HasOne(d => d.IdDokumentuSprzedazyNavigation)
                    .WithMany(p => p.Reklamacje)
                    .HasForeignKey(d => d.IdDokumentuSprzedazy)
                    .HasConstraintName("FK_Reklamacje_DokumentSprzedazy");

                entity.HasOne(d => d.IdKontrahentaNavigation)
                    .WithMany(p => p.Reklamacje)
                    .HasForeignKey(d => d.IdKontrahenta)
                    .HasConstraintName("FK_Reklamacje_Kontrahent");

                entity.HasOne(d => d.IdStatusuNavigation)
                    .WithMany(p => p.Reklamacje)
                    .HasForeignKey(d => d.IdStatusu)
                    .HasConstraintName("FK_Reklamacje_Status");

                entity.HasOne(d => d.IdTowaruNavigation)
                    .WithMany(p => p.Reklamacje)
                    .HasForeignKey(d => d.IdTowaru)
                    .HasConstraintName("FK_Reklamacje_Towar");

                entity.HasOne(d => d.IdZadanieReklamujacegoNavigation)
                    .WithMany(p => p.Reklamacjes)
                    .HasForeignKey(d => d.IdZadanieReklamujacego)
                    .HasConstraintName("FK_Reklamacje_ZadanieReklamujacego");
            });

            modelBuilder.Entity<RodzajDokumentu>(entity =>
            {
                entity.HasKey(e => e.IdRodzajuDokumentow);

                entity.ToTable("RodzajDokumentu");

                entity.Property(e => e.Dokument).HasMaxLength(50);
            });

            modelBuilder.Entity<RodzajUmowy>(entity =>
            {
                entity.HasKey(e => e.IdRodzajuUmowy);

                entity.ToTable("RodzajUmowy");

                entity.Property(e => e.NazwaUmowy).HasMaxLength(50);
            });

            modelBuilder.Entity<RodzajWolnego>(entity =>
            {
                entity.HasKey(e => e.IdRodzajWolnego);

                entity.ToTable("RodzajWolnego");

                entity.Property(e => e.NazwaWolnego).HasMaxLength(50);
            });

            modelBuilder.Entity<RodzajZatrudnienia>(entity =>
            {
                entity.HasKey(e => e.IdRodzajZatrudnienia);

                entity.Property(e => e.NazwaRodzajuZatrudnienia).HasMaxLength(50);
            });

            modelBuilder.Entity<SklepElementKoszyka>(entity =>
            {
                entity.HasKey(e => e.IdElementuKoszyka);

                entity.ToTable("SklepElementKoszyka");

                //entity.HasIndex(e => e.IdTowaru, "IX_SklepElementKoszyka_SklepTowarIdTowaru");

                entity.HasOne(d => d.SklepTowarIdTowaruNavigation)
                    .WithMany(p => p.SklepElementKoszyka)
                    .HasForeignKey(d => d.IdTowaru);
            });

            modelBuilder.Entity<SklepRodzaj>(entity =>
            {
                entity.HasKey(e => e.IdRodzaju);

                entity.ToTable("SklepRodzaj");

                entity.Property(e => e.Nazwa).HasMaxLength(30);
            });

            modelBuilder.Entity<SklepTowar>(entity =>
            {
                entity.HasKey(e => e.IdTowaru);

                entity.ToTable("SklepTowar");

                entity.Property(e => e.Cena).HasColumnType("money");
            });

            modelBuilder.Entity<SortowanieDokumentow>(entity =>
            {
                entity.HasKey(e => e.SortujDokumenty);

                entity.ToTable("SortowanieDokumentow");

                entity.Property(e => e.NazwaSortowaniaDokumentow).HasMaxLength(50);
            });

            modelBuilder.Entity<SortowaniePracownikow>(entity =>
            {
                entity.HasKey(e => e.SortujPracownikow);

                entity.ToTable("SortowaniePracownikow");

                entity.Property(e => e.NazwaSortowaniaPracownikow).HasMaxLength(50);
            });

            modelBuilder.Entity<SortowanieReklamacji>(entity =>
            {
                entity.HasKey(e => e.SortujEtapReklamacji);

                entity.ToTable("SortowanieReklamacji");

                entity.Property(e => e.NazwaSortowaniaEtapuReklamacji).HasMaxLength(50);
            });

            modelBuilder.Entity<SortowanieTowaru>(entity =>
            {
                entity.HasKey(e => e.SortujTowar);

                entity.ToTable("SortowanieTowaru");

                entity.Property(e => e.NazwaSortowaniaTowaru).HasMaxLength(50);
            });

            modelBuilder.Entity<SortowanieUrlopow>(entity =>
            {
                entity.HasKey(e => e.SortujUrlop);

                entity.ToTable("SortowanieUrlopow");

                entity.Property(e => e.NazwaSortowaniaUrlopu).HasMaxLength(50);
            });

            modelBuilder.Entity<SortowanieUzytkownikow>(entity =>
            {
                entity.HasKey(e => e.SortujUzytkownikow);

                entity.ToTable("SortowanieUzytkownikow");

                entity.Property(e => e.NazwaSortowaniaUzytkownikow).HasMaxLength(50);
            });

            modelBuilder.Entity<SposobPlatnosci>(entity =>
            {
                entity.HasKey(e => e.IdSposobuPlatnosci);

                entity.ToTable("SposobPlatnosci");

                entity.Property(e => e.NazwaSposobuPlatnosci).HasMaxLength(50);
            });

            modelBuilder.Entity<StanowiskoPracownika>(entity =>
            {
                entity.HasKey(e => e.IdStanowiskoPracownika);

                entity.ToTable("StanowiskoPracownika");

                entity.Property(e => e.NazwaStanowiska)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatusu);

                entity.ToTable("Status");

                entity.Property(e => e.NazwaStatusu).HasMaxLength(50);
            });

            modelBuilder.Entity<SzczegolyTowaru>(entity =>
            {
                entity.HasKey(e => e.IdSzczegolyTowaru);

                entity.ToTable("SzczegolyTowaru");

                entity.Property(e => e.OkresGwarancji).HasMaxLength(50);

                entity.HasOne(d => d.IdDodatkoweNavigation)
                    .WithMany(p => p.SzczegolyTowaru)
                    .HasForeignKey(d => d.IdDodatkowe)
                    .HasConstraintName("FK_SzczegolyTowaru_Dodatkowe");

                entity.HasOne(d => d.IdKategoriiTowaruNavigation)
                    .WithMany(p => p.SzczegolyTowaru)
                    .HasForeignKey(d => d.IdKategoriiTowaru)
                    .HasConstraintName("FK_SzczegolyTowaru_KategoriaTowaru");

                entity.HasOne(d => d.IdMarkiNavigation)
                    .WithMany(p => p.SzczegolyTowaru)
                    .HasForeignKey(d => d.IdMarki)
                    .HasConstraintName("FK_SzczegolyTowaru_Marka");
            });

            modelBuilder.Entity<Towar>(entity =>
            {
                entity.HasKey(e => e.IdTowaru);

                entity.ToTable("Towar");

                entity.Property(e => e.CenaBrutto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CenaNetto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdTypKontrahenta).HasColumnName("idTypKontrahenta");

                entity.Property(e => e.Ilosc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JednostkaMiary).HasMaxLength(20);

                entity.Property(e => e.KategoriaTowaruT).HasMaxLength(50);

                entity.Property(e => e.Kod).HasMaxLength(50);

                entity.Property(e => e.MarkaT).HasMaxLength(50);

                entity.Property(e => e.Marza).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProducentT).HasMaxLength(50);

                entity.Property(e => e.StawkaVatSprzedazy).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StawkaVatZakupu).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdDodatkoweNavigation)
                    .WithMany(p => p.Towar)
                    .HasForeignKey(d => d.IdDodatkowe)
                    .HasConstraintName("FK_Towar_Dodatkowe");

                entity.HasOne(d => d.IdKategoriiTowaruNavigation)
                    .WithMany(p => p.Towar)
                    .HasForeignKey(d => d.IdKategoriiTowaru)
                    .HasConstraintName("FK_Towar_KategoriaTowaru");

                entity.HasOne(d => d.IdMarkiNavigation)
                    .WithMany(p => p.Towar)
                    .HasForeignKey(d => d.IdMarki)
                    .HasConstraintName("FK_Towar_Marka");

                entity.HasOne(d => d.IdProducentaNavigation)
                    .WithMany(p => p.Towar)
                    .HasForeignKey(d => d.IdProducenta)
                    .HasConstraintName("FK_Towar_Producent");

                entity.HasOne(d => d.IdRodzajuDokumentowNavigation)
                    .WithMany(p => p.Towar)
                    .HasForeignKey(d => d.IdRodzajuDokumentow)
                    .HasConstraintName("FK_Towar_RodzajDokumentu");

                entity.HasOne(d => d.IdTypKontrahentaNavigation)
                    .WithMany(p => p.Towars)
                    .HasForeignKey(d => d.IdTypKontrahenta)
                    .HasConstraintName("FK_Towar_TypKontrahenta");
            });

            modelBuilder.Entity<TypKontrahenta>(entity =>
            {
                entity.HasKey(e => e.IdTypuKontrahenta);

                entity.Property(e => e.Dostawca).HasMaxLength(50);

                entity.Property(e => e.Odbiorca).HasMaxLength(50);

                entity.Property(e => e.Zablokowany).HasMaxLength(50);

                entity.HasOne(d => d.IdAdresuNavigation)
                    .WithMany(p => p.TypKontrahenta)
                    .HasForeignKey(d => d.IdAdresu)
                    .HasConstraintName("FK_TypKontrahenta_Adres");

                entity.HasOne(d => d.IdDanePersonalneNavigation)
                    .WithMany(p => p.TypKontrahenta)
                    .HasForeignKey(d => d.IdDanePersonalne)
                    .HasConstraintName("FK_TypKontrahenta_DanePersonalne");

                entity.HasOne(d => d.IdDodatkoweNavigation)
                    .WithMany(p => p.TypKontrahenta)
                    .HasForeignKey(d => d.IdDodatkowe)
                    .HasConstraintName("FK_TypKontrahenta_Dodatkowe");

                entity.HasOne(d => d.IdRodzajuDokumentowNavigation)
                    .WithMany(p => p.TypKontrahenta)
                    .HasForeignKey(d => d.IdRodzajuDokumentow)
                    .HasConstraintName("FK_TypKontrahenta_RodzajDokumentu");
            });

            modelBuilder.Entity<Urlop>(entity =>
            {
                entity.HasKey(e => e.IdUrlopu);

                entity.ToTable("Urlop");

                entity.Property(e => e.DataRozpUrlopuU).HasColumnType("date");

                entity.Property(e => e.DataUrodzeniaU).HasColumnType("date");

                entity.Property(e => e.DataZakonczeniaUrlopu).HasColumnType("date");

                entity.Property(e => e.DodatkoweDniUrlopu).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DrugieImieU).HasMaxLength(50);

                entity.Property(e => e.EmailU).HasMaxLength(50);

                entity.Property(e => e.GminaU).HasMaxLength(50);

                entity.Property(e => e.ImieMatkiU).HasMaxLength(50);

                entity.Property(e => e.ImieOjcaU).HasMaxLength(50);

                entity.Property(e => e.ImieU).HasMaxLength(50);

                entity.Property(e => e.KrajU).HasMaxLength(50);

                entity.Property(e => e.LimitUrlopuU).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MiejscowoscU).HasMaxLength(50);

                entity.Property(e => e.NazwaPracownikU).HasMaxLength(50);

                entity.Property(e => e.NazwiskoRodMatU).HasMaxLength(50);

                entity.Property(e => e.NazwiskoU).HasMaxLength(50);

                entity.Property(e => e.NrDomuU).HasMaxLength(50);

                entity.Property(e => e.NrLokaluU).HasMaxLength(50);

                entity.Property(e => e.NrPaszportuU).HasMaxLength(50);

                entity.Property(e => e.PowiatU).HasMaxLength(50);

                entity.Property(e => e.RodzajUmowyU).HasMaxLength(50);

                entity.Property(e => e.RodzajUrlopuU).HasMaxLength(50);

                entity.Property(e => e.StanowiskoU).HasMaxLength(50);

                entity.Property(e => e.TelefonU).HasMaxLength(50);

                entity.Property(e => e.UlicaU).HasMaxLength(50);

                entity.Property(e => e.WojewodzctwoU).HasMaxLength(50);

                entity.Property(e => e.WykorzystanoU).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WymiarEtatuU).HasMaxLength(20);

                entity.HasOne(d => d.IdRodzajWolnegoNavigation)
                    .WithMany(p => p.Urlop)
                    .HasForeignKey(d => d.IdRodzajWolnego)
                    .HasConstraintName("FK_Urlop_RodzajWolnego");
            });

            modelBuilder.Entity<Uzytkownik>(entity =>
            {
                entity.HasKey(e => e.IdUzytkownika);

                entity.ToTable("Uzytkownik");

                entity.HasOne(d => d.IdDaneLogowaniaNavigation)
                    .WithMany(p => p.Uzytkownik)
                    .HasForeignKey(d => d.IdDaneLogowania)
                    .HasConstraintName("FK_Uzytkownik_DaneLogowania");

                entity.HasOne(d => d.IdDanePersonalneNavigation)
                    .WithMany(p => p.Uzytkownik)
                    .HasForeignKey(d => d.IdDanePersonalne)
                    .HasConstraintName("FK_Uzytkownik_DanePersonalne");

                entity.HasOne(d => d.IdStanowiskoPracownikaNavigation)
                    .WithMany(p => p.Uzytkownik)
                    .HasForeignKey(d => d.IdStanowiskoPracownika)
                    .HasConstraintName("FK_Uzytkownik_StanowiskoPracownika");
            });

            modelBuilder.Entity<Vat>(entity =>
            {
                entity.HasKey(e => e.Vat1);

                entity.ToTable("VAT");

                entity.Property(e => e.Vat1)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<Wojewodzctwo>(entity =>
            {
                entity.HasKey(e => e.IdWojewodzctwa);

                entity.ToTable("Wojewodzctwo");

                entity.Property(e => e.NazwaWojewodzctwa).HasMaxLength(50);
            });

            modelBuilder.Entity<Wynagrodzenie>(entity =>
            {
                entity.HasKey(e => e.IdWynagrodzenia);

                entity.ToTable("Wynagrodzenie");

                entity.Property(e => e.Stawka).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdPracownikaNavigation)
                    .WithMany(p => p.Wynagrodzenie)
                    .HasForeignKey(d => d.IdPracownika)
                    .HasConstraintName("FK_Wynagrodzenie_Pracownik");

                entity.HasOne(d => d.IdRodzajZatrudnieniaNavigation)
                    .WithMany(p => p.Wynagrodzenie)
                    .HasForeignKey(d => d.IdRodzajZatrudnienia)
                    .HasConstraintName("FK_Wynagrodzenie_RodzajZatrudnienia");

                entity.HasOne(d => d.IdRodzajuUmowyNavigation)
                    .WithMany(p => p.Wynagrodzenie)
                    .HasForeignKey(d => d.IdRodzajuUmowy)
                    .HasConstraintName("FK_Wynagrodzenie_RodzajUmowy");

                entity.HasOne(d => d.IdStanowiskoPracownikaNavigation)
                    .WithMany(p => p.Wynagrodzenie)
                    .HasForeignKey(d => d.IdStanowiskoPracownika)
                    .HasConstraintName("FK_Wynagrodzenie_StanowiskoPracownika");

                entity.HasOne(d => d.IdZatrudnieniaNavigation)
                    .WithMany(p => p.Wynagrodzenie)
                    .HasForeignKey(d => d.IdZatrudnienia)
                    .HasConstraintName("FK_Wynagrodzenie_Zatrudnienie");
            });

            modelBuilder.Entity<ZadanieReklamujacego>(entity =>
            {
                entity.HasKey(e => e.IdZadanieReklamujacego);

                entity.ToTable("ZadanieReklamujacego");

                entity.Property(e => e.NazwaZadanie).HasMaxLength(50);
            });

            modelBuilder.Entity<ZakresWyszukiwaniaDaty>(entity =>
            {
                entity.HasKey(e => e.ZakresyWyszukiwaniaDaty);

                entity.ToTable("ZakresWyszukiwaniaDaty");

                entity.Property(e => e.NazwaZakresuWyszukiwaniaDaty).HasMaxLength(50);
            });

            modelBuilder.Entity<ZakupTowaru>(entity =>
            {
                entity.HasKey(e => e.IdZakupuTowaru);

                entity.ToTable("ZakupTowaru");

                entity.HasOne(d => d.IdDodatkoweNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdDodatkowe)
                    .HasConstraintName("FK_ZakupTowaru_Dodatkowe");

                entity.HasOne(d => d.IdDokumentuSprzedazyNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdDokumentuSprzedazy)
                    .HasConstraintName("FK_ZakupTowaru_DokumentSprzedazy");

                entity.HasOne(d => d.IdKontrahentaNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdKontrahenta)
                    .HasConstraintName("FK_ZakupTowaru_Kontrahent");

                entity.HasOne(d => d.IdPlatnosciNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdPlatnosci)
                    .HasConstraintName("FK_ZakupTowaru_Platnosci");

                entity.HasOne(d => d.IdRabatuNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdRabatu)
                    .HasConstraintName("FK_ZakupTowaru_Rabat");

                entity.HasOne(d => d.IdRodzajuDokumentowNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdRodzajuDokumentow)
                    .HasConstraintName("FK_ZakupTowaru_RodzajDokumentu");

                entity.HasOne(d => d.IdSposobuPlatnosciNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdSposobuPlatnosci)
                    .HasConstraintName("FK_ZakupTowaru_SposobPlatnosci");

                entity.HasOne(d => d.IdSzczegolyTowaruNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdSzczegolyTowaru)
                    .HasConstraintName("FK_ZakupTowaru_SzczegolyTowaru");

                entity.HasOne(d => d.IdTowaruNavigation)
                    .WithMany(p => p.ZakupTowaru)
                    .HasForeignKey(d => d.IdTowaru)
                    .HasConstraintName("FK_ZakupTowaru_Towar");
            });

            modelBuilder.Entity<Zatrudnienie>(entity =>
            {
                entity.HasKey(e => e.IdZatrudnienia);

                entity.ToTable("Zatrudnienie");

                entity.Property(e => e.DataRoczpoczeciaPracy).HasColumnType("datetime");

                entity.Property(e => e.DataZatrudnienia).HasColumnType("datetime");

                entity.Property(e => e.DataZwolnienia).HasColumnType("datetime");

                entity.Property(e => e.WymiarEtatu).HasMaxLength(50);

                entity.HasOne(d => d.IdRodzajuUmowyNavigation)
                    .WithMany(p => p.Zatrudnienie)
                    .HasForeignKey(d => d.IdRodzajuUmowy)
                    .HasConstraintName("FK_Zatrudnienie_RodzajZatrudnienia");

                entity.HasOne(d => d.IdRodzajuUmowy1)
                    .WithMany(p => p.Zatrudnienie)
                    .HasForeignKey(d => d.IdRodzajuUmowy)
                    .HasConstraintName("FK_Zatrudnienie_RodzajUmowy");

                entity.HasOne(d => d.IdStanowiskoPracownikaNavigation)
                    .WithMany(p => p.Zatrudnienie)
                    .HasForeignKey(d => d.IdStanowiskoPracownika)
                    .HasConstraintName("FK_Zatrudnienie_StanowiskoPracownika");

                entity.HasOne(d => d.IdUrlopNavigation)
                    .WithMany(p => p.Zatrudnienie)
                    .HasForeignKey(d => d.IdUrlop)
                    .HasConstraintName("FK_Zatrudnienie_Urlop");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
