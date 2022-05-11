using bakimonarim.entity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace bakimonarim.webui.Components
{
    public class Sidebar : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public Sidebar(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(HttpContext.User);         
            return View("_sidebar", currentUser);
        }
    }
}
