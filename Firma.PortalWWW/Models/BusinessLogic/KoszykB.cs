using Firma.Data.Models;
using Firma.Data.Models.Sklep;
using Firma.PortalWWW.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Firma.PortalWWW.Models.BusinessLogic
{
    public class KoszykB
    {
        private readonly TeaShopContext _context;

        private string idSesjiKoszyka;
        public KoszykB(TeaShopContext context, HttpContext httpContext)
        {
            _context = context;
            idSesjiKoszyka = getIdSesjiKoszyka(httpContext);
        }
        private string getIdSesjiKoszyka(HttpContext httpContext)
        {
            if (httpContext.Session.GetString("IdSesjiKoszyka") == null)
            {
                if (!string.IsNullOrWhiteSpace(httpContext.User.Identity.Name))
                {
                    httpContext.Session.SetString("IdSesjiKoszyka", httpContext.User.Identity.Name);
                }
                else
                {
                    Guid tempIdSesjiKoszyka = Guid.NewGuid();
                    httpContext.Session.SetString("IdSesjiKoszyka", tempIdSesjiKoszyka.ToString());
                }
            }
            return httpContext.Session.GetString("IdSesjiKoszyka").ToString();
        }
        public void DodajDoKoszyka(Towar towar)
        {
            var tempElementKoszyka =
                _context.SklepElementKoszyka
                .Where(e => e.IdSesjiKoszyka == idSesjiKoszyka && e.IdTowaru == towar.IdTowaru)
                .FirstOrDefault();

            if (tempElementKoszyka != null)
            {
                tempElementKoszyka.Ilosc++;
            }
            else
            {
                tempElementKoszyka = new SklepElementKoszyka()
                {
                    IdSesjiKoszyka = idSesjiKoszyka,
                    IdTowaru = towar.IdTowaru,
                    SklepTowarIdTowaruNavigation = _context.Towar.Find(towar.IdTowaru),
                    Ilosc = 1,
                    DataUtworzenia = DateTime.Now
                };
                _context.SklepElementKoszyka.Add(tempElementKoszyka);
            }
            _context.SaveChanges();
        }
        public void KupTeraz(DaneZakupow daneZakupow)
        {
            DanePersonalne danePersonalne = new DanePersonalne()
            {
                ImieDane = daneZakupow.Imie,
                NazwiskoDane = daneZakupow.Nazwisko,
                CzyAktywny = true,
                Nipdane = daneZakupow.NIP,
                NazwaDane = daneZakupow.NazwaFirmy,
                EmailDane = daneZakupow.email,

            };
            _context.DanePersonalne.Add(danePersonalne);
            _context.SaveChanges();
            Kontrahent kontrahent = new Kontrahent()
            {
                IdDanePersonalne = danePersonalne.IdDanePersonalne,
                CzyAktywny = true,
            };
            _context.Kontrahent.Add(kontrahent);


            _context.SaveChanges();
            var ElementyKoszyka = _context.SklepElementKoszyka.Where(x => x.IdSesjiKoszyka == idSesjiKoszyka).ToList();
            DokumentSprzedazy dokumentSprzedazy = new DokumentSprzedazy()

            {
                DataWystawienia = DateTime.Now,
                TerminPlatnosci = DateTime.Now,
                IdRabatu = 1,
                NumerDokumentu = DateTime.Now.ToString(),
                CzyAktywny = true,
                DokumentSprzedazyTowar = null,
                IdDaneParsonalne = danePersonalne.IdDanePersonalne,
                IdKontrahenta = kontrahent.IdKontrahenta,
                IdRodzajuDokumentow = int.Parse(daneZakupow.Typ),

            };
            _context.DokumentSprzedazy.Add(dokumentSprzedazy);
            _context.SaveChanges();
            foreach (var item in ElementyKoszyka)
            {
                DokumentSprzedazyTowar dokumentSprzedazyTowar = new DokumentSprzedazyTowar()
                {
                    IdDokumentSprzedazy = dokumentSprzedazy.IdDokumentuSprzedazy,
                    IdTowar = item.IdTowaru,
                    Ilosc = item.Ilosc,
                };
                _context.DokumentSprzedazyTowar.Add(dokumentSprzedazyTowar);

            }
            _context.SaveChanges();

            foreach (var elementyKoszyka in ElementyKoszyka)
            {
                _context.SklepElementKoszyka.Remove(elementyKoszyka);
            }
            _context.SaveChanges();

        }
        public async Task<List<SklepElementKoszyka>> GetElementykoszykaKlienta()
        {
            return await _context.SklepElementKoszyka.Where(e => e.IdSesjiKoszyka == this.idSesjiKoszyka).Include(e => e.SklepTowarIdTowaruNavigation).ToListAsync();
        }
        public async Task<decimal> GetRazem()
        {
            var items =
                (
                from element in _context.SklepElementKoszyka
                where element.IdSesjiKoszyka == this.idSesjiKoszyka
                select element.SklepTowarIdTowaruNavigation.CenaBrutto * (decimal?)element.Ilosc
                );
            return await items.SumAsync() ?? 0;
        }
    }
}



