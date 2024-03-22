using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Wynagrodzenie
    {
        public int IdWynagrodzenia { get; set; }
        public decimal? Stawka { get; set; }
        public int? IdPracownika { get; set; }
        public int? IdRodzajuUmowy { get; set; }
        public int? IdRodzajZatrudnienia { get; set; }
        public int? IdStanowiskoPracownika { get; set; }
        public int? IdZatrudnienia { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Pracownik? IdPracownikaNavigation { get; set; }
        public virtual RodzajZatrudnienia? IdRodzajZatrudnieniaNavigation { get; set; }
        public virtual RodzajUmowy? IdRodzajuUmowyNavigation { get; set; }
        public virtual StanowiskoPracownika? IdStanowiskoPracownikaNavigation { get; set; }
        public virtual Zatrudnienie? IdZatrudnieniaNavigation { get; set; }
    }
}
