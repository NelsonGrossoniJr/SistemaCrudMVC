using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using New_ATCSharp.Data;
using New_ATCSharp.Models;

namespace New_ATCSharp.Controllers
{
    public class PilotoViewModelsController : Controller
    {
        private readonly New_ATCSharpContext _context;

        public PilotoViewModelsController(New_ATCSharpContext context)
        {
            _context = context;
        }

        // GET: PilotoViewModels
        public async Task<IActionResult> Index()
        {
              return _context.PilotoViewModel != null ? 
                          View(await _context.PilotoViewModel.ToListAsync()) :
                          Problem("Entity set 'New_ATCSharpContext.PilotoViewModel'  is null.");
        }

        // GET: PilotoViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PilotoViewModel == null)
            {
                return NotFound();
            }

            var pilotoViewModel = await _context.PilotoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pilotoViewModel == null)
            {
                return NotFound();
            }

            return View(pilotoViewModel);
        }

        // GET: PilotoViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PilotoViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Idade,Equipe,CorridasGanhas,Data")] PilotoViewModel pilotoViewModel)
        {
            if (ModelState.IsValid)
            {
                pilotoViewModel.Data = DateTime.Now;
                Console.WriteLine(DateTime.Now);
                _context.Add(pilotoViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pilotoViewModel);
        }

        // GET: PilotoViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PilotoViewModel == null)
            {
                return NotFound();
            }

            var pilotoViewModel = await _context.PilotoViewModel.FindAsync(id);
            if (pilotoViewModel == null)
            {
                return NotFound();
            }
            return View(pilotoViewModel);
        }

        // POST: PilotoViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Idade,Equipe,CorridasGanhas")] PilotoViewModel pilotoViewModel)
        {
            if (id != pilotoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pilotoViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PilotoViewModelExists(pilotoViewModel.Id))
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
            return View(pilotoViewModel);
        }

        // GET: PilotoViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PilotoViewModel == null)
            {
                return NotFound();
            }

            var pilotoViewModel = await _context.PilotoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pilotoViewModel == null)
            {
                return NotFound();
            }

            return View(pilotoViewModel);
        }

        // POST: PilotoViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PilotoViewModel == null)
            {
                return Problem("Entity set 'New_ATCSharpContext.PilotoViewModel'  is null.");
            }
            var pilotoViewModel = await _context.PilotoViewModel.FindAsync(id);
            if (pilotoViewModel != null)
            {
                _context.PilotoViewModel.Remove(pilotoViewModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PilotoViewModelExists(int id)
        {
          return (_context.PilotoViewModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
