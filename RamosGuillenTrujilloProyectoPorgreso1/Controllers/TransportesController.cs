﻿using System;
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
    public class TransportesController : Controller
    {
        private readonly RamosGuillenTrujilloProyectoPorgreso1Context10 _context;

        public TransportesController(RamosGuillenTrujilloProyectoPorgreso1Context10 context)
        {
            _context = context;
        }

        // GET: Transportes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Transporte.ToListAsync());
        }

        // GET: Transportes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transporte == null)
            {
                return NotFound();
            }

            var transporte = await _context.Transporte
                .FirstOrDefaultAsync(m => m.IdTransporte == id);
            if (transporte == null)
            {
                return NotFound();
            }

            return View(transporte);
        }

        // GET: Transportes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transportes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTransporte,Tipo,Modelo,Matricula,Capacidad")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transporte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transporte);
        }

        // GET: Transportes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transporte == null)
            {
                return NotFound();
            }

            var transporte = await _context.Transporte.FindAsync(id);
            if (transporte == null)
            {
                return NotFound();
            }
            return View(transporte);
        }

        // POST: Transportes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTransporte,Tipo,Modelo,Matricula,Capacidad")] Transporte transporte)
        {
            if (id != transporte.IdTransporte)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transporte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransporteExists(transporte.IdTransporte))
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
            return View(transporte);
        }

        // GET: Transportes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transporte == null)
            {
                return NotFound();
            }

            var transporte = await _context.Transporte
                .FirstOrDefaultAsync(m => m.IdTransporte == id);
            if (transporte == null)
            {
                return NotFound();
            }

            return View(transporte);
        }

        // POST: Transportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transporte == null)
            {
                return Problem("Entity set 'RamosGuillenTrujilloProyectoPorgreso1Context10.Transporte'  is null.");
            }
            var transporte = await _context.Transporte.FindAsync(id);
            if (transporte != null)
            {
                _context.Transporte.Remove(transporte);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransporteExists(int id)
        {
          return _context.Transporte.Any(e => e.IdTransporte == id);
        }
    }
}
