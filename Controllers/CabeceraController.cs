using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pruebaasiservy.Models;

namespace pruebaasiservy.Controllers
{
    public class CabeceraController : Controller
    {
        private readonly pruebaReporteContext _context;

        public CabeceraController(pruebaReporteContext context)
        {
            _context = context;
        }

        // GET: Cabecera
        public async Task<IActionResult> Index()
        {
              return _context.Cabeceras != null ? 
                          View(await _context.Cabeceras.ToListAsync()) :
                          Problem("Entity set 'pruebaReporteContext.Cabeceras'  is null.");
        }

        // GET: Cabecera/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cabeceras == null)
            {
                return NotFound();
            }

            var cabecera = await _context.Cabeceras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cabecera == null)
            {
                return NotFound();
            }

            return View(cabecera);
        }

        // GET: Cabecera/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cabecera/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Linea1,Linea2,Linea3,Linea4,Linea5,Linea6,Total")] Cabecera cabecera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cabecera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cabecera);
        }

        // GET: Cabecera/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cabeceras == null)
            {
                return NotFound();
            }

            var cabecera = await _context.Cabeceras.FindAsync(id);
            if (cabecera == null)
            {
                return NotFound();
            }
            return View(cabecera);
        }

        // POST: Cabecera/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Linea1,Linea2,Linea3,Linea4,Linea5,Linea6,Total")] Cabecera cabecera)
        {
            if (id != cabecera.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cabecera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CabeceraExists(cabecera.Id))
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
            return View(cabecera);
        }

        // GET: Cabecera/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cabeceras == null)
            {
                return NotFound();
            }

            var cabecera = await _context.Cabeceras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cabecera == null)
            {
                return NotFound();
            }

            return View(cabecera);
        }

        // POST: Cabecera/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cabeceras == null)
            {
                return Problem("Entity set 'pruebaReporteContext.Cabeceras'  is null.");
            }
            var cabecera = await _context.Cabeceras.FindAsync(id);
            if (cabecera != null)
            {
                _context.Cabeceras.Remove(cabecera);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CabeceraExists(int id)
        {
          return (_context.Cabeceras?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
