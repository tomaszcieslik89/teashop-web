using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Pracownik
    {
        public Pracownik()
        {
            PlanUrlopu = new HashSet<PlanUrlopu>();
            Wynagrodzenie = new HashSet<Wynagrodzenie>();
        }

        public int IdPracownika { get; set; }
        public decimal? IdWynagrodzenie { get; set; }
        public int? IdDanePersonalne { get; set; }
        public int? IdAdresu { get; set; }
        public int? IdBanku { get; set; }
        public int? IdStanowiskoPracownika { get; set; }
        public int? IdUrlopu { get; set; }
        public int? IdZatrudnienia { get; set; }
        public int? IdPlci { get; set; }
        public int? IdUzytkownika { get; set; }
        public bool? CzyAktywny { get; set; }
        public string? ImieP { get; set; }
        public string? DrugieImieP { get; set; }
        public string? NazwiskoP { get; set; }
        public string? NazwiskoRodoweP { get; set; }
        public string? ImieOjcaP { get; set; }
        public string? ImieMatkiP { get; set; }
        public string? NrPaszportuP { get; set; }
        public decimal? Peselp { get; set; }
        public string? TelefonP { get; set; }
        public string? EmailP { get; set; }
        public DateTime? DataUrodzeniaP { get; set; }
        public string? PowiatP { get; set; }
        public string? MiejscowoscP { get; set; }
        public string? UlicaP { get; set; }
        public string? GminaP { get; set; }
        public string? KodPocztowyP { get; set; }
        public string? NrDomuP { get; set; }
        public string? NrLokaluP { get; set; }
        public DateTime? DataZatrudnieniaP { get; set; }
        public DateTime? DataRozpPracyP { get; set; }
        public DateTime? DataZwolnieniaP { get; set; }
        public string? WymiarEtatuP { get; set; }
        public decimal? StawkaP { get; set; }
        public decimal? LimitUrlopuP { get; set; }
        public decimal? DodatkoweDniUrlopuP { get; set; }
        public decimal? WykorzystanoP { get; set; }
        public decimal? PozostaloP { get; set; }
        public string? KrajP { get; set; }
        public string? PlecP { get; set; }
        public string? WojewodzctwoP { get; set; }
        public string? RodzajUmowyP { get; set; }
        public string? RodzajZatrudnieniaP { get; set; }
        public string? StanowiskoP { get; set; }

        public virtual Adres? IdAdresuNavigation { get; set; }
        public virtual Bank? IdBankuNavigation { get; set; }
        public virtual DanePersonalne? IdDanePersonalneNavigation { get; set; }
        public virtual Plec? IdPlciNavigation { get; set; }
        public virtual StanowiskoPracownika? IdStanowiskoPracownikaNavigation { get; set; }
        public virtual Urlop? IdUrlopuNavigation { get; set; }
        public virtual Uzytkownik? IdUzytkownikaNavigation { get; set; }
        public virtual Zatrudnienie? IdZatrudnieniaNavigation { get; set; }
        public virtual ICollection<PlanUrlopu> PlanUrlopu { get; set; }
        public virtual ICollection<Wynagrodzenie> Wynagrodzenie { get; set; }
    }
}
