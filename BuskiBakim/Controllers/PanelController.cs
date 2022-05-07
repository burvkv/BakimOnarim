using BuskiBakim.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
