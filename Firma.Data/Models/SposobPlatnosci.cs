using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class SposobPlatnosci
    {
        public SposobPlatnosci()
        {
            DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            ZakupTowaru = new HashSet<ZakupTowaru>();
        }

        public int IdSposobuPlatnosci { get; set; }
        public string? NazwaSposobuPlatnosci { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
