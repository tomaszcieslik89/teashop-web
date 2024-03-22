using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class DokumentSprzedazy
    {
        public DokumentSprzedazy()
        {
            //DokumentSprzedazyTowar = new HashSet<DokumentSprzedazyTowar>();
            //Reklamacje = new HashSet<Reklamacje>();
            //ZakupTowaru = new HashSet<ZakupTowaru>();
        }

        public int IdDokumentuSprzedazy { get; set; }
        public string? NumerDokumentu { get; set; }
        public DateTime? TerminPlatnosci { get; set; }
        public DateTime? DataWystawienia { get; set; }
        public int? IdDodatkowe { get; set; }
        public int? IdAdres { get; set; }
        public int? IdDaneParsonalne { get; set; }
        public int? IdRabatu { get; set; }
        public int? IdSposobuPlatnosci { get; set; }
        public int? IdRodzajuDokumentow { get; set; }
        public int? IdPlatnosci { get; set; }
        public int? IdKontrahenta { get; set; }
        public int? PozycjaDokumentu { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Adres? IdAdresNavigation { get; set; }
        public virtual DanePersonalne? IdDaneParsonalneNavigation { get; set; }
        public virtual Dodatkowe? IdDodatkoweNavigation { get; set; }
        public virtual Kontrahent? IdKontrahentaNavigation { get; set; }
        public virtual Platnosci? IdPlatnosciNavigation { get; set; }
        public virtual Rabat? IdRabatuNavigation { get; set; }
        public virtual RodzajDokumentu? IdRodzajuDokumentowNavigation { get; set; }
        public virtual SposobPlatnosci? IdSposobuPlatnosciNavigation { get; set; }
        public virtual ICollection<DokumentSprzedazyTowar>? DokumentSprzedazyTowar { get; set; }
        public virtual ICollection<Reklamacje> Reklamacje { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
