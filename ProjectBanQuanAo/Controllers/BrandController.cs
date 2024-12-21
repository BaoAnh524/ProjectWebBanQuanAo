using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBanQuanAo.Models;
using ProjectBanQuanAo.Repository;

namespace ProjectBanQuanAo.Controllers
{
    public class BrandController : Controller
    {
        private readonly DataContext _context;
        public BrandController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync(string slug="")
        {
            Brand category = _context.Brands.FirstOrDefault(x => x.slug == slug);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            var productByCategory = _context.Products.Where(x => x.brand.id == category.id);
            return View(await productByCategory.OrderByDescending(p => p.id).ToListAsync());
        }
    }
}
