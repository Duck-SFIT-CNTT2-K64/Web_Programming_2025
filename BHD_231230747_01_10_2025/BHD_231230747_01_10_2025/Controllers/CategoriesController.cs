using BHD_231230747_01_10_2025.Data;
using BHD_231230747_01_10_2025.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BHD_231230747_01_10_2025.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _db;
        public CategoriesController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index() => View(await _db.Categories.ToListAsync());

        public IActionResult Create() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category m)
        {
            if (!ModelState.IsValid) return View(m);
            _db.Categories.Add(m);
            await _db.SaveChangesAsync();
            TempData["ok"] = "Them danh muc thanh cong";
            return RedirectToAction(nameof(Index));
        }
    }
}
