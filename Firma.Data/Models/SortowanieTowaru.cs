using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class SortowanieTowaru
    {
        public int SortujTowar { get; set; }
        public string? NazwaSortowaniaTowaru { get; set; }
        public bool? CzyAktywny { get; set; }
    }
}
