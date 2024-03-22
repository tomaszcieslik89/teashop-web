using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Wojewodzctwo
    {
        public Wojewodzctwo()
        {
            Adres = new HashSet<Adres>();
        }

        public int IdWojewodzctwa { get; set; }
        public string? NazwaWojewodzctwa { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Adres> Adres { get; set; }
    }
}


