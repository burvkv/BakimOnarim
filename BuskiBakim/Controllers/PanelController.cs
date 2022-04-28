using Microsoft.AspNetCore.Mvc;

namespace BuskiBakim.Controllers
{
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
