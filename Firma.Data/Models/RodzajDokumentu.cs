using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class RodzajDokumentu
    {
        public RodzajDokumentu()
        {
            DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            Kontrahent = new HashSet<Kontrahent>();
            Towar = new HashSet<Towar>();
            TypKontrahenta = new HashSet<TypKontrahenta>();
            ZakupTowaru = new HashSet<ZakupTowaru>();
        }

        public int IdRodzajuDokumentow { get; set; }
        public string? Dokument { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<Kontrahent> Kontrahent { get; set; }
        public virtual ICollection<Towar> Towar { get; set; }
        public virtual ICollection<TypKontrahenta> TypKontrahenta { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
