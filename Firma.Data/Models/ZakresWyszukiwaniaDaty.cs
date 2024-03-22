using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class ZakresWyszukiwaniaDaty
    {
        public int ZakresyWyszukiwaniaDaty { get; set; }
        public string? NazwaZakresuWyszukiwaniaDaty { get; set; }
        public bool? CzyAktywny { get; set; }
    }
}
