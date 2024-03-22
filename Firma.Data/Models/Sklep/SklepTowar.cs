using System;
using System.Collections.Generic;

namespace Firma.Data.Models.Sklep
{
    public partial class SklepTowar
    {
        public SklepTowar()
        {
            SklepElementKoszyka = new HashSet<SklepElementKoszyka>();
        }
        public int IdTowaru { get; set; }
        public string Kod { get; set; } = null!;
        public string Nazwa { get; set; } = null!;
        public decimal Cena { get; set; }
        public string Foto { get; set; } = null!;
        public string Opis { get; set; } = null!;
        public int IdRodzaju { get; set; }
        public bool Promocja { get; set; }

        public virtual ICollection<SklepElementKoszyka> SklepElementKoszyka { get; set; }
    }
}
