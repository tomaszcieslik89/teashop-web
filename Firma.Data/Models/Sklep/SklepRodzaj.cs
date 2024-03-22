using System;
using System.Collections.Generic;

namespace Firma.Data.Models.Sklep
{
    public partial class SklepRodzaj
    {
        public int IdRodzaju { get; set; }
        public string Nazwa { get; set; } = null!;
        public string Opis { get; set; } = null!;
    }
}
