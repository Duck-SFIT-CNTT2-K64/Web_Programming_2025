using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LTW_Day07_TH.Models;

namespace LTW_Day07_TH.Controllers
{
    public class CtHoaDonsController : Controller
    {
        private readonly K64cnt2dbContext _context;

        public CtHoaDonsController(K64cnt2dbContext context)
        {
            _context = context;
        }

        // GET: CtHoaDons
        public async Task<IActionResult> Index()
        {
            var k64cnt2dbContext = _context.CtHoaDons.Include(c => c.HoaDon).Include(c => c.SanPham);
            return View(await k64cnt2dbContext.ToListAsync());
        }

        // GET: CtHoaDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ctHoaDon = await _context.CtHoaDons
                .Include(c => c.HoaDon)
                .Include(c => c.SanPham)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ctHoaDon == null)
            {
                return NotFound();
            }

            return View(ctHoaDon);
        }

        // GET: CtHoaDons/Create
        public IActionResult Create()
        {
            ViewData["HoaDonId"] = new SelectList(_context.HoaDons, "Id", "Id");
            ViewData["SanPhamId"] = new SelectList(_context.SanPhams, "Id", "Id");
            return View();
        }

        // POST: CtHoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HoaDonId,SanPhamId,SoLuongMua,DonGiaMua,ThanhTien,TrangThai")] CtHoaDon ctHoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ctHoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HoaDonId"] = new SelectList(_context.HoaDons, "Id", "Id", ctHoaDon.HoaDonId);
            ViewData["SanPhamId"] = new SelectList(_context.SanPhams, "Id", "Id", ctHoaDon.SanPhamId);
            return View(ctHoaDon);
        }

        // GET: CtHoaDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ctHoaDon = await _context.CtHoaDons.FindAsync(id);
            if (ctHoaDon == null)
            {
                return NotFound();
            }
            ViewData["HoaDonId"] = new SelectList(_context.HoaDons, "Id", "Id", ctHoaDon.HoaDonId);
            ViewData["SanPhamId"] = new SelectList(_context.SanPhams, "Id", "Id", ctHoaDon.SanPhamId);
            return View(ctHoaDon);
        }

        // POST: CtHoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HoaDonId,SanPhamId,SoLuongMua,DonGiaMua,ThanhTien,TrangThai")] CtHoaDon ctHoaDon)
        {
            if (id != ctHoaDon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ctHoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CtHoaDonExists(ctHoaDon.Id))
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
            ViewData["HoaDonId"] = new SelectList(_context.HoaDons, "Id", "Id", ctHoaDon.HoaDonId);
            ViewData["SanPhamId"] = new SelectList(_context.SanPhams, "Id", "Id", ctHoaDon.SanPhamId);
            return View(ctHoaDon);
        }

        // GET: CtHoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ctHoaDon = await _context.CtHoaDons
                .Include(c => c.HoaDon)
                .Include(c => c.SanPham)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ctHoaDon == null)
            {
                return NotFound();
            }

            return View(ctHoaDon);
        }

        // POST: CtHoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ctHoaDon = await _context.CtHoaDons.FindAsync(id);
            if (ctHoaDon != null)
            {
                _context.CtHoaDons.Remove(ctHoaDon);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CtHoaDonExists(int id)
        {
            return _context.CtHoaDons.Any(e => e.Id == id);
        }
    }
}
