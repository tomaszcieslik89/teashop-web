using Firma.Data.Models;
using Firma.Data.Models.CMS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firma.Intranet.Controllers
{
    public class AktualnoscController : Controller
    {
        private readonly TeaShopContext _context;
        public AktualnoscController(TeaShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return _context.CMSAktualnosc != null ?
                        View(await _context.CMSAktualnosc.ToListAsync()) :
                        Problem("Entity set 'FirmaIntranetContext.Aktualnosc'  is null.");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CMSAktualnosc == null)
            {
                return NotFound();
            }
            var aktualnosc = await _context.CMSAktualnosc
                .FirstOrDefaultAsync(m => m.IdAktualnosci == id);
            if (aktualnosc == null)
            {
                return NotFound();
            }
            return View(aktualnosc);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAktualnosci,LinkTytul,Tytul,Tresc,Pozycja")] CMSAktualnosc aktualnosc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aktualnosc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aktualnosc);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CMSAktualnosc == null)
            {
                return NotFound();
            }

            var aktualnosc = await _context.CMSAktualnosc.FindAsync(id);
            if (aktualnosc == null)
            {
                return NotFound();
            }
            return View(aktualnosc);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAktualnosci,LinkTytul,Tytul,Tresc,Pozycja")] CMSAktualnosc aktualnosc)
        {
            if (id != aktualnosc.IdAktualnosci)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aktualnosc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AktualnoscExists(aktualnosc.IdAktualnosci))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aktualnosc);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CMSAktualnosc == null)
            {
                return NotFound();
            }

            var aktualnosc = await _context.CMSAktualnosc
                .FirstOrDefaultAsync(m => m.IdAktualnosci == id);
            if (aktualnosc == null)
            {
                return NotFound();
            }

            return View(aktualnosc);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CMSAktualnosc == null)
            {
                return Problem("Entity set 'FirmaIntranetContext.Aktualnosc'  is null.");
            }
            var aktualnosc = await _context.CMSAktualnosc.FindAsync(id);
            if (aktualnosc != null)
            {
                _context.CMSAktualnosc.Remove(aktualnosc);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AktualnoscExists(int id)
        {
            return (_context.CMSAktualnosc?.Any(e => e.IdAktualnosci == id)).GetValueOrDefault();
        }
    }
}
