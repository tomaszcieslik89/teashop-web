using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Urlop
    {
        public Urlop()
        {
            PlanUrlopu = new HashSet<PlanUrlopu>();
            Pracownik = new HashSet<Pracownik>();
            Zatrudnienie = new HashSet<Zatrudnienie>();
        }

        public int IdUrlopu { get; set; }
        public decimal? WykorzystanoU { get; set; }
        public decimal? DodatkoweDniUrlopu { get; set; }
        public int? IdRodzajWolnego { get; set; }
        public bool? CzyAktywny { get; set; }
        public DateTime? DataRozpUrlopuU { get; set; }
        public string? RodzajUrlopuU { get; set; }
        public string? RodzajUmowyU { get; set; }
        public string? WymiarEtatuU { get; set; }
        public decimal? LimitUrlopuU { get; set; }
        public string? NazwaPracownikU { get; set; }
        public string? ImieU { get; set; }
        public string? DrugieImieU { get; set; }
        public string? NazwiskoU { get; set; }
        public string? NazwiskoRodMatU { get; set; }
        public string? ImieOjcaU { get; set; }
        public string? ImieMatkiU { get; set; }
        public string? MiejscowoscU { get; set; }
        public DateTime? DataUrodzeniaU { get; set; }
        public string? KrajU { get; set; }
        public string? PowiatU { get; set; }
        public string? GminaU { get; set; }
        public string? NrPaszportuU { get; set; }
        public string? UlicaU { get; set; }
        public string? NrDomuU { get; set; }
        public string? NrLokaluU { get; set; }
        public string? TelefonU { get; set; }
        public string? EmailU { get; set; }
        public string? WojewodzctwoU { get; set; }
        public DateTime? DataZakonczeniaUrlopu { get; set; }
        public string? StanowiskoU { get; set; }

        public virtual RodzajWolnego? IdRodzajWolnegoNavigation { get; set; }
        public virtual ICollection<PlanUrlopu> PlanUrlopu { get; set; }
        public virtual ICollection<Pracownik> Pracownik { get; set; }
        public virtual ICollection<Zatrudnienie> Zatrudnienie { get; set; }
    }
}