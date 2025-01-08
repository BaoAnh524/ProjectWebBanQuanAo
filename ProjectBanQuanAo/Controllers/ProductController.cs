using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBanQuanAo.Repository;

namespace ProjectBanQuanAo.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;
        public ProductController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> IndexAsync(string id= "")
        {

            return View();
        }
        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.brand)
                .FirstOrDefaultAsync(p => p.id == id);

            if (product == null)
            {
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}
