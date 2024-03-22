using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Dodatkowe
    {
        public Dodatkowe()
        {
            DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            Kontrahent = new HashSet<Kontrahent>();
            Reklamacje = new HashSet<Reklamacje>();
            SzczegolyTowaru = new HashSet<SzczegolyTowaru>();
            Towar = new HashSet<Towar>();
            TypKontrahenta = new HashSet<TypKontrahenta>();
            ZakupTowaru = new HashSet<ZakupTowaru>();
        }

        public int IdDodatkowe { get; set; }
        public string? Uwagi { get; set; }
        public string? Opis { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<Kontrahent> Kontrahent { get; set; }
        public virtual ICollection<Reklamacje> Reklamacje { get; set; }
        public virtual ICollection<SzczegolyTowaru> SzczegolyTowaru { get; set; }
        public virtual ICollection<Towar> Towar { get; set; }
        public virtual ICollection<TypKontrahenta> TypKontrahenta { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
