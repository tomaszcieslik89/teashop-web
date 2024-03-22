using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firma.Data.Models
{
    public partial class DokumentSprzedazyTowar
    {
        public int Id { get; set; }
        public int? IdDokumentSprzedazy { get; set; }
        [ForeignKey("IdTowarNavigation")]
        public int? IdTowar { get; set; }
        public int Ilosc { get; set; }

        public virtual DokumentSprzedazy IdDokumentSprzedazyNavigation { get; set; } = null!;
        public virtual Towar IdTowarNavigation { get; set; } = null!;
    }
}
