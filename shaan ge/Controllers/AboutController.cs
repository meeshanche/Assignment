using Microsoft.AspNetCore.Mvc;

namespace shaan_ge.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View("AboutView");
        }
    }
}
