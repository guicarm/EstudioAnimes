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
    public class DiretoresController : Controller
    {
        private readonly OracleFIAPDbContext _context;

        public DiretoresController(OracleFIAPDbContext context)
        {
            _context = context;
        }

        // GET: Diretores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Diretores.ToListAsync());
        }

        // GET: Diretores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diretores = await _context.Diretores
                .FirstOrDefaultAsync(m => m.DiretoresId == id);
            if (diretores == null)
            {
                return NotFound();
            }

            return View(diretores);
        }

        // GET: Diretores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Diretores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DiretoresId,Especializacao,ProjetosConcluidos")] Diretores diretores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diretores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diretores);
        }

        // GET: Diretores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diretores = await _context.Diretores.FindAsync(id);
            if (diretores == null)
            {
                return NotFound();
            }
            return View(diretores);
        }

        // POST: Diretores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiretoresId,Especializacao,ProjetosConcluidos")] Diretores diretores)
        {
            if (id != diretores.DiretoresId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diretores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiretoresExists(diretores.DiretoresId))
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
            return View(diretores);
        }

        // GET: Diretores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diretores = await _context.Diretores
                .FirstOrDefaultAsync(m => m.DiretoresId == id);
            if (diretores == null)
            {
                return NotFound();
            }

            return View(diretores);
        }

        // POST: Diretores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diretores = await _context.Diretores.FindAsync(id);
            if (diretores != null)
            {
                _context.Diretores.Remove(diretores);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiretoresExists(int id)
        {
            return _context.Diretores.Any(e => e.DiretoresId == id);
        }
    }
}
