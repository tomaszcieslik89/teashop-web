using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class ZadanieReklamujacego
    {
        public ZadanieReklamujacego()
        {
            Reklamacjes = new HashSet<Reklamacje>();
        }

        public int IdZadanieReklamujacego { get; set; }
        public string? NazwaZadanie { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Reklamacje> Reklamacjes { get; set; }
    }
}
