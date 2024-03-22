using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class RodzajUmowy
    {
        public RodzajUmowy()
        {
            Wynagrodzenie = new HashSet<Wynagrodzenie>();
            Zatrudnienie = new HashSet<Zatrudnienie>();
        }

        public int IdRodzajuUmowy { get; set; }
        public string? NazwaUmowy { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Wynagrodzenie> Wynagrodzenie { get; set; }
        public virtual ICollection<Zatrudnienie> Zatrudnienie { get; set; }
    }
}
