﻿using Microsoft.AspNetCore.Mvc;

namespace Test4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
