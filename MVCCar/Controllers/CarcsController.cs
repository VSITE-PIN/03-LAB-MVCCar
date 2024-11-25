using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCCar.Data;
using MVCCar.Models;

namespace MVCCar.Controllers
{
    public class CarcsController : Controller
    {
        private readonly MVCCarContext _context;

        public CarcsController(MVCCarContext context)
        {
            _context = context;
        }

        // GET: Carcs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carcs.ToListAsync());
        }

        // GET: Carcs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carcs = await _context.Carcs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carcs == null)
            {
                return NotFound();
            }

            return View(carcs);
        }

        // GET: Carcs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carcs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Color,ProductionYear,Price,Manufacturer")] Carcs carcs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carcs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carcs);
        }

        // GET: Carcs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carcs = await _context.Carcs.FindAsync(id);
            if (carcs == null)
            {
                return NotFound();
            }
            return View(carcs);
        }

        // POST: Carcs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Color,ProductionYear,Price,Manufacturer")] Carcs carcs)
        {
            if (id != carcs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carcs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarcsExists(carcs.Id))
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
            return View(carcs);
        }

        // GET: Carcs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carcs = await _context.Carcs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carcs == null)
            {
                return NotFound();
            }

            return View(carcs);
        }

        // POST: Carcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carcs = await _context.Carcs.FindAsync(id);
            if (carcs != null)
            {
                _context.Carcs.Remove(carcs);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarcsExists(int id)
        {
            return _context.Carcs.Any(e => e.Id == id);
        }
    }
}
