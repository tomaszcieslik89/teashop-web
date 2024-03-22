using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class PlatnoscPrzelewem
    {
        public PlatnoscPrzelewem()
        {
            Platnosci = new HashSet<Platnosci>();
        }

        public int IdPlatnosciPrzelewem { get; set; }
        public int? IdPlatnoscOdKontrahenta { get; set; }
        public int? IdPlatnoscDoDostawcy { get; set; }
        public int? IdBanku { get; set; }
        public DateTime? DataPaltnosci { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Bank? IdBankuNavigation { get; set; }
        public virtual PlatnoscDoDostawcy? IdPlatnoscDoDostawcyNavigation { get; set; }
        public virtual PlatnoscOdKontrahenta? IdPlatnoscOdKontrahentaNavigation { get; set; }
        public virtual ICollection<Platnosci> Platnosci { get; set; }
    }
}
