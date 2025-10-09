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
    public class QuanTrisController : Controller
    {
        private readonly K64cnt2dbContext _context;

        public QuanTrisController(K64cnt2dbContext context)
        {
            _context = context;
        }

        // GET: QuanTris
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuanTris.ToListAsync());
        }

        // GET: QuanTris/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quanTri = await _context.QuanTris
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quanTri == null)
            {
                return NotFound();
            }

            return View(quanTri);
        }

        // GET: QuanTris/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuanTris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TaiKhoan,MatKhau,TrangThai")] QuanTri quanTri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quanTri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quanTri);
        }

        // GET: QuanTris/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quanTri = await _context.QuanTris.FindAsync(id);
            if (quanTri == null)
            {
                return NotFound();
            }
            return View(quanTri);
        }

        // POST: QuanTris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TaiKhoan,MatKhau,TrangThai")] QuanTri quanTri)
        {
            if (id != quanTri.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quanTri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuanTriExists(quanTri.Id))
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
            return View(quanTri);
        }

        // GET: QuanTris/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quanTri = await _context.QuanTris
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quanTri == null)
            {
                return NotFound();
            }

            return View(quanTri);
        }

        // POST: QuanTris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quanTri = await _context.QuanTris.FindAsync(id);
            if (quanTri != null)
            {
                _context.QuanTris.Remove(quanTri);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuanTriExists(int id)
        {
            return _context.QuanTris.Any(e => e.Id == id);
        }
    }
}
