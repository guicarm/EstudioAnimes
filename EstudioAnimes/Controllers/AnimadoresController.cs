using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EstudioAnime.Models;
using EstudioAnime.Persistencia;

namespace EstudioAnimes.Controllers
{
    public class AnimadoresController : Controller
    {
        private readonly OracleFIAPDbContext _context;

        public AnimadoresController(OracleFIAPDbContext context)
        {
            _context = context;
        }

        // GET: Animadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Animadores.ToListAsync());
        }

        // GET: Animadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animadores = await _context.Animadores
                .FirstOrDefaultAsync(m => m.AnimadoresId == id);
            if (animadores == null)
            {
                return NotFound();
            }

            return View(animadores);
        }

        // GET: Animadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Animadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnimadoresId,EstiloAnimacao,AnosExperiencia")] Animadores animadores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animadores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(animadores);
        }

        // GET: Animadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animadores = await _context.Animadores.FindAsync(id);
            if (animadores == null)
            {
                return NotFound();
            }
            return View(animadores);
        }

        // POST: Animadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AnimadoresId,EstiloAnimacao,AnosExperiencia")] Animadores animadores)
        {
            if (id != animadores.AnimadoresId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(animadores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimadoresExists(animadores.AnimadoresId))
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
            return View(animadores);
        }

        // GET: Animadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animadores = await _context.Animadores
                .FirstOrDefaultAsync(m => m.AnimadoresId == id);
            if (animadores == null)
            {
                return NotFound();
            }

            return View(animadores);
        }

        // POST: Animadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animadores = await _context.Animadores.FindAsync(id);
            if (animadores != null)
            {
                _context.Animadores.Remove(animadores);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimadoresExists(int id)
        {
            return _context.Animadores.Any(e => e.AnimadoresId == id);
        }
    }
}
