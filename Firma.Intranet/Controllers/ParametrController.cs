using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firma.Data.Models;
using Firma.Data.Models.CMS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace Firma.Intranet.Controllers
{
    public class ParametrController : Controller
    {
        private readonly TeaShopContext _context;

        public ParametrController(TeaShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
              return _context.CMSParametr != null ? 
                          View(await _context.CMSParametr.ToListAsync()) :
                          Problem("Entity set 'FirmaIntranetContext.Parametr'  is null.");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CMSParametr == null)
            {
                return NotFound();
            }

            var parametr = await _context.CMSParametr
                .FirstOrDefaultAsync(m => m.IdParametru == id);
            if (parametr == null)
            {
                return NotFound();
            }

            return View(parametr);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdParametru,Kod,Nazwa,Wartosc,Opis")] CMSParametr parametr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parametr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parametr);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CMSParametr == null)
            {
                return NotFound();
            }

            var parametr = await _context.CMSParametr.FindAsync(id);
            if (parametr == null)
            {
                return NotFound();
            }
            return View(parametr);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdParametru,Kod,Nazwa,Wartosc,Opis")] CMSParametr parametr)
        {
            if (id != parametr.IdParametru)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parametr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParametrExists(parametr.IdParametru))
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
            return View(parametr);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CMSParametr == null)
            {
                return NotFound();
            }

            var parametr = await _context.CMSParametr
                .FirstOrDefaultAsync(m => m.IdParametru == id);
            if (parametr == null)
            {
                return NotFound();
            }

            return View(parametr);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CMSParametr == null)
            {
                return Problem("Entity set 'FirmaIntranetContext.Parametr'  is null.");
            }
            var parametr = await _context.CMSParametr.FindAsync(id);
            if (parametr != null)
            {
                _context.CMSParametr.Remove(parametr);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ParametrExists(int id)
        {
          return (_context.CMSParametr?.Any(e => e.IdParametru == id)).GetValueOrDefault();
        }
    }
}
