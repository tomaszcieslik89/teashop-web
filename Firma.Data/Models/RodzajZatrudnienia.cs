using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class RodzajZatrudnienia
    {
        public RodzajZatrudnienia()
        {
            Wynagrodzenie = new HashSet<Wynagrodzenie>();
            Zatrudnienie = new HashSet<Zatrudnienie>();
        }

        public int IdRodzajZatrudnienia { get; set; }
        public string? NazwaRodzajuZatrudnienia { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Wynagrodzenie> Wynagrodzenie { get; set; }
        public virtual ICollection<Zatrudnienie> Zatrudnienie { get; set; }
    }
}
