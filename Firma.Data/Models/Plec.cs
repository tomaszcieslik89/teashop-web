using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Plec
    {
        public Plec()
        {
            Kontrahent = new HashSet<Kontrahent>();
            Pracownik = new HashSet<Pracownik>();
        }

        public int IdPlci { get; set; }
        public string? NazwaPlci { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Kontrahent> Kontrahent { get; set; }
        public virtual ICollection<Pracownik> Pracownik { get; set; }
    }
}
