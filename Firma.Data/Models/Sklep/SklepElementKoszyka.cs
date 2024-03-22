using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Firma.Data.Models.Sklep
{
    public partial class SklepElementKoszyka
    {
        public int IdElementuKoszyka { get; set; }
        public string IdSesjiKoszyka { get; set; } = null!;
        [ForeignKey("SklepTowarIdTowaruNavigation")]
        public int IdTowaru { get; set; }
        // public int SklepTowarIdTowaru { get; set; }
        //public SklepTowar SklepTowar { get; set; }
        public int Ilosc { get; set; }
        public DateTime DataUtworzenia { get; set; }
        [IgnoreDataMember]
        public Towar SklepTowarIdTowaruNavigation { get; set; }
    }
}
