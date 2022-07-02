using Microsoft.AspNetCore.Mvc;

namespace shaan_ge.Controllers
{
    public class QUIZ_2 : Controller
    {
        public IActionResult Index()
        {
            ViewBag.message = "Zeeshan";
            ViewBag.message2 = "Shabeer";
            return View("Quiz2");
        }
    }
}
