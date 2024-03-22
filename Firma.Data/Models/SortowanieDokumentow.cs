using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class SortowanieDokumentow
    {
        public int SortujDokumenty { get; set; }
        public string? NazwaSortowaniaDokumentow { get; set; }
        public bool? CzyAktywny { get; set; }
    }
}
