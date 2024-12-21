using Microsoft.AspNetCore.Mvc;
using ProjectBanQuanAo.Models;
using ProjectBanQuanAo.Repository;
using System.Diagnostics;

namespace ProjectBanQuanAo.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DataContext _context;

		public HomeController(ILogger<HomeController> logger, DataContext context
			)
		{
			_context = context;
			_logger = logger;
		}

		public IActionResult Index()
		{
			var products = _context.Products.ToList();
			return View(products);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
