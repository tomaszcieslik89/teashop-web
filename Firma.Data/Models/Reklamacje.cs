using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Reklamacje
    {
        public int IdReklamacji { get; set; }
        public int? IdTowaru { get; set; }
        public int? IdDodatkowe { get; set; }
        public int? IdZadanieReklamujacego { get; set; }
        public int? IdKontrahenta { get; set; }
        public DateTime? DataZakupu { get; set; }
        public DateTime? DataPowstaniaWady { get; set; }
        public DateTime? DataGwarancjiDo { get; set; }
        public int? IdDokumentuSprzedazy { get; set; }
        public int? IdStatusu { get; set; }
        public bool? CzyAktywny { get; set; }
        public string? ImieR { get; set; }
        public string? NazwiskoR { get; set; }
        public string? MiejscowoscR { get; set; }
        public string? KodPocztowyR { get; set; }
        public string? UlicaR { get; set; }
        public string? NrLokaluR { get; set; }
        public string? NrDomuR { get; set; }
        public string? Peselr { get; set; }
        public string? TowaryR { get; set; }
        public string? DostawcaR { get; set; }
        public string? IloscR { get; set; }
        public string? JednostkaR { get; set; }
        public string? DokumentR { get; set; }
        public string? OpisR { get; set; }
        public string? TelefonR { get; set; }
        public string? EmailR { get; set; }
        public string? ZadaniaReklamujacegoR { get; set; }

        public virtual Dodatkowe? IdDodatkoweNavigation { get; set; }
        public virtual DokumentSprzedazy? IdDokumentuSprzedazyNavigation { get; set; }
        public virtual Kontrahent? IdKontrahentaNavigation { get; set; }
        public virtual Status? IdStatusuNavigation { get; set; }
        public virtual Towar? IdTowaruNavigation { get; set; }
        public virtual ZadanieReklamujacego? IdZadanieReklamujacegoNavigation { get; set; }
    }
}
