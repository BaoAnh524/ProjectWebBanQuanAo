using Microsoft.AspNetCore.Mvc;

namespace ProjectBanQuanAo.Controllers
{
    public class Products : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
