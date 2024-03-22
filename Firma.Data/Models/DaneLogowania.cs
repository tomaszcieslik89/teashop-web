using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class DaneLogowania
    {
        public DaneLogowania()
        {
            Uzytkownik = new HashSet<Uzytkownik>();
        }

        public int IdDaneLogowania { get; set; }
        public string? NazwaUzytkownika { get; set; }
        public string? HasloUzytkownika { get; set; }
        public DateTime? DataUtworzenia { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Uzytkownik> Uzytkownik { get; set; }
    }
}
