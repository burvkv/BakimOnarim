using bakimonarim.entity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bakimonarim.webui.Components
{
    [ViewComponent]
    public class Navbar : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public Navbar(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(HttpContext.User);
            return View("_navbar",currentUser);

        }
    }
}
