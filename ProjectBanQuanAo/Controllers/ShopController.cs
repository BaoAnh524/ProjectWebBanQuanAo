﻿using Microsoft.AspNetCore.Mvc;
using ProjectBanQuanAo.Repository;

namespace ProjectBanQuanAo.Controllers
{
    public class ShopController : Controller
    {
        private readonly DataContext _context;
        public ShopController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
