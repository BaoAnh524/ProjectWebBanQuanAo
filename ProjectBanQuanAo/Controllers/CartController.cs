﻿using Microsoft.AspNetCore.Mvc;

namespace ProjectBanQuanAo.Controllers
{

    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
