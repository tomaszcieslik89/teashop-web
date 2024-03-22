using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class SortowanieUrlopow
    {
        public int SortujUrlop { get; set; }
        public string? NazwaSortowaniaUrlopu { get; set; }
        public bool? CzyAktywny { get; set; }
    }
}
