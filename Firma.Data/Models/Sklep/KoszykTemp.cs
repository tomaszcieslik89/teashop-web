namespace Firma.Data.Models.Sklep
{
    public partial class KoszykTemp
    {
        public int Id { get; set; }
        public string Nazwa { get; set; } = null!;
        public decimal Cena { get; set; }
        public int Ilość { get; set; }
        public DateTime DataUtworzenia { get; set; }
    }
}
