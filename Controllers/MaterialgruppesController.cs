using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOE3MaterialVerwaltung.Data;
using SOE3MaterialVerwaltung.Models;

namespace SOE3MaterialVerwaltung.Controllers
{
    public class MaterialgruppesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaterialgruppesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Materialgruppes
        public async Task<IActionResult> Index()
        {
              return _context.Materialgruppe != null ? 
                          View(await _context.Materialgruppe.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Materialgruppe'  is null.");
        }

        // GET: Materialgruppes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Materialgruppe == null)
            {
                return NotFound();
            }

            var materialgruppe = await _context.Materialgruppe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materialgruppe == null)
            {
                return NotFound();
            }

            return View(materialgruppe);
        }

        // GET: Materialgruppes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Materialgruppes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Materialgruppe materialgruppe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materialgruppe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materialgruppe);
        }

        // GET: Materialgruppes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Materialgruppe == null)
            {
                return NotFound();
            }

            var materialgruppe = await _context.Materialgruppe.FindAsync(id);
            if (materialgruppe == null)
            {
                return NotFound();
            }
            return View(materialgruppe);
        }

        // POST: Materialgruppes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Materialgruppe materialgruppe)
        {
            if (id != materialgruppe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materialgruppe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterialgruppeExists(materialgruppe.Id))
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
            return View(materialgruppe);
        }

        // GET: Materialgruppes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Materialgruppe == null)
            {
                return NotFound();
            }

            var materialgruppe = await _context.Materialgruppe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materialgruppe == null)
            {
                return NotFound();
            }

            return View(materialgruppe);
        }

        // POST: Materialgruppes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Materialgruppe == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Materialgruppe'  is null.");
            }
            var materialgruppe = await _context.Materialgruppe.FindAsync(id);
            if (materialgruppe != null)
            {
                _context.Materialgruppe.Remove(materialgruppe);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaterialgruppeExists(int id)
        {
          return (_context.Materialgruppe?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
