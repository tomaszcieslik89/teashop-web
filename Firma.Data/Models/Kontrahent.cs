using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Kontrahent
    {
        public Kontrahent()
        {
            DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            Reklamacje = new HashSet<Reklamacje>();
            ZakupTowaru = new HashSet<ZakupTowaru>();
        }

        public int IdKontrahenta { get; set; }
        public int? IdAdresu { get; set; }
        public int? IdTypuKontrahenta { get; set; }
        public int? IdRodzajuDokumentow { get; set; }
        public int? IdPlatnosci { get; set; }
        public int? IdRabatu { get; set; }
        public int? IdDodatkowe { get; set; }
        public int? IdDanePersonalne { get; set; }
        public int? IdPlci { get; set; }
        public int? IdBanku { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Adres? IdAdresuNavigation { get; set; }
        public virtual Bank? IdBankuNavigation { get; set; }
        public virtual DanePersonalne? IdDanePersonalneNavigation { get; set; }
        public virtual Dodatkowe? IdDodatkoweNavigation { get; set; }
        public virtual Platnosci? IdPlatnosciNavigation { get; set; }
        public virtual Plec? IdPlciNavigation { get; set; }
        public virtual Rabat? IdRabatuNavigation { get; set; }
        public virtual RodzajDokumentu? IdRodzajuDokumentowNavigation { get; set; }
        public virtual TypKontrahenta? IdTypuKontrahentaNavigation { get; set; }
        public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<Reklamacje> Reklamacje { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
