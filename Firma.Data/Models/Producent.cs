using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Producent
    {
        public Producent()
        {
            Towar = new HashSet<Towar>();
        }

        public int IdProducenta { get; set; }
        public string? NazwaProducenta { get; set; }
        public decimal? Gwarancja { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Towar> Towar { get; set; }
    }
}
