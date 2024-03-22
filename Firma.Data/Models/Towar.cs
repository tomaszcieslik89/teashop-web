using Firma.Data.Models.Sklep;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firma.Data.Models
{
    public partial class Towar
    {
        public Towar()
        {
           // DokumentSprzedazy = new HashSet<DokumentSprzedazy>();
            Reklamacje = new HashSet<Reklamacje>();
            ZakupTowaru = new HashSet<ZakupTowaru>();
        }
        [Key]
        public int IdTowaru { get; set; }
        public decimal? CenaNetto { get; set; }
        public decimal? CenaBrutto { get; set; }
        public string? JednostkaMiary { get; set; }
        public decimal? Marza { get; set; }
        public decimal? StawkaVatZakupu { get; set; }
        public decimal? StawkaVatSprzedazy { get; set; }
        public string? Kod { get; set; }
        public string? KodEan { get; set; }
        public string? Nazwa { get; set; }
        public string? Opis { get; set; }
        public decimal? Ilosc { get; set; }
        public int? IdProducenta { get; set; }
        public int? IdDodatkowe { get; set; }
        public int? IdRodzajuDokumentow { get; set; }
        public int? IdTypKontrahenta { get; set; }
        public int? IdKategoriiTowaru { get; set; }
        public int? IdMarki { get; set; }
        public bool? CzyAktywny { get; set; }
        public string? MarkaT { get; set; }
        public string? KategoriaTowaruT { get; set; }
        public string? ProducentT { get; set; }

        public virtual ICollection<DokumentSprzedazyTowar> DokumentSprzedazyTowar { get; set; }

        [ForeignKey("IdElementuKoszyka")]
        public virtual ICollection<SklepElementKoszyka> SklepElementKoszyka { get; set; }

        public virtual Dodatkowe? IdDodatkoweNavigation { get; set; }
        public virtual KategoriaTowaru? IdKategoriiTowaruNavigation { get; set; }
        public virtual Marka? IdMarkiNavigation { get; set; }
        public virtual Producent? IdProducentaNavigation { get; set; }
        public virtual RodzajDokumentu? IdRodzajuDokumentowNavigation { get; set; }
        public virtual TypKontrahenta? IdTypKontrahentaNavigation { get; set; }
        //public virtual ICollection<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual ICollection<Reklamacje> Reklamacje { get; set; }
        public virtual ICollection<ZakupTowaru> ZakupTowaru { get; set; }
    }
}
