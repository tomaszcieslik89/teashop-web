using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Marka
    {
        public Marka()
        {
            SzczegolyTowaru = new HashSet<SzczegolyTowaru>();
            Towar = new HashSet<Towar>();
        }

        public int IdMarki { get; set; }
        public string? NazwaMarki { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<SzczegolyTowaru> SzczegolyTowaru { get; set; }
        public virtual ICollection<Towar> Towar { get; set; }
    }
}
