using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class TypKontrahenta
    {
        public TypKontrahenta()
        {
            Kontrahents = new HashSet<Kontrahent>();
            Towars = new HashSet<Towar>();
        }

        public int IdTypuKontrahenta { get; set; }
        public int? IdAdresu { get; set; }
        public int? IdDanePersonalne { get; set; }
        public int? IdDodatkowe { get; set; }
        public int? IdRodzajuDokumentow { get; set; }
        public string? Odbiorca { get; set; }
        public string? Dostawca { get; set; }
        public string? Zablokowany { get; set; }
        public int? IdKontrahenta { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual Adres? IdAdresuNavigation { get; set; }
        public virtual DanePersonalne? IdDanePersonalneNavigation { get; set; }
        public virtual Dodatkowe? IdDodatkoweNavigation { get; set; }
        public virtual RodzajDokumentu? IdRodzajuDokumentowNavigation { get; set; }
        public virtual ICollection<Kontrahent> Kontrahents { get; set; }
        public virtual ICollection<Towar> Towars { get; set; }
    }
}
