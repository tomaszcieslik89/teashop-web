using System;
using System.Collections.Generic;

namespace Firma.Data.Models.CMS
{
    public partial class CMSParametr
    {
        public int IdParametru { get; set; }
        public string Kod { get; set; } = null!;
        public string Nazwa { get; set; } = null!;
        public string Wartosc { get; set; } = null!;
        public string Opis { get; set; } = null!;
    }
}
