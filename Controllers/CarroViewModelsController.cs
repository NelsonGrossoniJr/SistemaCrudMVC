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
    public class CarroViewModelsController : Controller
    {
        private readonly New_ATCSharpContext _context;
        private IWebHostEnvironment _environment;

        public CarroViewModelsController(New_ATCSharpContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: CarroViewModels
        public async Task<IActionResult> Index()
        {
              return _context.CarroViewModel != null ? 
                          View(await _context.CarroViewModel.ToListAsync()) :
                          Problem("Entity set 'New_ATCSharpContext.CarroViewModel'  is null.");
        }

        // GET: CarroViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarroViewModel == null)
            {
                return NotFound();
            }

            var carroViewModel = await _context.CarroViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carroViewModel == null)
            {
                return NotFound();
            }

            return View(carroViewModel);
        }

        // GET: CarroViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarroViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo,Cor,Potencia,Upload,CarImgFileName")] CarroViewModel carroViewModel)
        {
            if(!ModelState.IsValid) return View(carroViewModel);

            if (carroViewModel.Upload is not null)
            {
                carroViewModel.CarImgFileName = carroViewModel.Upload.FileName;

                string path = Path.Combine(_environment.ContentRootPath, "wwwroot/imagens", carroViewModel.Upload.FileName);

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    carroViewModel.Upload.CopyTo(fs);
                }
            }
            
            

                _context.Add(carroViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           

            
        }

        // GET: CarroViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CarroViewModel == null)
            {
                return NotFound();
            }

            var carroViewModel = await _context.CarroViewModel.FindAsync(id);
            if (carroViewModel == null)
            {
                return NotFound();
            }
            return View(carroViewModel);
        }

        // POST: CarroViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo,Cor,Potencia,Upload,CarImgFileName")] CarroViewModel carroViewModel)
        {
            if (id != carroViewModel.Id)
            {
                return NotFound();
            }

            if (carroViewModel.Upload is not null)
            {
                carroViewModel.CarImgFileName = carroViewModel.Upload.FileName;

                string path = Path.Combine(_environment.ContentRootPath, "wwwroot/imagens", carroViewModel.Upload.FileName);

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    carroViewModel.Upload.CopyTo(fs);
                }
            }
            else
            {
                carroViewModel.CarImgFileName = _context.CarroViewModel.AsNoTracking().FirstOrDefault(car => car.Id == id).CarImgFileName;
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carroViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarroViewModelExists(carroViewModel.Id))
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
            return View(carroViewModel);
        }

        // GET: CarroViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CarroViewModel == null)
            {
                return NotFound();
            }

            var carroViewModel = await _context.CarroViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carroViewModel == null)
            {
                return NotFound();
            }

            return View(carroViewModel);
        }

        // POST: CarroViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CarroViewModel == null)
            {
                return Problem("Entity set 'New_ATCSharpContext.CarroViewModel'  is null.");
            }
            var carroViewModel = await _context.CarroViewModel.FindAsync(id);
            if (carroViewModel != null)
            {
                _context.CarroViewModel.Remove(carroViewModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarroViewModelExists(int id)
        {
          return (_context.CarroViewModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
