using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBanQuanAo.Models;
using ProjectBanQuanAo.Repository;

namespace ProjectBanQuanAo.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DataContext _context;
        public CategoriesController(DataContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index(string slug="")
        {
            Category category = _context.Categories.FirstOrDefault(x => x.slug == slug);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            var productByCategory = _context.Products.Where(x => x.Category.id == category.id);
            return View(await productByCategory.OrderByDescending(p => p.id).ToListAsync());
        }
    }
}
