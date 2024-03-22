using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class PlanUrlopu
    {
        public int IdPlanuUrlopu { get; set; }
        public int? IdPracownika { get; set; }
        public int? IdUrlopu { get; set; }
        public int? IdRodzajWolnego { get; set; }
        public DateTime? DataRozpoczeciaUrlopu { get; set; }
        public DateTime? DataZakonczeniaUrlopu { get; set; }
        public decimal? Dni { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Pracownik? IdPracownikaNavigation { get; set; }
        public virtual RodzajWolnego? IdRodzajWolnegoNavigation { get; set; }
        public virtual Urlop? IdUrlopuNavigation { get; set; }
    }
}
