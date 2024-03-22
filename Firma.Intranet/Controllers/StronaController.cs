using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Firma.Data.Models.CMS;
using Firma.Data.Models;

namespace Firma.Intranet.Controllers
{
    public class StronaController : Controller
    {
        private readonly TeaShopContext _context;

        public StronaController(TeaShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
              return _context.CMSStrona != null ? 
                          View(await _context.CMSStrona.ToListAsync()) :
                          Problem("Entity set 'FirmaIntranetContext.Strona'  is null.");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CMSStrona == null)
            {
                return NotFound();
            }

            var strona = await _context.CMSStrona
                .FirstOrDefaultAsync(m => m.IdStrony == id);
            if (strona == null)
            {
                return NotFound();
            }

            return View(strona);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdStrony,LinkTytul,Tytul,Tresc,Pozycja")] CMSStrona strona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(strona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(strona);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CMSStrona == null)
            {
                return NotFound();
            }

            var strona = await _context.CMSStrona.FindAsync(id);
            if (strona == null)
            {
                return NotFound();
            }
            return View(strona);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdStrony,LinkTytul,Tytul,Tresc,Pozycja")] CMSStrona strona)
        {
            if (id != strona.IdStrony)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(strona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StronaExists(strona.IdStrony))
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
            return View(strona);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CMSStrona == null)
            {
                return NotFound();
            }

            var strona = await _context.CMSStrona
                .FirstOrDefaultAsync(m => m.IdStrony == id);
            if (strona == null)
            {
                return NotFound();
            }

            return View(strona);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CMSStrona == null)
            {
                return Problem("Entity set 'FirmaIntranetContext.Strona'  is null.");
            }
            var strona = await _context.CMSStrona.FindAsync(id);
            if (strona != null)
            {
                _context.CMSStrona.Remove(strona);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StronaExists(int id)
        {
          return (_context.CMSStrona?.Any(e => e.IdStrony == id)).GetValueOrDefault();
        }
    }
}
