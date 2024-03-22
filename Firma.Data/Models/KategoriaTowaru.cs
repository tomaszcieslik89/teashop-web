using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class KategoriaTowaru
    {
        public KategoriaTowaru()
        {
            SzczegolyTowaru = new HashSet<SzczegolyTowaru>();
            Towar = new HashSet<Towar>();
        }

        public int IdKategoriiTowaru { get; set; }
        public string? NazwaKategorii { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<SzczegolyTowaru> SzczegolyTowaru { get; set; }
        public virtual ICollection<Towar> Towar { get; set; }
    }
}
