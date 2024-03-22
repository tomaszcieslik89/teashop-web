using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class ZakupTowaru
    {
        public int IdZakupuTowaru { get; set; }
        public int? IdDokumentuSprzedazy { get; set; }
        public int? IdDodatkowe { get; set; }
        public int? IdKontrahenta { get; set; }
        public int? IdTowaru { get; set; }
        public int? IdRabatu { get; set; }
        public int? IdSposobuPlatnosci { get; set; }
        public int? IdRodzajuDokumentow { get; set; }
        public int? IdPlatnosci { get; set; }
        public int? IdSzczegolyTowaru { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Dodatkowe? IdDodatkoweNavigation { get; set; }
        public virtual DokumentSprzedazy? IdDokumentuSprzedazyNavigation { get; set; }
        public virtual Kontrahent? IdKontrahentaNavigation { get; set; }
        public virtual Platnosci? IdPlatnosciNavigation { get; set; }
        public virtual Rabat? IdRabatuNavigation { get; set; }
        public virtual RodzajDokumentu? IdRodzajuDokumentowNavigation { get; set; }
        public virtual SposobPlatnosci? IdSposobuPlatnosciNavigation { get; set; }
        public virtual SzczegolyTowaru? IdSzczegolyTowaruNavigation { get; set; }
        public virtual Towar? IdTowaruNavigation { get; set; }
    }
}