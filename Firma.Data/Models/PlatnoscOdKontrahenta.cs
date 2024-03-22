using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class PlatnoscOdKontrahenta
    {
        public PlatnoscOdKontrahenta()
        {
            PlatnoscBlikiem = new HashSet<PlatnoscBlikiem>();
            PlatnoscGotowka = new HashSet<PlatnoscGotowka>();
            PlatnoscKarta = new HashSet<PlatnoscKarta>();
            PlatnoscPrzelewem = new HashSet<PlatnoscPrzelewem>();
            Platnosci = new HashSet<Platnosci>();
        }

        public int IdPlatnosciOdKontrahenta { get; set; }
        public string? Waluta { get; set; }
        public decimal? KwotaNetto { get; set; }
        public decimal? KwotaBrutto { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Marza { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<PlatnoscBlikiem> PlatnoscBlikiem { get; set; }
        public virtual ICollection<PlatnoscGotowka> PlatnoscGotowka { get; set; }
        public virtual ICollection<PlatnoscKarta> PlatnoscKarta { get; set; }
        public virtual ICollection<PlatnoscPrzelewem> PlatnoscPrzelewem { get; set; }
        public virtual ICollection<Platnosci> Platnosci { get; set; }
    }
}
