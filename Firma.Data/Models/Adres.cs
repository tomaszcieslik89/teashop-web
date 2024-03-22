using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Adres
    {
        public Adres()
        {
            DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            Kontrahent = new HashSet<Kontrahent>();
            Pracownik = new HashSet<Pracownik>();
            TypKontrahenta = new HashSet<TypKontrahenta>();
        }

        public int IdAdresu { get; set; }
        public string? Miejscowosc { get; set; }
        public string? Ulica { get; set; }
        public string? NrDomu { get; set; }
        public string? NrLokalu { get; set; }
        public string? KodPocztowy { get; set; }
        public string? Powiat { get; set; }
        public int? IdKraju { get; set; }
        public int? IdWojewodzctwa { get; set; }
        public string? Gmina { get; set; }
        public int? IdDodatkowe { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Kraj? IdKrajuNavigation { get; set; }
        public virtual Wojewodzctwo? IdWojewodzctwaNavigation { get; set; }
        public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<Kontrahent> Kontrahent { get; set; }
        public virtual ICollection<Pracownik> Pracownik { get; set; }
        public virtual ICollection<TypKontrahenta> TypKontrahenta { get; set; }
    }
}
