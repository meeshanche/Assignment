﻿using Microsoft.AspNetCore.Mvc;

namespace shaan_ge.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View("AddView");
        }
    }
}
