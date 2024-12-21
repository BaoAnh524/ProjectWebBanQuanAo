using Microsoft.AspNetCore.Mvc;
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
    }
}
