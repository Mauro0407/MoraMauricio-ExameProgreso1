using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoraMauricio_ExameProgreso1.Data;
using MoraMauricio_ExameProgreso1.Models;

namespace MoraMauricio_ExameProgreso1.Controllers
{
    public class CelularsController : Controller
    {
        private readonly MoraMauricio_ExameProgreso1Context _context;

        public CelularsController(MoraMauricio_ExameProgreso1Context context)
        {
            _context = context;
        }

        // GET: Celulars
        public async Task<IActionResult> Index()
        {
            var moraMauricio_ExameProgreso1Context = _context.Celular.Include(c => c.EArmas);
            return View(await moraMauricio_ExameProgreso1Context.ToListAsync());
        }

        // GET: Celulars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular
                .Include(c => c.EArmas)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // GET: Celulars/Create
        public IActionResult Create()
        {
            ViewData["MMoraId"] = new SelectList(_context.Set<MMora>(), "Id", "Id");
            return View();
        }

        // POST: Celulars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Modelo,Año,Precio,MMoraId")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(celular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MMoraId"] = new SelectList(_context.Set<MMora>(), "Id", "Id", celular.MMoraId);
            return View(celular);
        }

        // GET: Celulars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular.FindAsync(id);
            if (celular == null)
            {
                return NotFound();
            }
            ViewData["MMoraId"] = new SelectList(_context.Set<MMora>(), "Id", "Id", celular.MMoraId);
            return View(celular);
        }

        // POST: Celulars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Modelo,Año,Precio,MMoraId")] Celular celular)
        {
            if (id != celular.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(celular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CelularExists(celular.Id))
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
            ViewData["MMoraId"] = new SelectList(_context.Set<MMora>(), "Id", "Id", celular.MMoraId);
            return View(celular);
        }

        // GET: Celulars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular
                .Include(c => c.EArmas)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // POST: Celulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var celular = await _context.Celular.FindAsync(id);
            if (celular != null)
            {
                _context.Celular.Remove(celular);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CelularExists(int id)
        {
            return _context.Celular.Any(e => e.Id == id);
        }
    }
}
