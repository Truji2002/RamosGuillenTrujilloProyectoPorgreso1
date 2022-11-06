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
    public class ConductorsController : Controller
    {
        private readonly RamosGuillenTrujilloProyectoPorgreso1Context _context;

        public ConductorsController(RamosGuillenTrujilloProyectoPorgreso1Context context)
        {
            _context = context;
        }

        // GET: Conductors
        public async Task<IActionResult> Index()
        {
            var ramosGuillenTrujilloProyectoPorgreso1Context = _context.Conductor.Include(c => c.Ruta).Include(c => c.Transporte);
            return View(await ramosGuillenTrujilloProyectoPorgreso1Context.ToListAsync());
        }

        // GET: Conductors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Conductor == null)
            {
                return NotFound();
            }

            var conductor = await _context.Conductor
                .Include(c => c.Ruta)
                .Include(c => c.Transporte)
                .FirstOrDefaultAsync(m => m.IdConductor == id);
            if (conductor == null)
            {
                return NotFound();
            }

            return View(conductor);
        }

        // GET: Conductors/Create
        public IActionResult Create()
        {
            ViewData["IdConductor"] = new SelectList(_context.Set<Ruta>(), "IdRuta", "PuntoLlegada");
            ViewData["IdConductor"] = new SelectList(_context.Set<Transporte>(), "IdTransporte", "Matricula");
            return View();
        }

        // POST: Conductors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdConductor,Nombre,Apellido,Cedula,NumeroTelefono,Correo,FechaNacimiento,FechaEmisionLicencia,FechaVencimientoLicencia,Contraseña,IdRuta,IdTransporte")] Conductor conductor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conductor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdConductor"] = new SelectList(_context.Set<Ruta>(), "IdRuta", "PuntoLlegada", conductor.IdConductor);
            ViewData["IdConductor"] = new SelectList(_context.Set<Transporte>(), "IdTransporte", "Matricula", conductor.IdConductor);
            return View(conductor);
        }

        // GET: Conductors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Conductor == null)
            {
                return NotFound();
            }

            var conductor = await _context.Conductor.FindAsync(id);
            if (conductor == null)
            {
                return NotFound();
            }
            ViewData["IdConductor"] = new SelectList(_context.Set<Ruta>(), "IdRuta", "PuntoLlegada", conductor.IdConductor);
            ViewData["IdConductor"] = new SelectList(_context.Set<Transporte>(), "IdTransporte", "Matricula", conductor.IdConductor);
            return View(conductor);
        }

        // POST: Conductors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdConductor,Nombre,Apellido,Cedula,NumeroTelefono,Correo,FechaNacimiento,FechaEmisionLicencia,FechaVencimientoLicencia,Contraseña,IdRuta,IdTransporte")] Conductor conductor)
        {
            if (id != conductor.IdConductor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conductor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConductorExists(conductor.IdConductor))
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
            ViewData["IdConductor"] = new SelectList(_context.Set<Ruta>(), "IdRuta", "PuntoLlegada", conductor.IdConductor);
            ViewData["IdConductor"] = new SelectList(_context.Set<Transporte>(), "IdTransporte", "Matricula", conductor.IdConductor);
            return View(conductor);
        }

        // GET: Conductors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Conductor == null)
            {
                return NotFound();
            }

            var conductor = await _context.Conductor
                .Include(c => c.Ruta)
                .Include(c => c.Transporte)
                .FirstOrDefaultAsync(m => m.IdConductor == id);
            if (conductor == null)
            {
                return NotFound();
            }

            return View(conductor);
        }

        // POST: Conductors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Conductor == null)
            {
                return Problem("Entity set 'RamosGuillenTrujilloProyectoPorgreso1Context.Conductor'  is null.");
            }
            var conductor = await _context.Conductor.FindAsync(id);
            if (conductor != null)
            {
                _context.Conductor.Remove(conductor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConductorExists(int id)
        {
          return _context.Conductor.Any(e => e.IdConductor == id);
        }
    }
}
