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
    public class EstudiosController : Controller
    {
        private readonly OracleFIAPDbContext _context;

        public EstudiosController(OracleFIAPDbContext context)
        {
            _context = context;
        }

        // GET: Estudios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estudios.ToListAsync());
        }

        // GET: Estudios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudios = await _context.Estudios
                .FirstOrDefaultAsync(m => m.EstudiosId == id);
            if (estudios == null)
            {
                return NotFound();
            }

            return View(estudios);
        }

        // GET: Estudios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estudios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstudiosId,NomeEstudio,Pais,DataFundação")] Estudios estudios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudios);
        }

        // GET: Estudios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudios = await _context.Estudios.FindAsync(id);
            if (estudios == null)
            {
                return NotFound();
            }
            return View(estudios);
        }

        // POST: Estudios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstudiosId,NomeEstudio,Pais,DataFundação")] Estudios estudios)
        {
            if (id != estudios.EstudiosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudiosExists(estudios.EstudiosId))
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
            return View(estudios);
        }

        // GET: Estudios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudios = await _context.Estudios
                .FirstOrDefaultAsync(m => m.EstudiosId == id);
            if (estudios == null)
            {
                return NotFound();
            }

            return View(estudios);
        }

        // POST: Estudios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudios = await _context.Estudios.FindAsync(id);
            if (estudios != null)
            {
                _context.Estudios.Remove(estudios);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudiosExists(int id)
        {
            return _context.Estudios.Any(e => e.EstudiosId == id);
        }
    }
}
