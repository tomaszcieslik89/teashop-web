using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Zatrudnienie
    {
        public Zatrudnienie()
        {
            Pracownik = new HashSet<Pracownik>();
            Wynagrodzenie = new HashSet<Wynagrodzenie>();
        }

        public int IdZatrudnienia { get; set; }
        public DateTime? DataZatrudnienia { get; set; }
        public DateTime? DataRoczpoczeciaPracy { get; set; }
        public DateTime? DataZwolnienia { get; set; }
        public int? IdRodzajuUmowy { get; set; }
        public string? WymiarEtatu { get; set; }
        public int? IdRodzajZatrudnienia { get; set; }
        public int? IdStanowiskoPracownika { get; set; }
        public int? IdUrlop { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual RodzajUmowy? IdRodzajuUmowy1 { get; set; }
        public virtual RodzajZatrudnienia? IdRodzajuUmowyNavigation { get; set; }
        public virtual StanowiskoPracownika? IdStanowiskoPracownikaNavigation { get; set; }
        public virtual Urlop? IdUrlopNavigation { get; set; }
        public virtual ICollection<Pracownik> Pracownik { get; set; }
        public virtual ICollection<Wynagrodzenie> Wynagrodzenie { get; set; }
    }
}