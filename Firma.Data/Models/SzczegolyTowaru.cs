using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class SzczegolyTowaru
    {
        public SzczegolyTowaru()
        {
            ZakupTowaru = new HashSet<ZakupTowaru>();
        }

        public int IdSzczegolyTowaru { get; set; }
        public int? IdDodatkowe { get; set; }
        public int? IdKategoriiTowaru { get; set; }
        public string? OkresGwarancji { get; set; }
        public int? IdMarki { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Dodatkowe? IdDodatkoweNavigation { get; set; }
        public virtual KategoriaTowaru? IdKategoriiTowaruNavigation { get; set; }
        public virtual Marka? IdMarkiNavigation { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
