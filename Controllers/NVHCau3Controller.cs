using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiThiNVH.Models;

namespace BaiThiNVH.Controllers
{
    public class NVHCau3Controller : Controller
    {
        private readonly NVH _context;

        public NVHCau3Controller(NVH context)
        {
            _context = context;
        }

        // GET: NVHCau3
        public async Task<IActionResult> Index()
        {
              return _context.NVHCau3 != null ? 
                          View(await _context.NVHCau3.ToListAsync()) :
                          Problem("Entity set 'NVH.NVHCau3'  is null.");
        }

        // GET: NVHCau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NVHCau3 == null)
            {
                return NotFound();
            }

            var nVHCau3 = await _context.NVHCau3
                .FirstOrDefaultAsync(m => m.Ten == id);
            if (nVHCau3 == null)
            {
                return NotFound();
            }

            return View(nVHCau3);
        }

        // GET: NVHCau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NVHCau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ten,Lop,DiaChi")] NVHCau3 nVHCau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nVHCau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nVHCau3);
        }

        // GET: NVHCau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NVHCau3 == null)
            {
                return NotFound();
            }

            var nVHCau3 = await _context.NVHCau3.FindAsync(id);
            if (nVHCau3 == null)
            {
                return NotFound();
            }
            return View(nVHCau3);
        }

        // POST: NVHCau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Ten,Lop,DiaChi")] NVHCau3 nVHCau3)
        {
            if (id != nVHCau3.Ten)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nVHCau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVHCau3Exists(nVHCau3.Ten))
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
            return View(nVHCau3);
        }

        // GET: NVHCau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NVHCau3 == null)
            {
                return NotFound();
            }

            var nVHCau3 = await _context.NVHCau3
                .FirstOrDefaultAsync(m => m.Ten == id);
            if (nVHCau3 == null)
            {
                return NotFound();
            }

            return View(nVHCau3);
        }

        // POST: NVHCau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NVHCau3 == null)
            {
                return Problem("Entity set 'NVH.NVHCau3'  is null.");
            }
            var nVHCau3 = await _context.NVHCau3.FindAsync(id);
            if (nVHCau3 != null)
            {
                _context.NVHCau3.Remove(nVHCau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NVHCau3Exists(string id)
        {
          return (_context.NVHCau3?.Any(e => e.Ten == id)).GetValueOrDefault();
        }
    }
}
