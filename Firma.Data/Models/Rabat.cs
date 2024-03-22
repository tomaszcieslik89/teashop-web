using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Rabat
    {
        public Rabat()
        {
            DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            Kontrahent = new HashSet<Kontrahent>();
            ZakupTowaru = new HashSet<ZakupTowaru>();
        }

        public int IdRabatu { get; set; }
        public decimal? Procent { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<Kontrahent> Kontrahent { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
