
using bakimonarim.entity.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuskiBakim.Controllers
{
    [Authorize]
    public class PanelController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public PanelController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            ViewData["Title"] = "HHT - Panel";
            return View();
        }
      
    }
}