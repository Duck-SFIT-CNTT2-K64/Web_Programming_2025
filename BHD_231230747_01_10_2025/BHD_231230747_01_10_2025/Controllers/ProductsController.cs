using BHD_231230747_01_10_2025.Data;
using BHD_231230747_01_10_2025.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BHD_231230747_01_10_2025.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public ProductsController(AppDbContext db, IWebHostEnvironment env)
        { _db = db; _env = env; }

        private void LoadCategories(int? selectedId = null)
        {
            ViewBag.Categories = new SelectList(_db.Categories.AsNoTracking().ToList(),
                                                nameof(Category.Id), nameof(Category.Name),
                                                selectedId);
        }

        public async Task<IActionResult> Index()
        {
            var list = await _db.Products.Include(p => p.Category).ToListAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            LoadCategories();
            return View(new Product());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product model, IFormFile? ImageFile)
        {
            if (ImageFile == null || ImageFile.Length == 0)
                ModelState.AddModelError("Image", "Vui long chon anh san pham");
            else
            {
                var ext = Path.GetExtension(ImageFile.FileName).ToLowerInvariant();
                var okExt = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                if (!okExt.Contains(ext))
                    ModelState.AddModelError("Image", "Chi chap nhan anh .jpg, .jpeg, .png, .gif");
                else if (ImageFile.Length > 2 * 1024 * 1024)
                    ModelState.AddModelError("Image", "Anh toi da 2MB");
            }

            if (!ModelState.IsValid)
            {
                LoadCategories(model.CategoryId);
                return View(model);
            }

            // luu anh
            var uploads = Path.Combine(_env.WebRootPath, "products");
            Directory.CreateDirectory(uploads);
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(ImageFile!.FileName)}";
            var filePath = Path.Combine(uploads, fileName);
            using (var stream = System.IO.File.Create(filePath))
                await ImageFile.CopyToAsync(stream);
            model.Image = $"/products/{fileName}";

            // luu database
            _db.Products.Add(model);
            await _db.SaveChangesAsync();
            TempData["ok"] = "Them san pham thanh cong";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var p = await _db.Products.FindAsync(id);
            if (p == null) return NotFound();
            LoadCategories(p.CategoryId);
            return View(p);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product model, IFormFile? ImageFile)
        {
            if (id != model.Id) return NotFound();

            if (ImageFile != null && ImageFile.Length > 0)
            {
                var ext = Path.GetExtension(ImageFile.FileName).ToLowerInvariant();
                var okExt = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                if (!okExt.Contains(ext))
                    ModelState.AddModelError("Image", "Chi chap nhan anh .jpg, .jpeg, .png, .gif");
                else if (ImageFile.Length > 2 * 1024 * 1024)
                    ModelState.AddModelError("Image", "Anh toi da 2MB");
            }

            if (!ModelState.IsValid)
            {
                LoadCategories(model.CategoryId);
                return View(model);
            }

            if (ImageFile != null && ImageFile.Length > 0)
            {
                var uploads = Path.Combine(_env.WebRootPath, "products");
                Directory.CreateDirectory(uploads);
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(ImageFile.FileName)}";
                var filePath = Path.Combine(uploads, fileName);
                using (var stream = System.IO.File.Create(filePath))
                    await ImageFile.CopyToAsync(stream);
                model.Image = $"/products/{fileName}";
            }

            try
            {
                _db.Update(model);
                await _db.SaveChangesAsync();
                TempData["ok"] = "Cap nhat san pham thanh cong";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_db.Products.Any(e => e.Id == id)) return NotFound();
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var p = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var p = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var p = await _db.Products.FindAsync(id);
            if (p != null)
            {
                _db.Products.Remove(p);
                await _db.SaveChangesAsync();
            }
            TempData["ok"] = "Đã xóa sản phẩm";
            return RedirectToAction(nameof(Index));
        }
    }
}
