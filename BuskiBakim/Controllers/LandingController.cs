using Microsoft.AspNetCore.Mvc;

namespace BuskiBakim.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Tanıtım";
            return View();
        }
    }
}
