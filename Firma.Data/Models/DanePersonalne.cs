using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class DanePersonalne
    {
        public DanePersonalne()
        {
            DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            Kontrahent = new HashSet<Kontrahent>();
            Pracownik = new HashSet<Pracownik>();
            TypKontrahenta = new HashSet<TypKontrahenta>();
            Uzytkownik = new HashSet<Uzytkownik>();
        }

        public int IdDanePersonalne { get; set; }
        public int? IdDodatkowe { get; set; }
        public string? ImieDane { get; set; }
        public string? DrugieImie { get; set; }
        public string? NazwiskoDane { get; set; }
        public string? NazwiskoRodoweMatki { get; set; }
        public string? ImieOjca { get; set; }
        public string? ImieMatki { get; set; }
        public string? NrPaszportu { get; set; }
        public string? Peseldane { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public string? Nipdane { get; set; }
        public string? Regondane { get; set; }
        public string? TelefonDane { get; set; }
        public string? EmailDane { get; set; }
        public string? NazwaDane { get; set; }
        public bool? CzyAktywny { get; set; }
        public string? MiejscowoscDane { get; set; }
        public string? UlicaDane { get; set; }
        public string? NrDomuDane { get; set; }
        public string? Kraj { get; set; }
        public string? Wojewodztwo { get; set; }
        public string? Plec { get; set; }
        public string? UwagiDane { get; set; }
        public string? RachunekNrDane { get; set; }
        public decimal? RabatDane { get; set; }
        public string? BankDane { get; set; }
        public string? NrLokaluDane { get; set; }
        public string? KodPocztowyDane { get; set; }
        public string? KodDane { get; set; }
        public string? WalutaDane { get; set; }
        public string? FormaPlatnosciDane { get; set; }

        public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<Kontrahent> Kontrahent { get; set; }
        public virtual ICollection<Pracownik> Pracownik { get; set; }
        public virtual ICollection<TypKontrahenta> TypKontrahenta { get; set; }
        public virtual ICollection<Uzytkownik> Uzytkownik { get; set; }
    }
}
