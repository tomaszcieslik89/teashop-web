using Firma.Data.Models;
using Firma.PortalWWW.Models;
using Firma.PortalWWW.Models.Sklep;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Firma.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TeaShopContext _context;
        public HomeController(TeaShopContext context)
        {
            _context = new TeaShopContext();
        }

        public IActionResult Index(int? id)
        {
            ViewBag.ModelStrony =
               (
                from strona in _context.CMSStrona
                where strona.LinkTytul == "StronaGłówna"
                orderby strona.Pozycja
                select strona
            ).ToList();
            ViewBag.ModelAktualnosci =
                (
                    from aktualnosci in _context.CMSAktualnosc
                    where aktualnosci.LinkTytul == "StronaGłówna"
                    orderby aktualnosci.Pozycja
                    select aktualnosci
                ).ToList();
            ViewBag.ModelParametry =
                (
                    from parametry in _context.CMSParametr
                    where parametry.Kod == "StronaGłówna"
                    orderby parametry.IdParametru
                    select parametry
                ).ToList();
            if (id == null)
                id = _context.CMSStrona.First().IdStrony;
            var item = _context.CMSStrona.Find(id);
            return View(item);//zwraca widok
        }
        public IActionResult Sklep(int? id)
        {
            ViewBag.ModelStrony =
               (
                from strona in _context.CMSStrona
                where strona.LinkTytul == "Sklep"
                orderby strona.Pozycja
                select strona
            ).ToList();
            ViewBag.ModelAktualnosci =
                (
                    from aktualnosci in _context.CMSAktualnosc
                    where aktualnosci.LinkTytul == "Sklep"
                    orderby aktualnosci.Pozycja
                    select aktualnosci
                ).ToList();
            ViewBag.ModelParametry =
                (
                    from parametry in _context.CMSParametr
                    where parametry.Kod == "Sklep"
                    orderby parametry.IdParametru
                    select parametry
                ).ToList();
            if (id == null)
                id = _context.CMSParametr.First().IdParametru;
            var item = _context.CMSParametr.Find(id);
            var towary = _context.Towar.Where(x => x.CzyAktywny == true && x.Ilosc > 0).ToList();
            List<TowaryModel> listaTowarow = new List<TowaryModel>();
            foreach (var itemTowar in towary)
            {
                TowaryModel towaryModel = new TowaryModel()
                {
                    Cena = itemTowar.CenaBrutto,
                    Nazwa = itemTowar.Nazwa,
                    Marka = itemTowar.MarkaT,
                    Id = itemTowar.IdTowaru,
                };
                listaTowarow.Add(towaryModel);
            }
            return View(listaTowarow);
        }

        public IActionResult Artykuly(int? id)
        {
            var dane = _context.CMSStrona.Where(x => x.LinkTytul == "Artykuły").ToList();
            return View(dane);
        }
        public IActionResult YerbaMate(int? id)
        {
            ViewBag.ModelStrony =
               (
                from strona in _context.CMSStrona
                where strona.LinkTytul == "YerbaMate"
                orderby strona.Pozycja
                select strona
            ).ToList();
            ViewBag.ModelAktualnosci =
                (
                    from aktualnosci in _context.CMSAktualnosc
                    where aktualnosci.LinkTytul == "YerbaMate"
                    orderby aktualnosci.Pozycja
                    select aktualnosci
                ).ToList();
            ViewBag.ModelParametry =
                (
                    from parametry in _context.CMSParametr
                    where parametry.Kod == "YerbaMate"
                    orderby parametry.IdParametru
                    select parametry
                ).ToList();
            if (id == null)
                id = _context.CMSStrona.First().IdStrony;
            var item = _context.CMSStrona.Find(id);
            return View(item);
        }
        public IActionResult RodzajeHerbat(int? id)
        {
            ViewBag.ModelStrony =
               (
                from strona in _context.CMSStrona
                where strona.LinkTytul == "RodzajeHerbat"
                orderby strona.Pozycja
                select strona
            ).ToList();
            ViewBag.ModelAktualnosci =
                (
                    from aktualnosci in _context.CMSAktualnosc
                    where aktualnosci.LinkTytul == "RodzajeHerbat"
                    orderby aktualnosci.Pozycja
                    select aktualnosci
                ).ToList();
            ViewBag.ModelParametry =
                (
                    from parametry in _context.CMSParametr
                    where parametry.Kod == "RodzajeHerbat"
                    orderby parametry.IdParametru
                    select parametry
                ).ToList();
            if (id == null)
                id = _context.CMSStrona.First().IdStrony;
            var item = _context.CMSStrona.Find(id);
            return View(item);
        }
        public IActionResult Kontakt(int? id)
        {
            ViewBag.ModelStrony =
               (
                from strona in _context.CMSStrona
                where strona.LinkTytul == "Kontakt"
                orderby strona.Pozycja
                select strona
            ).ToList();
            ViewBag.ModelAktualnosci =
                (
                    from aktualnosci in _context.CMSAktualnosc
                    where aktualnosci.LinkTytul == "Kontakt"
                    orderby aktualnosci.Pozycja
                    select aktualnosci
                ).ToList();
            ViewBag.ModelParametry =
                (
                    from parametry in _context.CMSParametr
                    where parametry.Kod == "Kontakt"
                    orderby parametry.IdParametru
                    select parametry
                ).ToList();
            if (id == null)
                id = _context.CMSStrona.First().IdStrony;
            var item = _context.CMSStrona.Find(id);
            return View(item);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
