using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Kontrahent = new HashSet<Kontrahent>();
            PlatnoscPrzelewem = new HashSet<PlatnoscPrzelewem>();
            Pracownik = new HashSet<Pracownik>();
        }

        public int IdBanku { get; set; }
        public string? NazwaBanku { get; set; }
        public string? NumerKonta { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Kontrahent> Kontrahent { get; set; }
        public virtual ICollection<PlatnoscPrzelewem> PlatnoscPrzelewem { get; set; }
        public virtual ICollection<Pracownik> Pracownik { get; set; }
    }
}
