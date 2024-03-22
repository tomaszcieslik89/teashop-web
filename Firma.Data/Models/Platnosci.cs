using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Platnosci
    {
        public Platnosci()
        {
            DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            Kontrahent = new HashSet<Kontrahent>();
            ZakupTowaru = new HashSet<ZakupTowaru>();
        }

        public int IdPlatnosci { get; set; }
        public decimal? Waluta { get; set; }
        public string? NrKontaBankowego { get; set; }
        public decimal? Netto { get; set; }
        public decimal? Brutto { get; set; }
        public decimal? WartoscZamowienia { get; set; }
        public decimal? RejestrDluznikow { get; set; }
        public int? IdPlatnosciOdKontrahenta { get; set; }
        public int? IdPlatnosciDoDostawcy { get; set; }
        public int? IdPlatnosciPrzelewem { get; set; }
        public int? IdPlatnosciKarta { get; set; }
        public int? IdPlatnosciGotowka { get; set; }
        public int? IdPlatnosciBlikiem { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual PlatnoscBlikiem? IdPlatnosciBlikiemNavigation { get; set; }
        public virtual PlatnoscDoDostawcy? IdPlatnosciDoDostawcyNavigation { get; set; }
        public virtual PlatnoscGotowka? IdPlatnosciGotowkaNavigation { get; set; }
        public virtual PlatnoscKarta? IdPlatnosciKartaNavigation { get; set; }
        public virtual PlatnoscOdKontrahenta? IdPlatnosciOdKontrahentaNavigation { get; set; }
        public virtual PlatnoscPrzelewem? IdPlatnosciPrzelewemNavigation { get; set; }
        public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<Kontrahent> Kontrahent { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
