using Firma.Data.Models;
using Firma.PortalWWW.Models.BusinessLogic;
using Firma.PortalWWW.Models.Sklep;
using Microsoft.AspNetCore.Mvc;

namespace Firma.PortalWWW.Controllers
{
    public class DaneZakupow
    {  
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Typ { get; set; }
        public string NIP { get; set; }
        public string NazwaFirmy { get; set; }
        public string email { get; set; }
    }
    public class KoszykController : Controller
    {
        private readonly TeaShopContext _context;
        public KoszykController(TeaShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() 
        {
            KoszykB koszykB = new KoszykB(_context, this.HttpContext);
            DaneDoKoszyka daneDoKoszyka = new DaneDoKoszyka()
            {
                ElementyKoszyka = await koszykB.GetElementykoszykaKlienta(),
                Razem = await koszykB.GetRazem()
            };
            return View(daneDoKoszyka); 
        }
        public async Task<IActionResult> DodajDoKoszyka(int id) 
        {
            KoszykB koszykB = new KoszykB(_context, this.HttpContext);
            koszykB.DodajDoKoszyka(await _context.Towar.FindAsync(id));
            return RedirectToAction("Index"); 
        }
        public async Task<IActionResult> KupTeraz(DaneZakupow daneZakupow)
        {
            KoszykB koszykB = new KoszykB(_context, this.HttpContext);
            koszykB.KupTeraz(daneZakupow);
            TempData["KupTeraz"] = "Herbata została kupiona.";
            return RedirectToAction("Sklep", "Home"); 
        }
    }
}
