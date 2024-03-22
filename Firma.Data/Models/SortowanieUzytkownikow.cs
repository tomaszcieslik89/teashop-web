using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class SortowanieUzytkownikow
    {
        public int SortujUzytkownikow { get; set; }
        public string? NazwaSortowaniaUzytkownikow { get; set; }
        public bool? CzyAktywny { get; set; }
    }
}
