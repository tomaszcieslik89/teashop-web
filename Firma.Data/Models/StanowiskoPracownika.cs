using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class StanowiskoPracownika
    {
        public StanowiskoPracownika()
        {
            Pracownik = new HashSet<Pracownik>();
            Uzytkownik = new HashSet<Uzytkownik>();
            Wynagrodzenie = new HashSet<Wynagrodzenie>();
            Zatrudnienie = new HashSet<Zatrudnienie>();
        }

        public int IdStanowiskoPracownika { get; set; }
        public string? NazwaStanowiska { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Pracownik> Pracownik { get; set; }
        public virtual ICollection<Uzytkownik> Uzytkownik { get; set; }
        public virtual ICollection<Wynagrodzenie> Wynagrodzenie { get; set; }
        public virtual ICollection<Zatrudnienie> Zatrudnienie { get; set; }
    }
}
