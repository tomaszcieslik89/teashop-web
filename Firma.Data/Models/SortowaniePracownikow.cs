using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class SortowaniePracownikow
    {
        public int SortujPracownikow { get; set; }
        public string? NazwaSortowaniaPracownikow { get; set; }
        public bool? CzyAktywny { get; set; }
    }
}
