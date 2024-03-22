using System;
using System.Collections.Generic;

namespace Firma.Data.Models.CMS
{
    public partial class CMSAktualnosc
    {
        public int IdAktualnosci { get; set; }
        public string LinkTytul { get; set; } = null!;
        public string Tytul { get; set; } = null!;
        public string Tresc { get; set; } = null!;
        public int Pozycja { get; set; }
    }
}
