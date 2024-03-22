using Firma.Data.Models.Sklep;
namespace Firma.PortalWWW.Models.Sklep
{
    public class DaneDoKoszyka
    {
        public List<SklepElementKoszyka> ElementyKoszyka { get; set; }
        public decimal Razem { get; set; }
    }
}
