using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeThanhNam_03.Models;
using LeThanhNam_03.Data;

namespace LeThanhNam_03.Controllers
{
    public class PhongBanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhongBanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PhongBan
        public async Task<IActionResult> Index()
        {
              return _context.PhongBan != null ? 
                          View(await _context.PhongBan.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PhongBan'  is null.");
        }

        // GET: PhongBan/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.PhongBan == null)
            {
                return NotFound();
            }

            var phongBan = await _context.PhongBan
                .FirstOrDefaultAsync(m => m.MaPhongBan == id);
            if (phongBan == null)
            {
                return NotFound();
            }

            return View(phongBan);
        }

        // GET: PhongBan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhongBan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaPhongBan,TenPhongBan")] PhongBan phongBan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phongBan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phongBan);
        }

        // GET: PhongBan/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.PhongBan == null)
            {
                return NotFound();
            }

            var phongBan = await _context.PhongBan.FindAsync(id);
            if (phongBan == null)
            {
                return NotFound();
            }
            return View(phongBan);
        }

        // POST: PhongBan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaPhongBan,TenPhongBan")] PhongBan phongBan)
        {
            if (id != phongBan.MaPhongBan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phongBan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongBanExists(phongBan.MaPhongBan))
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
            return View(phongBan);
        }

        // GET: PhongBan/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.PhongBan == null)
            {
                return NotFound();
            }

            var phongBan = await _context.PhongBan
                .FirstOrDefaultAsync(m => m.MaPhongBan == id);
            if (phongBan == null)
            {
                return NotFound();
            }

            return View(phongBan);
        }

        // POST: PhongBan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.PhongBan == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PhongBan'  is null.");
            }
            var phongBan = await _context.PhongBan.FindAsync(id);
            if (phongBan != null)
            {
                _context.PhongBan.Remove(phongBan);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongBanExists(string id)
        {
          return (_context.PhongBan?.Any(e => e.MaPhongBan == id)).GetValueOrDefault();
        }
    }
}
