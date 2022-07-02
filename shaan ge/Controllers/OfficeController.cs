using Microsoft.AspNetCore.Mvc;

namespace shaan_ge.Controllers
{
    public class OfficeController : Controller
    {
        public IActionResult Index()
        {
            return View("OfficeView");
        }
    }
}
