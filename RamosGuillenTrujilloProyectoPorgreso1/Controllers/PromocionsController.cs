using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RamosGuillenTrujilloProyectoPorgreso1.Data;
using RamosGuillenTrujilloProyectoPorgreso1.Models;

namespace RamosGuillenTrujilloProyectoPorgreso1.Controllers
{
    public class PromocionsController : Controller
    {
        private readonly RamosGuillenTrujilloProyectoPorgreso1Context10 _context;

        public PromocionsController(RamosGuillenTrujilloProyectoPorgreso1Context10 context)
        {
            _context = context;
        }

        // GET: Promocions
        public async Task<IActionResult> Index()
        {
              return View(await _context.Promocion.ToListAsync());
        }

        // GET: Promocions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Promocion == null)
            {
                return NotFound();
            }

            var promocion = await _context.Promocion
                .FirstOrDefaultAsync(m => m.IdPromociones == id);
            if (promocion == null)
            {
                return NotFound();
            }

            return View(promocion);
        }

        // GET: Promocions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Promocions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPromociones,FechaCaducidad,TipoPromocion,Descripcion")] Promocion promocion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(promocion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(promocion);
        }

        // GET: Promocions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Promocion == null)
            {
                return NotFound();
            }

            var promocion = await _context.Promocion.FindAsync(id);
            if (promocion == null)
            {
                return NotFound();
            }
            return View(promocion);
        }

        // POST: Promocions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPromociones,FechaCaducidad,TipoPromocion,Descripcion")] Promocion promocion)
        {
            if (id != promocion.IdPromociones)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(promocion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PromocionExists(promocion.IdPromociones))
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
            return View(promocion);
        }

        // GET: Promocions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Promocion == null)
            {
                return NotFound();
            }

            var promocion = await _context.Promocion
                .FirstOrDefaultAsync(m => m.IdPromociones == id);
            if (promocion == null)
            {
                return NotFound();
            }

            return View(promocion);
        }

        // POST: Promocions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Promocion == null)
            {
                return Problem("Entity set 'RamosGuillenTrujilloProyectoPorgreso1Context10.Promocion'  is null.");
            }
            var promocion = await _context.Promocion.FindAsync(id);
            if (promocion != null)
            {
                _context.Promocion.Remove(promocion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PromocionExists(int id)
        {
          return _context.Promocion.Any(e => e.IdPromociones == id);
        }
    }
}
