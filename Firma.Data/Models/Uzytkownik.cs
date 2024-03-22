using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Uzytkownik
    {
        public Uzytkownik()
        {
            Pracownik = new HashSet<Pracownik>();
        }

        public int IdUzytkownika { get; set; }
        public int? IdDanePersonalne { get; set; }
        public int? IdStanowiskoPracownika { get; set; }
        public int? IdDaneLogowania { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual DaneLogowania? IdDaneLogowaniaNavigation { get; set; }
        public virtual DanePersonalne? IdDanePersonalneNavigation { get; set; }
        public virtual StanowiskoPracownika? IdStanowiskoPracownikaNavigation { get; set; }
        public virtual ICollection<Pracownik> Pracownik { get; set; }
    }
}