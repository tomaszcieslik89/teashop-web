using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Kraj
    {
        public Kraj()
        {
            Adres = new HashSet<Adres>();
        }

        public int IdKraju { get; set; }
        public string? NazwaKraju { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Adres> Adres { get; set; }
    }
}
