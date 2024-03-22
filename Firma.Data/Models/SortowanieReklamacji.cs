using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class SortowanieReklamacji
    {
        public int SortujEtapReklamacji { get; set; }
        public string? NazwaSortowaniaEtapuReklamacji { get; set; }
        public bool? CzyAktywny { get; set; }
    }
}
