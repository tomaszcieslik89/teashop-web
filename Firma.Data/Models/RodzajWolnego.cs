using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class RodzajWolnego
    {
        public RodzajWolnego()
        {
            PlanUrlopu = new HashSet<PlanUrlopu>();
            Urlop = new HashSet<Urlop>();
        }

        public int IdRodzajWolnego { get; set; }
        public string? NazwaWolnego { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<PlanUrlopu> PlanUrlopu { get; set; }
        public virtual ICollection<Urlop> Urlop { get; set; }
    }
}
