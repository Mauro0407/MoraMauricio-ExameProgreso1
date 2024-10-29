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
    public class MMorasController : Controller
    {
        private readonly MoraMauricio_ExameProgreso1Context _context;

        public MMorasController(MoraMauricio_ExameProgreso1Context context)
        {
            _context = context;
        }

        // GET: MMoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.MMora.ToListAsync());
        }

        // GET: MMoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mMora = await _context.MMora
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mMora == null)
            {
                return NotFound();
            }

            return View(mMora);
        }

        // GET: MMoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MMoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Edad,Salario,Nombre,Activo,FechaRegistro")] MMora mMora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mMora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mMora);
        }

        // GET: MMoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mMora = await _context.MMora.FindAsync(id);
            if (mMora == null)
            {
                return NotFound();
            }
            return View(mMora);
        }

        // POST: MMoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Edad,Salario,Nombre,Activo,FechaRegistro")] MMora mMora)
        {
            if (id != mMora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mMora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MMoraExists(mMora.Id))
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
            return View(mMora);
        }

        // GET: MMoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mMora = await _context.MMora
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mMora == null)
            {
                return NotFound();
            }

            return View(mMora);
        }

        // POST: MMoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mMora = await _context.MMora.FindAsync(id);
            if (mMora != null)
            {
                _context.MMora.Remove(mMora);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MMoraExists(int id)
        {
            return _context.MMora.Any(e => e.Id == id);
        }
    }
}
